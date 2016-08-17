using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;

namespace App.Newsfeed
{
	public static class DB
	{
		private static string s_connectionString = GetConnectionStringInternal();

		private static string GetConnectionStringInternal()
		{
			string dbPath = HttpContext.Current.Server.MapPath("~/App_Data/News.db3");

			var cb = new SQLiteConnectionStringBuilder {
				DataSource = dbPath,
				ForeignKeys = true,
				DateTimeFormat = SQLiteDateFormats.ISO8601
			};

			return cb.ToString();
		}

		public static string GetConnectionString()
		{
			return s_connectionString;
		}

		public static SQLiteConnection GetConnection()
		{
			var conn = new SQLiteConnection(s_connectionString);
			conn.Open();
			return conn;
		}

		public static NPoco.IDatabase GetDatabase()
		{
			return new NPoco.Database(s_connectionString, NPoco.DatabaseType.SQLite);
		}
	}
}