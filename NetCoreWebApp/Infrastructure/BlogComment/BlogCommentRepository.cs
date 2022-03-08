using Domain.Entities;
using Domain.Shared.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.BlogComment
{
    public class BlogCommentRepository : IBlogCommentRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public BlogCommentRepository(ApplicationDbContext applicationDbContext) => _applicationDbContext = applicationDbContext;
        
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public Task<List<Domain.Entities.BlogComment>> GetBlogComments()
        {
            return _applicationDbContext.blogcomment.ToListAsync();
        }
    }
}
