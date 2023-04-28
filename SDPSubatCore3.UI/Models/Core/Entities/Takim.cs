using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDPSubatCore3.UI.Models.Core.Entities
{
	public class Takim
	{
		[Key]
		public int TakimtID { get; set; }
		public string TakimAdi { get; set; }


		public List<CalisanTakim> CalisanTakims { get; set; }
	}
}
