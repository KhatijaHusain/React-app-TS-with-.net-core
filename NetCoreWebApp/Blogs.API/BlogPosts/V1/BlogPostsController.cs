using AutoMapper;
using Blogs.API.Configuration.Controllers.v1;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlogPost = Blogs.API.BlogPosts.V1.Models.BlogPost;

namespace Blogs.API.BlogPosts.V1
{
    public class BlogPostsController : BaseController<BlogPostsController>
    {
        private readonly IBlogPostRepository _blogpostRepository;
        private readonly IMapper _mapper;
        public BlogPostsController(ILogger<BlogPostsController> logger, IMapper mapper, IBlogPostRepository blogpostRepository) : base(logger)
        {
            _blogpostRepository = blogpostRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(BlogPost), 200)]
        public async Task<IActionResult> GetAsync()
        {
            List<BlogPost> blogPosts = _mapper.Map<List<BlogPost>>(await _blogpostRepository.GetBlogPosts());
            return Ok(blogPosts);
        }



        [HttpGet("{blogpostid:int}", Name = "GetBlog")]
        [ProducesResponseType(typeof(BlogPost), 200)]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int blogpostid)
        {
            BlogPost blogPosts = _mapper.Map<BlogPost>(await _blogpostRepository.GetBlogPostById(blogpostid));
            return Ok(blogPosts);
        }
    }
}
