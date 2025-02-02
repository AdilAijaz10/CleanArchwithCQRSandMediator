﻿using CleanArchwithCQRSandMediator.Application.Common.Mapping;
using CleanArchwithCQRSandMediator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchwithCQRSandMediator.Application.Blogs.Queries.GetBlog
{
    public class BlogVM : IMapFrom<Blog>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
