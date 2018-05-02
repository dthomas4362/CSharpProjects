using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Android.Content;
using System.Net.Http;
using Android.Support.V4.App;
using System.Net.Http.Headers;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace App1
{
    public class Fragment1 : Android.App.Fragment
    {
        BaseAdapter<DTO_Campus> mAdapter;
        static ListView mListView;
        private ProgressBar mprogressBar;
        private ImageView mSelectedPic;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public static Fragment1 NewInstance()
        {
            var frag1 = new Fragment1 { Arguments = new Bundle() };
            return frag1;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.ViewHome, container, false);

            mListView = view.FindViewById<ListView>(Resource.Id.listView);
            mprogressBar = view.FindViewById<ProgressBar>(Resource.Id.progressBar);

            GetCampusesAsync();

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

        private void PicSelected(ImageView selectedPic)
        {
            mSelectedPic = selectedPic;
            Intent intent = new Intent();
            intent.SetType("image/*");
            intent.SetAction(Intent.ActionGetContent);
            this.StartActivityForResult(Intent.CreateChooser(intent, "Selecte a Photo"), 0);
        }



        internal async System.Threading.Tasks.Task<List<DTO_Campus>> GetCampusesAsync()
        {
            ArrayAdapter<string> adapter;
            List<DTO_Campus> campuses = new List<DTO_Campus>();

            string URL = @"http://www.jumpcreek.com/CollegeFall/Service1.svc/";
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 15, 0);

            try
            {
                var dto = new DTO_Login { loginID = 0 };

                string json = JsonConvert.SerializeObject(dto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //HttpResponseMessage response = null;
                //response = await client.PostAsync(URL, content);

                HttpResponseMessage response = await client.PostAsync(string.Format(@"{0}{1}", URL, "GetCampuses"), content);

                response.EnsureSuccessStatusCode();

                var json2 = await response.Content.ReadAsStringAsync();

                var des = (Wrapper<DTO_Campus>)Newtonsoft.Json.JsonConvert.DeserializeObject(json2, typeof(Wrapper<DTO_Campus>));


                campuses = des.Data.ToList();

                Action<ImageView> action = PicSelected;

                mAdapter = new LegacyFriendListAdapter(this.Context, Resource.Layout.LegacyFriendAdapter, campuses, action);

                foreach (DTO_Campus campus in campuses)
                {

                    System.Diagnostics.Debug.Print(campus.CampusName);
                
                    mListView.Adapter = mAdapter;

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
            }

            return campuses;
        }
    }
}
