namespace Models
{
    public interface IBanker : ICustomer
    {
        string Numero { get; }
        double LigneDeCredit { get; set; }
        Personne Titulaire { get; }

        void AppliquerInteret();
    }
}