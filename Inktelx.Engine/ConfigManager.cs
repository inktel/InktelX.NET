using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace InktelX.Engine
{
	/// <summary>
	/// Convenience class to access config settings in typesafe index and typesafe return
	/// </summary>
	public static class ConfigManager
	{
		public static class ConnectionStrings
		{
			public static string VicidialEntities
			{
				get { return "name=VicidialEntities"; }
			}
		}


		/// <summary>
		/// These are quick accessors to common app settigns.  We will refactor this to reference a table of settings once we introduce the InktelX unique data model -->
		/// </summary>
		public static class AppSettings
		{

			public static int DefaultWrapWarningTimeInSeconds
			{
				get { return int.Parse(ConfigurationManager.AppSettings["DefaultWrapWarningTimeInSeconds"]); }
			}

			public static string DefaultWrapWarningMessage
			{
				get { return ConfigurationManager.AppSettings["DefaultWrapWarningMessage"]; }
			}

			public static string ClientApplicationUrlParams
			{
				get { return ConfigurationManager.AppSettings["ClientApplicationUrlParams"]; }
			}
		}
	}
}
