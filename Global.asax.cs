// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="">
//   Copyright © 2016 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.Newsfeed
{
	using System.Web;
	using System.Web.Optimization;
	using System.Web.Routing;
	using System.Web.Http;

	public class Application : HttpApplication
	{
		protected void Application_Start()
		{
			
			//RegisterGlobalFilters(GlobalFilters.Filters);
			GlobalConfiguration.Configure(WebApiConfig.Register);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles); 
		}
	}
}
