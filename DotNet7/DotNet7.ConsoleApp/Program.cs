// See https://aka.ms/new-console-template for more information
using DotNet7.ConsoleApp.AdoDotNetExamples;
using DotNet7.ConsoleApp.DapperExamples;
using DotNet7.ConsoleApp.EFCoreExamples;
using DotNet7.ConsoleApp.HttpClientExamples;
using DotNet7.ConsoleApp.Models;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();

//adoDotNetExample.Edit(1002);

//adoDotNetExample.Create("GoAgain", "42Dugg", "Forever Rolling");
//adoDotNetExample.Update(1002,"GoAgain", "42Dugg", "Forever Rolling");

//adoDotNetExample.Delete(2002);


//Dapper Examples

//DapperExample dapperExample = new DapperExample();
//dapperExample.Read();

//dapperExample.Edit(1002);
//dapperExample.Create("SpinDaBagg", "42Dugg", "Forever Rolling");
//dapperExample.Update(10,"GoAgain", "42Dugg", "Forever Rolling");

//dapperExample.Delete(3003);


//EFCoreExample eFCoreExample = new EFCoreExample();
//eFCoreExample.Read();
//eFCoreExample.Edit(1005);
//eFCoreExample.Update(1002,"EFCore", "42Dugg", "Forever Rolling");
//eFCoreExample.Delete(4002);


//Console.WriteLine("Loading.......");
//Console.ReadKey();

//HttpClientExample client = new HttpClientExample();
//await client.Run();

//BlogModel blog = new BlogModel();
//blog.BlogTitle = "heinhtet";
//blog.BlogAuthor = "hh";
//blog.BlogContent = "C# object to json";

//string json = JsonConvert.SerializeObject(blog);  // C# obj to Json

//Console.WriteLine(json);

//BlogModel blog2 = JsonConvert.DeserializeObject<BlogModel>(json) ! ;
//Console.WriteLine(blog2.BlogTitle);
//Console.WriteLine(blog2.BlogAuthor);
//Console.WriteLine(blog2.BlogContent);


Console.WriteLine("Loading.......");
Console.ReadKey();

HttpClientExample client = new HttpClientExample();
await client.Run();





Console.ReadKey();