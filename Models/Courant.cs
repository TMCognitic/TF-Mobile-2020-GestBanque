using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Courant
    {
        private string _numero;
        private double _ligneDeCredit;
        private double _solde;
        private Personne _titulaire;

        public string Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public double LigneDeCredit
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

        public double Solde
        {
            get
            {
                return _solde;
            }

            private set
            {
                _solde = value;
            }
        }

        public Personne Titulaire
        {
            get
            {
                return _titulaire;
            }

            set
            {
                _titulaire = value;
            }
        }

        public void Depot(double montant)
        {
            if (!(montant > 0))
                return;

            Solde += montant;
        }

        public void Retrait(double montant)
        {
            if (!(montant > 0))
                return; //à changer en exception par la suite

            if (Solde - montant < -LigneDeCredit)
                return; //à changer en exception par la suite

            Solde -= montant;
        }


    }
}
