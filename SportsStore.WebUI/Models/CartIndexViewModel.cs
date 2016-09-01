using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Models
{
	/// <summary>
	/// The view model class for visualizing cart manipulations
	/// </summary>
	public class CartIndexViewModel
	{
		public Cart Cart { get; set; }
		public string ReturnUrl { get; set; }
	}
}