using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SDPSubatCore3.UI.Models.Core.Entities
{
	public class Unvan
	{
		[Key]
		public int UnvanID { get; set; }
		public string UnvanAdi { get; set; }

		public List<Calisan> Calisans { get; set; }
	}
}
