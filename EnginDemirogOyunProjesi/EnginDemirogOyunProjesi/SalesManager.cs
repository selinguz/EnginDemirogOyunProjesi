using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogOyunProjesi
{
	class SalesManager : ISalesManager
	{
		public void Sell(Player player)
		{
			Console.WriteLine(player.FirstName + " oyuncusuna satış yapıldı");
		}

		public void ShowSaleInfo(Sale sale)
		{
			Console.WriteLine($"Satış yapılan oyun adı: {sale.GameName}\nOyunun satış fiyatı: {sale.GamePrice}\n");
		}
	}
}
