using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace App.Newsfeed
{
	public class NewsController : ApiController
	{
		// GET: api/News
		public IEnumerable<Article> Get()
		{
			using (var db = DB.GetDatabase())
			{
				return db.Fetch<Article>().OrderByDescending(a => a.Published);
			}
		}

		// GET: api/News/5
		public Article Get(long id)
		{
			using (var db = DB.GetDatabase())
			{
				return db.SingleById<Article>(id);
			}
		}

		// POST: api/News - this should be really PUT, but it nees
		public void Post([FromBody]Article value)
		{
			using (var db = DB.GetDatabase())
			{
				if (value.RowId > 0)
				{
					db.Update(value);
				}
				else
				{
					db.Insert(value);
				}

			}
		}
		

		// DELETE: api/News/5
		public void Delete(long id)
		{
			using (var db = DB.GetDatabase())
			{
				db.Delete<Article>(id);
			}
		}
	}
}
