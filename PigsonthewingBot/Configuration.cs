using System;
using System.Xml;

namespace PigsonthewingBot
{
	public class Configuration
	{
		public static string username = null;
		public static string password = null;
		public const string ConfigurationFile = "pigs.xml";

		public static bool LoadXML()
		{
			if (!System.IO.File.Exists(ConfigurationFile))
			{
				MainClass.Log("There is no config file");
				return false;
			}

			XmlDocument file = new XmlDocument();
			file.Load(ConfigurationFile);

			foreach (XmlNode item in file.ChildNodes[0])
			{
				switch(item.Name.ToLower())
				{
					case "username":
						username = item.InnerText;
						break;
					case "password":
						password = item.InnerText;
						break;
				}
			}

			return true;
		}
	}
}

