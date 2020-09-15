using Models;
using System;

namespace GestBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personne titulaire = new Personne();
            //titulaire.Nom = "Doe";
            //titulaire.Prenom = "John";
            //titulaire.DateNaiss = new DateTime(1970, 1, 1);
            //ou
            Personne titulaire = new Personne()
            {
                Nom = "Doe",
                Prenom = "John",
                DateNaiss = new DateTime(1970, 1, 1)
            };

            Courant courant = new Courant()
            {
                Numero = "00001",
                LigneDeCredit = 300,
                Titulaire = titulaire
            };

            courant.Depot(200);
            courant.Retrait(500);


            Console.WriteLine(courant.Solde);
        }
    }
}
