using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnugDemo.Models
{
    public class BlogRepo : IBlogRepo
    {
        public BlogRepo()
        {

        }

        public BlogPost GetPost()
        {
            var post = new BlogPost
            {
                PostId = 123,
                Title = "ONUG ROCKS!",
                Content = "ASP.NET 5 is also cool!"
            };

            return post;
        }
    }
}
