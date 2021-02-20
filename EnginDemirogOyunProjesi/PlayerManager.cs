using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogOyunProjesi
{
	class PlayerManager : IPlayerManager
	{
		//public void Save(Player player)
		//{
		//	Console.WriteLine(player.FirstName + " " + player.LastName +" kaydedildi.");
		//}

		//public void Update(Player player)
		//{
		//	Console.WriteLine(player.FirstName + " " + player.LastName + "'ın bilgileri güncellendi.");
		//}

		//public void Delete(Player player)
		//{
		//	Console.WriteLine(player.FirstName + " " + player.LastName + " silindi.");
		//}
		public void Add(Player player)
		{
			Console.WriteLine(player.FirstName + " " + player.LastName + " kaydedildi.");
		}

		public void Delete(Player player)
		{
			Console.WriteLine(player.FirstName + " " + player.LastName + " silindi.");
		}

		public void Update(Player player)
		{
			Console.WriteLine(player.FirstName + " " + player.LastName + "'ın bilgileri güncellendi.");
		}
	}
}
