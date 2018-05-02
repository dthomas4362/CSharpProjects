using Android.App;
using Android.OS;
using Android.Widget;
using Android.Views;
using Android.Content;
using Newtonsoft.Json;
using System.Collections.Generic;
using Android.Support.Design.Widget;
using Android.Support.V7.AppCompat;
using Android.Support.V7.App;
using Android.Support.V4.Widget;
using SupportFragment = Android.Support.V4.App.Fragment;
using Java.Lang;

namespace App1
{
    [Activity(Label = "UserDashboard", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class UserDashboard : AppCompatActivity
    {
        private FrameLayout mFragmentContainer;
        BottomNavigationView mBottomNavigation;
        //private Fragment mCurrentFragment;
        //private Fragment1 mFragment1;
        //private Fragment2 mFragment2;
        //private Fragment3 mFragment3;
        //private Fragment4 mFragment4;
        //private Stack<Fragment> mStackFragments;
        //static ListView mListView;
        //private ProgressBar mprogressBar;
        static List<DTO_Campus> mCollege;
        TextView mPassword;
        TextView mUsername;
        User mLoggedOnUser;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.UserDashboard);

            mFragmentContainer = FindViewById<FrameLayout>(Resource.Id.fragmentContainer);
            mBottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            //mFragment1 = new Fragment1();
            //mFragment2 = new Fragment2();
            //mFragment3 = new Fragment3();
            //mFragment4 = new Fragment4();
            //mStackFragments = new Stack<Fragment>();

            //mListView = FindViewById<ListView>(Resource.Id.listView);
            //mprogressBar = FindViewById<ProgressBar>(Resource.Id.progressBar);


          //  mUsername = FindViewById<TextView>(Resource.Id.username);
          //  mPassword = FindViewById<TextView>(Resource.Id.password);

            mBottomNavigation.NavigationItemSelected += BottomNavigation_NavigationItemSelected;

            // Load the Home/Dashboard fragment on creation
            LoadFragment(Resource.Id.action_home);

        }

        private void BottomNavigation_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            LoadFragment(e.Item.ItemId);
        }

        void LoadFragment(int id)
        {
            Fragment fragment = null;
            switch (id)
            {
                case Resource.Id.action_home:
                    fragment = Fragment1.NewInstance();
                    break;
                case Resource.Id.action_profile:
                    fragment = Fragment2.NewInstance();
                    break;
                case Resource.Id.action_messages:
                    fragment = Fragment3.NewInstance();
                    break;
                case Resource.Id.action_settings:
                    fragment = Fragment4.NewInstance();
                    break;
                default:
                    break;
            }

            if (fragment == null)
                return;

            FragmentManager.BeginTransaction()
                .Replace(Resource.Id.fragmentContainer, fragment)
                .Commit();
        }

        //private void BottomNavigation_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        //{
        //    switch(e.Item.ItemId)
        //    {
        //        case Resource.Id.action_home:
        //            ShowFragment(mFragment1);
        //            Toast.MakeText(this, "Action Legacy Home clicked!", ToastLength.Short).Show();
        //            getCampusesAsync();
        //            break;

        //        case Resource.Id.action_profile:
        //            ShowFragment(mFragment2);
        //            Toast.MakeText(this, "Action Legacy Profile Viewer clicked!", ToastLength.Short).Show();
        //            break;

        //        case Resource.Id.action_messages:
        //            ShowFragment(mFragment3);
        //            Toast.MakeText(this, "Action Legacy Messages clicked!", ToastLength.Short).Show();
        //            mListView.SetFilterText("");
        //            break;

        //        case Resource.Id.action_settings:
        //            ShowFragment(mFragment4);
        //            Toast.MakeText(this, "Action Legacy Settings clicked!", ToastLength.Short).Show();
        //            break;
        //        default:
        //            break;
        //    }

        //}


        //public override bool OnOptionsItemSelected(IMenuItem item)
        //{
        //    switch (item.ItemId)
        //    {
        //        case Resource.Id.action_home:
        //            ShowFragment(mFragment1);
        //            Toast.MakeText(this, "Action Legacy Home clicked!", ToastLength.Short).Show();
        //            //getCampusesAsync();
        //            return true;
        //        // getCampusesAsync();

        //        case Resource.Id.action_profile:
        //            ShowFragment(mFragment2);
        //            Toast.MakeText(this, "Action Legacy Profile Viewer clicked!", ToastLength.Short).Show();
        //            return true;

        //        case Resource.Id.action_messages:
        //            ShowFragment(mFragment3);
        //            Toast.MakeText(this, "Action Legacy Messages clicked!", ToastLength.Short).Show();
        //            //mListView.SetFilterText("");
        //            return true;

        //        case Resource.Id.action_settings:
        //            ShowFragment(mFragment4);
        //            Toast.MakeText(this, "Action Legacy Settings clicked!", ToastLength.Short).Show();
        //            return true;

        //        default:
        //            return base.OnOptionsItemSelected(item);
        //    }
        //}

        //private void ShowFragment(Fragment fragment)
        //{
        //    //if (fragment.IsVisible)
        //    //{
        //    //    return;
        //    //}
        //    var trans = FragmentManager.BeginTransaction();

        //    fragment.View.BringToFront();
        //    mCurrentFragment.View.BringToFront();

        //    trans.Hide(mCurrentFragment);
        //    trans.Show(fragment);

        //    trans.AddToBackStack(null);
        //    mStackFragments.Push(mCurrentFragment);
        //    trans.Commit();

        //    mCurrentFragment = fragment;
        //}

        //public override void OnBackPressed()
        //{

        //    if (FragmentManager.BackStackEntryCount > 0)
        //    {
        //        FragmentManager.PopBackStack();
        //        mCurrentFragment = mStackFragments.Pop();
        //    }
        //    else
        //    {
        //        base.OnBackPressed();
        //    }
        //}
        //    internal async System.Threading.Tasks.Task<List<DTO_Campus>> getCampusesAsync()
        //    {
        //        BaseAdapter<DTO_Campus> mAdapter;

        //        ArrayAdapter<string> adapter;

        //        List<DTO_Campus> campuses = new List<DTO_Campus>();

        //        string URL = @"http://www.jumpcreek.com/CollegeFall/Service1.svc/";
        //        HttpClient client = new HttpClient();

        //        client.BaseAddress = new Uri(URL);
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        client.Timeout = new TimeSpan(0, 15, 0);

        //        try
        //        {
        //            var dto = new DTO_Login { loginID = 0 };

        //            string json = JsonConvert.SerializeObject(dto);
        //            var content = new StringContent(json, Encoding.UTF8, "application/json");
        //            //HttpResponseMessage response = null;
        //            //response = await client.PostAsync(URL, content);

        //            HttpResponseMessage response = await client.PostAsync(string.Format(@"{0}{1}", URL, "GetCampuses"), content);

        //            response.EnsureSuccessStatusCode();

        //            var json2 = await response.Content.ReadAsStringAsync();

        //            var des = (Wrapper<DTO_Campus>)Newtonsoft.Json.JsonConvert.DeserializeObject(json2, typeof(Wrapper<DTO_Campus>));


        //            campuses = des.Data.ToList();


        //            mAdapter = new LegacyFriendListAdapter(this, Resource.Layout.LegacyFriendAdapter, campuses);

        //            foreach (DTO_Campus campus in campuses)
        //            {

        //                System.Diagnostics.Debug.Print(campus.CampusName);

        //                mListView.Adapter = mAdapter;

        //                mprogressBar.Visibility = ViewStates.Gone;
        //            }
        //        }
        //        catch (HttpRequestException hre)
        //        {
        //            // Debug.WriteLine(hre.Message);
        //        }
        //        catch (System.TypeInitializationException ex)
        //        {
        //            // Debug.WriteLine(ex.StackTrace);
        //        }

        //        return campuses;
        //    }
        //}
    }
}