namespace cSharp120126.Struct
{
    public struct Reservation
    {
        public int uId;
        DateTime StartDate;
        Client ResevationClient;
        Voyage DetailsVoyage;

        public Reservation(DateTime startDate,Client reservationClient, Voyage detailsVoyage)
        {
            uId = ++cSharp120126.Model.StructSet.ClientIdCounter;
            StartDate = startDate;
            ResevationClient = reservationClient;
            DetailsVoyage = detailsVoyage;
        }

        public override string ToString()
        {
            return $"[Client] uId: {uId}, Depart de Voyage: {StartDate}, Reservation de Client: {ResevationClient}, Voyage {DetailsVoyage}";
        }
    }
}
