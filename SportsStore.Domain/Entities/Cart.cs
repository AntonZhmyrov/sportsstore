using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Domain.Entities
{
	/// <summary>
	/// This class represents a simple cart for keeping products that are in the buying list
	/// </summary>
	public class Cart
	{
		private List<CartLine> _lineCollection = new List<CartLine>();

		public IEnumerable<CartLine> Lines => _lineCollection;

		public void Clear()
		{
			_lineCollection.Clear();
		}

		public decimal ComputeTotalValue()
		{
			return _lineCollection.Sum(e => e.Product.Price * e.Quantity);
		}

		public void RemoveLine(Product product)
		{
			_lineCollection.RemoveAll(l => l.Product.ProductId == product.ProductId);
		}

		public void AddItem(Product product, int quantity)
		{
			var line = _lineCollection.FirstOrDefault(p => p.Product.ProductId == product.ProductId);

			if (line == null)
			{
				_lineCollection.Add(new CartLine
				{
					Product = product,
					Quantity = quantity
				});
			}
			else
			{
				line.Quantity += quantity;
			}
		}
	}
}
