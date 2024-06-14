using System;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Opgave 2. Test af Klassen Booking. :");
            Console.WriteLine("--------------------------");
            Booking b1 = new Booking(101, new DateTime(2024, 6, 21, 14, 0, 0), new DateTime(2024, 6, 21, 16, 0, 0), 10);
            Booking b2 = new Booking(102, new DateTime(2024, 6, 22, 12, 0, 0), new DateTime(2024, 6, 21, 14, 0, 0), 12);
            Booking b3 = new Booking(103, new DateTime(2024, 6, 22, 10, 0, 0), new DateTime(2024, 6, 21, 11, 0, 0), 9);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine();

            Console.WriteLine("--------------------------");
            Console.WriteLine("Opgave 3. Test af  Klassen GymHall.:");
            Console.WriteLine("--------------------------");
            GymHall GH1 = new GymHall(1, "GymHall 1", "Roskilde 1", "11223344", "GymHall1@gmail.com");
            GymHall GH2 = new GymHall(2, "GymHall 2", "Holbæk 2", "44332211", "GymHall2@gmail.com");
            Console.WriteLine(GH1);
            Console.WriteLine(GH2);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------");
            Console.WriteLine("Opgave 4 Test af RegisterBooking:");
            Console.WriteLine("--------------------------");
            GH1.RegisterBooking(b1);
            GH2.RegisterBooking(b2);
            GH2.RegisterBooking(b3);
            Console.WriteLine(GH1);
            Console.WriteLine(GH2);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Opgave 4 Test af PrintBookings():");
            Console.WriteLine("--------------------------");
            GH1.PrintBookings();
            GH2.PrintBookings();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Opgave 4 Test af RemoveBooking:");
            //Console.WriteLine("--------------------------");
            //GH2.RemoveBooking(b3);
            //Console.WriteLine(GH1);
            //Console.WriteLine(GH2);
            //Console.WriteLine();
            //Console.WriteLine();

            Console.WriteLine("--------------------------");
            Console.WriteLine("Opgave 6 Test af BookingDurationOK and IsItSundayBooking :");
            Console.WriteLine("--------------------------");

            Booking b4 = new Booking(104, new DateTime(2024, 6, 21, 15, 0, 0), new DateTime(2024, 6, 21, 16, 0, 0), 11);
            Console.WriteLine($"Is booking valid?: {b4.BookingDurationOK}");
            Console.WriteLine($"Is it Sunday?: {b4.IsItSundayBooking}");
            Console.WriteLine("--------------------------");
            Booking b5 = new Booking(105, new DateTime(2024, 6, 23, 13, 0, 0), new DateTime(2024, 6, 23, 16, 0, 0), 7);
            Console.WriteLine($"Is booking valid?: {b5.BookingDurationOK}");
            Console.WriteLine($"Is it Sunday?: {b5.IsItSundayBooking}");

            Console.WriteLine("--------------------------");
            Console.WriteLine("Opgave 6 Test af TotalBookings");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"TotalBookings GH1?: {GH1.TotalBookings}");
            Console.WriteLine($"TotalBookings GH2?: {GH2.TotalBookings}");

            Console.WriteLine("--------------------------");
            Console.WriteLine("Opgave 7 Test af Validerings funktion:");
            Console.WriteLine("--------------------------");

            Booking b6 = new Booking(106, new DateTime(2024, 6, 21, 10, 0, 0), new DateTime(2024, 6, 21, 18, 0, 0), 10);
            Booking b7 = new Booking(107, new DateTime(2024, 6, 21, 11, 0, 0), new DateTime(2024, 6, 21, 11, 0, 0), 10);
            Booking b8 = new Booking(108, new DateTime(2024, 6, 21, 11, 0, 0), new DateTime(2024, 6, 21, 12, 0, 0), 30);

            GH1.Validate(b6);
            GH1.Validate(b7);
            GH1.Validate(b8);

            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Opgave 8 Test af Exceptions :");
            //Console.WriteLine("--------------------------");

            //try
            //{
            //    Booking b6 = new Booking(106, new DateTime(2024, 6, 21, 10, 0, 0), new DateTime(2024, 6, 21, 18, 0, 0), 10);
            //    GH1.Validate(b6);
            //}
            //catch (Exception e)
            //{
                
            //    Console.WriteLine(e.Message);
            //}
            //try
            //{
            //    Booking b7 = new Booking(107, new DateTime(2024, 6, 21, 11, 0, 0), new DateTime(2024, 6, 21, 11, 0, 0), 10);
            //    GH1.Validate(b7);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //try
            //{
            //    Booking b8 = new Booking(108, new DateTime(2024, 6, 21, 11, 0, 0), new DateTime(2024, 6, 21, 12, 0, 0), 30);
            //    GH1.Validate(b8);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
