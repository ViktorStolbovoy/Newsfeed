// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="">
//   Copyright © 2016 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.Newsfeed
{
	using System.Web.Routing;

	using App.Newsfeed.Routing;

	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.Add("Default", new DefaultRoute());
		}
	}
}
