using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShopTycoon.Data
{
	public class Shopitem
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public WeatherBonus weatherBonus { get; set; }
	}
}
