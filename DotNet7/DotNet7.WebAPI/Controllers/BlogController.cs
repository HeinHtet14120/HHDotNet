 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNet7.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IActionResult GetBlogs()
        {
            return Ok("GetBlog");
        }

        [HttpPost]
        public IActionResult CreateBlogs()
        {
            return Ok("CreateBlog");
        }

        [HttpPut]
        public IActionResult UpdateBlogs()
        {
            return Ok("Update Blog");
        }

        [HttpDelete]
        public IActionResult DeleteBlogs()
        {
            return Ok("DeleteBlog");
        }
    }
}

