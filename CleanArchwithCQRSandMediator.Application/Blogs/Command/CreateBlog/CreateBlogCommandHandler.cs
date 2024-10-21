using AutoMapper;
using CleanArchwithCQRSandMediator.Application.Blogs.Queries.GetBlog;
using CleanArchwithCQRSandMediator.Domain.Model;
using CleanArchwithCQRSandMediator.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchwithCQRSandMediator.Application.Blogs.Command.CreateBlog
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, BlogVM>
    {
        private readonly IBlogRepository blogRepository;
        private readonly IMapper mapper;

        public CreateBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            this.blogRepository = blogRepository;
            this.mapper = mapper;
        }
        public async Task<BlogVM> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var BlogEntity = new Blog() { Name= request.Name, Author=request.Author,Description=request.Description };
            var Result = await blogRepository.CreateAsync(BlogEntity);
            return mapper.Map<BlogVM>(Result);
        }
    }
}
