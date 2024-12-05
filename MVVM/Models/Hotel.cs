using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get; }
        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        /// <summary>
        /// Get the reservation for a user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservationBook.GetAllReservations();
        }

        /// <summary>
        /// Make a reservation.
        /// </summary>
        /// <param name="reservation"></param>
        /// <exception cref="ReservationConflictException"
        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservatoin(reservation);
        }
    }
}
