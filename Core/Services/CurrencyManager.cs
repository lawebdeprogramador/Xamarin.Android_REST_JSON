using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Core
{
	public class CurrencyManager
	{
		ICurrencyService restService;

		public CurrencyManager(ICurrencyService service)
		{
			restService = service;
		}

		public Task<Currency> GetTasksAsync()
		{
			return restService.RefreshDataAsync();
		}

		public Task SaveCurrencyAsync(Currency item, bool isNewItem = false)
		{
			//write here the code to Save an item
			//do not forget to delete the exception
			throw new NotImplementedException();
		}

		public Task DeleteCurrencyAsync(Currency item)
		{
			//write here the code to Delete an item
			//do not forget to delete the exception
			throw new NotImplementedException();
		}
	}
}
