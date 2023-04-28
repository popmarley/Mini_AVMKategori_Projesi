namespace SDPSubatCore3.UI.Models.Core.Entities
{
	public class CalisanTakim
	{
		public int CalisanID { get; set; }
		public int TakimID { get; set; }


		public Calisan Calisan { get; set; }
		public Takim Takim { get; set; }
	}
}
