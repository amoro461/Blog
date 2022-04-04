#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blog.Api.Database;
using Blog.Shared;

namespace Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserModelsController : ControllerBase
    {
        private readonly UserDatabaseContext _context;

        public UserModelsController(UserDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/UserModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUserModels()
        {
            return await _context.UserModels.ToListAsync();
        }
    }
}
