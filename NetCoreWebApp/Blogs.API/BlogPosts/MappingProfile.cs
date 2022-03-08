using AutoMapper;
using Blogs.API.BlogComments.V1.Models;
using Blogs.API.BlogPosts.V1.Models;

namespace Blogs.API.BlogPosts
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Entities.BlogPost, BlogPost>();
            CreateMap<Domain.Entities.BlogComment, BlogComment>();
        }
    }
}
