using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDPSubatCore3.UI.Models.Core.Entities
{
	public class Category
	{
		[Key]
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }


		public List<Product> Products { get; set; }
	}
}
