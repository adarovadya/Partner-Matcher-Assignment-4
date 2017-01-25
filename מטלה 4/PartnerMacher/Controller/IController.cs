using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerMacher.Controller
{
    public interface IController
    {
        void joinGroup(string group, string publisher);
        void publishSport(string groupName, string expirationDate, string content, string Location,
               string Sport, string date, string length, string profficiency);
        void publishDate(string groupName, string expirationDate, string content, string Location, string wantedSex /*f/m*/,
                string minAge, string maxAge, string date, bool mobility, string religion, 
                bool veggie, string education/*comboBox*/, string minHigth, string language,
                string body /*comboBox*/, string MartialStatus /*comboBox*/);

        void publishTravel(string groupName, string expirationDate, string content, string destination, string wantedSex /*f/m*/,
               string minAge, string maxAge, string date, string flexibility, string religion,
                bool veggie, string education /*comboBox*/, string language,
                string approxLength, string Location);

        void publishApartment(string groupName,string expirationDate, string content, string city, string street,
               string minAge, string maxAge, string joinMonth, string language, 
                string currentRoomates, string roomates, string contractLength,
                bool furniture);
    }
}
