namespace ShopAPI.Model
{
	public class User
	{
		public int Id { get; set; }

		public string Email { get; set; }
		public string Password { get; set; }
		public DateTime CreationDateTime { get; set; }
		public bool IsActive { get; set; }
		public UserRole Role { get; set; }

		public PersonalInfo? PersonalInfo { get; set; }
		public AdressInfo? AdressInfo { get; set; }
		public List<Order> OrderList { get; set; } = new();
	}

	public enum UserRole
	{
		Admin,
		Customer
	}
}
