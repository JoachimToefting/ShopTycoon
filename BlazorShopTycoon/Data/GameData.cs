using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShopTycoon.Data
{
	public class GameData
	{
		public int YourMoney { get; set; }
		public List<Shelfitem> Shelfitems { get; set; }
	}
}
