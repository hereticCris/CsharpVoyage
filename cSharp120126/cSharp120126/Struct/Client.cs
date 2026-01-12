namespace cSharp120126.Struct
{
    public struct Client
    {
        public int uId;
        public string Prenom;
        public string Nom;

        public Client(string prenom, string nom)
        {
            uId = ++ cSharp120126.Model.StructSet.ClientIdCounter;
            
            Prenom = prenom;
            Nom = nom;
        }

        public override string ToString()
        {
            return $"[Client] uId: {uId}, Prenom: {Prenom}, Nom: {Nom}";
        }        
    }
}
