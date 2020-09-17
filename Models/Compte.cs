using System;
using System.Net.Sockets;

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

            private set
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

            private set
            {
                _titulaire = value;
            }
        }

        public Compte(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire;
        }

        public Compte(string numero, Personne titulaire, double solde)
            : this(numero, titulaire)
        {
            Solde = solde;
        }

        public void AppliquerInteret()
        {
            //Template Method (Design Pattern)
            Solde += CalculInteret();
        }

        public void Depot(double montant)
        {
            if (!(montant > 0))
                throw new ArgumentOutOfRangeException();

            Solde += montant;
        }

        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0D);
        }

        protected void Retrait(double montant, double ligneDeCredit)
        {
            if (!(montant > 0))
                throw new ArgumentOutOfRangeException();

            if (Solde - montant < -ligneDeCredit)
                throw new SoldeInsuffisantException();

            Solde -= montant;
        }

        protected abstract double CalculInteret();
    }
}