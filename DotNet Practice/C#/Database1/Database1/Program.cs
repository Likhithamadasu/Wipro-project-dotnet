using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database1
{
    internal class Program
    {
        class Database
        {
            static void Main()
            {
                using (var context = new BloggingContext())
                {
                    // Create and save a new Blog
                    Console.Write("Enter a name for a new Blog: ");
                    var blogName = Console.ReadLine();

                    var blog = new Blog { BlogName = blogName, BlogType = "Tech", BlogHeader = "Welcome to My Tech Blog", BlogDescription = "A blog about tech news and updates." };
                    context.Blogs.Add(blog);
                    context.SaveChanges();

                    // Create and save a new Post
                    Console.Write("Enter a title for a new Post: ");
                    var postTitle = Console.ReadLine();
                    Console.Write("Enter content for the Post: ");
                    var postContent = Console.ReadLine();

                    var post = new Post { Title = postTitle, Content = postContent, BlogId = blog.BlogId };
                    context.Posts.Add(post);
                    context.SaveChanges();

                    // Display all Blogs and their Posts
                    var blogs = context.Blogs.Include("Posts").ToList();
                    Console.WriteLine("All blogs in the database:");
                    foreach (var b in blogs)
                    {
                        Console.WriteLine($"Blog Name: {b.BlogName}, Type: {b.BlogType}");
                        foreach (var p in b.Posts)
                        {
                            Console.WriteLine($"- Post Title: {p.Title}");
                        }
                    }
                }
            }
        }



    }
}
