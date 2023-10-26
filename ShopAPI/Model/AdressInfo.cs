namespace ShopAPI.Model
{
	public class AdressInfo
	{
		public int Id { get; set; }
		public string PostalCode { get; set; }
		public string PostalCity { get; set; }
		public string Settlement { get; set; }
		public string? StreetName { get; set; }
		public string? StreetNumber { get; set; }
		public string HomeNumber { get; set; }

		public int UserId { get; set; }
		public User User { get; set; } = null!;
	}
}
