using System;
using System.Net.Mime;
using System.Text;
using DotNet7.ConsoleApp.Models;
using Newtonsoft.Json;

namespace DotNet7.ConsoleApp.HttpClientExamples
{
	public class HttpClientExample 
	{
		public async Task Run() 
		{
            //await Create("heintothehtet", "Sundayyy", "it is Sundayyyy");
			await Read();

            await Delete(7002);

            //await Update(7002, "heinhtet", "Friday", "Thanks god it is friday");

            //         await Edit(9);

            //         await Edit(1);

        }

		private async Task Read()
		{
			HttpClient client = new HttpClient();
			//var response = await client.GetAsync("Route");
			HttpResponseMessage response = await client.GetAsync("https://localhost:7108/api/Blog");

			if (response.IsSuccessStatusCode)
			{
				string json = await response.Content.ReadAsStringAsync();
				List<BlogModel> lst = JsonConvert.DeserializeObject<List<BlogModel>>(json)!;

                foreach (BlogModel item in lst)
                {
                    Console.WriteLine(item.BlogId);
                    Console.WriteLine(item.BlogTitle);
                    Console.WriteLine(item.BlogAuthor);
                    Console.WriteLine(item.BlogContent);

                }
            }
			else
			{
				Console.WriteLine(response.Content.ReadAsStringAsync());
			}
		}

        private async Task Edit(int id)
        {
            string url = $"https://localhost:7108/api/Blog/{id}";
            HttpClient client = new HttpClient();
            //var response = await client.GetAsync("Route");
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                BlogModel item = JsonConvert.DeserializeObject<BlogModel>(json)!;
                Console.WriteLine(item.BlogId);
                Console.WriteLine(item.BlogTitle);
                Console.WriteLine(item.BlogAuthor);
                Console.WriteLine(item.BlogContent);

            }
            else
            {
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }
        }

        public async Task Create(string title, string author, string content)
        {
            BlogModel blog = new BlogModel()
            {
                BlogTitle = title,
                BlogAuthor = author,
                BlogContent = content
            };

            string jsonBlog = JsonConvert.SerializeObject(blog);
            HttpContent httpContent = new StringContent(jsonBlog, Encoding.UTF8, MediaTypeNames.Application.Json);
            string url = $"https://localhost:7108/api/Blog";
            HttpClient client = new HttpClient();
            //var response = await client.GetAsync("Route");
            HttpResponseMessage response = await client.PostAsync(url, httpContent);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                Console.WriteLine(await response.Content.ReadAsStringAsync());

            }
            else
            {
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }
        }

        public async Task Update(int id, string title, string author, string content)
        {
            BlogModel blog = new BlogModel()
            {
                BlogTitle = title,
                BlogAuthor = author,
                BlogContent = content
            };

            string jsonBlog = JsonConvert.SerializeObject(blog);
            HttpContent httpContent = new StringContent(jsonBlog, Encoding.UTF8, MediaTypeNames.Application.Json);
            string url = $"https://localhost:7108/api/Blog/{id}";
            HttpClient client = new HttpClient();
            //var response = await client.GetAsync("Route");
            HttpResponseMessage response = await client.PutAsync(url, httpContent);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                Console.WriteLine(await response.Content.ReadAsStringAsync());

            }
            else
            {
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }
        }

        private async Task Delete(int id)
        {
            string url = $"https://localhost:7108/api/Blog/{id}";
            HttpClient client = new HttpClient();
            //var response = await client.GetAsync("Route");
            HttpResponseMessage response = await client.DeleteAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                Console.WriteLine(await response.Content.ReadAsStringAsync());

            }
            else
            {
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }
        }
    }
}

