using System.Collections.Generic;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
	/// <summary>
	/// Represents the interface for getting access to product's database
	/// </summary>
	public interface IProductRepository
	{
		IEnumerable<Product> Products { get; }
	}
}
