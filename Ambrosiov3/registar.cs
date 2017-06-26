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




namespace Ambrosiov3
{
    [Activity(Label = "Registar")]
    public class registar : Activity
    {
        Button mButtonRegistar2;
        BD database = new BD();
        private string user;
        private string pass;
        private string email;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.registar);
            user = FindViewById<EditText>(Resource.Id.textuser).Text;
            pass = FindViewById<EditText>(Resource.Id.textpass).Text;

            mButtonRegistar2 = FindViewById<Button>(Resource.Id.btregistar2);

            mButtonRegistar2.Click += mButtonRegistar2_Click;
            
        }

       
        void mButtonRegistar2_Click(object sender, EventArgs e)
        {
            database.Register(user, pass);
            Intent intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);




        }
    }
}