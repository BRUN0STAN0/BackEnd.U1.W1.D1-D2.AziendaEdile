using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AziendaEdile
{
    public class Pagamento
    {
        public int ID_Pagamento { get; set; }
        public DateTime Periodo { get; set; }
        public bool Acconto { get; set; }
        public decimal Ammontare { get; set; }
        public int ID_Dipendente { get; set; }

        public static List<Pagamento> Pagamenti = new List<Pagamento>();
    }
}