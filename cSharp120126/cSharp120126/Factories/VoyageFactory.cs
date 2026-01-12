using cSharp120126.Model;
using cSharp120126.Struct;
using cSharp120126.Enums;

namespace cSharp120126.Factories
{
    public static class VoyageFactory
    {
        public static Voyage Create(string destination, double prix, int duree, Transport locomotion)
        {
            var newVoyage = new Voyage(destination, prix, duree, locomotion);
            Model.StructSet.Voyages.Add(newVoyage);
            return newVoyage;
        }

        public static Struct.Voyage UpdateVoyage(int uId, string destination, double prix, int duree, Transport locomotion)
        {
            var voyageToUpdate = Model.StructSet.Voyages.Where(x => x.uId == uId).FirstOrDefault();
            if(voyageToUpdate.uId == 0)
                Console.WriteLine("Voyage not found, unable to update voyage.");
            
            var updatedVoyage = new Voyage(destination, prix, duree, locomotion)
            {
                uId = voyageToUpdate.uId // Preserve the original uId
            };

            int index = Model.StructSet.Voyages.IndexOf(voyageToUpdate);
            Model.StructSet.Voyages[index] = updatedVoyage;

            return updatedVoyage;
        }

        public static string DisplayAllVoyages()
        {
            List<string> voyageStrings = new List<string>();
            foreach(var voyage in Model.StructSet.Voyages)
            {
                voyageStrings.Add(voyage.ToString());
            }
            return string.Join("\n", voyageStrings);
        }

        public static bool DeleteVoyage(int uId)
        {
            var voyageToDelete = Model.StructSet.Voyages.Where(x => x.uId == uId).FirstOrDefault();
            if(voyageToDelete.uId == 0)
            {
                Console.WriteLine("Voyage not found, unable to delete voyage.");
                return false;
            }
            
            Model.StructSet.Voyages.Remove(voyageToDelete);
            Console.WriteLine($"Voyage with uId {uId} has been deleted.");
            return true;
        }


    }
}