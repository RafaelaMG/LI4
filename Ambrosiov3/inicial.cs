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
    [Activity(Label = "Inicial")]
    public class inicial : Activity
    {
        Button mButtonPesquisar;
        Button mButtonSugestoes;
        Button mButtonHistorico;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.inicial);
            mButtonPesquisar = FindViewById<Button>(Resource.Id.btpesquisa);
            mButtonSugestoes = FindViewById<Button>(Resource.Id.btsugestao);
            mButtonHistorico = FindViewById<Button>(Resource.Id.bthistorico);


            mButtonPesquisar.Click += mButtonPesquisar_Click;
            mButtonSugestoes.Click += mButtonSugestoes_Click;
            mButtonHistorico.Click += mButtonHistorico_Click;
        }

        void mButtonPesquisar_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(pesquisar));
            this.StartActivity(intent);

        }

        void mButtonSugestoes_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(sugestoes));
            this.StartActivity(intent);

        }

        void mButtonHistorico_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(historico));
            this.StartActivity(intent);

        }


    }
}