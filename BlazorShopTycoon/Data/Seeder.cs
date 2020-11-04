using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShopTycoon.Data
{
	public class Seeder
	{
		public static List<Shopitem> seeding()
		{
			List<Shopitem> returnitem = new List<Shopitem>();

			returnitem.Add(new Shopitem { ID = 1, Name = "Umbrella", Price = 12, weatherBonus = WeatherBonus.rain });
			returnitem.Add(new Shopitem { ID = 2, Name = "ReyBånds", Price = 30, weatherBonus = WeatherBonus.sunshine });
			returnitem.Add(new Shopitem { ID = 3, Name = "Raincoat", Price = 15, weatherBonus = WeatherBonus.rain });
			returnitem.Add(new Shopitem { ID = 4, Name = "Sunscreen", Price = 9, weatherBonus = WeatherBonus.sunshine });
			returnitem.Add(new Shopitem { ID = 5, Name = "Candy", Price = 12, weatherBonus = WeatherBonus.none });
			returnitem.Add(new Shopitem { ID = 6, Name = "Waffles", Price = 12, weatherBonus = WeatherBonus.cloudy });

			return returnitem;
		}
	}
}
