using System.Net.WebSockets;

namespace cSharp120126.Struct
{
    public struct Client
    {
        public string Prenom;
        public string Nom;

        Client(string prenom, string nom)
        {
            Prenom = prenom;
            Nom = nom;
        }

        

    }
}
