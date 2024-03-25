using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_Cosmetics.Data.Models;

namespace Shop_Cosmetics.Data.interfaces
{
	interface IAllCosmetics
	{
		IEnumerable<Cosmetics> cosmetics { get; }
		IEnumerable<Cosmetics> getFavCosmetics { get; set; }
		Cosmetics getObjectCosmetics(int cosmeticsId);
	}
}

