using Microsoft.EntityFrameworkCore;

namespace SDPSubatCore3.UI.Models.Core.Entities
{
	[Owned()]
	public class PersonAdress
	{
		public string City { get; set; }
		public string Country { get; set; }
	}
}
