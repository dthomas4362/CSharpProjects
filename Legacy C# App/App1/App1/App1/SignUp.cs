using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System;
using Java.Lang;
using Android.Content;
using System.Net;
using System.Collections.Specialized;
using System.Text;
using Org.Json;
using Newtonsoft.Json;
using Java.Util;


namespace App1
{
    [Activity(Label = "SignUp")]
    public class SignUp : Activity, DatePickerDialog.IOnDateSetListener
    {
        private const int DATE_DIALOG = 1;
        private int year, month, day;
        EditText userEmail, userPassword, firstName, lastName, dob;
        Button signInTab, createAcctBtn;

        public void OnDateSet(DatePicker view, int year, int monthOfYear, int dayofMonth)
        {
            this.year = year;
            this.month = monthOfYear + 1;
            this.day = dayofMonth;
            var dateSelected = new DateTime(year, month, day);
            dob.FindViewById<EditText>(Resource.Id.dobInput).Text = dateSelected.ToString("MM/dd/yyyy");
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SignUp);

            userEmail = (EditText)FindViewById(Resource.Id.emailInput);
            userPassword = (EditText)FindViewById(Resource.Id.passwordInput);
            firstName = (EditText)FindViewById(Resource.Id.firstNameInput);
            lastName = (EditText)FindViewById(Resource.Id.lastNameInput);
            dob = (EditText)FindViewById(Resource.Id.dobInput);
            //gender = (EditText)FindViewById(Resource.Id.genderSelect);
            createAcctBtn = (Button)FindViewById(Resource.Id.createAcctBtn);
            signInTab = (Button)FindViewById(Resource.Id.signInTab);

            createAcctBtn.Click += SignUp_Click;
            signInTab.Click += SignIn_Click;

            dob.Click += delegate {
                ShowDialog(DATE_DIALOG);
            };
            //mRelativeLayout.Click += mRelativeLayout_Click;
        }

        //protected override void MDatePickerBtn_Click(object sender, EventArgs e)
        //{
        //    FragmentTransaction transaction = FragmentManager.BeginTransaction();
        //    DatePickerFragment dpFragment = new DatePickerFragment();
        //    dpFragment.Show(transaction, "Date Picker Fragment");
        //}

        protected override Dialog OnCreateDialog(int id)
        {
            Calendar c = Calendar.GetInstance(Locale.Us);
            int year = c.Get(CalendarField.Year);
            int month = c.Get(CalendarField.Month);
            int day = c.Get(CalendarField.DayOfMonth);

            switch (id)
            {
                case DATE_DIALOG:
                    {
                        return new DatePickerDialog(this, this, year, month, day);
                    }
                    break;
                default:
                    break;
            }
            return null;
        }

        void SignUp_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(UserDashboard));
            User user = new User()
            {
                //UserID = 1,
                UserName = userEmail.Text,
                password = userPassword.Text
            };

            intent.PutExtra("User", JsonConvert.SerializeObject(user));

            this.StartActivity(intent);
            //this.OverridePendingTransition(Resource.Animation.slide_in_top, Resource.Animation.slide_out_bottom);
        }


        void SignIn_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Login));

            this.StartActivity(intent);
        }

        //public void OnClick(View v)
        //{
        //    switch (v.Id)
        //    {
        //        case Resource.Id.signUpBtn:
        //            Intent up = new Intent(this, typeof(Login));
        //            StartActivity(up);
        //            Finish();
        //            break;
        //    }
        //}
    }
}