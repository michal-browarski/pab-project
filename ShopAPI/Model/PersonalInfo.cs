namespace ShopAPI.Model
{
	public class PersonalInfo
	{
		public int Id { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public Gender Gender { get; set; }
	}

	public enum Gender
	{
		Male,
		Female,
		Other
	}
}
