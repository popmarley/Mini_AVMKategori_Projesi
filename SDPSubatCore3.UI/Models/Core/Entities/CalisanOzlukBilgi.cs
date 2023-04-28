using System.ComponentModel.DataAnnotations;

namespace SDPSubatCore3.UI.Models.Core.Entities
{
	public class CalisanOzlukBilgi
	{
		[Key]
		public int CalisanOzlukBilgiID { get; set; }
		public string TC { get; set; }
		public string Adres { get; set; }
		public string Tel { get; set; }
		//30 kolon var
		public int CalisanID { get; set; }


		public Calisan Calisan { get; set; }

	}
}
