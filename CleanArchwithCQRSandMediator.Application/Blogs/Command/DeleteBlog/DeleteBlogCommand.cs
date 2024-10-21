using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchwithCQRSandMediator.Application.Blogs.Command.DeleteBlog
{
    public class DeleteBlogCommand :IRequest<int>
    {
        public int Id { get; set; }
    }
}
