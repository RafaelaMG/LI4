using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.InputMethods;

namespace Ambrosiov3
{
    [Activity(Label = "SharedPreferences", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        RelativeLayout mRelativeLayout;
        Button mButton;
        Button mButtonRegistar;
        BD database = new BD();
        private string user;
        private string pass;

        
    
     
    
        

        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
            mButton = FindViewById<Button>(Resource.Id.btlogin);
            mButtonRegistar = FindViewById<Button>(Resource.Id.btregistar);
            user = FindViewById<EditText>(Resource.Id.loginuser).Text;
            pass = FindViewById<EditText>(Resource.Id.loginpass).Text;




            mRelativeLayout = FindViewById<RelativeLayout>(Resource.Id.mainView);
            mRelativeLayout.Click += mRelativeLayout_Click;


            mButton.Click += mButton_Click;
            mButtonRegistar.Click += mButtonRegistar_Click;
           
           


        }

        void mButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(inicial));
            this.StartActivity(intent);
          
        }

        void mButtonRegistar_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(registar));
            this.StartActivity(intent);
       
            
            
    
        }

      
        void mRelativeLayout_Click(object sender, EventArgs e)
        {
            InputMethodManager inputManager = (InputMethodManager)this.GetSystemService(Activity.InputMethodService);
            inputManager.HideSoftInputFromWindow(this.CurrentFocus.WindowToken, HideSoftInputFlags.None);
        }

       
    }
}

