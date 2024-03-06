using System;
using Newtonsoft.Json;
using System.Net.Mime;
using System.Text;
using DotNet7.ConsoleApp.Models;
using RestSharp;

namespace DotNet7.ConsoleApp.RestClientExamples
{
	public class RestClientExample
	{

        private readonly string _apiUrl = "https://localhost:7108/api/Blog";

        public async Task Run()
        {
            //await Create("heintothehtet141414", "Sundayyy", "it is Sundayyyy");

            await Delete(8002);
            await Read();


            //await Update(8002, "heinhtet", "Friday", "Thanks god it is friday");

            //await Edit(4);

            //         await Edit(1); 

        }

        private async Task Read()
        {
            RestRequest request = new RestRequest(_apiUrl, Method.Get);
            RestClient client = new RestClient();
            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content!;
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
                Console.WriteLine(response.Content!);
            }
        }

        private async Task Edit(int id)
        {
            string url = $"{_apiUrl}/{id}";
            RestRequest request = new RestRequest(url, Method.Get);
            RestClient client = new RestClient();
            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content!;
                BlogModel item = JsonConvert.DeserializeObject<BlogModel>(json)!;
                Console.WriteLine(item.BlogId);
                Console.WriteLine(item.BlogTitle);
                Console.WriteLine(item.BlogAuthor);
                Console.WriteLine(item.BlogContent);

            }
            else
            {
                Console.WriteLine(response.Content);
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

            RestRequest request = new RestRequest(_apiUrl, Method.Post);
            request.AddBody(blog);
            RestClient client = new RestClient();
            RestResponse response = await client.ExecuteAsync(request);


            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content!);

            }
            else
            {
                Console.WriteLine(response.Content!);
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

            string url = $"{_apiUrl}/{id}";
            RestRequest request = new RestRequest(url, Method.Put);
            request.AddBody(blog);
            RestClient client = new RestClient();
            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content!);

            }
            else
            {
                Console.WriteLine(response.Content!);
            }
        }

        private async Task Delete(int id)
        {
            string url = $"{_apiUrl}/{id}";
            RestRequest request = new RestRequest(url, Method.Delete);
            RestClient client = new RestClient();
            RestResponse response = await client.DeleteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine( response.Content!);

            }
            else
            {
                Console.WriteLine(response.Content!);
            }
        }
    }
}

