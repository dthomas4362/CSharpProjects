using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.OS;
using Android.Widget;
using Android.Views;
using Newtonsoft.Json;
using System.Net.Http;
using Android.Util;
using Android.Views;
using Android.Widget;
using System.Net.Http.Headers;

namespace App1
{
    public class Fragment2 : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public static Fragment2 NewInstance()
        {
            var frag2 = new Fragment2 { Arguments = new Bundle() };
            return frag2;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return inflater.Inflate(Resource.Layout.ViewProfile, null);
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
        //        //HttpResponseMessage response = null;
        //        //response = await client.PostAsync(URL, content);

        //        HttpResponseMessage response = await client.PostAsync(string.Format(@"{0}{1}", URL, "GetCampuses"), content);

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

}