using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NPoco;

namespace App.Newsfeed
{
	[TableName("ARTICLE")]
	[PrimaryKey("ROWID", AutoIncrement = true)]
	public class Article
	{
		[Column("ROWID")]
		public long RowId { get; set;}
		[Column("PUBLISHED")]
		public DateTime Published { get; set; }
		[Column("BODY")]
		public string Body { get; set; }
	}
}