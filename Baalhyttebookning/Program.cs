namespace Baalhyttebookning
{
    public class Program
    {
        static void Main(string[] args)
        {            
            Boernegruppe boernegruppe1 = new Boernegruppe("1", "Gruppe 1", "pusling", 10);
            Console.WriteLine();
            Boernegruppe boernegruppe2 = new Boernegruppe("2", "Gruppe 2", "junior", 7);
            Console.WriteLine();

            Reservation reservation1 = new Reservation(1, DateTime.Now, boernegruppe1);
            Console.WriteLine(reservation1);
            Reservation reservation2 = new Reservation(2, DateTime.Now, boernegruppe2);
            Console.WriteLine(reservation2);
                      
            Reservationer reservationer = new Reservationer(2023);
            reservationer.ReservationsDictionary.Add(reservation1.ID, reservation1);
            Console.WriteLine(reservationer.ID);
        }
    }
}