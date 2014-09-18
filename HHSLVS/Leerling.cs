using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace HHSLVS
{
    public class Leerling
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        [ReadOnly(true)]
        public int StudentNummer { get; set; }

        public virtual Studie Studie { get; set; }

        [DisplayName("Inschrijving")]
        public int JaarVanInschrijving { get; set; }
    }
}
