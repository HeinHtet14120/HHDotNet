using System;
using DotNet7.ConsoleApp.Models;
using Newtonsoft.Json;

namespace DotNet7.ConsoleApp.HttpClientExamples
{
	public class HttpClientExample2
	{
		public async Task Run()
		{
            await Read();
            //await JsonPlaceHolder();
        }

		private async Task Read()
		{
			HttpClient client = new HttpClient();
			HttpResponseMessage response = await client.GetAsync("http://localhost:5106/api/Blog");
			if (response.IsSuccessStatusCode)
			{
				string jsonStr = await response.Content.ReadAsStringAsync();
				Console.WriteLine(jsonStr);

				//JsonConvert.SerializeObject() // C# obj to JSON
				//JsonConvert.DeserializeObject() // Json to C# Obj 

				List<BlogModel> lst = JsonConvert.DeserializeObject<List<BlogModel>>(jsonStr)!;
                //lst.Add(new BlogModel()
                //{
                //    BlogTitle = "Hein Htet",
                //    BlogAuthor = "hein Htet",
                //    BlogContent = "hein htet"
                //});

                //BlogModel[] lst2 = JsonConvert.DeserializeObject<BlogModel[]>(jsonStr)!;
                //lst2[0] = 


                foreach (BlogModel item in lst)
                {
                    Console.WriteLine(item.BlogId);
                    Console.WriteLine(item.BlogTitle);
                    Console.WriteLine(item.BlogAuthor);
                    Console.WriteLine(item.BlogContent);

                }
            }
		}


        private async Task JsonPlaceHolder()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                Console.WriteLine(jsonStr);

                //JsonConvert.SerializeObject() // C# obj to JSON
                //JsonConvert.DeserializeObject() // Json to C# Obj 

                List<JsonPlaceHolderModel> lst = JsonConvert.DeserializeObject<List<JsonPlaceHolderModel>>(jsonStr)!;

                foreach (JsonPlaceHolderModel item in lst)
                {
                    Console.WriteLine(item.userId);
                    Console.WriteLine(item.id);
                    Console.WriteLine(item.title);
                    Console.WriteLine(item.body);
                }
            }
        }
    }
}

