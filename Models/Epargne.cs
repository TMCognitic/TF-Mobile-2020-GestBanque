using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Models
{
    public class Epargne : Compte
    {
        private DateTime _dernierRetrait;

        public DateTime DernierRetrait
        {
            get
            {
                return _dernierRetrait;
            }

            private set
            {
                _dernierRetrait = value;
            }
        }

        public Epargne(string numero, Personne titulaire)
            : base(numero, titulaire)
        {
        }

        public Epargne(string numero, Personne titulaire, double solde, DateTime dernierRetrait)
            : base(numero, titulaire, solde)
        {
            DernierRetrait = dernierRetrait;
        }

        public override void Retrait(double montant)
        {
            double oldSolde = Solde;
            base.Retrait(montant);

            if(oldSolde != Solde)
                DernierRetrait = DateTime.Now;
        }

        protected override double CalculInteret()
        {
            return Solde * .045;
        }
    }
}
