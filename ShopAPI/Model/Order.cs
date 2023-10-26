namespace ShopAPI.Model
{
	public class Order
	{
		public int Id { get; set; }
		public DateTime CreationDateTime { get; set; }
		public OrderStatus Status { get; set; }
		public DateTime ShippingDate { get; set; }
		public string? Annotations { get; set; }

		public int UserId { get; set; }
		public User User { get; set; } = null!;

		public List<OrderItem> OrderItems { get; set; } = new();
	}

	public enum OrderStatus
	{
		ShopCart,
		Ready,
		Shipped,
		Completed
	}
}
