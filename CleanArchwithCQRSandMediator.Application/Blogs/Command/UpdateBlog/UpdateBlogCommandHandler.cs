using CleanArchwithCQRSandMediator.Application.Blogs.Queries.GetBlog;
using CleanArchwithCQRSandMediator.Domain.Model;
using CleanArchwithCQRSandMediator.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchwithCQRSandMediator.Application.Blogs.Command.UpdateBlog
{
    public  class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, int>
    {
        private readonly IBlogRepository blogRepository;

        public UpdateBlogCommandHandler(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }
        public async Task<int> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var updateEntity = new Blog()
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                Author = request.Author,
            };
            return await blogRepository.UpdateAsync(request.Id, updateEntity);
        }
    }
}
