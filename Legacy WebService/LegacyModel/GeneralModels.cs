using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyModel
{
    public class Users
    {
        public string user_first { get; set; }
        public string user_last { get; set; }
        public string user_email { get; set; }
        public string user_password { get; set; }
        public DateTime user_date_of_birth { get; set; }
        public string user_gender { get; set; }
        public Users() { }

        public Users(string fname, string lname, string em, string pw, DateTime birth, string gender)
        {
            user_first = fname;
            user_last = lname;
            user_email = em;
            user_password = pw;
            user_date_of_birth = birth;
            user_gender = gender;
        }

        public void print()
        {
            Console.WriteLine(string.Format("{0} {1} email:{2} {3}",user_first, user_last, user_email, user_password));
        }


    }
    public partial class DTO_religion
    {
        public int id { get; set; }
        public string religion1 { get; set; }
    }

    public partial class DTO_gender
    {
        public int id { get; set; }
        public string gender1 { get; set; }
    }

    public partial class DTO_politic
    {
        public int id { get; set; }
        public string politic1 { get; set; }
    }

    public partial class DTO_country
    {
        public int id { get; set; }
        public string country1 { get; set; }
    }

    public partial class DTO_user_types
    {
        public int id { get; set; }
        public string user_type { get; set; }
    }

    public partial class DTO_messagetypes
    {
        public int id { get; set; }
        public string message_type { get; set; }
    }

    public partial class DTO_hobby
    {
        public int id { get; set; }
        public string hobby1 { get; set; }
    }
    
    public partial class DTO_job
    {
        public int id { get; set; }
        public string position { get; set; }
        public string company_name { get; set; }
        public DateTime? year_started { get; set; }
        public DateTime? year_ended { get; set; }
    }

    public partial class DTO_school
    {
        public int id { get; set; }
        public string school_name { get; set; }
        public string school_address { get; set; }
        public string school_zip { get; set; }
        public string school_country { get; set; }
        public string school_year { get; set; }

    }

    public partial class DTO_state
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? countries_id { get; set; }
        public string countryName { get; set; }

    }

    public partial class DTO_address
    {
        public int id { get; set; }
        public string address1 { get; set; }
        public string postal_code { get; set; }
        public int? state_id { get; set; }
        public string stateName { get; set;}

    }

    public partial class DTO_message
    {
        public int id { get; set; }
        public int? message_type_id { get; set; }
        public int? users_id { get; set; }
        public string title { get; set; }
        public string message1 { get; set; }
        public string authorName { get; set; }

    }

    public partial class DTO_user_job
    {
        public int id { get; set; }
        public int? users_id { get; set; }
        public int? jobs_id { get; set; }
        public string jobName { get; set; }

    }

    public partial class DTO_user_address
    {
        public int id { get; set; }
        public int? users_id { get; set; }
        public int? addresses_id { get; set; }
        public string addressDetails { get; set; }

    }

    public partial class DTO_user_hobby
    {
        public int id { get; set; }
        public int? users_id { get; set; }
        public int? hobbies_id { get; set; }
        public string hobbyName { get; set; }
    }

    public partial class DTO_user_school
    {
        public int id { get; set; }
        public int? users_id { get; set; }
        public int? schools_id { get; set; }
        public string schoolName { get; set; }
        public string schoolLocation { get; set; }
        public string schoolYear { get; set; }
    }

    public partial class DTO_associate
    {
        public int id { get; set; }
        public int? user_id { get; set; }
        public int? associate_user_id { get; set; }

    }

    public partial class DTO_admin_associates
    {
        public int id { get; set; }
        public int? admin_id { get; set; }
        public int? associate_user_id { get; set; }

    }

    public partial class DTO_login
    {
        public string email_address { get; set; }
        public string password { get; set; }

    }

    public partial class DTO_user
    {
        public int id { get; set; }
        public int? admin_id { get; set; }
        public int? associate_user_id { get; set; }
        public string email_address { get; set; }
        public string title { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string suffix { get; set; }
        public DateTime? date_of_birth { get; set; }
        public string genderType { get; set; }
        public string politicName { get; set; }
        public string religionName { get; set; }
        public int user_types_id { get; set; }
        public string password { get; set; }
        public string image { get; set; }


        
    }


}
