using System;

namespace SportsStore.WebUI.Models
{
	/// <summary>
	/// This is the view model class which contains the information needed for pagination
	/// </summary>
	public class PagingInfo
	{
		public int TotalItems { get; set; }
		public int ItemsPerPage { get; set; }
		public int CurrentPage { get; set; }

		public int TotalPages
		{
			get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
		}
	}
}