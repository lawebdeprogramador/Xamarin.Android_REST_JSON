using System;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Core
{
	public interface ICurrencyService
	{
		Task<Currency> RefreshDataAsync();

		Task SaveCurrencyAsync(Currency item, bool isNewItem);

		Task DeleteCurrencyAsync(string id);
	}
}
