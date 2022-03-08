using Domain.Shared.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public interface IBlogPostRepository : IRepository
    {
        Task<List<BlogPost>> GetBlogPosts();
        Task<Domain.Entities.BlogPost> GetBlogPostById(int id);
    }
}
