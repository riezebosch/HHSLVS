using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HHSLVS
{
    public class Leerling
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        public int StudentNummer { get; set; }

        public Studie Studie { get; set; }

        public int JaarVanInschrijving { get; set; }
    }
}
