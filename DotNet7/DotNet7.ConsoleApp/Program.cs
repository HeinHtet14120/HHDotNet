// See https://aka.ms/new-console-template for more information
using DotNet7.ConsoleApp.AdoDotNetExamples;
using DotNet7.ConsoleApp.DapperExamples;

Console.WriteLine("Hello, World!");

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();

//adoDotNetExample.Edit(1002);

//adoDotNetExample.Create("GoAgain", "42Dugg", "Forever Rolling");
//adoDotNetExample.Update(1002,"GoAgain", "42Dugg", "Forever Rolling");

//adoDotNetExample.Delete(2002);


//Dapper Examples

DapperExample dapperExample = new DapperExample();
//dapperExample.Read();

dapperExample.Edit(1002);
//dapperExample.Create("SpinDaBagg", "42Dugg", "Forever Rolling");
//dapperExample.Update(10,"GoAgain", "42Dugg", "Forever Rolling");

dapperExample.Delete(3003);





Console.ReadKey();