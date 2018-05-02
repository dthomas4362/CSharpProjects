using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace App1
{
    class LegacyFriendListAdapter : BaseAdapter<DTO_Campus>
    {
        private Context mContext;
        private int mLayout;
        private List<DTO_Campus> mCampus;
        private Action<ImageView> mActionPicSelected;
        private int row_campus;
        private List<DTO_Campus> mCollege;

        public LegacyFriendListAdapter (Context context, int layout, List<DTO_Campus> college, Action<ImageView> picSelected)
        {
            this.mContext = context;
            this.mLayout = layout;
            this.mCampus = college;
            this.mActionPicSelected = picSelected;
        }

        public override DTO_Campus this[int position]
        {
            get { return mCampus[position]; }
        }

       // public override DTO_Campus this[int position] => throw new NotImplementedException();

        public override int Count
        {
            get { return mCampus.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(mLayout, parent, false);
            }

            row.FindViewById<TextView>(Resource.Id.campusName).Text = mCampus[position].CampusName;
            //  row.FindViewById<TextView>(Resource.Id.txtNumber).Text = mContacts[position].Number;

            ImageView pic = row.FindViewById<ImageView>(Resource.Id.imgPic);

            if (mCampus[position].Image != null)
            {
                pic.SetImageBitmap(BitmapFactory.DecodeByteArray(mCampus[position].Image, 0, mCampus[position].Image.Length));
            }


            // pic.Tag = position;
            // pic.Click -= pic_Click;
            // pic.Click += pic_Click;
            return row;
        }

        //void pic_Click(object sender, EventArgs e)
        //{
        //    //Picture has been clicked
        //    mActionPicSelected.Invoke((ImageView)sender);
        //}
    }
}