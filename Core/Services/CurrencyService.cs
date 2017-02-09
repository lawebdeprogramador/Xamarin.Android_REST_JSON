using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Core
{
	public class CurrencyService:ICurrencyService
	{
		HttpClient client;

		public Currency Item { get; set; }

		public CurrencyService()
		{
		/* in case your webservice requires authentication
		 * 
			var authData = string.Format("{0}:{1}", Constants.Username, Constants.Password);
			var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));
         */

			client = new HttpClient();

			/* in case your webservice requires authentication
			 * 
			client.MaxResponseContentBufferSize = 256000;
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
			*/
		}

		public Task DeleteCurrencyAsync(string id)
		{
			//write here the code to Delete an item
			//do not forget to delete the exception
			throw new NotImplementedException();
		}

		public async Task<Currency> RefreshDataAsync()
		{
			Item = new Currency();
			var uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

			try
			{
				var response = await client.GetAsync(uri);
				if (response.IsSuccessStatusCode)
				{
					var content = await response.Content.ReadAsStringAsync();
					Item = JsonConvert.DeserializeObject<Currency>(content);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(@"-------------------- ERROR ENCOUNTRED {0}", ex.Message);
			}

			return Item;
		}

		public Task SaveCurrencyAsync(Currency item, bool isNewItem)
		{
			//write here the code to Save an item
			//do not forget to delete the exception
			throw new NotImplementedException();
		}
	}
}
