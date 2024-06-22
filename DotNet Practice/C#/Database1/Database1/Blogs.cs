﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database1
{
    internal class Blogs
    {
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



    }
}