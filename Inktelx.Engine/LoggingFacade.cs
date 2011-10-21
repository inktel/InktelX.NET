using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections.Specialized;

using InktelX.Engine.Logging;

namespace InktelX.Engine
{

	/// <summary>
	/// Convenient methods for working with logs and plumbing related to them.
	/// </summary>
	public class LoggingFacade
	{
		private static StringDictionary _logEventCodes = new StringDictionary();



		/// <summary>
		/// Convenient way to get access to the class.  Equivalent to new LogingFacade()
		/// </summary>
		public static LoggingFacade Instance
		{
			get { return new LoggingFacade(); }
		}


		static LoggingFacade()
		{
			_logEventCodes.Add("USERS_ADD", "ADMIN ADD USER");
			_logEventCodes.Add("USERS_MODIFY", "ADMIN MODIFY USER");
			_logEventCodes.Add("TIMECLOCK_LOGIN", "USER FORCED LOGIN FROM STATUS PAGE");
			_logEventCodes.Add("USERS_DELETE", "ADMIN DELETE USER");
			_logEventCodes.Add("SYSTEMSTATUSES_MODIFY", "ADMIN MODIFY SYSTEM STATUS");
			_logEventCodes.Add("CAMPAIGNS_ADD", "ADMIN ADD CAMPAIGN");
			_logEventCodes.Add("CAMPAIGNS_MODIFY", "ADMIN MODIFY CAMPAIGN");
			_logEventCodes.Add("CARRIERS_ADD", "ADMIN ADD CARRIER");
			_logEventCodes.Add("CARRIERS_MODIFY", "ADMIN MODIFY CARRIER");
			_logEventCodes.Add("USERGROUPS_ADD", "ADMIN ADD USER GROUP");
			_logEventCodes.Add("USERGROUPS_MODIFY", "ADMIN MODIFY USER GROUP");
			_logEventCodes.Add("PHONES_MODIFY", "ADMIN MODIFY PHONE");
			_logEventCodes.Add("INGROUPS_ADD", "ADMIN ADD INBOUND GROUP");
			_logEventCodes.Add("INGROUPS_MODIFY", "ADMIN MODIFY INGROUP");
			_logEventCodes.Add("DIDS_ADD", "ADMIN ADD DID");
			_logEventCodes.Add("DIDS_MODIFY", "ADMIN MODIFY DID");
			_logEventCodes.Add("USERGROUPS_DELETE", "ADMIN DELETE USER GROUP");
			_logEventCodes.Add("SERVERS_MODIFY", "ADMIN MODIFY SERVER");
			_logEventCodes.Add("CARRIERS_DELETE", "ADMIN DELETE CARRIER");
			_logEventCodes.Add("REMOTEAGENTS_ADD", "ADMIN ADD REMOTE AGENT");
			_logEventCodes.Add("REMOTEAGENTS_MODIFY", "ADMIN MODIFY REMOTE AGENT");
			_logEventCodes.Add("PHONES_DELETE", "ADMIN DELETE PHONE");
			_logEventCodes.Add("REMOTEAGENTS_DELETE", "ADMIN DELETE REMOTE AGENT");
			_logEventCodes.Add("USERS_COPY", "ADMIN COPY USER");
			_logEventCodes.Add("PHONES_ADD", "ADMIN ADD PHONE");
			_logEventCodes.Add("INGROUPS_DELETE", "ADMIN DELETE INGROUP");
			_logEventCodes.Add("CAMPAIGNS_COPY", "ADMIN COPY CAMPAIGN");
			_logEventCodes.Add("INGROUPS_COPY", "ADMIN COPY INBOUND GROUP");
			_logEventCodes.Add("CAMPAIGN_STATUS_ADD", "ADMIN ADD CAMPAIGN STATUS");
			_logEventCodes.Add("CAMPAIGN_ALTDIAL_ADD", "ADMIN ADD CAMPAIGN ALT DIAL");
			_logEventCodes.Add("CAMPAIGN_ALTDIALS_DELETE", "ADMIN DELETE CAMPAIGN ALT DIAL");
			_logEventCodes.Add("CAMPAIGN_PAUSECODE_ADD", "ADMIN ADD CAMPAIGN PAUSE CODE");
			_logEventCodes.Add("CAMPAIGNS_MODIFY", "ADMIN MODIFY CAMPAIGN ACTIVE LISTS");
			_logEventCodes.Add("LEADS_EXPORT", "ADMIN EXPORT LIST");
			_logEventCodes.Add("LISTS_ADD", "ADMIN ADD LIST");
			_logEventCodes.Add("LISTS_LOAD", "ADMIN LOAD LIST");
			_logEventCodes.Add("LISTS_MODIFY", "ADMIN MODIFY LIST");
			_logEventCodes.Add("LISTS_RESET", "ADMIN RESET LIST");
			_logEventCodes.Add("LISTS_DELETE", "ADMIN DELETE LIST");
			_logEventCodes.Add("CAMPAIGN_DIALSTATUSES_DELETE", "ADMIN DELETE CAMPAIGN DIAL STATUS");
			_logEventCodes.Add("CAMPAIGNS_RESET", "ADMIN RESET CAMPAIGN LEAD HOPPER");
			_logEventCodes.Add("CAMPAIGN_DIALSTATUS_ADD", "ADMIN ADD CAMPAIGN DIAL STATUS");
			_logEventCodes.Add("CAMPAIGN_RECYCLE_ADD", "ADMIN ADD CAMPAIGN LEAD RECYCLE");
			_logEventCodes.Add("CAMPAIGNS_DELETE", "ADMIN DELETE CAMPAIGN");
			_logEventCodes.Add("TIMECLOCK_LOGOUT", "USER FORCED LOGOUT FROM STATUS PAGE");
			_logEventCodes.Add("LEADS_EXPORT", "ADMIN EXPORT CALLS REPORT");
			_logEventCodes.Add("CONFTEMPLATES_ADD", "ADMIN ADD CONF TEMPLATE");
			_logEventCodes.Add("CONFTEMPLATES_MODIFY", "ADMIN MODIFY CONF TEMPLATE");
			_logEventCodes.Add("CALLTIMES_ADD", "ADMIN ADD CALL TIME");
			_logEventCodes.Add("CALLTIMES_MODIFY", "ADMIN MODIFY CALL TIME");
			_logEventCodes.Add("CAMPAIGN_STATUS_MODIFY", "ADMIN MODIFY CAMPAIGN STATUS");
			_logEventCodes.Add("CAMPAIGN_STATUS_DELETE", "ADMIN DELETE CAMPAIGN STATUS");
			_logEventCodes.Add("CAMPAIGN_RECYCLE_MODIFY", "ADMIN MODIFY CAMPAIGN LEAD RECYCLE");
			_logEventCodes.Add("CAMPAIGN_PAUSECODE_MODIFY", "ADMIN MODIFY CAMPAIGN PAUSE CODE");
			_logEventCodes.Add("CAMPAIGN_RECYCLE_DELETE", "ADMIN DELETE CAMPAIGN LEAD RECYCLE");
			_logEventCodes.Add("SCRIPTS_ADD", "ADMIN ADD SCRIPT");
			_logEventCodes.Add("SYSTEMSETTINGS_MODIFY", "ADMIN MODIFY SYSTEM SETTINGS");
			_logEventCodes.Add("DIDS_COPY", "ADMIN COPY DID");
			_logEventCodes.Add("DIDS_DELETE", "ADMIN DELETE DID");
			_logEventCodes.Add("CAMPAIGN_PAUSECODES_DELETE", "ADMIN DELETE CAMPAIGN PAUSE CODE");
			_logEventCodes.Add("STATUSCATEGORIES_ADD", "ADMIN ADD STATUS CATEGORY");
			_logEventCodes.Add("FILTERS_ADD", "ADMIN ADD FILTER");
			_logEventCodes.Add("SERVERS_TRUNK_ADD", "ADMIN ADD SERVER TRUNK");
			_logEventCodes.Add("SERVERTRUNKS_DELETE", "ADMIN DELETE SERVER TRUNK");
			_logEventCodes.Add("LEADS_MODIFY", "ADMIN MODIFY LEAD");
			_logEventCodes.Add("SCRIPTS_MODIFY", "ADMIN MODIFY SCRIPT");
			_logEventCodes.Add("LISTS_ADD", "ADMIN ADD NUMBER TO DNC LIST");
			_logEventCodes.Add("SYSTEMSTATUSES_DELETE", "ADMIN DELETE SYSTEM STATUS");
			_logEventCodes.Add("LEADS_SEARCH", "ADMIN MODIFY LEAD");
			//_logEventCodes.Add("LISTS_ADD", "ADMIN ADD NUMBER TO CAMPAIGN DNC LIST 10003");
			//_logEventCodes.Add("LISTS_ADD", "ADMIN ADD NUMBER TO CAMPAIGN DNC LIST 10004");
			//_logEventCodes.Add("LISTS_ADD", "ADMIN ADD NUMBER TO CAMPAIGN DNC LIST 10005");
			_logEventCodes.Add("FILTERS_MODIFY", "ADMIN MODIFY FILTER");
			_logEventCodes.Add("LISTS_ADD", "ADMIN ADD NUMBER TO CAMPAIGN DNC LIST GovTest1");
			_logEventCodes.Add("INGROUPS_MODIFY", "USER INGROUP VIGA ADD");
			_logEventCodes.Add("CAMPAIGNS_MODIFY", "ADMIN MODIFY CAMPAIGN DETAIL");
			_logEventCodes.Add("USERS_MODIFY", "USER INGROUP SETTINGS");
			_logEventCodes.Add("CAMPAIGNS_MODIFY", "ADMIN MODIFY CAMPAIGN BASIC");
			_logEventCodes.Add("CAMPAIGNS_COPY", "ADMIN COYP CAMPAIGN");


		}

		/// <summary>
		/// Given a log section and log event type, returns vicidial's event_code values.  For each combination of event_section and event_type, vicidial stores
		/// a composite string into event_code field of log.  To avoid having to enter these event_code values manually, this method provides such a string
		/// for 99% of the combinations.<br/>
		/// <br/>
		/// For example, campaign clone has event_section='CAMPAIGN', event_type='COPY', and event_code='ADMIN COYP CAMPAIGN' (typo is correct)<br/>
		/// <br/>
		/// When using the AddLog method, the developer can optionally pass NULL on the event_code and the this value will be generated automatically.<br/>
		/// <br/>
		/// In once instance, adding a DNC to campaign, metadata is included in the event_code, such as adding number to a campaign dnc list.
		/// <br/>
		/// The log has event_section='CAMPAIGN', event_type='ADD', and event_code='ADMIN ADD NUMBER TO CAMPAIGN DNC LIST 10003'.
		/// In this case, the Vicidial.Data developer should pass an explicit value for event_code when calling AddLog(...) method to remain consistent.
		/// 
		/// </summary>
		/// <param name="section"></param>
		/// <param name="type"></param>
		/// <returns></returns>
		public string GetEventCode(LogEventSection section, LogEventType type)
		{
			string key = String.Format("{0}_{1}", section.Name, type.Name);
			if (_logEventCodes.ContainsKey(key))
				return _logEventCodes[key];

			return String.Empty;

		}


	}
}
