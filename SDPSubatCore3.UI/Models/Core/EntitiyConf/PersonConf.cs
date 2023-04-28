using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SDPSubatCore3.UI.Models.Core.Entities;

namespace SDPSubatCore3.UI.Models.Core.EntitiyConf
{
	public class PersonConf : IEntityTypeConfiguration<Person>// adres ve person name sınıfında owned att. kullandığımız için bu şekilde yaptık
	{
		public void Configure(EntityTypeBuilder<Person> builder)
		{
			builder.OwnsOne(a => a.PersonName).Property(a => a.Name).HasColumnName("FirstName");
			builder.OwnsOne(a => a.PersonName).Property(a => a.MidName).HasColumnName("SecoundName");
			builder.OwnsOne(a => a.PersonAdress).Property(a => a.City).HasColumnName("Sehir");
			builder.OwnsOne(a => a.PersonAdress).Property(a => a.Country).HasColumnName("Ulke");
			

		}
	}
}
