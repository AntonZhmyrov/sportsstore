using SportsStore.Domain.Entities;
using System.Data.Entity;

namespace SportsStore.Domain.Concrete
{
	/// <summary>
	/// This class represents the database of Products objects
	/// </summary>
	public class EFDbContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
	}
}
