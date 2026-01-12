using cSharp120126.Enums;
using cSharp120126.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp120126.Factories
{
    internal class ReservationFactory
    {
        public static Reservation Create(DateTime startDate, Client reservationClient, Voyage detailsVoyage)
        {
            var newReservation = new Reservation(startDate, reservationClient, detailsVoyage);
            Model.StructSet.Reservations.Add(newReservation);
            return newReservation;
        }

        public static Struct.Reservation UpdateReservation(int uId, DateTime startDate, Client reservationClient, Voyage detailsVoyage)
        {
            var reservationToUpdate = Model.StructSet.Reservations.Where(x => x.uId == uId).FirstOrDefault();
            if (reservationToUpdate.uId == 0)
                Console.WriteLine("Rservation not found, unable to update reservation.");

            var updatedReservation = new Reservation(startDate, reservationClient, detailsVoyage)
            {
                uId = reservationToUpdate.uId // Preserve the original uId
            };

            int index = Model.StructSet.Reservations.IndexOf(reservationToUpdate);
            Model.StructSet.Reservations[index] = updatedReservation;

            return updatedReservation;
        }

        public static string DisplayAllReservation()
        {
            List<string> reservationsStrings = new List<string>();
            foreach (var reservation in Model.StructSet.Reservations)
            {
                reservationsStrings.Add(reservation.ToString());
            }
            return string.Join("\n", reservationsStrings);
        }

        public static bool DeleteReservations(int uId)
        {
            var reservationToDelete = Model.StructSet.Reservations.Where(x => x.uId == uId).FirstOrDefault();
            if (reservationToDelete.uId == 0)
            {
                Console.WriteLine("Reservation not found, unable to delete reservation.");
                return false;
            }

            Model.StructSet.Reservations.Remove(reservationToDelete);
            Console.WriteLine($"Reservation with uId {uId} has been deleted.");
            return true;
        }
    }
}
