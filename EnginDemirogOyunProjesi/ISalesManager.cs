using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogOyunProjesi
{
	interface ISalesManager
	{
		void Sell(Player player);

		void ShowSaleInfo(Sale sale);
	}
}
