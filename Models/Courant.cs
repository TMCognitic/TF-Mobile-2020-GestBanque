using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Models
{
    public class Courant : Compte
    {
        private double _ligneDeCredit;

        public override double LigneDeCredit
        {
            get
            {
                return _ligneDeCredit;
            }

            set
            {
                if (value < 0)
                    return; //à changer en exception par la suite

                _ligneDeCredit = value;
            }
        }

        protected override double CalculInteret()
        {
            return Solde * (Solde > 0 ? .03 : .0975);
        }
    }
}
