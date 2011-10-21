using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InktelX.Engine.Logging
{
	/// <summary>
	/// Vicidial stores strings in the event_type for the log.  Since we will need to log throughout our business layer similar to vicidial within PHP, we'll ensure
	/// log consistency by using a strongly typed LogEventType.  These values represent all the distinct values currently found in the event_type of vicidial_admin_log 
	/// </summary>
	public partial class LogEventType
	{
		public string Name { get; private set; }
		public static readonly LogEventType ADD;
		public static readonly LogEventType MODIFY;
		public static readonly LogEventType LOGIN;
		public static readonly LogEventType DELETE;
		public static readonly LogEventType COPY;
		public static readonly LogEventType EXPORT;
		public static readonly LogEventType LOAD;
		public static readonly LogEventType RESET;
		public static readonly LogEventType LOGOUT;
		public static readonly LogEventType SEARCH;

		static LogEventType()
		{
			ADD = new LogEventType() { Name = "ADD" };
			MODIFY = new LogEventType() { Name = "MODIFY" };
			LOGIN = new LogEventType() { Name = "LOGIN" };
			DELETE = new LogEventType() { Name = "DELETE" };
			COPY = new LogEventType() { Name = "COPY" };
			EXPORT = new LogEventType() { Name = "EXPORT" };
			LOAD = new LogEventType() { Name = "LOAD" };
			RESET = new LogEventType() { Name = "RESET" };
			LOGOUT = new LogEventType() { Name = "LOGOUT" };
			SEARCH = new LogEventType() { Name = "SEARCH" };
		}

	}
}
