// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.Auth.cs" company="">
//   Copyright � 2016 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.Newsfeed
{
	using Microsoft.AspNet.Identity;
	using Microsoft.Owin;
	using Microsoft.Owin.Security.Cookies;
	using Owin;

	public partial class Startup
	{
		// For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
		public void ConfigureAuth(IAppBuilder app)
		{
			//// Uncomment the following lines to enable logging in with third party login providers
			////app.UseMicrosoftAccountAuthentication(
			////    clientId: "",
			////    clientSecret: "");

			////app.UseTwitterAuthentication(
			////   consumerKey: "",
			////   consumerSecret: "");

			////app.UseFacebookAuthentication(
			////   appId: "",
			////   appSecret: "");

			////app.UseGoogleAuthentication();
		}
	}
}
