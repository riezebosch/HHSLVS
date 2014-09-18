using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HHSLVS;

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
    }
}
