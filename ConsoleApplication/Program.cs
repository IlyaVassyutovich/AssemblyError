using System;
using System.Collections.Generic;
using EasyCaching.InMemory;
using Microsoft.Extensions.Configuration;

namespace ConsoleApplication
{
	internal static class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello, world!");

			UseConfiguration();

			UseEasyCaching();

			Console.ReadLine();
		}

		private static void UseEasyCaching()
		{
			var options = new InMemoryCachingOptions();
			var caching = new InMemoryCaching("Test", options);
			caching.Add("aaa", "bbb");
			Console.WriteLine(caching.Get("aaa"));
		}

		private static void UseConfiguration()
		{
			var configuration = new ConfigurationBuilder()
				.AddInMemoryCollection(
					new[] {new KeyValuePair<string, string>("foo", "bar")})
				.Build();

			Console.WriteLine(configuration["foo"]);
		}
	}
}