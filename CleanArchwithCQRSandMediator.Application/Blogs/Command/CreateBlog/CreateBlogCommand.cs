using CleanArchwithCQRSandMediator.Application.Blogs.Queries.GetBlog;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchwithCQRSandMediator.Application.Blogs.Command.CreateBlog
{
    public class CreateBlogCommand : IRequest<BlogVM>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
