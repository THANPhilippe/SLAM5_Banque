using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    class Compte
    {
        private int numero;
  

        public Compte(int numero)
        {
            this.numero = numero;
        }

    }

    class Courant : Compte
    {
        int decouvert = 0;
        int solde;
        public Courant(int numero, int decouvert, int solde) : base(numero)
        {
        }

    }

    class Epargne : Compte
    {

        static int taux;
        public Epargne(int numero) : base(numero)
        {
        }
    }

}
