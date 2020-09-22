using System;

namespace Carwash
{
    public class TheCarwash
    {
        Action<Voiture> _handler;
        #region Classique
        //public TheCarwash()
        //{
        //    _handler += Preparer;
        //    _handler += Laver;
        //    _handler += Secher;
        //    _handler += Finaliser;
        //}

        //private void Preparer(Voiture voiture)
        //{
        //    Console.WriteLine($"Je prépare la voiture : {voiture.Plaque}");
        //}

        //private void Laver(Voiture voiture)
        //{
        //    Console.WriteLine($"Je lave la voiture : {voiture.Plaque}");
        //}

        //private void Secher(Voiture voiture)
        //{
        //    Console.WriteLine($"Je sèche la voiture : {voiture.Plaque}");
        //}

        //private void Finaliser(Voiture voiture)
        //{
        //    Console.WriteLine($"Je finalise la voiture : {voiture.Plaque}");
        //}
        #endregion

        #region Méthodes anonymes
        public TheCarwash()
        {
            _handler += delegate (Voiture voiture) { Console.WriteLine($"Je prépare la voiture : {voiture.Plaque}"); };
            _handler += delegate (Voiture voiture) { Console.WriteLine($"Je lave la voiture : {voiture.Plaque}"); };
            _handler += delegate (Voiture voiture) { Console.WriteLine($"Je sèche la voiture : {voiture.Plaque}"); };
            _handler += delegate (Voiture voiture) { Console.WriteLine($"Je finalise la voiture : {voiture.Plaque}"); };
        }
        #endregion

        internal void Traiter(Voiture voiture)
        {
            _handler?.Invoke(voiture);
        }
    }
}
