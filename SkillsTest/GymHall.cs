using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class GymHall
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int TotalBookings
        {
            get { return Bookings.Count; }
        }

        public Dictionary<int, Booking> Bookings;


        public GymHall(int id, string name, string address, string phone, string email)
        {
            ID = id;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            Bookings = new Dictionary<int, Booking>();
        }

        public void RegisterBooking(Booking booking) 
        {
            Bookings.Add(booking.ID, booking);
        }
        
        public void PrintBookings()
        {
            foreach (var booking in Bookings.Values)
            {
                Console.WriteLine(booking);
            }
        }
        public void RemoveBooking(Booking booking) 
        { 
        Bookings.Remove(booking.ID);
        }

        public bool Validate(Booking booking)
        {
            string message = "";

            if (!booking.BookingDurationOK)
            {
                message = "Max booking time is 2 hours";
                Console.WriteLine(message);
                return false;

                //throw new Exception("Max booking time is 2 hours");

            }
            if (booking.Start <= booking.End)
            {
                message = "Start must be before End";
                Console.WriteLine(message);
                return false;

                //throw new Exception("start must be before end");

            }
            if (booking.Participants > 20)
            {
                message = "max 20 participants";
                Console.WriteLine(message);
                return false;

                //throw new Exception("max 20 participants");
            }
            return true;
        }
        public override string ToString()
        {
            string bookings = "";
            foreach (var b in Bookings)
            {
                bookings += b.ToString();
            }
            return $"ID: {ID}\n" +
                   $"Name: {Name}\n" +
                   $"Address: {Address}\n" +
                   $"Phone: {Phone}\n" +
                   $"Email: {Email}\n" +
                   $"Bookings:\n{bookings}\n";
        }
    }
}
