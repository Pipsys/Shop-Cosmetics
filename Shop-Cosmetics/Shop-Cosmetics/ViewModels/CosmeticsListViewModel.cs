using Shop_Cosmetics.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_Cosmetics.Data.Models;

namespace Shop_Cosmetics.ViewModels
{
	public class CosmeticsListViewModel
	{
		public IEnumerable<Cosmetics> allCosmetics { get; set; }

		public string currCaterogy { get; set; }
	}
}

