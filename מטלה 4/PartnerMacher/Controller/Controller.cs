using PartnerMacher.View;
using PartnerMacher.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerMacher.Controller
{
    class MyController : IController
    {
        protected MyModel m_model;
        protected IView m_view;

        public MyController() { }


        public void SetModel(MyModel model)
        {
            m_model = model;
        }

        public void SetView(IView view)
        {
            m_view = view;
        }

        public void Output(string title, string output)
        {
            if (m_view != null)
                m_view.Output(title, output);
            else Console.WriteLine("Error (0)");
        }

        public DataTable ShowUserGroups()
        {
            return m_model.ShowUserGroups();
        }

        public void initiate()
        {
            m_model.initiate();
        }

        public void Login(string email, string password)
        {
            if (m_model.Login(email, password))
                m_view.returnLogin();
        }

        public bool SignUp(string email, string password, string fullname, string address, string birthdate, string sex)
        {
            return m_model.SignUp(email, password, fullname, address, birthdate, sex);
        }

        public List<string> GetCities()
        {
            return m_model.GetCities();
        }

        public List<string> GetFields()
        {
            return m_model.GetFields();
        }

        public DataTable SearchByFieldLocation(string field, string location)
        {
            return m_model.SearchByFieldLocation(field, location);
        }

        public void SendMail(string title, string text, string address)
        {
            m_model.SendMail(title, text, address);
        }

        public void joinGroup(string group, string publisher)
        {
            m_model.joinGroup(group, publisher);
        }

        public void CreateGroup(string email, string grpName, string area)
        {
            m_model.createNewGroup(email, grpName, area);

        }

        public void publishSport(string groupName, string expirationDate, string content, string Location, string Sport, string date, string length, string profficiency)
        {
            m_model.publishSport(groupName, expirationDate, content, Location, Sport, date, length, profficiency);
        }

        public void publishDate(string groupName, string expirationDate, string content, string Location, string wantedSex, string minAge, string maxAge, string date, bool mobility, string religion, bool veggie, string education, string minHigth, string language, string body, string MartialStatus)
        {
            m_model.publishDate(groupName, expirationDate, content, Location, wantedSex, minAge, maxAge, date, mobility, religion, veggie, education, minHigth, language, body, MartialStatus);
        }

        public void publishTravel(string groupName, string expirationDate, string content, string destination, string wantedSex, string minAge, string maxAge, string date, string flexibility, string religion, bool veggie, string education, string language, string approxLength, string Location)
        {
            m_model.pubishTravel(groupName, expirationDate, content, destination, wantedSex, minAge, maxAge, date, flexibility, religion, veggie, education, language, approxLength, Location);
        }

        public void publishApartment(string groupName, string expirationDate, string content, string city, string street, string minAge, string maxAge, string joinMonth, string language, string currentRoomates, string roomates, string contractLength, bool furniture)
        {
            m_model.pubishApartment(groupName, expirationDate, content, city, street, minAge, maxAge, joinMonth, language, currentRoomates, roomates, contractLength, furniture);
        }

        public string getConecteduser()
        {
            return m_model.getConecteduser();
        }
    }
}