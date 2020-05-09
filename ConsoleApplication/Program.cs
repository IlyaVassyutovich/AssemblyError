using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace ConsoleApplication
{
	internal static class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello, world!");

			UseConfiguration();

			Console.ReadLine();
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