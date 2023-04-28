using Microsoft.EntityFrameworkCore;

namespace SDPSubatCore3.UI.Models.Core.Entities
{
	[Owned()]
	public class PersonName
	{
		public string Name { get; set; }
		public string MidName { get; set; }
		public string Surname { get; set; }
	}
}
