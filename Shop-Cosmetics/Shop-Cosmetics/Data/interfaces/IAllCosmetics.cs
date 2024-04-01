using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_Cosmetics.Data.Models;

namespace Shop_Cosmetics.Data.interfaces
{
	public interface IAllCosmetics
	{
		IEnumerable<Cosmetics> cosmetics { get; }
		IEnumerable<Cosmetics> getFavCosmetics { get;}
		Cosmetics getObjectCosmetics(int cosmeticsId);
	}
}

