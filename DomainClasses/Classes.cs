using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace DomainClasses
{
    public class Blog
    {
        public Blog()
        {
            Posts = new List<Post>();
        }

        [Key]
        [Column("Id")]
        public int Id { get; set; }
        
        //[Required]
        [MaxLength(20)]
        public string Title { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
        [Required]
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
