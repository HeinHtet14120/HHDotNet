using System;
using DotNet7.ConsoleApp.Models;
using Refit;

namespace DotNet7.ConsoleApp.RefitExamples
{
	public interface IBlogApi
	{
        [Get("/api/blog")]
        Task<List<BlogModel>> GetBlogs();

        [Get("/api/blog/{id}")]
        Task<BlogModel> GetBlog(int id);

        [Post("/api/blog")]
        Task<string> CreateBlog(BlogModel blog);

        [Put("/api/blog/{id}")]
        Task<string> UpdateBlog(int id ,BlogModel blog);

        [Delete("/api/blog/{id}")]
        Task<string> DeleteBlog(int id);
    }
}

