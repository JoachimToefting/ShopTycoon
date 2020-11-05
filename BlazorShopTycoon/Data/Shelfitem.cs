using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShopTycoon.Data
{
	public class Shelfitem
	{
		[Required]
		public int ShopitemID { get; set; }
		[Required,Range(0,int.MaxValue)]
		public double Shelfprice { get; set; }
		[Required,Range(1,int.MaxValue)]
		public int Shelfcount { get; set; }
	}
}
