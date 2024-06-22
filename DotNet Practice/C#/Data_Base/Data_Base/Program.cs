using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Base
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

                    var blog = new Blog
                    {
                        BlogName = blogName,
                        BlogType = "Tech",
                        BlogHeader = "Welcome to My Tech Blog",
                        BlogDescription = "A blog about tech news and updates."
                    };
                    context.Blogs.Add(blog);
                    context.SaveChanges();

                    // Create and save a new Post
                    Console.Write("Enter a title for a new Post: ");
                    var postTitle = Console.ReadLine();
                    Console.Write("Enter content for the Post: ");
                    var postContent = Console.ReadLine();

                    var post = new Post
                    {
                        Title = postTitle,
                        Content = postContent,
                        BlogId = blog.BlogId
                    };
                    context.Posts.Add(post);
                    context.SaveChanges();

                    // Display all Blogs and their Posts
                    var blogs = context.Blogs.Include(b => b.Posts).ToList();
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

        public partial class Blog
        {
            public Blog()
            {
                this.Posts = new HashSet<Post>();
            }

            public int BlogId { get; set; }
            public string BlogName { get; set; }
            public string BlogType { get; set; }
            public string BlogHeader { get; set; }
            public string BlogDescription { get; set; }

            public virtual ICollection<Post> Posts { get; set; }
        }

        public partial class Post
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public int BlogId { get; set; }

            public virtual Blog Blog { get; set; }
        }

        public partial class BloggingContext : DbContext
        {
            public BloggingContext()
                : base("name=BloggingContext")
            {
            }

            public virtual DbSet<Blog> Blogs { get; set; }
            public virtual DbSet<Post> Posts { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Blog>()
                    .HasMany(e => e.Posts)
                    .WithRequired(e => e.Blog)
                    .HasForeignKey(e => e.BlogId)
                    .WillCascadeOnDelete(false);
            }
        }
    }


}

