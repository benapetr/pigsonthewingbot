using System;

namespace PigsonthewingBot
{
	class MainClass
	{
		public static void Log(string text)
		{
			Console.WriteLine(DateTime.Now.ToString() + ": " + text);
		}

		public static void ExceptionHandler(Exception xx)
		{
			Log ("EXCEPTION: " + xx.ToString () + xx.StackTrace);
		}

		public static void Main (string[] args)
		{
			try
			{
				Configuration.LoadXML();
				DotNetWikiBot.Site site = new DotNetWikiBot.Site("en.wikipedia.org", Configuration.username, Configuration.password);

			}
			catch (Exception fail)
			{
				ExceptionHandler(fail);
			}
		}
	}
}
