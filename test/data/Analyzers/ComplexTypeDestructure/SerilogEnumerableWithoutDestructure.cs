using System;
using System.Collections.Generic;
using Serilog;

namespace ConsoleApp
{
    public static class Program
    {
		public static void Main()
		{
			Log.Logger.Information("{MyProperty}", new List<string>() { "test" });
		}
    }
}
