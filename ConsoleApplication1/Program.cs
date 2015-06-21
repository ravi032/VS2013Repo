using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses;
using Pluralsight.DataLayer;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                 var blog = db.Blogs.Find(1);
                 if (blog != null)
                 {
                     Console.WriteLine("Title: " + blog.Title);
                     db.Blogs.Remove(blog);
                     db.SaveChanges();
                 }
            }

           // CreateBlog();
           // AddPost();
        }

        private static void AddPost()
        {
            using (var db = new Context())
            {
                try
                {

                    var blog = db.Blogs.Find(2);
                    if (blog != null)
                    {
                        blog.Posts.Add(new Post
                        {
                            Title = "My First Post",
                            Content = "Let's keep this short"
                        });
                        db.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("No blogs available to add post.");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void CreateBlog()
        {
            var objBlog = new Blog() { Title="First Blog", BloggerName="Ravi" };

            using (var db = new Context())
            {
                db.Blogs.Add(objBlog);

                try
                {
                    db.SaveChanges();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
