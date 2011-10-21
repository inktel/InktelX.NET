using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InktelX.Engine.Logging
{
	/// <summary>
	/// Vicidial stores strings in the event_section for the log.  Since we will need to log throughout our business layer similar to vicidial within PHP, we'll ensure
	/// log consistency by using a strongly typed LogEventSection.  These values represent all the distinct values currently found in the event_section of vicidial_admin_log 
	/// <br/>
	/// <br/>
	/// 
	/// Sample usage for Vicidial.Data developer: <br/>
	///
	/// Log entry within AddCampaignByCloning(...)<br/>
	/// ...<br/>
	/// AddLog(LogEventSection.CAMPAIGNS, LogEventType.COPY, campaignID, ...);
	/// </summary>
	public partial class LogEventSection
	{
		public string Name { get; private set; }
		public static readonly LogEventSection CALLTIMES;
		public static readonly LogEventSection CAMPAIGNS;
		public static readonly LogEventSection CAMPAIGN_ALTDIAL;
		public static readonly LogEventSection CAMPAIGN_ALTDIALS;
		public static readonly LogEventSection CAMPAIGN_DIALSTATUS;
		public static readonly LogEventSection CAMPAIGN_DIALSTATUSES;
		public static readonly LogEventSection CAMPAIGN_PAUSECODE;
		public static readonly LogEventSection CAMPAIGN_PAUSECODES;
		public static readonly LogEventSection CAMPAIGN_RECYCLE;
		public static readonly LogEventSection CAMPAIGN_STATUS;
		public static readonly LogEventSection CARRIERS;
		public static readonly LogEventSection CONFTEMPLATES;
		public static readonly LogEventSection DIDS;
		public static readonly LogEventSection FILTERS;
		public static readonly LogEventSection INGROUPS;
		public static readonly LogEventSection LEADS;
		public static readonly LogEventSection LISTS;
		public static readonly LogEventSection PHONES;
		public static readonly LogEventSection REMOTEAGENTS;
		public static readonly LogEventSection SCRIPTS;
		public static readonly LogEventSection SERVERS;
		public static readonly LogEventSection SERVERS_TRUNK;
		public static readonly LogEventSection SERVERSTRUNKS;
		public static readonly LogEventSection STATUSCATEGORIES;
		public static readonly LogEventSection SYSTEMSETTINGS;
		public static readonly LogEventSection TIMECLOCK;
		public static readonly LogEventSection USERGROUPS;
		public static readonly LogEventSection USERS;

		static LogEventSection()
		{
			CALLTIMES = new LogEventSection() { Name = "CALLTIMES" };
			CAMPAIGNS = new LogEventSection() { Name = "CAMPAIGNS" };
			CAMPAIGN_ALTDIAL = new LogEventSection() { Name = "CAMPAIGN_ALTDIAL" };
			CAMPAIGN_ALTDIALS = new LogEventSection() { Name = "CAMPAIGN_ALTDIALS" };
			CAMPAIGN_DIALSTATUS = new LogEventSection() { Name = "CAMPAIGN_DIALSTATUS" };
			CAMPAIGN_DIALSTATUSES = new LogEventSection() { Name = "CAMPAIGN_DIALSTATUSES" };
			CAMPAIGN_PAUSECODE = new LogEventSection() { Name = "CAMPAIGN_PAUSECODE" };
			CAMPAIGN_PAUSECODES = new LogEventSection() { Name = "CAMPAIGN_PAUSECODES" };
			CAMPAIGN_RECYCLE = new LogEventSection() { Name = "CAMPAIGN_RECYCLE" };
			CAMPAIGN_STATUS = new LogEventSection() { Name = "CAMPAIGN_STATUS" };
			CARRIERS = new LogEventSection() { Name = "CARRIERS" };
			CONFTEMPLATES = new LogEventSection() { Name = "CONFTEMPLATES" };
			DIDS = new LogEventSection() { Name = "DIDS" };
			FILTERS = new LogEventSection() { Name = "FILTERS" };
			INGROUPS = new LogEventSection() { Name = "INGROUPS" };
			LEADS = new LogEventSection() { Name = "LEADS" };
			LISTS = new LogEventSection() { Name = "LISTS" };
			PHONES = new LogEventSection() { Name = "PHONES" };
			REMOTEAGENTS = new LogEventSection() { Name = "REMOTEAGENTS" };
			SCRIPTS = new LogEventSection() { Name = "SCRIPTS" };
			SERVERS = new LogEventSection() { Name = "SERVERS" };
			SERVERS_TRUNK = new LogEventSection() { Name = "SERVERS_TRUNK" };
			SERVERSTRUNKS = new LogEventSection() { Name = "SERVERSTRUNKS" };
			STATUSCATEGORIES = new LogEventSection() { Name = "STATUSCATEGORIES" };
			SYSTEMSETTINGS = new LogEventSection() { Name = "SYSTEMSETTINGS" };
			TIMECLOCK = new LogEventSection() { Name = "TIMECLOCK" };
			USERGROUPS = new LogEventSection() { Name = "USERGROUPS" };
			USERS = new LogEventSection() { Name = "USERS" };
		}
	}
}
