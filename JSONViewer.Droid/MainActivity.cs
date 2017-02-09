using Android.App;
using Android.Widget;
using Android.OS;
using Core;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json.Linq;

namespace JSONViewer.Droid
{
	[Activity(Label = "EuroConverter.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		CurrencyManager cmanager;
		public Currency currencyData
		{
			get;
			set;
		}
		protected async override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

		    TextView txtUS = FindViewById<TextView>(Resource.Id.txtUSD);
			TextView txtca = FindViewById<TextView>(Resource.Id.txtCAD);
			TextView txtru = FindViewById<TextView>(Resource.Id.txtRUB);
			TextView txtrn = FindViewById<TextView>(Resource.Id.txtRON);
			TextView txtjp = FindViewById<TextView>(Resource.Id.txtJPY);
			TextView txtgp = FindViewById<TextView>(Resource.Id.txtGBP);
			TextView txtdk = FindViewById<TextView>(Resource.Id.txtDKK);
			TextView txtval = FindViewById<TextView>(Resource.Id.txtValue);

			cmanager = new CurrencyManager(new CurrencyService());
			currencyData = await cmanager.GetTasksAsync();

			txtval.Text = "1 Euro";

			txtUS.Text = currencyData.rates.USD.ToString() +" USD";
			txtca.Text = currencyData.rates.CAD.ToString()+ " CAD";
			txtru.Text = currencyData.rates.RUB.ToString()+ " RUB";
			txtrn.Text = currencyData.rates.RON.ToString()+ " RON";
			txtjp.Text = currencyData.rates.JPY.ToString()+ " JPY";
			txtgp.Text = currencyData.rates.GBP.ToString()+ " GBP";
			txtdk.Text = currencyData.rates.DKK.ToString()+ " DKK";

		}

	
	}
}

