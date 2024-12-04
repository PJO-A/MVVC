using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; set; }
        public string Username { get; set; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; set; }
        public TimeSpan Length=>EndTime.Subtract(StartTime);

        public Reservation(RoomID roomID, string username, DateTime startTime, DateTime endTime)
        {
            RoomID = roomID;
            Username = username;
            StartTime = startTime;
            EndTime = endTime;
        }

        /// <summary>
        /// Check if a reservation conflicts.
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
          public bool Conflicts(Reservation reservation)
            {
                if(reservation.RoomID != RoomID)
                {
                    return false; 
                }
                return reservation.StartTime < EndTime && reservation.EndTime > StartTime;
            }


    }
}
