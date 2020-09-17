using System;
using System.Runtime.Serialization;

namespace Models
{
    [Serializable]
    internal class SoldeInsuffisantException : InvalidOperationException
    {
        public SoldeInsuffisantException() : base("Le solde est insuffisant!")
        {
        }
    }
}