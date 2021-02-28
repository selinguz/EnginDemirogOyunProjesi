using System;

namespace EnginDemirogOyunProjesi
{
	class Program
	{
		static void Main(string[] args)
		{
			PlayerManager playerManager = new PlayerManager();
			SalesManager salesManager = new SalesManager();
			
			


			if (EDevlet.VatandasSorgula("12345678901","Selin","Güzel",new DateTime(1988)))
			{
				Player player1 = new Player
				{
					Id = 1,
					TcNo = "123456",
					FirstName = "Selin",
					LastName = "Güzel",
					DogumYili = new DateTime(1988)
				};
				playerManager.Add(player1);
				salesManager.Sell(player1);
			}

			if(EDevlet.VatandasSorgula("12345678901", "Cem", "Namak", new DateTime(1989)))
			{
				Player player2 = new Player
				{
					Id = 2,
					TcNo = "34567",
					FirstName = "Cem",
					LastName = "Namak",
					DogumYili = new DateTime(1989)
				};
				playerManager.Update(player2);
			}
			
			if(EDevlet.VatandasSorgula("12345678901", "Cem", "Namak", new DateTime(1989)))
			{
				Player player3 = new Player
				{
					Id = 3,
					TcNo = "56789",
					FirstName = "Mehmet",
					LastName = "Akar",
					DogumYili = new DateTime(1975)

				};
				playerManager.Delete(player3);
			}

			Campaign campaigns = new Campaign();
			

			Sale sale = new Sale
			{
				Id = 1,
				GameName = "Stardew Valley",
				GamePrice = 24.90
			};
			salesManager.ShowSaleInfo(sale);

			Campaign campaign = new Campaign
			{
				CampaignName = "%50 indirim"
			};

			CampaignManager campaignManager = new CampaignManager();
			campaignManager.Add(campaign);
			campaignManager.Update(campaign);
			campaignManager.Delete(campaign);
		}
	}
}
