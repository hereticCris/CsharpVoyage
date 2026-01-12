namespace cSharp120126.Factories
{
    public static class ClientFactory
    {
        public static Struct.Client CreateClient(string prenom, string nom)
        {
            var newClient = new Struct.Client(prenom, nom);
            Model.StructSet.Clients.Add(newClient);
            return newClient;
        }

        public static Struct.Client UpdateClient(int uId, string prenom, string nom)
        {
            var clientToUpdate = Model.StructSet.Clients.Where(x => x.uId == uId).FirstOrDefault();
            if(clientToUpdate.uId == 0)
                Console.WriteLine("Client not found, unable to update client.");
            
            var updatedClient = new Struct.Client(prenom, nom)
            {
                uId = clientToUpdate.uId // Preserve the original uId
            };

            int index = Model.StructSet.Clients.IndexOf(clientToUpdate);
            Model.StructSet.Clients[index] = updatedClient;

            return updatedClient;
        }

        public static string DisplayAllClients()
        {
            List<string> clientStrings = new List<string>();
            foreach(var client in Model.StructSet.Clients)
            {
                clientStrings.Add(client.ToString());
            }
            return string.Join("\n", clientStrings);
        }

        public static bool DeleteClient(int uId)
        {
            var clientToDelete = Model.StructSet.Clients.Where(x => x.uId == uId).FirstOrDefault();
            if(clientToDelete.uId == 0)
            {
                Console.WriteLine("Client not found, unable to delete client.");
                return false;
            }
            
            Model.StructSet.Clients.Remove(clientToDelete);
            Console.WriteLine($"Client with uId {uId} has been deleted.");
            return true;
        }
    }
}