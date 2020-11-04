using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace BlazorShopTycoon.Data
{
	public class ShopStoreService
	{
		public List<Shopitem> Shopitems { get; set; }
		public ShopStoreService()
		{
			Shopitems = Seeder.seeding();
		}
		public List<Shelfitem> Shelfitems { get; set; } = new List<Shelfitem>();
		public void NewShelfItem(Shelfitem shelfitem)
		{
			var existingitem = Shelfitems.Where(x => x.ShopitemID == shelfitem.ShopitemID).FirstOrDefault();
			if (existingitem != null)
			{
				if (existingitem.Shelfprice == shelfitem.Shelfprice)
				{
					existingitem.Shelfcount += shelfitem.Shelfcount;
				}
				else
				{
					//ikke samme pris
				}
			}
			else
			{
				Shelfitems.Add(shelfitem);
			}
		}
	}
}
