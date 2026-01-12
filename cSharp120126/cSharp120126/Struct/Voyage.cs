using cSharp120126.Enums;

namespace cSharp120126.Struct
{
    public struct Voyage
    {
        public int uId;

        string Destination;
        double Prix;
        int Duree;
        Transport Locomotion;

        public Voyage(string destination, double prix, int duree, Transport locomotion)
        {
            uId = ++ cSharp120126.Model.StructSet.VoyageIdCounter;

            Destination = destination;
            Prix = prix;
            Duree = duree;
            Locomotion = locomotion;
        }

        public override string ToString()
        {
            return $"[Voyage] uId: {uId}, Destination: {Destination}, Prix: {Prix}, Duree: {Duree}, Locomotion: {Locomotion}";
        }
    }
}
