using CleanArchwithCQRSandMediator.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchwithCQRSandMediator.Application.Blogs.Command.DeleteBlog
{
    public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand, int>
    {
        private readonly IBlogRepository blogRepository;

        public DeleteBlogCommandHandler(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }
        public Task<int> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            return blogRepository.DeleteAsync(request.Id);
        }
    }
}
