namespace SportsStore.Domain.Entities
{
	/// <summary>
	/// The basic line of products of the same type, which is on the buying list
	/// </summary>
	public class CartLine
	{
		public Product Product { get; set; }
		public int Quantity { get; set; }
	}
}
