// See https://aka.ms/new-console-template for more information
using DotNet7.ConsoleApp.AdoDotNetExamples;

Console.WriteLine("Hello, World!");

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();

adoDotNetExample.Edit(1002);

//adoDotNetExample.Create("GoAgain", "42Dugg", "Forever Rolling");
//adoDotNetExample.Update(1002,"GoAgain", "42Dugg", "Forever Rolling");

adoDotNetExample.Delete(2002);

Console.ReadKey();