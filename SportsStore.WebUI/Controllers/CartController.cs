using System.Linq;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Controllers
{
	public class CartController : Controller
	{
		private IProductRepository _repository;

		public CartController(IProductRepository repository)
		{
			_repository = repository;
		}

		public RedirectToRouteResult AddToCart(int productId, string returnUrl)
		{
			var product = _repository.Products.FirstOrDefault(p => p.ProductId == productId);

			if (product != null)
			{
				GetCart().AddItem(product, 1);
			}

			return RedirectToAction("Index", new { returnUrl });
		}

		public RedirectToRouteResult RemoveFromCart(int productId, string returnUrl)
		{
			var product = _repository.Products.FirstOrDefault(p => p.ProductId == productId);

			if (product != null)
			{
				GetCart().RemoveLine(product);
			}

			return RedirectToAction("Index", new { returnUrl });
		}

		private Cart GetCart()
		{
			var cart = (Cart)Session["Cart"];

			if (cart == null)
			{
				cart = new Cart();
				Session["Cart"] = cart;
			}

			return cart;
		}
	}
}