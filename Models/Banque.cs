﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Banque
    {
        private Dictionary<string, Compte> _comptes = new Dictionary<string, Compte>();
        public string Nom { get; set; }

        public Compte this[string numero]
        {
            get 
            {
                //_comptes.TryGetValue(numero, out Courant courant);
                //return courant;
                //ou
                return _comptes[numero];
            }
        }

        public void Ajouter(Compte compte)
        {
            compte.PassageEnNegatifEvent += PassageEnNegatifAction;
            _comptes.Add(compte.Numero, compte);
        }        

        public void Supprimer(string numero)
        {
            Compte compte = this[numero];
            compte.PassageEnNegatifEvent -= PassageEnNegatifAction;
            _comptes.Remove(numero);
        }

        private void PassageEnNegatifAction(Compte compte)
        {
            Console.WriteLine($"Le compte {compte.Numero} vient de passer en négatif!");
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double total = 0;
            foreach (Compte compte in _comptes.Values)
            {
                if (compte.Titulaire == titulaire)
                {
                    total += compte;
                }
            }

            return total;
        }

    }
}
