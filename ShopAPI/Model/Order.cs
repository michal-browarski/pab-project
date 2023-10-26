namespace ShopAPI.Model
{
	public class Order
	{
		public int Id { get; set; }
		public DateTime CreationDateTime { get; set; }
		public OrderStatus Status { get; set; }
		public DateTime ShippingDate { get; set; }
		public string? Annotations { get; set; }
	}

	public enum OrderStatus
	{
		ShopCart,
		Ready,
		Shipped,
		Completed
	}
}
