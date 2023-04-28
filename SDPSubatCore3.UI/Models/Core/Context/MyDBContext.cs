using Microsoft.EntityFrameworkCore;
using SDPSubatCore3.UI.Models.Core.Entities;
using SDPSubatCore3.UI.Models.Core.EntitiyConf;

namespace SDPSubatCore3.UI.Models.Core.Context
{
	public class MyDBContext:DbContext
	{
		public MyDBContext(DbContextOptions opt) : base(opt)
		{
			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//1 to n
			modelBuilder.Entity<Calisan>()
				.HasOne<Unvan>(a => a.Unvan)//bir çalışan bir ünvanı olduğu için "hasone" kullanılır
				.WithMany(a => a.Calisans)//bir ünvanın da birden fazla çalışanı olduğu için "withmany" kullanılır 
				.HasForeignKey(a => a.UnvanID);

			//1 to 1
			modelBuilder.Entity<Calisan>()
				.HasOne(a => a.CalisanOzlukBilgi)
				.WithOne(a => a.Calisan)
				.HasForeignKey<CalisanOzlukBilgi>(a => a.CalisanID);
			//n to n
			modelBuilder.Entity<CalisanTakim>().HasKey(a => new
			{
				a.CalisanID,
				a.TakimID
			});
			modelBuilder.Entity<CalisanTakim>()
				.HasOne<Calisan>(a => a.Calisan)
				.WithMany(a => a.CalisanTakims)
				.HasForeignKey(a => a.CalisanID);
			modelBuilder.Entity<CalisanTakim>()
				.HasOne<Takim>(a => a.Takim)
				.WithMany(a => a.CalisanTakims)
				.HasForeignKey(a => a.TakimID);

			modelBuilder.ApplyConfiguration(new PersonConf());


			//modelBuilder.Entity<Category>()
			// .ToTable("MyCategories");   eger db de Categories tablo adını farklı bi isimde göndermek istersek bu şekilde yazıyoruz.


			base.OnModelCreating(modelBuilder);	
		}


		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Calisan> Calisans { get; set; }
		public DbSet<CalisanOzlukBilgi> CalisanOzlukBilgis { get; set; }
		public DbSet<Takim> Takims { get; set; }
		public DbSet<CalisanTakim> CalisanTakims { get; set; }
		public DbSet<Unvan> Unvan { get; set; }
		public DbSet<Person> People { get; set; }
	}
}
