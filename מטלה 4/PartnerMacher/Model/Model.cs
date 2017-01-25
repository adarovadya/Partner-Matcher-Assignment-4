using PartnerMacher.Controller;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Data.OleDb;
using System.Net.Mail;
using System.Data;
using System.Windows.Forms;

namespace PartnerMacher.Model
{
    class MyModel
    {
        private Mutex m_mutex;
        private MyController m_controller;
        private List<Thread> m_threads;
        private OleDbConnection DB;
        private string connectedUser = null;

        public MyModel(MyController c)
        {
            m_controller = c;
            m_threads = new List<Thread>();
            m_mutex = new Mutex();
            DB = new OleDbConnection();
            /*DB.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"\DB\PartnersMatcherDB.accdb; Persist Security Info=False;";*/
            DB.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath.ToString() + @"\PartnersMatcherDB.accdb;
                                        Persist Security Info=False;";
        }

        public string getConecteduser()
        {
            return connectedUser;
        }

        public void initiate()
        {
            try
            {
                DB.Open();
            }
            catch (Exception ex)
            {
                m_controller.Output("Error initiate:", ex.ToString());
            }
            DB.Close();
        }

        public bool Login(string email, string password)
        {
            bool ans = false;
            try
            {
                DB.Open();
            }
            catch (Exception ex)
            {
                m_controller.Output("Error Login:", ex.ToString());
            }
            OleDbCommand varifyLogin = new OleDbCommand();
            varifyLogin.Connection = DB;
            varifyLogin.CommandText = "select * from Users where email='" + email + "' and password='" + password + "'";
            OleDbDataReader reader = varifyLogin.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count == 1)
            {
                connectedUser = email;
                m_controller.Output("Welcome Back", "Login Succesfully");
                ans = true;
            }
            else
            {
                m_controller.Output("Login Failed", "Seems like the login information inserted is wrong, please try again.");
            }
            DB.Close();
            return ans;
        }

        internal void publishSport(string groupName, string expirationDate, string content, string location, string sport, string date, string length, string profficiency)
        {
            //check if theres such group
            DB.Open();
            OleDbCommand varify = new OleDbCommand();
            varify.Connection = DB;
            varify.CommandText = "select * from MembersGroups where groupID='" + groupName + "' and memberID='" + connectedUser + "'";
            OleDbDataReader reader = varify.ExecuteReader();
            int count = 0;
            if (reader.Read())
            {
                count++;
            }
            if (count == 0)
            {
                m_controller.Output("Error", "You are not a member of this group and therefore you cannot post an ad for it.");
                DB.Close();
                return;
            }
            var a = reader["groupID"];
            bool check = (bool)reader["published_ad"];
            if (!check)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = DB;
                cmd.CommandText = "update MembersGroups set published_ad ='-1' where groupID='" + groupName + "' and memberID='" + connectedUser + "'";
                cmd.ExecuteNonQuery();

                if (expirationDate == "") expirationDate = DateTime.Today.AddMonths(2).ToString("d");

                cmd = new OleDbCommand();
                cmd.Connection = DB;
                cmd.CommandText = "insert into SportAds ([grp_name],[publisher], [publish_date], [expiration_date], [content], [location], [sport], [time], [length], [profficiency]) values ('" + groupName + "','" + connectedUser + "','" + DateTime.Today.ToString("d") + "','" + expirationDate + "','" + content + "','" + location + "','" + sport + "','" + date + "','" + length + "','" + profficiency + "')";
                cmd.ExecuteNonQuery();
                //output
                m_controller.Output("Well done!", "Your ad was succesfully posted!");

            }
            else m_controller.Output("Error", "You already posted an ad for this group, only one ad can be posted.");
            DB.Close();
            //check if the user is a member and didnt posted an ad before
            //post add or return error
        }

        public void pubishApartment(string groupName, string expirationDate, string content, string city, string street, string minAge, string maxAge, string joinMonth, string language, string currentRoomates, string roomates, string contractLength, bool furniture)
        {
            //check if theres such group
            DB.Open();
            OleDbCommand varify = new OleDbCommand();
            varify.Connection = DB;
            varify.CommandText = "select * from MembersGroups where groupID='" + groupName + "' and memberID='" + connectedUser + "'";
            OleDbDataReader reader = varify.ExecuteReader();

            if (!reader.Read())
            {
                m_controller.Output("Error", "You are not a member of this group and therefore you cannot post an ad for it.");
                DB.Close();
                return;
            }

            bool check = (bool)reader["published_ad"];
            if (!check)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = DB;
                cmd.CommandText = "update MembersGroups set published_ad ='-1' where groupID='" + groupName + "' and memberID='" + connectedUser + "'";
                cmd.ExecuteNonQuery();

                string fur = "0";
                if (expirationDate == "") expirationDate = DateTime.Today.AddMonths(2).ToString("d");
                if (furniture) fur = "-1";

                cmd = new OleDbCommand();
                cmd.Connection = DB;
                cmd.CommandText = "insert into ApartmentAds ([grp_name],[publisher], [publish_date], [expiration_date], [content], [city], [street], [min_age], [max_age], [join_month], [language], [current_roomates], [roomates], [contract_length], [furniture]) values ('" + groupName + "','" + connectedUser + "','" + DateTime.Today.ToString("d") + "','" + expirationDate + "','" + content + "','" + city + "','" + street + "','" + minAge + "','" + maxAge + "','" + joinMonth + "','" + language + "','" + currentRoomates + "','" + roomates + "','" + contractLength + "','" + fur + "')";
                cmd.ExecuteNonQuery();
                //output
                m_controller.Output("Well done!", "Your ad was succesfully posted!");
            }
            else m_controller.Output("Error", "You already posted an ad for this group, only one ad can be posted.");
            DB.Close();
            //check if the user is a member and didnt posted an ad before
            //post add or return error
        }


        public void pubishTravel(string groupName, string expirationDate, string content, string destination, string wantedSex, string minAge, string maxAge, string date, string flexibility, string religion, bool veggie, string education, string language, string approxLength, string location)
        {
            //check if theres such group
            DB.Open();
            OleDbCommand varify = new OleDbCommand();
            varify.Connection = DB;
            varify.CommandText = "select * from MembersGroups where groupID='" + groupName + "' and memberID='" + connectedUser + "'";
            OleDbDataReader reader = varify.ExecuteReader();

            if (!reader.Read())
            {
                m_controller.Output("Error", "You are not a member of this group and therefore you cannot post an ad for it.");
                DB.Close();
                return;
            }

            bool check = (bool)reader["published_ad"];

            if (!check)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = DB;
                cmd.CommandText = "update MembersGroups set published_ad ='-1' where groupID='" + groupName + "' and memberID='" + connectedUser + "'";
                cmd.ExecuteNonQuery();

                int veg = 0;
                if (expirationDate == "") expirationDate = DateTime.Today.AddMonths(2).ToString("d");
                if (veggie) veg = -1;

                cmd = new OleDbCommand();
                cmd.Connection = DB;
                cmd.CommandText = "insert into TravelAds ([grp_name],[publisher], [publish_date], [expiration_date], [content], [destination], [wanted_sex], [min_age], [max_age], [approx_time], [time_flexibility], [religion], [veggie], [education], [language], [approx_length], [location]) values ('" + groupName + "','" + connectedUser + "','" + DateTime.Today.ToString("d") + "','" + expirationDate + "','" + content + "','" + destination + "','" + wantedSex + "','" + minAge + "','" + maxAge + "','" + date + "','" + flexibility + "','" + religion + "','" + veg + "','" + education + "','" + language + "','" + approxLength + "','" + location + "')";
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e) { MessageBox.Show(e.ToString()); }
                //output
                m_controller.Output("Well done!", "Your ad was succesfully posted!");
            }
            else m_controller.Output("Error", "You already posted an ad for this group, only one ad can be posted.");
            DB.Close();
            //check if the user is a member and didnt posted an ad before
            //post add or return error
        }

        public void publishDate(string groupName, string expirationDate, string content, string location, string wantedSex, string minAge, string maxAge, string date, bool mobility, string religion, bool veggie, string education, string minHigth, string language, string body, string martialStatus)
        {
            //check if theres such group
            DB.Open();
            OleDbCommand varify = new OleDbCommand();
            varify.Connection = DB;
            varify.CommandText = "select * from MembersGroups where groupID='" + groupName + "' and memberID='" + connectedUser + "'";
            OleDbDataReader reader = varify.ExecuteReader();

            if (!reader.Read())
            {
                m_controller.Output("Error", "You are not a member of this group and therefore you cannot post an ad for it.");
                DB.Close();
                return;
            }

            bool check = (bool)reader["published_ad"];

            if (!check)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = DB;
                cmd.CommandText = "update MembersGroups set published_ad ='-1' where groupID='" + groupName + "' and memberID='" + connectedUser + "'";
                cmd.ExecuteNonQuery();

                string veg = "0", mob = "0";
                if (expirationDate == "") expirationDate = DateTime.Today.AddMonths(2).ToString("d");
                if (veggie) veg = "-1";
                if (mobility) mob = "-1";

                cmd = new OleDbCommand();
                cmd.Connection = DB;
                cmd.CommandText = "insert into DateAds ([grp_name],[publisher], [publish_date], [expiration_date], [content], [location], [wanted_sex], [min_age], [max_age], [meeting_time], [mobility], [religion], [veggie], [education],[min_height], [language], [body_structure], [martial_status]) values ('" + groupName + "','" + connectedUser + "','" + DateTime.Today.ToString("d") + "','" + expirationDate + "','" + content + "','" + location + "','" + wantedSex + "','" + minAge + "','" + maxAge + "','" + date + "','" + mob + "','" + religion + "','" + veg + "','" + education + "','" + minHigth + "','" + language + "','" + body + "','" + martialStatus + "')";
                cmd.ExecuteNonQuery();
                //output
                m_controller.Output("Well done!", "Your ad was succesfully posted!");

            }
            else m_controller.Output("Error", "You already posted an ad for this group, only one ad can be posted.");
            DB.Close();
            //check if the user is a member and didnt posted an ad before
            //post add or return error
        }

        public void SendMail(string title, string text, string address)
        {
            sendMail(title, text, address);
        }

        public DataTable SearchByFieldLocation(string field, string Location)
        {
            DataTable dataTable = new DataTable();
            OleDbDataReader reader = null;
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DB;

                switch (field.ToLower())
                {
                    case "date":
                        DB.Open();
                        command.CommandText = "select * from DateAds where location ='" + Location + "' and expiration_date > Date()";
                        reader = command.ExecuteReader();
                        break;

                    case "sport":
                        DB.Open();
                        command.CommandText = "select * from SportAds where location ='" + Location + "' and expiration_date > Date()";
                        reader = command.ExecuteReader();
                        break;
                    case "trip":
                        DB.Open();
                        command.CommandText = "select * from TravelAds where location ='" + Location + "' and expiration_date > Date()";
                        reader = command.ExecuteReader();
                        break;
                    case "apartment":
                        DB.Open();
                        command.CommandText = "select * from ApartmentAds where city ='" + Location + "' and expiration_date > Date()";
                        reader = command.ExecuteReader();
                        break;
                    default:
                        reader = null;
                        break;
                }
                dataTable.Load(reader);
                DB.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                m_controller.Output("Error", e.Message);
            }
            finally
            {
                DB.Close();
                if (null != reader)
                    reader.Close();
            }
            return dataTable;
        }

        public List<string> GetFields()
        {
            List<string> ans = new List<string>();
            ans.Add("Sport");
            ans.Add("Date");
            ans.Add("Trip");
            ans.Add("Apartment");
            ans.Sort();
            return ans;
        }

        public List<string> GetCities()
        {
            List<string> ans = new List<string>();
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DB;
                command.CommandText = "select * from Cities";
                DB.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ans.Add(reader.GetString(0));
                    Console.WriteLine(reader.GetString(0));
                }
                DB.Close();
            }
            catch (Exception e)
            {
                m_controller.Output("Error ", "Error in function GetCities()");
                DB.Close();
            }
            return ans;
        }

        /*public void SignUp(string email, string password)
        {
            try
            {
                DB.Open();
            }
            catch (Exception ex)
            {
                m_controller.Output("Error SignUp:", ex.ToString());
            }
            OleDbCommand varifyLogin = new OleDbCommand();
            varifyLogin.Connection = DB;
            varifyLogin.CommandText = "select * from Users where email='" + email + "'";
            OleDbDataReader reader = varifyLogin.ExecuteReader();
            int count = 0;
            while (reader.Read())
                count++;

            if (count != 0)
            {
                m_controller.Output("Error SignUp", "A user with that email address already exists");
            }
            else
            {
                int check = 0;
                OleDbCommand registerUser = new OleDbCommand();
                registerUser.Connection = DB;
                registerUser.CommandType = CommandType.Text;
                registerUser.CommandText = "insert into Users ([email],[password]) values ('" + email + "','" + password + "')";
                try
                {
                    reader = registerUser.ExecuteReader();
                    count = 0;
                    while (reader.Read())
                    {
                        count++;
                    }
                }
                catch(Exception e)
                {
                    m_controller.Output("Wrong Input", e.Message);
                }
                if (count == 1)
                {
                    m_controller.Output("Welcome", "Registration Completed");
                    sendMail("Welcome to Partner Matcher", "Your registration to Partner Matcher is completed, we hope you enjoy our services.\n\nNow go search for partners, what are you waiting for?, your next partner is just a few clicks away...\n\nBest Regards,\nPartner Matcher team", email);
                }
            }
            DB.Close();
        }*/

        public bool SignUp(string email, string password, string fullname, string address, string birthdate, string sex)
        {
            try
            {
                DB.Open();
            }
            catch (Exception ex)
            {
                m_controller.Output("Error", ex.ToString());
                DB.Close();
                return false;
            }
            OleDbCommand varify = new OleDbCommand();
            varify.Connection = DB;
            varify.CommandText = "select * from Users where email='" + email + "'";
            OleDbDataReader reader = varify.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count != 0)
            {
                m_controller.Output("Error", "A user with that email address already exists");
                DB.Close();
                return false;
            }
            else
            {
                int check = 0;
                OleDbCommand registerUser = new OleDbCommand();
                registerUser.Connection = DB;
                registerUser.CommandType = CommandType.Text;
                registerUser.CommandText = "insert into Users ([email],[password]) values ('" + email + "','" + password + "')";
                try
                {
                    check = registerUser.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    m_controller.Output("Wrong Input", "Invalid parameters inserted");
                    DB.Close();
                    return false;
                }
                if (check == 1)
                {
                    if (fullname != "")
                    {
                        registerUser.CommandText = "update Users set full_name ='" + fullname + "' where email = '" + email + "'";
                        try
                        {
                            registerUser.ExecuteNonQuery();
                        }
                        catch (Exception e) { m_controller.Output("Error", "Invalid name inserted"); }
                    }
                    if (address != "")
                    {
                        registerUser.CommandText = "update Users set address ='" + address + "' where email = '" + email + "'";
                        try
                        {
                            registerUser.ExecuteNonQuery();
                        }
                        catch (Exception e) { m_controller.Output("Error", "Invalid address inserted"); }
                    }
                    if (birthdate != "")
                    {
                        registerUser.CommandText = "update Users set birthdate ='" + birthdate + "' where email = '" + email + "'";
                        try
                        {
                            registerUser.ExecuteNonQuery();
                        }
                        catch (Exception e) { m_controller.Output("Error", "Invalid birthdate inserted"); }
                    }
                    if (sex != "")
                    {
                        registerUser.CommandText = "update Users set sex ='" + sex + "' where email = '" + email + "'";
                        try
                        {
                            registerUser.ExecuteNonQuery();
                        }
                        catch (Exception e) { m_controller.Output("Error", "Invalid gender inserted"); }
                    }
                    m_controller.Output("Welcome", "Registration Completed");
                    sendMail("Welcome to Partner Matcher", "Your registration to Partner Matcher is completed, we hope you enjoy our services.\n\nNow go search for partners, what are you waiting for?, your next partner is just a few clicks away...\n\nBest Regards,\nPartner Matcher team", email);
                    DB.Close();
                    return true;
                }
            }
            DB.Close();
            return false;
        }

        private void sendMail(string title, string text, string adress)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("partnermatcher.bgu@gmail.com");
                mail.To.Add(adress);
                mail.Subject = title;
                mail.Body = text;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("partnermatcher.bgu", "qwerty1234asdf");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                m_controller.Output("Error sendMail:", ex.ToString());
            }
        }

        public void joinGroup(string group, string publisher)
        {
            JoinGroup(group, publisher);
        }

        private void JoinGroup(string group, string publisher)
        {
            if (connectedUser == null) return;
            try
            {
                DB.Open();
            }
            catch (Exception ex)
            {
                m_controller.Output("DB Error", ex.ToString());
                DB.Close();
            }
            OleDbCommand validate = new OleDbCommand();
            validate.Connection = DB;
            validate.CommandText = "select * from GroupRequests where user='" + connectedUser + "' and group_name='" + group + "' and publisher='" + publisher + "'";
            int check = 0;
            try
            {
                OleDbDataReader reader = validate.ExecuteReader();
                while (reader.Read())
                    check++;

                if (check != 0)
                {
                    m_controller.Output("Error", "You already requested to join this group");
                    DB.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                m_controller.Output("DB Error", ex.ToString());
                DB.Close();
            }

            OleDbCommand join = new OleDbCommand();
            join.Connection = DB;
            join.CommandType = CommandType.Text;
            join.CommandText = "insert into GroupRequests ([user],[group_name],[publisher]) values ('" + connectedUser + "','" + group + "','" + publisher + "')";
            try
            {
                check = join.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                m_controller.Output("Wrong Input", e.Message);
                DB.Close();
            }
            if (check == 1)
            {
                m_controller.Output("Request sent succesfully", "Your request to join the group was sent succesfully, all you have to do now is wait for approval.");
                sendMail("Partner Matcher", "We are just contacting you to notify that a request to join a group was sent from your account, if you asked to join the group you may dispose this mail.\nIf it was not you please contact us by replying to this mail.\n\nBest Regard\nPartner Matcher Team", connectedUser);
            }
            DB.Close();
        }

        /*Parameters:
            [0] Ad type (date, sport, apartment, trip)
            [1] Group Name
            [2] 
            [3] 

            check if is manager and handle accordingly
        */
        public void publishAd()
        {

        }

        private void Publish()
        {
            //Data needed : 
        }

        public DataTable ShowUserGroups()
        {
            if (connectedUser == null)
            {
                return null;
            }
            OleDbConnection oledb = new OleDbConnection();
            OleDbConnection oledb2 = new OleDbConnection();

            OleDbDataReader reader = null;
            OleDbDataReader reader2 = null;

            OleDbCommand command;
            OleDbCommand command2;

            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("Group Name");
            dataTable.Columns.Add("Area");
            dataTable.Columns.Add("joining date");
            dataTable.Columns.Add("number of friends in group");

            try
            {
                oledb.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath.ToString() + @"\PartnersMatcherDB.accdb;
                                        Persist Security Info=False;";
                oledb2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath.ToString() + @"\PartnersMatcherDB.accdb;
                                        Persist Security Info=False;";
                command = new OleDbCommand();
                command.Connection = oledb;
                oledb.Open();
                oledb2.Open();

                command.CommandText = "select * from MembersGroups where memberID ='" + connectedUser + "'";
                reader = command.ExecuteReader();

                //dataTable.Load(reader);
                DataRow workRow;

                while (reader.Read())
                {
                    string groupID = (string)reader["groupID"];
                    reader2 = null;
                    command2 = new OleDbCommand();
                    command2.Connection = oledb2;
                    command2.CommandText = "select * from Groups where grp_name ='" + groupID + "'";
                    reader2 = command2.ExecuteReader();

                    reader2.Read();
                    string area = (string)reader2["area"];
                    string joiningDate = reader["join_date"].ToString();
                    string numberOfFriendsInGroup = reader2["members"].ToString();

                    workRow = dataTable.NewRow();
                    workRow["Group Name"] = groupID;
                    workRow["Area"] = area;
                    workRow["joining date"] = joiningDate;
                    workRow["number of friends in group"] = numberOfFriendsInGroup;

                    dataTable.Rows.Add(workRow);
                }

                oledb.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        private void create_group(string groupName, string email, string area, string members)
        {
            DB.Open();

            //Check if the group exists
            OleDbCommand check = new OleDbCommand();
            check.Connection = DB;
            check.CommandText = "select * from Groups where grp_name='" + groupName + "'";
            OleDbDataReader reader = check.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count != 0)
            {
                m_controller.Output("Error", "Seems like this group name is already taken, please try another name");
                return;
            }

            DateTime today = DateTime.Today;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = DB;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Groups ([grp_name],[creationDate],[manager],[area],[members]) values('" + groupName + "','" + today.ToString("d") + "','" + email + "','" + area + "','" + members + "')";
            cmd.ExecuteNonQuery();
            DB.Close();
        }

        private void add_group_member(string groupName, string email)
        {
            DB.Open();

            //Check if the group exists
            OleDbCommand checkgroup = new OleDbCommand();
            checkgroup.Connection = DB;
            checkgroup.CommandText = "select * from Groups where grp_name='" + groupName + "'";
            OleDbDataReader grp_reader = checkgroup.ExecuteReader();
            int count = 0;
            while (grp_reader.Read())
            {
                count++;
            }
            if (count == 0)
            {
                m_controller.Output("Error", "Seems like we have no group with such name");
                return;
            }

            OleDbCommand cmd1 = new OleDbCommand();
            DateTime today = DateTime.Today;
            cmd1.Connection = DB;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "Insert into MembersGroups ([groupID],[memberID],[join_date]) values('" + groupName + "','" + email + "','" + today.ToString("d") + "');";
            cmd1.ExecuteNonQuery();
            /*
            //NEED TO INCREASE THE NUMBER OF MEMBERS IN GROUP
            OleDbCommand increament = new OleDbCommand();
            increament.Connection = DB;
            increament.CommandType = CommandType.Text;
            increament.CommandText = "select members from Groups where grp_name ='" + groupName + "'";
            var reader = increament.ExecuteReader();
            int members;
            bool check = Int32.TryParse(reader.ToString(), out members);
            if (check)
            {
                members++;
            }
            increament.CommandText = "update Groups set members ='" + members + "' where grp_name = '" + groupName + "'";
            increament.ExecuteNonQuery();*/
            DB.Close();
        }

        public void createNewGroup(string email, string groupName, string area)
        {
            try
            {
                if (area != "date" & area != "sport" & area != "trip" & area != "apartment")
                {
                    //print error
                    m_controller.Output("Group area error", "This area of interest doesn't exist yet in PartnerMatcher database, our experts will examine your request to create new area in 48 hours, thank you for your patience! hope you will enjoy our app!");
                    return;
                }
                if (connectedUser != null)
                    if (connectedUser == email)
                    {
                        create_group(groupName, email, area, "1");
                        add_group_member(groupName, email);
                        m_controller.Output("Success CreateGroup", "Your group " + groupName + " has been successfuly added");
                        sendMail("Group Created", "You have just created succesfuly new group named " + groupName + " hope you will enjoy our app!", email);
                    }
                    else
                    {
                        //user is not manager check if manager exists if not search send mail
                        DB.Open();
                        OleDbCommand varify = new OleDbCommand();
                        varify.Connection = DB;
                        varify.CommandText = "select * from Users where email='" + email + "'";
                        OleDbDataReader reader = varify.ExecuteReader();
                        int count = 0;
                        while (reader.Read())
                        {
                            count++;
                        }
                        if (count != 1)
                        {
                            m_controller.Output("Create Group Error", "The User Email inserted as group manager does not exist, a mail was sent to invite them to join the app and add their group - Group was not added.");
                            sendMail("Partner Matcher", "Hello, one of our users added you as a manager of a group, but since you are not signed up in our system the group could not be added\nYou are most welcome to join Partner Matcher to add your groups and search for partners.\n\nBest Regards,\nPartner Matcher Team", email);
                            //EDIT MESSAGE - NO MANAGER USER EXISTS SEND MAIL AND ALERT USER GROUP WAS NOT ADDED
                            return;
                        }
                        DB.Close();
                        create_group(groupName, email, area, "2");
                        add_group_member(groupName, email);
                        add_group_member(groupName, connectedUser);
                        m_controller.Output("Success CreateGroup", "Your group " + groupName + " has been successfuly added");
                        sendMail("Group Created", connectedUser + " have just created succesfuly new group named " + groupName + " and chose you as its manager\nIf it's not your group please contact us immediatly.", email);
                        sendMail("Group Created", "You have just created succesfuly new group named " + groupName + " hope you will enjoy our app!", connectedUser);
                    }
                else
                {
                    m_controller.Output("Login Error", "You must sign in before creating a group");
                }
            }
            catch (Exception e)
            {
                m_controller.Output("Create Group Error", e.Message);
            }
        }
    }
}
