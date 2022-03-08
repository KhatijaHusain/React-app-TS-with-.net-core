using AutoMapper;
using Blogs.API.Configuration.Controllers.v1;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Blogs.API.BlogComments
{
    public class BlogCommentsController : BaseController<BlogCommentsController>
    {
        private readonly ILogger<BlogCommentsController> _logger;
        private readonly IMapper _autoMapper;
        private readonly IBlogCommentRepository _repository;
        public BlogCommentsController(ILogger<BlogCommentsController> logger, IMapper autoMapper, IBlogCommentRepository repository) : base(logger)
        {
            _logger = logger;
            _autoMapper = autoMapper;
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(BlogComment),200)]
        public async Task<IActionResult> GetAsync()
        {
            var comments = await _repository.GetBlogComments();
            return Ok(comments);
        }
    }
}
