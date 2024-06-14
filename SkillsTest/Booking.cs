using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Booking
    {
        public int ID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Participants { get; set; }
        public bool BookingDurationOK
        {
            get
            {
                if (Start.AddHours(2) <= End)
                {
                    return false;
                }
                return true;
            }
        }
        public bool IsItSundayBooking
        {
            get
            {
                if (Start.DayOfWeek == DayOfWeek.Sunday)
                {
                    return true;
                }
                return false;
            }
        }

        public Booking(int id, DateTime start, DateTime end, int participants) 
        { 
            ID = id;
            Start = start;
            End = end;
            Participants = participants;
            
        }

        public override string ToString()
        {
            return $"ID: {ID}\n" +
                $"Start: {Start}\n" +
                $"End: {End}\n" +
                $"Participants {Participants}\n";
        }
    }
}
