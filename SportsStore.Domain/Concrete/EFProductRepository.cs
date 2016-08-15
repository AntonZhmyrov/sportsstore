using System.Collections.Generic;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
	/// <summary>
	/// Represents a repository class, based on Repository pattern, whic has access to Products database 
	/// </summary>
	public class EFProductRepository : IProductRepository
	{
		private EFDbContext _context = new EFDbContext();

		public IEnumerable<Product> Products
		{
			get { return _context.Products; }
		}
	}
}
