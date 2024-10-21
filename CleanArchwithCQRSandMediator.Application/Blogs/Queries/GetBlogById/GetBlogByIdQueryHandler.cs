using AutoMapper;
using CleanArchwithCQRSandMediator.Application.Blogs.Queries.GetBlog;
using CleanArchwithCQRSandMediator.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchwithCQRSandMediator.Application.Blogs.Queries.GetBlogById
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, BlogVM>
    {
        private readonly IBlogRepository blogRepository;
        private readonly IMapper mapper;

        public GetBlogByIdQueryHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            this.blogRepository = blogRepository;
            this.mapper = mapper;
        }
        public async Task<BlogVM> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var blog = await blogRepository.GetByIdAsync(request.BlogId);
            return mapper.Map<BlogVM>(blog);
        }
    }
}
