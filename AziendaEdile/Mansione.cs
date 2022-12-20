using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AziendaEdile
{
    public class Mansione
    {
        public int ID_Mansione { get; set; }
        public string Tipologia { get; set; }
        public string Descrizione { get; set; }

        public static List<Mansione> Mansioni = new List<Mansione>();
    }
}