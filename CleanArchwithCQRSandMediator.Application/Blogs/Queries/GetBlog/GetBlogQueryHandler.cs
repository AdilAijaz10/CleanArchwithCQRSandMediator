using MediatR;
using CleanArchwithCQRSandMediator.Domain.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CleanArchwithCQRSandMediator.Application.Blogs.Queries.GetBlog
{
    //to handle reqest and response                 
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<BlogVM>>
    {
        private readonly IBlogRepository blogRepository;
        private readonly IMapper mapper;

        //IBlogRepositroy Injected form Domain Repository
        public GetBlogQueryHandler(IBlogRepository blogRepository, IMapper mapper) {
            this.blogRepository = blogRepository;
            this.mapper = mapper;
        }
        //business logic
        public async Task<List<BlogVM>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
             var blog = await blogRepository.GetAllBlogAsync();
            //var BlogList =  blog.Select(x=> new BlogVM 
            //  {Id =x.Id, Name=x.Name,Description=x.Description,Author=x.Author }).ToList();
            var BlogList = mapper.Map<List<BlogVM>>(blog);
            return BlogList;
        }
    }
}
