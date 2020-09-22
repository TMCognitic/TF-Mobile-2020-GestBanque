using System;

namespace Carwash
{
    class Program
    {
        static void Main(string[] args)
        {
            TheCarwash carwash = new TheCarwash();
            carwash.Traiter(new Voiture("1-ABC-123"));
        }
    }
}
