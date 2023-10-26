namespace ShopAPI.Model
{
	public class SubCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public List<Item> Items { get; set; } = new();

		public int CategoryId { get; set; }
		public Category Category { get; set; } = null!;
	}
}
