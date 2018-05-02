using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace App1
{
    public class Fragment3 : Android.App.Fragment
    {
        BaseAdapter<DTO_Message> mAdapter;
        static ListView messageListView;
        private ProgressBar mprogressBar;


        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public static Fragment3 NewInstance()
        {
            var frag3 = new Fragment3 { Arguments = new Bundle() };
            return frag3;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.ViewMessages, container, false);

            messageListView = view.FindViewById<ListView>(Resource.Id.messagelistView);
            mprogressBar = view.FindViewById<ProgressBar>(Resource.Id.progressBar);

            GetMessagesAsync();

            UpdateView();
            return view;
        }

        private void UpdateView()
        {
            if (mAdapter != null)
            {
                mAdapter.NotifyDataSetChanged();
            }
        }


        internal async System.Threading.Tasks.Task<List<DTO_Message>> GetMessagesAsync()
        {
            BaseAdapter<DTO_Message> mAdapter;

            ArrayAdapter<string> adapter;

            List<DTO_Message> messages = new List<DTO_Message>();
          
            string URL = @" http://www.jumpcreek.com/legacy/Service1.svc/";
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 15, 0);

            try
            {
                var dto = new DTO_Message { messageLogin = 0 };

                string json = JsonConvert.SerializeObject(dto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //HttpResponseMessage response = null;
                //response = await client.PostAsync(URL, content);

                HttpResponseMessage response = await client.PostAsync(string.Format(@"{0}{1}", URL, "getMessages"), content);

                response.EnsureSuccessStatusCode();

                var json2 = await response.Content.ReadAsStringAsync();

                var des = (Wrapper<DTO_Message>)Newtonsoft.Json.JsonConvert.DeserializeObject(json2, typeof(Wrapper<DTO_Message>));

                messages = des.Data.ToList();
                //   messages1 = des.Data.ToList();


                mAdapter = new LegacyMessagesListAdapter(this.Context, Resource.Layout.LegacyMessageAdapter, messages);

                //  var dto1 = new DTO_Hobbies { hobbies_id = 3 };

                foreach (DTO_Message message in messages)
                {
                    //  if (hobbie_id.authorName == "Sports")
                    //  {

                    System.Diagnostics.Debug.Print(message.authorName);
                    System.Diagnostics.Debug.Print(message.message1);
            
                    messageListView.Adapter = mAdapter;

                    mprogressBar.Visibility = ViewStates.Gone;
                 
                }
            }
            catch (HttpRequestException hre)
            {
                // Debug.WriteLine(hre.Message);
            }
            catch (System.TypeInitializationException ex)
            {
                // Debug.WriteLine(ex.StackTrace);
                System.Diagnostics.Debug.Print(ex.StackTrace);
                // mListView.Adapter = mAdapter;
            }

            // return campuses;

            return messages;
        }

        //internal async System.Threading.Tasks.Task<List<DTO_Campus>> GetCampusesAsync()
        //{
        //    BaseAdapter<DTO_Campus> mAdapter;

        //    ArrayAdapter<string> adapter;

        //    List<DTO_Campus> campuses = new List<DTO_Campus>();

        //    string URL = @"http://www.jumpcreek.com/CollegeFall/Service1.svc/";
        //    HttpClient client = new HttpClient();

        //    client.BaseAddress = new Uri(URL);
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    client.Timeout = new TimeSpan(0, 15, 0);

        //    try
        //    {
        //        var dto = new DTO_Login { loginID = 0 };

        //        string json = JsonConvert.SerializeObject(dto);
        //        var content = new StringContent(json, Encoding.UTF8, "application/json");
        //        //HttpResponseMessage response = null;
        //        //response = await client.PostAsync(URL, content);

        //        HttpResponseMessage response = await client.PostAsync(string.Format(@"{0}{1}", URL, "GetCampuses"), content);

        //        response.EnsureSuccessStatusCode();

        //        var json2 = await response.Content.ReadAsStringAsync();

        //        var des = (Wrapper<DTO_Campus>)Newtonsoft.Json.JsonConvert.DeserializeObject(json2, typeof(Wrapper<DTO_Campus>));


        //        campuses = des.Data.ToList();


        //        mAdapter = new LegacyFriendListAdapter(this, Resource.Layout.LegacyFriendAdapter, campuses);

        //        foreach (DTO_Campus campus in campuses)
        //        {

        //            System.Diagnostics.Debug.Print(campus.CampusName);

        //            mListView.Adapter = mAdapter;

        //            mprogressBar.Visibility = ViewStates.Gone;
        //        }
        //    }
        //    catch (HttpRequestException hre)
        //    {
        //        // Debug.WriteLine(hre.Message);
        //    }
        //    catch (System.TypeInitializationException ex)
        //    {
        //        // Debug.WriteLine(ex.StackTrace);
        //    }

        //    return campuses;
        //}

        //public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        //{
        //    View view = inflater.Inflate(Resource.Layout.ViewProfile, container, false);
        //    return view;
        //}
    }

    //public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    //{
    //    View view = inflater.Inflate(Resource.Layout.ViewMessages, container, false);
    //    return view;
    //}
}