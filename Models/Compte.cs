using System;

namespace Models
{
    public abstract class Compte : ICustomer, IBanker
    {
        public static double operator +(double d, Compte courant)
        {
            return ((d > 0D) ? d : 0D) + ((courant.Solde > 0D) ? courant.Solde : 0D);
        }

        private string _numero;
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

        public virtual double LigneDeCredit
        {
            get
            {
                return 0;
            }

            set
            {
                throw new InvalidOperationException("La ligne de crédit ne peut être affectée par le fonctionnement par défaut!");
            }
        }

        public void AppliquerInteret()
        {
            //Template Method (Design Pattern)
            Solde += CalculInteret();
        }

        public void Depot(double montant)
        {
            if (!(montant > 0))
                return;

            Solde += montant;
        }

        public virtual void Retrait(double montant)
        {
            if (!(montant > 0))
                return; //à changer en exception par la suite

            if (Solde - montant < -LigneDeCredit)
                return; //à changer en exception par la suite

            Solde -= montant;
        }

        protected abstract double CalculInteret();
    }
}