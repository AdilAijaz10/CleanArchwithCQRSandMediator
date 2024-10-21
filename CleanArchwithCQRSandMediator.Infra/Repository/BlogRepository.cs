using CleanArchwithCQRSandMediator.Domain.Model;
using CleanArchwithCQRSandMediator.Domain.Repository;
using CleanArchwithCQRSandMediator.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchwithCQRSandMediator.Infra.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogDBContext blogDBContext;

        public BlogRepository(BlogDBContext blogDBContext)
        {
            this.blogDBContext = blogDBContext;
        }
        public async Task<Blog> CreateAsync(Blog blog)
        {
            await blogDBContext.AddAsync(blog);
            await blogDBContext.SaveChangesAsync();
            return blog;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await blogDBContext.Blogs
                 .Where(model => model.Id == id)
                 .ExecuteDeleteAsync();
        }

        public async Task<List<Blog>> GetAllBlogAsync()
        {
            return await blogDBContext.Blogs.ToListAsync();
        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return await blogDBContext.Blogs.AsNoTracking()
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<int> UpdateAsync(int id, Blog blog)
        {
            if (id != blog.Id)
            {
                throw new ArgumentException("Id mismatch", nameof(id));
            }
            return await blogDBContext.Blogs
                 .Where(model => model.Id == id)
                 .ExecuteUpdateAsync(setters => setters
                   
                   .SetProperty(m => m.Name, blog.Name)
                   .SetProperty(m => m.Description, blog.Description)
                   .SetProperty(m => m.Author, blog.Author)
                 );
        }
    }
}
