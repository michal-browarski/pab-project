namespace ShopAPI.Model
{
	public class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public string Description { get; set; }

		public List<OrderItem> OrderItems { get; set; } = new();

		public int SubCategoryId { get; set; }
		public SubCategory SubCategory { get; set; } = null!;
	}
}
