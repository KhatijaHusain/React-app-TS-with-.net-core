using Domain.Entities;
using Domain.Shared.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.BlogPost
{
    public class BlogPostRepository : IBlogPostRepository
    {
        public BlogPostRepository(ApplicationDbContext applicationDbContext) => _applicationDbContext = applicationDbContext;
        private readonly ApplicationDbContext _applicationDbContext;
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public Task<List<Domain.Entities.BlogPost>> GetBlogPosts()
        {
           return _applicationDbContext.blogposts
             .Include(x => x.blogcomment)
             .ToListAsync();
        }

        public Task<Domain.Entities.BlogPost> GetBlogPostById(int id)
        {
            return  _applicationDbContext.blogposts
                    .FirstOrDefaultAsync(x => x.blogpostid == id);
        }
    }
}
