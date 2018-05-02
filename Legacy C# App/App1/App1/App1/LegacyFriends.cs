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
    public class Wrapper<T>
    {
        public List<T> Data { get; set; }
    }

    public class DTO_Login
    {
        public int loginID { get; set; }
    }

    class DTO_Campus
    {     
        public int CampusID { get; set; }
        public string CampusName { get; set; }
      //  public ImageView Image { get; set; }
        public string ImageBase64 { private get; set; }
        public byte[] Image
        {
            get
            {
                if (ImageBase64 != "" && ImageBase64 != null)
                {
                    byte[] image = Convert.FromBase64String(ImageBase64);
                    return image;
                }

                return null;
            }
        }



    }

    class DTO_Message
    {
        public int messageLogin { get; set; }
        public string authorName { get; set; }
        public string message1 { get; set; }
        //public string messages { get; set; }
        public string messageTitle { get; set; }
    }
}