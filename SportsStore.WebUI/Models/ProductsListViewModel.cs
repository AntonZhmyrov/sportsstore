using System.Collections.Generic;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Models
{
	/// <summary>
	/// This class is the view model to pass to the view, containing information about pagination
	/// and objects of type Product
	/// </summary>
	public class ProductsListViewModel
	{
		public IEnumerable<Product> Products { get; set; }
		public PagingInfo PagingInfo { get; set; } 
	}
}