﻿using System.Linq;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.Controllers
{
	/// <summary>
	/// This is the main controller class, which handles default http requests
	/// It displays the database content's
	/// </summary>
	public class ProductController : Controller
	{
		private IProductRepository _repository;
		public int PageSize = 4;

		public ProductController(IProductRepository productRepository)
		{
			_repository = productRepository;
		}

		public ViewResult List(string category, int page = 1)
		{
			var model = new ProductsListViewModel
			{
				Products = _repository.Products
				.Where(p => category == null || p.Category == category)
				.OrderBy(p => p.ProductId)
				.Skip((page - 1) * PageSize)
				.Take(PageSize),

				PagingInfo = new PagingInfo
				{
					CurrentPage = page,
					ItemsPerPage = PageSize,
					TotalItems = category == null ? _repository.Products.Count() : _repository.Products.Count(e => e.Category == category)
				},
				CurrentCategory = category
			};

			return View(model);
		}
	}
}