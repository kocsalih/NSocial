﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using NSocial.DataAccess;
using NSocial.ModelBase;


namespace NSocial.Models
{
	public class Post : UserBase
	{
		public int ID { get; set; }
		public HttpPostedFileBase PostImagePath { get; set; }
		public string Text { get; set; }
		public DateTime PostDate { get; set; }
		public int LikesCount { get; set; }
		public int PunchsCount { get; set; }
		public int CommentsCount { get; set; }
		public int UserID { get; set; }
		public User RoleID { get; set; }
		public ICollection<Post> Comments { get; set; }
	}
}