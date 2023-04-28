using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SDPSubatCore3.UI.Models.Core.Entities
{
	public class Product
	{
		[Key]
		public int ProductID { get; set; }
		[Display(Name = "Ürün Giriniz")]
		public string ProductName { get; set; }
		public decimal UnitPrice { get; set; }
		public int CategoryID { get; set; }


		[ForeignKey("CategoryID")]
		public Category Category { get; set; }
	}
}
