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

            Courant courant2 = new Courant()
            {
                Numero = "00002",
                LigneDeCredit = 300,
                Titulaire = titulaire
            };

            Banque TechnoBanque = new Banque()
            {
                Nom = "TechnoBanque" 
            };

            TechnoBanque.Ajouter(courant);
            TechnoBanque.Ajouter(courant2);

            TechnoBanque["00001"].Depot(200);
            TechnoBanque["00002"].Depot(200);
            TechnoBanque["00001"].Retrait(500);


            Console.WriteLine($"Solde du compte 00001 : {TechnoBanque["00001"].Solde}");
            Console.WriteLine($"Avoir des compte de {titulaire.Nom} {titulaire.Prenom} : {TechnoBanque.AvoirDesComptes(titulaire)}");
        }
    }
}
