using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;

namespace DataLayer
{
    public class DBSaver
    {
        public void DeleteCompany(string companyName) {
            using (var db = new TransportSystemDB()) {
                var toBeDeletedCompany = from c in db.Companies
                                         where c.Name.Equals(companyName)
                                         select c;
                db.DeleteObject(toBeDeletedCompany.First());
                db.SaveChanges();
            }
        }

        public void RegisterCompany(string name, string city, string address, string phone, string email) {
            using (var db = new TransportSystemDB()) {
                Company company = new Company() { Name = name, City = city, Address = address, PhoneNumber = phone, Email = email };
                db.Companies.AddObject(company);
                db.SaveChanges();
            }
        }

        public void EditCompany(string company, string attribute, string value) {
            using (var db = new TransportSystemDB()) {
                var query = from c in db.Companies
                                    where c.Name.Equals(company)
                                    select c;
                Company editedCompany = query.First();
                EditCompanyAttribute(attribute, editedCompany, value);   
                db.Refresh(System.Data.Objects.RefreshMode.ClientWins, editedCompany);
                db.SaveChanges();
            }
        }

        public void RegisterTravel(string company, string startCity, DateTime startTime, string stop, string endCity, DateTime endTime, int ticketPrice) {
            using (var db = new TransportSystemDB()) {
                Travel travel = new Travel() { 
                    Company = company, StartCity = startCity , StartTime = startTime, EndCity = endCity, EndTime = endTime, TicketPrice = ticketPrice
                };

                Stop intermediaryStop = new Stop() { stop1 = stop, id = travel.id };
                db.Stops.AddObject(intermediaryStop);
                db.Travels.AddObject(travel);
                db.SaveChanges();
            }
        }

        private void EditCompanyAttribute(string attribute, Company editedCompany, string value)
        {
            switch (attribute)
            {
                case "Name":
                    editedCompany.Name = value;
                    break;
                case "City":
                    editedCompany.City = value;
                    break;
                case "Address":
                    editedCompany.Address = value;
                    break;
                case "Phone":
                    editedCompany.PhoneNumber = value;
                    break;
                case "Email":
                    editedCompany.Email = value;
                    break;
            }
        }
    }
}
