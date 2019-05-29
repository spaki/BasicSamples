using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace BasicSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region WebServer
            //var html = "<h1 style='color: purple;'>Thanos dies in the first 10min... endgame!</h1>";

            //new WebHostBuilder()
            //    .UseKestrel()
            //    .UseUrls("http://*:5050") // it is not mandatory
            //    .Configure(app => {
            //        app.Run(async (context) => await context.Response.WriteAsync(html));
            //    })
            //    .Build()
            //    .Run();
            #endregion

            #region Basic Numbers
            //int num1;
            //num1 = 20;
            //Console.WriteLine($"num1: {num1}");

            //int? num2;
            //num2 = null;
            //Console.WriteLine($"num2: {num2}");

            //decimal num3 = 10;
            //Console.WriteLine($"num3: {num3}");

            //var num4 = 10.3;
            //Console.WriteLine($"num4({num4.GetType()}): {num4}");
            #endregion

            #region Basic Strings
            //string word1 = null;
            //Console.WriteLine($"word1: {word1}");

            //var word2 = "got is worse than lost!";
            //Console.WriteLine($"word2: {word2}");
            #endregion

            #region Basic Flow

            //var max = 10;
            //if(2 > max)
            //    Console.WriteLine("we reach the if!");
            //else
            //    Console.WriteLine("we reach the else!");

            //var bigger = 1 > 2 ? "it is true" : "it is false";
            //Console.WriteLine(bigger);

            //var length = 10;
            //for (int i = 0; i < length; i++)
            //{
            //    Console.WriteLine($"{i}");
            //    Console.WriteLine("... and lets go to the next...");
            //}

            #endregion

            #region Generics

            //var numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);

            //foreach (var item in numbers)
            //    Console.WriteLine(item);

            //var person1 = new Person();
            //person1.Name = "Peter Park";
            //person1.Age = 12;

            //var person2 = new Person { Name = "Chapolin", Age = 60 };

            //var people = new List<Person>
            //{
            //    person1,
            //    person2,
            //    new Person { Name = "Liu Kang", Age = 50 },
            //    new Person { Name = "Pepper Potts", Age = 40 }
            //};

            //foreach (var item in people)
            //{
            //    Console.WriteLine($"{item.Name} - {item.Age}");
            //}

            //for (int i = 0; i < people.Count; i++)
            //{
            //    var item = people[i];
            //    Console.WriteLine($"{item.Name} - {item.Age}");
            //}

            #endregion

            #region Special Types

            //dynamic temp;

            //temp = 0;
            //Console.WriteLine($"temp: {temp}");

            //temp = new Person { Name = "Eduardo Spaki", Age = 16 };
            //Console.WriteLine($"temp: {temp.Name} - Birth Year -> {temp.GetBirthYear()}");

            //var company = new { CompanyName = "ACME", MarketCap = 1_000_000_000_000 };
            //Console.WriteLine($"{company.CompanyName} - Market Cap -> {company.MarketCap:C}");

            //var tuple = (first: "one", second: "two", third: new Person { Name = "Rita Repulsa" });
            //Console.WriteLine($"{tuple.first} - {tuple.second} - {tuple.third.Name}");

            #endregion

            #region Actions e Functions

            //var sayHi = new Action<string, string, string>(PrintMessage);
            //sayHi("Oi, eu sou o", "Hi, I'm", "Goku");

            //Func<int, int, string> monaySumCalc = (y, x) => 
            //{
            //    return $"{y + x :c}";
            //};

            //Func<int, int, string> monayTimesCalc = (y, x) => $"{y * x:c}";

            //var sum = monaySumCalc(2, 5);
            //var times = monayTimesCalc(2, 5);
            //Console.WriteLine("Sum: " + sum);
            //Console.WriteLine("Times: " + times);

            #endregion
        }

        static void PrintMessage(string message1, string message2, string character)
        {
            Console.WriteLine($"{message1} {character}");
            Console.WriteLine($"{message2} {character}");
        }
    }
}
