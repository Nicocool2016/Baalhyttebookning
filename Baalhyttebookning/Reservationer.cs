using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Baalhyttebookning
{
    public class Reservationer
    {
        public int ID { get; set; }
        public Dictionary<int, Reservation> ReservationsDictionary { get; set; }
        public List<Reservation> ReservationsList { get; set; }


        public Reservationer(int id)
        {
            ID = id;
            ReservationsDictionary = new Dictionary<int, Reservation>();
            ReservationsList = new List<Reservation>();

            void RegistrerReservation(Reservation reservation)
            {
                ReservationsList.Add(reservation);
            }

            void PrintReservationer()
            {
                foreach (Reservation reservation in ReservationsList)
                {
                    Console.WriteLine(reservation);
                }
            }

            void FjernReservation(Reservation reservation)
            {
                ReservationsList.Remove(reservation);
            }
        }
    }
}

    

