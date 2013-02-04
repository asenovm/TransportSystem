using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace TransportSystem
{
    public class ValidationUtil
    {

        public static bool IsValidTime(string time) {
            if (!Regex.IsMatch(time, "\\d+/\\d+/\\d+ \\d+:\\d+:\\d+"))
            {
                return false;
            }
            else
            {
                string[] times = time.Split(' ');
                string[] date = times[0].Split('/');
                string[] hours = times[1].Split(':');
                int month = int.Parse(date[0]);
                int day = int.Parse(date[1]);
                int year = int.Parse(date[2]);

                int hour = int.Parse(hours[0]);
                int minute = int.Parse(hours[1]);
                int seconds = int.Parse(hours[2]);

                return month < 12 && month > 0 && day > 1 && day < 31 && hour >= 0 && hour < 24 && minute >= 0 && minute < 60 && seconds >= 0 && seconds < 60;
            }
        }

        public static bool IsValidCity(string city) {
            return Regex.IsMatch(city, "[a-zA-Z]+");
        }

        public static bool IsValidAddress(string address) {
            return Regex.IsMatch(address, "[a-zA-Z]+");
        }

        public static bool IsValidPhone(string phone) {
            return Regex.IsMatch(phone, "\\+?\\d{4,}");
        }

        public static bool IsValidEmail(string email) {
            return Regex.IsMatch(email, "[a-zA-Z0-9_\\-\\.]+@[a-zA-Z0-9_\\-\\.]+\\.[a-zA-Z]+");
        }

        public static bool IsValidName(string name) {
            return Regex.IsMatch(name, "[a-zA-Z]+");
        }
    }
}