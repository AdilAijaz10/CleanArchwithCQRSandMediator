﻿using CleanArchwithCQRSandMediator.Application.Blogs.Queries.GetBlog;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchwithCQRSandMediator.Application.Blogs.Queries.GetBlogById
{
    public class GetBlogByIdQuery :IRequest<BlogVM>
    {
        public int BlogId { get; set; }
    }
}
