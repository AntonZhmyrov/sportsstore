﻿using System;
using System.Text;
using System.Web.Mvc;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.HtmlHelpers
{
	/// <summary>
	/// This class contains the implementations of HtmlHelper methods
	/// </summary>
	public static class PagingHelpers
	{
		public static MvcHtmlString PageLinks(this HtmlHelper html,
			PagingInfo pagingInfo,
			Func<int, string> pageUrl)
		{
			var result = new StringBuilder();

			for (int i = 1; i <= pagingInfo.TotalPages; i++)
			{
				var tag = new TagBuilder("a");
				tag.MergeAttribute("href", pageUrl(i));
				tag.InnerHtml = i.ToString();

				if (i == pagingInfo.CurrentPage)
				{
					tag.AddCssClass("selected");
					tag.AddCssClass("btn-primary");
				}

				tag.AddCssClass("btn btn-default");
				result.Append(tag);
			}

			return MvcHtmlString.Create(result.ToString());
		}
	}
}