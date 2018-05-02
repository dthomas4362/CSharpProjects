using LegacyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Legacy_DAL;

namespace LegacyService
{
    public class Service1 : IService1
    {
        public List<DTO_religion> getReligions()
        {
            List<DTO_religion> ret = new List<DTO_religion>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.religions.ToList();
                foreach (var r in list)
                {
                    DTO_religion o = new DTO_religion();
                    o.id = r.id;
                    o.religion1 = r.religion1;
                    ret.Add(o);
                }
                return ret;
            }
        }



        public List<DTO_gender> getGenders()
        {
            List<DTO_gender> ret = new List<DTO_gender>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.genders.ToList();
                foreach (var r in list)
                {
                    DTO_gender o = new DTO_gender();
                    o.id = r.id;
                    o.gender1 = r.gender1;
                    ret.Add(o);
                }
                return ret;
            }
        }
        public List<DTO_politic> getPolitics()
        {
            List<DTO_politic> ret = new List<DTO_politic>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.politics.ToList();
                foreach (var r in list)
                {
                    DTO_politic o = new DTO_politic();
                    o.id = r.id;
                    o.politic1 = r.politic1;
                    ret.Add(o);
                }
                return ret;
            }
        }
        public List<DTO_country> getCountries()
        {
            List<DTO_country> ret = new List<DTO_country>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.countries.ToList();
                foreach (var r in list)
                {
                    DTO_country o = new DTO_country();
                    o.id = r.id;
                    o.country1 = r.name;
                    ret.Add(o);
                }
                return ret;
            }
        }

        public List<DTO_user_types> getUserTypes()
        {
            List<DTO_user_types> ret = new List<DTO_user_types>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.user_types.ToList();
                foreach (var r in list)
                {
                    DTO_user_types o = new DTO_user_types();
                    o.id = r.id;
                    o.user_type = r.user_type;
                    ret.Add(o);
                }
                return ret;
            }
        }
        public List<DTO_messagetypes> getMessageTypes()
        {
            List<DTO_messagetypes> ret = new List<DTO_messagetypes>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.messagetypes.ToList();
                foreach (var r in list)
                {
                    DTO_messagetypes o = new DTO_messagetypes();
                    o.id = r.id;
                    o.message_type = r.message_type;
                    ret.Add(o);
                }
                return ret;
            }
        }

        public List<DTO_hobby> getHobbies()
        {
            List<DTO_hobby> ret = new List<DTO_hobby>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.hobbies.ToList();
                foreach (var r in list)
                {
                    DTO_hobby o = new DTO_hobby();
                    o.id = r.id;
                    o.hobby1 = r.hobby1;
                    ret.Add(o);
                }
                return ret;
            }
        }

        public List<DTO_job> getJobs()
        {
            List<DTO_job> ret = new List<DTO_job>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.jobs.ToList();
                foreach (var r in list)
                {
                    DTO_job o = new DTO_job();
                    o.id = r.id;
                    o.position = r.position;
                    o.company_name = r.company_name;
                    o.year_started = r.year_started;
                    o.year_ended = r.year_ended;
                    ret.Add(o);
                }
                return ret;
            }
        }


        public List<DTO_school> getSchools()
        {

            List<DTO_school> ret = new List<DTO_school>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.schools.ToList();
                foreach (var r in list)
                {
                    DTO_school o = new DTO_school();
                    o.id = r.id;
                    o.school_name = r.school_name;
                    o.school_address = r.school_address;
                    o.school_zip = r.school_zip;
                    o.school_country = r.school_country;
                    o.school_year = r.school_year;
                    ret.Add(o);
                }
                return ret;
            }
        }

        public List<DTO_state> getStates()
        {

            List<DTO_state> ret = new List<DTO_state>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.states.ToList();
                foreach (var r in list)
                {
                    DTO_state o = new DTO_state();
                    o.id = r.id;
                    o.name = r.name;
                    o.countries_id = r.countries_id;
                    o.countryName = r.country.name;
                    ret.Add(o);
                }
                return ret;
            }
        }

        public List<DTO_address> getAddresses()
        {

            List<DTO_address> ret = new List<DTO_address>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.addresses.ToList();
                foreach (var r in list)
                {
                    DTO_address o = new DTO_address();
                    o.id = r.id;
                    o.address1 = r.address1;
                    o.postal_code = r.postal_code;
                    o.state_id = r.state_id;
                    o.stateName = r.state.name;


                    ret.Add(o);
                }
                return ret;
            }
        }

        public List<DTO_message> getMessages()
        {

            List<DTO_message> ret = new List<DTO_message>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.messages.ToList();
                foreach (var r in list)
                {
                    DTO_message o = new DTO_message();
                    o.id = r.id;
                    o.message_type_id = r.message_type_id;
                    o.users_id = r.users_id;
                    o.title = r.title;
                    o.message1 = r.message1;
                    o.authorName = r.user.first_name + " " + r.user.last_name;


                    ret.Add(o);
                }
                return ret;
            }
        }

        public List<DTO_user_job> getUserJobs()
        {

            List<DTO_user_job> ret = new List<DTO_user_job>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.users_jobs.ToList();
                foreach (var r in list)
                {
                    DTO_user_job o = new DTO_user_job();
                    o.id = r.id;
                    o.users_id = r.users_id;
                    o.jobs_id = r.jobs_id;
                    o.jobName = r.job.position + " at " + r.job.company_name + " from " + r.job.year_started + " - " + r.job.year_ended;

                    ret.Add(o);
                }
                return ret;
            }
        }

        public List<DTO_user_address> getUserAddress()
        {

            List<DTO_user_address> ret = new List<DTO_user_address>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.user_addresses.ToList();
                foreach (var r in list)
                {
                    DTO_user_address o = new DTO_user_address();
                    o.id = r.id;
                    o.users_id = r.users_id;
                    o.addresses_id = r.addresses_id;
                    o.addressDetails = r.address.address1 + " , " + r.address.state.name + " , " + r.address.postal_code;
                    ret.Add(o);
                }
                return ret;
            }
        }

        public List<DTO_user_hobby> getUserHobby()
        {

            List<DTO_user_hobby> ret = new List<DTO_user_hobby>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.users_hobbies.ToList();
                foreach (var r in list)
                {
                    DTO_user_hobby o = new DTO_user_hobby();
                    o.id = r.id;
                    o.users_id = r.users_id;
                    o.hobbies_id = r.hobbies_id;
                    o.hobbyName = r.hobby.hobby1;
                    ret.Add(o);
                }
                return ret;
            }
        }

        public List<DTO_user_school> getUserSchool()
        {

            List<DTO_user_school> ret = new List<DTO_user_school>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.users_schools.ToList();
                foreach (var r in list)
                {
                    DTO_user_school o = new DTO_user_school();
                    o.id = r.id;
                    o.users_id = r.users_id;
                    o.schools_id = r.schools_id;
                    o.schoolName = r.school.school_name;
                    o.schoolLocation = r.school.school_zip;
                    o.schoolYear = r.school.school_year;
                    ret.Add(o);
                }
                return ret;
            }
        }

        public List<DTO_associate> getAssociate()
        {

            List<DTO_associate> ret = new List<DTO_associate>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.associates.ToList();
                foreach (var r in list)
                {
                    DTO_associate o = new DTO_associate();
                    o.id = r.id;
                    o.user_id = r.user_id;
                    o.associate_user_id = r.associate_user_id;
                    ret.Add(o);
                }
                return ret;
            }
        }

        public List<DTO_admin_associates> getAdminAssociate()
        {

            List<DTO_admin_associates> ret = new List<DTO_admin_associates>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var list = db.admin_associates.ToList();
                foreach (var r in list)
                {
                    DTO_admin_associates o = new DTO_admin_associates();
                    o.id = r.id;
                    o.admin_id = r.admin_id;
                    o.associate_user_id = r.associate_user_id;
                    ret.Add(o);
                }
                return ret;
            }
        }

        public List<DTO_user> getUser(DTO_user user)
        {

            List<DTO_user> ret = new List<DTO_user>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var r = db.users.Where(c => c.id == user.id).FirstOrDefault();


                DTO_user o = new DTO_user();
                o.id = r.id;
                o.email_address = r.email_address;
                o.title = r.title;
                o.first_name = r.first_name;
                o.middle_name = r.middle_name;
                o.last_name = r.last_name;
                o.suffix = r.suffix;
                o.date_of_birth = r.date_of_birth;
                o.genderType = r.gender.gender1;
                o.politicName = r.politic.politic1;
                o.religionName = r.religion.religion1;
                o.user_types_id = r.user_types_id;
                o.password = r.password;
                o.image = r.image;
                ret.Add(o);
            }
            return ret;
        }
        public List<DTO_user> newLogin(DTO_login user)
        {

            List<DTO_user> ret = new List<DTO_user>();
            using (Legacy_DAL.DB_42039_legacyEntities db = new Legacy_DAL.DB_42039_legacyEntities())
            {
                var r = db.users.Where(c => c.email_address == user.email_address).FirstOrDefault();

                if (r != null)
                {
                    //if (r.password != user.password)
                    //{
                    //    DTO_user o = new DTO_user();
                    //    o.id = 22;
                    //    ret.Add(o);
                    //}

                    //else
                    //{
                        DTO_user o = new DTO_user();
                        o.id = r.id;
                        o.email_address = r.email_address;
                        o.title = r.title;
                        o.first_name = r.first_name;
                        o.middle_name = r.middle_name;
                        o.last_name = r.last_name;
                        o.suffix = r.suffix;
                        o.date_of_birth = r.date_of_birth;
                        o.genderType = r.gender.gender1;
                        o.politicName = r.politic.politic1;
                        o.religionName = r.religion.religion1;
                        o.user_types_id = r.user_types_id;
                        o.password = r.password;
                        o.image = r.image;
                        ret.Add(o);
                    }
                //}
                else
                {
                    DTO_user o = new DTO_user();
                    o.id = 22;
                    ret.Add(o);
                }

                return ret;

            }
        }
            
    }





    }








