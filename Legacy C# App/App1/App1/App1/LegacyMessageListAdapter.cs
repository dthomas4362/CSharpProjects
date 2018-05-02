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

namespace App1
{
        class LegacyMessagesListAdapter : BaseAdapter<DTO_Message>
        {
            private Context mContext;
            private int mLayout;
            private List<DTO_Message> mUserMessage;
            //   private Action<ImageView> mActionPicSelected;
            private int row_user;
            private List<DTO_Message> mMessage;

            public LegacyMessagesListAdapter(Context context, int layout, List<DTO_Message> user)
            {
                this.mContext = context;
                this.mLayout = layout;
                this.mUserMessage = user;
                // mActionPicSelected = picSelected;
            }

            public override DTO_Message this[int position]
            {
                get { return mUserMessage[position]; }
            }

            // public override DTO_Campus this[int position] => throw new NotImplementedException();

            public override int Count
            {
                get { return mUserMessage.Count; }
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

                row.FindViewById<TextView>(Resource.Id.authorName).Text = mUserMessage[position].authorName;
                row.FindViewById<TextView>(Resource.Id.message).Text = mUserMessage[position].message1;
             //row.FindViewById<TextView>(Resource.Id.message).Text = mUserMessage[position].message1;

            //ImageView pic = row.FindViewById<ImageView>(Resource.Id.imgPic);
            //if (mContacts[position].Image != null)
            //{
            //    pic.SetImageBitmap(BitmapFactory.DecodeByteArray(mContacts[position].Image, 0, mContacts[position].Image.Length));
            //}


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