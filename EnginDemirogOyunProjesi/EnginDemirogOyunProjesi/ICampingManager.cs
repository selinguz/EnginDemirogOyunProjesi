using System;
using System.Collections.Generic;
using System.Text;

namespace EnginDemirogOyunProjesi
{
	interface ICampingManager
	{
		void Add(Campaign campaign);

		void Delete(Campaign campaign);

		void Update(Campaign campaign);
	}
}
