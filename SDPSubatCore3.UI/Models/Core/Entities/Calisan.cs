using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDPSubatCore3.UI.Models.Core.Entities
{
	public class Calisan
	{
		[Key]
		public int CalisanID { get; set; }
		public string AdSoyad { get; set; }
		public int UnvanID { get; set; }


		public Unvan Unvan { get; set; }
		public CalisanOzlukBilgi CalisanOzlukBilgi { get; set; }

		public List<CalisanTakim> CalisanTakims { get; set; }
	}
}
