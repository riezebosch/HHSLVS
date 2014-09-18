using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HHSLVS;
using System.Transactions;
using System.Linq;
using System.Data.Entity;

namespace HHSLVS.Tests
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {
            using(var context = new SchoolContext())
            {
                context.Leerlingen.Add(new Leerling
                    {
                        Naam = "Manuel Riezebosch",
                        StudentNummer = 20206021,
                        Studie = new Studie
                        {
                            Naam = "Informatica",

                        },
                        JaarVanInschrijving = 2000,

                    });

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestRelatedEntities()
        {
            using (var scope = new TransactionScope())
            {
                using (var context = new SchoolContext())
                {
                    var leerling = context.Leerlingen.Add(new Leerling
                    {
                        Naam = "Test"
                    });

                    var studie = new Studie
                    {
                        Naam = "PretPakket"
                    };

                    leerling.Studie = studie;

                    context.SaveChanges();
                }

                using (var context = new SchoolContext())
                {
                    context.Database.Log += Console.WriteLine;

                    var leerling = context
                        .Leerlingen
                        .Include(l => l.Studie)
                        .First(p => p.Naam == "Test");
                    Assert.IsNotNull(leerling.Studie);
                }

                //scope.Complete();
            }
        }
    }
}
