using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet7.RESTAPI;
using DotNet7.RESTAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HHDotNet.RESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;  //globel variable

        //constructor
        public BlogController()
        {
            _db = new AppDbContext();
        }

         
        [HttpGet]
        public IActionResult GetBlogs()
        {
            List<BlogModel> lst = _db.Blogs.OrderByDescending(x => x.BlogId).ToList();

            return Ok(lst);
        }

        [HttpGet("{id}")]
        public IActionResult GetBlog(int id)
        {
            BlogModel? item = _db.Blogs.Where(item => item.BlogId == id).FirstOrDefault();
            //BlogModel item = db.Blogs.FirstOrDefault(item => item.BlogId == id);

            if (item is null)
            {
                return NotFound("no data found");
            }

            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreateBlogs(BlogModel blog)
        {
            _db.Blogs.Add(blog);
            int result = _db.SaveChanges();

            string message = result > 0 ? "Saving Successful" : "Saving Failed";

            return Ok(message);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBlogs(int id, BlogModel blogModel)
        {
            BlogModel? item = _db.Blogs.Where(item => item.BlogId == id).FirstOrDefault();
            //BlogModel item = db.Blogs.FirstOrDefault(item => item.BlogId == id);

            if (item is null)
            {
                return NotFound("no data found");
            }

            item.BlogTitle = blogModel.BlogTitle;
            item.BlogAuthor = blogModel.BlogAuthor;
            item.BlogContent = blogModel.BlogContent;
            int result = _db.SaveChanges();

            string message = result > 0 ? "Updating Successful" : "Updating Failed";
            return Ok(message);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBlogs(int id)
        {
            BlogModel? item = _db.Blogs.Where(item => item.BlogId == id).FirstOrDefault();
            //BlogModel item = db.Blogs.FirstOrDefault(item => item.BlogId == id);

            if (item is null)
            {
                return NotFound("No data found.");
            }
            _db.Blogs.Remove(item);
            int result = _db.SaveChanges();

            string message = result > 0 ? "Deleting Successful" : "Deleting Failed";
            return Ok(message);
        }
    }
}

