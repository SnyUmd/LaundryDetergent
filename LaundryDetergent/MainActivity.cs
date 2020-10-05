using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Text;
using System;

namespace LaundryDetergent
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public Button BtnSet;
        public EditText EditT_Capa;
        public EditText EditT_Price;
        public EditText EditT_Amount;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            //-------------------------------------------------------
            BtnSet = FindViewById<Button>(Resource.Id.Button_Set);
            BtnSet.Click += BtnSet_Click;

            //-------------------------------------------------------
            EditT_Capa = FindViewById<EditText>(Resource.Id.EditText_Capa);
            EditT_Capa.KeyPress += EditT_KeyPress;

            EditT_Price = FindViewById<EditText>(Resource.Id.EditText_Price);
            EditT_Price.KeyPress += EditT_KeyPress;

            EditT_Amount = FindViewById<EditText>(Resource.Id.EditText_Amount);
            EditT_Amount.KeyPress += EditT_KeyPress;
        }



        //************************************************************
        private void BtnSet_Click(object sender, System.EventArgs e)
        {
           
        }



        //************************************************************
        private void EditT_KeyPress(object sender, Android.Views.View.KeyEventArgs e)
        {
            bool blEditT_Capa = false, blEditT_Price = false, blEditT_Amount = false;

            if (EditT_Capa.Text != "") blEditT_Capa = true;
            if (EditT_Price.Text != "") blEditT_Price = true;
            if (EditT_Amount.Text != "") blEditT_Amount = true;

            if (blEditT_Capa && blEditT_Price && blEditT_Amount) BtnSet.Enabled = true;
            else BtnSet.Enabled = true;
        }

    }
}