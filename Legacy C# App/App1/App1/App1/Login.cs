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

namespace App1
{
    [Activity(Label = "Login")]
    public class Login : Activity//, Android.Views.View.IOnClickListener
    {
        EditText userEmail, userPassword;
        Button signInTab, signUpTab, continueBtn, facebookBtn, twitterBtn;
        TextView forgotPassword;
      //  signInAsync sn;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Login);
            //initialize();
            userEmail = (EditText)FindViewById(Resource.Id.emailInput);
            userPassword = (EditText)FindViewById(Resource.Id.passwordInput);
            signInTab = (Button)FindViewById(Resource.Id.signInTab);
            signUpTab = (Button)FindViewById(Resource.Id.signUpTab);
            continueBtn = (Button)FindViewById(Resource.Id.continueBtn);
            forgotPassword = (TextView)FindViewById(Resource.Id.forgotPassword);


            continueBtn.Click += Continue_Click;
            signUpTab.Click += SignUp_Click;
            //mRelativeLayout.Click += mRelativeLayout_Click;
        }

        void Continue_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(UserDashboard));

            //intent.PutExtra("UserID", 1);
            //intent.PutExtra("Username", "Joseph");

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

        void SignUp_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SignUp));

            this.StartActivity(intent);
        }


        //public void initialize()
        //{
        //    signUp = (TextView)FindViewById(Resource.Id.signUpTxt);
        //    userEmail = (EditText)FindViewById(Resource.Id.emailInput);
        //    userPassword = (EditText)FindViewById(Resource.Id.passwordInput);
        //    signIn = (Button)FindViewById(Resource.Id.signInBtn);
        //    signUp.SetOnClickListener(this);
        //    signIn.SetOnClickListener(this);
        //}
        //public void OnClick(View v)
        //{
        //    switch (v.Id)
        //    {
        //        case Resource.Id.signInBtn:
        //            //  sn = new signInAsync(this);
        //            // sn.Execute();
        //            Intent up1 = new Intent(this, typeof(LoginSuccess));
        //            StartActivity(up1);
        //            Finish();
        //            break;
        //        case Resource.Id.signUpTxt:
        //            Intent up = new Intent(this, typeof(SignUp));
        //            StartActivity(up);
        //            Finish();
        //            break;
        //    }
        //}
        //public class signInAsync : AsyncTask<Java.Lang.Object, Java.Lang.Object, Java.Lang.Object>
        //{
        //    MainActivity mainActivity;

        //    public signInAsync(MainActivity mainActivity)
        //    {
        //        this.mainActivity = mainActivity;
        //    }
        //    string userEmail, userPassword;
        //    protected override void OnPreExecute()
        //    {
        //        base.OnPreExecute();

        //        userEmail = mainActivity.email.Text;
        //        userPassword = mainActivity.password.Text;
        //    }
        //    protected override Java.Lang.Object RunInBackground(params Java.Lang.Object[] @params)
        //    {

        //        WebClient client = new WebClient();
        //        Uri uri = new Uri("http://192.168.1.100/Login/xamarinsignIn.php");
        //        NameValueCollection parameters = new NameValueCollection();
        //        parameters.Add("uemail", userEmail);
        //        parameters.Add("pass", userPassword);
        //        var response = client.UploadValues(uri, parameters);
        //        var responseString = Encoding.Default.GetString(response);
        //        JSONObject ob = new JSONObject(responseString);
        //        if (ob.OptString("success").Equals("1"))
        //        {
        //            mainActivity.RunOnUiThread(() =>
        //            Toast.MakeText(mainActivity, "You Successfully LogIn", ToastLength.Short).Show());
        //        }
        //        else
        //        {
        //            mainActivity.RunOnUiThread(() =>
        //                                       Toast.MakeText(mainActivity, "InValid Email or Password", ToastLength.Short).Show());

        //        }

        //        return null;
        //    }

    }
}