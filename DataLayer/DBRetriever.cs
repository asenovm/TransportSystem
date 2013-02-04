using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DBRetriever
    {

        private const string DATE_FORMAT = "MM/dd/yyyy HH:mm:ss";

        public IEnumerable<string> GetCompanyNames() {
            IEnumerable<string> result = null;
            using (var db = new TransportSystemDB()) {
                var query = from c in db.Companies
                            select c.Name;
                result = new LinkedList<string>(query);
            }
            return result;
        }

        public IEnumerable<TravelDAO> GetAllTravels() {
            LinkedList<TravelDAO> result = new LinkedList<TravelDAO>();
            using (var db = new TransportSystemDB()) {
                var travels = from c in db.Travels
                              select c;
                var stops = from c in db.Stops
                            select c;
                var joinedTravels = travels.Join(stops, s => s.id, w => w.id, (s,w) => s);

                foreach (var travel in joinedTravels) { 
                    result.AddLast(new TravelDAO(travel.Company, travel.StartCity, travel.StartTime, new LinkedList<Stop>(travel.Stops), travel.EndCity, travel.EndTime, travel.TicketPrice));
                }
            }
            return result;
        }

        public IEnumerable<TravelDAO> GetFastestTravels() {
            Dictionary<string, TravelDAO> fastestTravels = new Dictionary<string, TravelDAO>();
            IEnumerable<TravelDAO> allTravels = GetAllTravels();
            foreach (var travel in allTravels) {
                if (!fastestTravels.ContainsKey(travel.EndCity))
                {
                    fastestTravels.Add(travel.EndCity, travel);
                }
                else{
                    TimeSpan currentTravelLength = travel.EndTime.Subtract(travel.StartTime);
                    TravelDAO currentFastestTravel = fastestTravels[travel.EndCity];
                    TimeSpan otherTravelLength = currentFastestTravel.EndTime.Subtract(currentFastestTravel.StartTime);
                    if (currentTravelLength.CompareTo(otherTravelLength) < 0) {
                        fastestTravels[travel.EndCity] = travel;
                    }
                }
            }
            return fastestTravels.Values;
        }

        public IEnumerable<TravelDAO> GetCheapestTravels() {
            Dictionary<string, TravelDAO> cheapestTravels = new Dictionary<string, TravelDAO>();
            IEnumerable<TravelDAO> allTravels = GetAllTravels();
            foreach (var travel in allTravels)
            {
                if (!cheapestTravels.ContainsKey(travel.EndCity))
                {
                    cheapestTravels.Add(travel.EndCity, travel);
                }
                else
                {
                    int currentTravelPrice= travel.TicketPrice;
                    TravelDAO currentCheapestTravel = cheapestTravels[travel.EndCity];
                    int otherTravelPrice = currentCheapestTravel.TicketPrice;
                    if (currentTravelPrice < otherTravelPrice)
                    {
                        cheapestTravels[travel.EndCity] = travel;
                    }
                }
            }
            return cheapestTravels.Values;            
        }

        public IEnumerable<TravelDAO> GetMatchingTravels(IEnumerable<TravelDAO> travels, string key, string value) {
            LinkedList<TravelDAO> matchingTravels = new LinkedList<TravelDAO>();
            foreach (var travel in travels) {
                if (IsAddingItem(travel, key, value))
                {
                    matchingTravels.AddLast(travel);
                }
            }
            return matchingTravels;
        }

        private bool IsAddingItem(TravelDAO travel, string key, string value) {
            switch (key)
            {
                case "start":
                    return travel.StartCity.Equals(value);
                case "end":
                    return travel.EndCity.Equals(value);
                case "startTime":
                    return travel.StartTime.Equals(DateTime.ParseExact(value, DATE_FORMAT, System.Globalization.CultureInfo.GetCultureInfo("EN-US")));
                case "endTime":
                    return travel.EndTime.Equals(DateTime.ParseExact(value, DATE_FORMAT, System.Globalization.CultureInfo.GetCultureInfo("EN-US")));
                case "company":
                    return travel.Company.Equals(value);
                case "ticketPrice":
                    return travel.TicketPrice == int.Parse(value);
                default:
                    return false;
            }        
        }

        public bool ExistsCompany(string companyName) {
            using (var db = new TransportSystemDB()) {
                var company = from c in db.Companies
                              where c.Name.Equals(companyName)
                              select c;
                return new LinkedList<Company>(company).Count > 0;
            }
        }
    }
}
