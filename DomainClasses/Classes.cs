﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace DomainClasses
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string BloggerName { get; set; }
        public List<Post> Posts { get; set; }
        public string BlogCode
        {
            get { return Title.Substring(0, 1) + ":" + BloggerName.Substring(0, 1); }
        }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual Blog Blog { get; set; }
    }

}
