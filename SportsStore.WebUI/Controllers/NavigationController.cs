using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;

namespace SportsStore.WebUI.Controllers
{
	public class NavigationController : Controller
	{
		private IProductRepository _repository;

		public NavigationController(IProductRepository repository)
		{
			_repository = repository;
		}

		public PartialViewResult Menu(string category = null)
		{
			ViewBag.SelectedCategory = category;

			IEnumerable<string> categories = _repository.Products
				.Select(x => x.Category)
				.Distinct()
				.OrderBy(x => x);

			return PartialView("FlexMenu", categories);
		}
	}
}