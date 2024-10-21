using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchwithCQRSandMediator.Application.Blogs.Queries.GetBlog
{
    public class GetBlogQuery :IRequest<List<BlogVM>>
    {

    }
}
