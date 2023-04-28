using System;

namespace SDPSubatCore3.UI.Models.Core.Entities
{
	public class Person
	{
		public int PersonID { get; set; }
		public DateTime CreatedDate { get; set; }
		public PersonAdress PersonAdress { get; set; }
		public PersonName PersonName { get; set; }
	}
}
