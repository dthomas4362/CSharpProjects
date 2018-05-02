using LegacyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //ServiceReference1.Service1Client ws = new ServiceReference1.Service1Client();
            //var u = ws.addUser("Mike", "Jones", "jones1@yahoo.com", "123456");
            //u.print();
            ServiceReference1.Service1Client ws = new ServiceReference1.Service1Client();
            var list = ws.getReligions();
            foreach( var r in list)
            {
                Console.WriteLine(r.religion1);
            }
            var list1 = ws.getGenders();
            foreach (var r in list1)
            {
                Console.WriteLine(r.gender1);
            }

            var list2 = ws.getPolitics();
            foreach (var r in list2)
            {
                Console.WriteLine(r.politic1);
            }
            var list3 = ws.getCountries();
            foreach (var r in list3)
            {
                Console.WriteLine(r.country1);
            }

            var list4 = ws.getUserTypes();
            foreach (var r in list4)
            {
                Console.WriteLine(r.user_type);
            }

            var list6 = ws.getMessageTypes();
            foreach (var r in list6)
            {
                Console.WriteLine(r.message_type);
            }
            var list5 = ws.getHobbies();
            foreach (var r in list5)
            {
                Console.WriteLine(r.hobby1);
            }

            var list7 = ws.getSchools();
            foreach (var r in list7)
            {
                Console.WriteLine(r.school_name + " located at zipcode " + r.school_zip + " graduated " + r.school_year );
            }

            var list8 = ws.getJobs();
            foreach (var r in list8)
            {
                Console.WriteLine(r.position + " at " + r.company_name + " from " + r.year_started + " - " + r.year_ended );
            }

            var list9 = ws.getStates();
            foreach (var r in list9)
            {
                Console.WriteLine(r.name + " at " + r.countryName);
            }

            var list10 = ws.getAddresses();
            foreach (var r in list10)
            {
                Console.WriteLine(r.address1 + " " + r.postal_code + " " + r.stateName);
            }

            var list11 = ws.getMessages();
            foreach (var r in list11)
            {
                Console.WriteLine(r.title + " " + r.message1 + " from " + r.authorName);
            }

            var list12 = ws.getUserJobs();
            foreach (var r in list12)
            {
                Console.WriteLine(r.jobName + " for user " + r.users_id);
            }

            var list13 = ws.getUserAddress();
            foreach (var r in list13)
            {
                Console.WriteLine(r.addressDetails);
            }

            var list14 = ws.getUserHobby();
            foreach (var r in list14)
            {
                Console.WriteLine(r.hobbyName);
            }

            var list15 = ws.getUserSchool();
            foreach (var r in list15)
            {
                Console.WriteLine(r.schoolName + " at zipcode " + r.schoolLocation + " attended in " + r.schoolYear  );
            }

            var list16 = ws.getAssociate();
            foreach (var r in list16)
            {
                Console.WriteLine(r.associate_user_id + " is a friend of " + r.user_id );
            }

            var list17 = ws.getAdminAssociate();
            foreach (var r in list17)
            {
                Console.WriteLine(r.admin_id + " is a friend of " + r.associate_user_id);
            }

            

            

           


            Console.ReadLine();
        }
    }
}
