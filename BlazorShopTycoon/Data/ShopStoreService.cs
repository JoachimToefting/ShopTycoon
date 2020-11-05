using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace BlazorShopTycoon.Data
{
	public class ShopStoreService
	{
		public string ErrorText { get; set; }
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
					Shelfitems.Add(shelfitem);
				}
			}
			else
			{
				if (shelfitem.ShopitemID <= Shopitems.Count() && shelfitem.ShopitemID > 0)
				{
					Shelfitems.Add(shelfitem);
				}
				else
				{
					ErrorText = "No shopitem";
				}
			}
		}
		public void DeleteShelfItem(int id)
		{
			Shelfitems.Remove(Shelfitems.FirstOrDefault(x => x.ShopitemID == id));
		}
		public void SellShelfitem(int id,double price, int count)
		{
			var item = Shelfitems.FirstOrDefault(x => x.ShopitemID == id && x.Shelfprice == price);

			item.Shelfcount = item.Shelfcount - count;
		}
	}
}
