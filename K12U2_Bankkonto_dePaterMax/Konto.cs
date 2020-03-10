using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K12U2_Bankkonto_dePaterMax
{
    class Konto : IO
    {
        private double stand;

        double IO.kontostand
        {
            get{ return stand; }
            set { stand = value; }
        }

        public Konto(double kontoStand)
        {
            stand = kontoStand;
        }
    }
}
