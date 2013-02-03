using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class TravelDAO
    {
        public string Company {get; set;}

        public string StartCity { get; set; }

        public DateTime StartTime { get; set; }

        public string EndCity { get; set; }

        public DateTime EndTime { get; set; }

        public int TicketPrice { get; set; }

        public string Stops { get{
            StringBuilder builder = new StringBuilder();
            if (stops.Count > 0) {
                builder.Append(stops.ElementAt(0).stop1);
            }
            for (int i = 1; i < stops.Count; ++i) {
                builder.Append(", ");
                builder.Append(stops.ElementAt(i).stop1);
            }
            return builder.ToString();
        } }

        private LinkedList<Stop> stops;

        public TravelDAO(string company, string startCity, DateTime startTime, LinkedList<Stop> stops, string endCity, DateTime endTime, int ticketPrice) {
            this.Company = company;
            this.StartCity = startCity;
            this.StartTime = startTime;
            this.EndCity = endCity;
            this.EndTime = endTime;
            this.TicketPrice = ticketPrice;
            this.stops = new LinkedList<Stop>(stops);
        }

    }
}
