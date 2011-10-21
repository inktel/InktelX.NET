using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InktelX.Engine
{
	/// <summary>
	/// This type supports the Call Distribution for Vicidial Outbound. These string values are hardcoded into vicidial.  This class, along with
	/// corresponding methods such as GetCallDistributionStrategies() are designed to wrap these values and make them programatically simple and
	/// consistent to use.
	/// </summary>
	partial class CallDistributionStrategy
	{
		public static readonly CallDistributionStrategy random;
		public static readonly CallDistributionStrategy oldest_call_start;
		public static readonly CallDistributionStrategy oldest_call_finish;
		public static readonly CallDistributionStrategy overall_user_level;
		public static readonly CallDistributionStrategy campaign_rank;
		public static readonly CallDistributionStrategy fewest_calls;
		public static readonly CallDistributionStrategy longest_wait_time;

		static CallDistributionStrategy()
		{
			random = new CallDistributionStrategy() { Name = "random", FriendlyName = "Random" };
			oldest_call_start = new CallDistributionStrategy() { Name = "oldest_call_start", FriendlyName = "Oldest Call Start" };
			oldest_call_finish = new CallDistributionStrategy() { Name = "oldest_call_finish", FriendlyName = "Oldest Call Finish" };
			overall_user_level = new CallDistributionStrategy() { Name = "overall_user_level", FriendlyName = "Overall User Level" };
			campaign_rank = new CallDistributionStrategy() { Name = "campaign_rank", FriendlyName = "Campaign Rank" };
			fewest_calls = new CallDistributionStrategy() { Name = "fewest_calls", FriendlyName = "Fewest Call Volume" };
			longest_wait_time = new CallDistributionStrategy() { Name = "longest_wait_time", FriendlyName = "Longest Wait Time" };
		}

		//implicit cast to assign where string value is expected
		public static implicit operator string(CallDistributionStrategy cds)
		{
			return cds.Name;
		}

		public static CallDistributionStrategy Parse(string value)
		{
			CallDistributionStrategy[] values = { random, oldest_call_start, oldest_call_finish, overall_user_level, campaign_rank, fewest_calls, longest_wait_time };

			return (from t in values
					where t.FriendlyName == value || t.Name == value
					select t).SingleOrDefault();
		}
	}



	/// <summary>
	/// This type supports the Dial method for Vicidial Outbound. These string values are hardcoded into vicidial.  This class, along with
	/// corresponding methods such as GetDialMethods() are designed to wrap these values and make them programmatically simple and
	/// consistent to use.
	/// </summary>
	partial class DialMethod
	{
		public static readonly DialMethod manual;
		public static readonly DialMethod ratio;
		public static readonly DialMethod adapt_hard_limit;
		public static readonly DialMethod adapt_tapered;
		public static readonly DialMethod adapt_average;
		public static readonly DialMethod inbound_man;

		static DialMethod()
		{
			manual = new DialMethod() { Name = "MANUAL", FriendlyName = "Manual" };
			ratio = new DialMethod() { Name = "RATIO", FriendlyName = "Ratio" };
			adapt_hard_limit = new DialMethod() { Name = "ADAPT_HARD_LIMIT", FriendlyName = "Adapt Hard Limit" };
			adapt_tapered = new DialMethod() { Name = "ADAPT_TAPERED", FriendlyName = "Adapt Tapered" };
			adapt_average = new DialMethod() { Name = "ADAPT_AVERAGE", FriendlyName = "Adapt Average" };
			inbound_man = new DialMethod() { Name = "INBOUND_MAN", FriendlyName = "Inbound Manual" };
		}

		//implicit cast to string for convenience
		public static implicit operator string(DialMethod dm)
		{
			return dm.Name;
		}
	}

	partial class vicidial_admin_log
	{
		public vicidial_admin_log()
		{
			event_date = DateTime.Now;
		}

	}

	partial class vicidial_users
	{
		public static string QueryStringParam { get { return "vcdu"; } }
		public vicidial_users()
		{
			//setup default vicidial values; cannot allow nulls since vicidial interface inserts blanks
			phone_login = "";
			phone_pass = "";
			delete_users = "0";
			delete_user_groups = "0";
			delete_lists = "0";
			delete_campaigns = "0";
			delete_ingroups = "0";
			delete_remote_agents = "0";
			load_leads = "0";
			campaign_detail = "0";
			ast_admin_access = "0";
			ast_delete_phones = "0";
			delete_scripts = "0";
			modify_leads = "0";
			hotkeys_active = "0";
			change_agent_campaign = "0";
			agent_choose_ingroups = "1";
			closer_campaigns = null;
			scheduled_callbacks = "1";
			agentonly_callbacks = "0";
			agentcall_manual = "0";
			vicidial_recording = "1";
			vicidial_transfers = "1";
			delete_filters = "0";
			alter_agent_interface_options = "0";
			closer_default_blended = "0";
			delete_call_times = "0";
			modify_call_times = "0";
			modify_users = "0";
			modify_campaigns = "0";
			modify_lists = "0";
			modify_scripts = "0";
			modify_filters = "0";
			modify_ingroups = "0";
			modify_usergroups = "0";
			modify_remoteagents = "0";
			modify_servers = "0";
			view_reports = "0";
			vicidial_recording_override = "DISABLED";
			alter_custdata_override = "NOT_ACTIVE";
			qc_enabled = "0";
			qc_user_level = 1;
			qc_pass = "0";
			qc_finish = "0";
			qc_commit = "0";
			add_timeclock_log = "0";
			modify_timeclock_log = "0";
			delete_timeclock_log = "0";
			alter_custphone_override = "NOT_ACTIVE";
			vdc_agent_api_access = "0";
			modify_inbound_dids = "0";
			delete_inbound_dids = "0";
			active = "Y";
			alert_enabled = "0";
			download_lists = "0";
			agent_shift_enforcement_override = "DISABLED";
			manager_shift_enforcement_override = "0";
			shift_override_flag = "0";
			export_reports = "0";
			delete_from_dnc = "0";
			email = "";
			user_code = "";
			territory = "";
			allow_alerts = "0";
			agent_choose_territories = "1";
			custom_one = "";
			custom_two = "";
			custom_three = "";
			custom_four = "";
			custom_five = "";

			//PHP specific logic here


		}


		public string FriendlyDisplayUserAndName
		{
			get { return String.Format("{0} - {1}", user, full_name); }
		}
	}

	partial class vicidial_campaign_stats
	{


	}


	partial class vicidial_campaigns
	{
		public static string QueryStringParam { get { return "vcdc"; } }



		public vicidial_campaigns()
		{
			//setup default vicidial values; cannot allow nulls since vicidial interface inserts blanks
			active = "Y";
			dial_status_a = "NEW";
			lead_order = "DOWN";
			park_ext = String.Empty;
			park_file_name = String.Empty;
			allow_closers = "N";
			hopper_level = 50;
			voicemail_ext = String.Empty;
			dial_timeout = 60;
			dial_prefix = "9";
			campaign_cid = "0000000000";
			campaign_vdad_exten = "8368";
			campaign_rec_exten = "8309";
			campaign_recording = "ONDEMAND";
			campaign_rec_filename = "FULLDATE_CUSTPHONE";
			campaign_script = String.Empty;
			get_call_launch = "NONE";
			am_message_exten = "vm-goodbye";
			amd_send_to_vmx = "N";
			alt_number_dialing = "N";
			scheduled_callbacks = "N";
			lead_filter_id = "NONE";
			drop_call_seconds = 5;
			drop_action = "MESSAGE";
			safe_harbor_exten = "8307";
			display_dialable_count = "Y";
			wrapup_seconds = 0;
			wrapup_message = "Wrapup Call";
			use_internal_dnc = "N";
			allcalls_delay = 0;
			omit_phone_code = "N";
			dial_method = "MANUAL";
			available_only_ratio_tally = "N";
			adaptive_dropped_percentage = "3";
			adaptive_maximum_level = "3.0";
			adaptive_latest_server_time = "2100";
			adaptive_intensity = "0";
			adaptive_dl_diff_target = 0;
			concurrent_transfers = "AUTO";
			auto_alt_dial = "NONE";
			auto_alt_dial_statuses = " B N NA DC -";
			agent_pause_codes_active = "Y";
			campaign_changedate = DateTime.Now;
			campaign_stats_refresh = "Y";
			dial_statuses = " NEW -";
			disable_alter_custdata = "N";
			no_hopper_leads_logins = "N";
			list_order_mix = "DISABLED";
			campaign_allow_inbound = "N";
			manual_dial_list_id = 998;
			default_xfer_group = "---NONE---";
			queue_priority = 50;
			drop_inbound_group = "---NONE---";
			qc_enabled = "N";
			qc_shift_id = "24HRMIDNIGHT";
			qc_get_record_launch = "NONE";
			qc_show_recording = "Y";
			survey_first_audio_file = "US_pol_survey_hello";
			survey_dtmf_digits = "1238";
			survey_ni_digit = "8";
			survey_opt_in_audio_file = "US_pol_survey_transfer";
			survey_ni_audio_file = "US_thanks_no_contact";
			survey_method = "AGENT_XFER";
			survey_no_response_action = "OPTIN";
			survey_ni_status = "NI";
			survey_response_digit_map = "1-DEMOCRAT|2-REPUBLICAN|3-INDEPENDANT|8-OPTOUT|X-NO RESPONSE|";
			survey_xfer_exten = "8300";
			survey_camp_record_dir = "/home/survey";
			disable_alter_custphone = "Y";
			display_queue_count = "Y";
			manual_dial_filter = "NONE";
			agent_clipboard_copy = "NONE";
			agent_extended_alt_dial = "N";
			use_campaign_dnc = "N";
			three_way_call_cid = "CAMPAIGN";
			three_way_dial_prefix = String.Empty;
			web_form_target = "vdcwebform";
			vtiger_search_category = "LEAD";
			vtiger_create_call_record = "Y";
			vtiger_create_lead_record = "Y";
			vtiger_screen_login = "Y";
			cpd_amd_action = "DISABLED";
			agent_allow_group_alias = "N";
			default_group_alias = String.Empty;
			vtiger_search_dead = "ASK";
			vtiger_status_call = "N";
			survey_third_digit = String.Empty;
			survey_third_audio_file = "US_thanks_no_contact";
			survey_third_status = "NI";
			survey_third_exten = "8300";
			survey_fourth_digit = String.Empty;
			survey_fourth_audio_file = "US_thanks_no_contact";
			survey_fourth_status = "NI";
			survey_fourth_exten = "8300";
			drop_lockout_time = "0";
			quick_transfer_button = "N";
			prepopulate_transfer_preset = "N";
			drop_rate_group = "DISABLED";
			view_calls_in_queue = "NONE";
			view_calls_in_queue_launch = "MANUAL";
			grab_calls_in_queue = "N";
			call_requeue_button = "N";
			pause_after_each_call = "N";
			no_hopper_dialing = "N";
			agent_dial_owner_only = "NONE";
			agent_display_dialable_leads = "N";
			web_form_address_two = String.Empty;
			waitforsilence_options = String.Empty;
			agent_select_territories = "N";
			crm_popup_login = "N";
			timer_action = "NONE";
			timer_action_message = String.Empty;
			timer_action_seconds = -1;
			start_call_url = String.Empty;
			dispo_call_url = string.Empty;
			xferconf_c_number = String.Empty;
			xferconf_d_number = String.Empty;
			xferconf_e_number = String.Empty;
		}

		public string FriendlyDisplayIDAndName
		{
			get { return String.Format("{0} - {1}", campaign_id, campaign_name); }
		}
	}


	partial class vicidial_call_times
	{
		public static vicidial_call_times _24hours = null;
		public static vicidial_call_times _9amTo9pm = null;
		public static vicidial_call_times _9amTo5pm = null;
		public static vicidial_call_times _12pm_5pm = null;
		public static vicidial_call_times _12pm_9pm = null;
		public static vicidial_call_times _5pm_9pm = null;

		static vicidial_call_times()
		{
			VicidialEntities _emv = new VicidialEntities(ConfigManager.ConnectionStrings.VicidialEntities);
			foreach (vicidial_call_times vct in _emv.vicidial_call_times)
			{
				switch (vct.call_time_id)
				{
					case "24hours":
						_24hours = vct;
						break;

					case "9am-9pm":
						_9amTo9pm = vct;
						break;

					case "9am-5pm":
						_9amTo5pm = vct;
						break;

					case "12pm-5pm":
						_12pm_5pm = vct;
						break;

					case "12pm-9pm":
						_12pm_9pm = vct;
						break;

					case "5pm-9pm":
						_5pm_9pm = vct;
						break;
				}
			}

		}
	}

	partial class vicidial_campaign_stats_debug
	{
		public vicidial_campaign_stats_debug()
		{
			server_ip = "0.0.0.0";	//TODO check this
			update_time = DateTime.Now;
		}


	}


	partial class vicidial_statuses
	{
		public static vicidial_statuses NewLead { get; private set; }
		public static vicidial_statuses LeadToBeCalled { get; private set; }
		public static vicidial_statuses LeadBeingCalled { get; private set; }
		public static vicidial_statuses AgentNotAvailable { get; private set; }
		public static vicidial_statuses AgentNotAvailableIn { get; private set; }
		public static vicidial_statuses NoAnswerAutoDial { get; private set; }
		public static vicidial_statuses CallBack { get; private set; }
		public static vicidial_statuses CallBackHold { get; private set; }
		public static vicidial_statuses AnswerMachine { get; private set; }
		public static vicidial_statuses AnswerMachineAuto { get; private set; }
		public static vicidial_statuses AnswerMachineSentToMesg { get; private set; }
		public static vicidial_statuses AnswerMachineMsgPlayed { get; private set; }
		public static vicidial_statuses FaxMachineAuto { get; private set; }
		public static vicidial_statuses Busy { get; private set; }
		public static vicidial_statuses DisconnectedNumber { get; private set; }
		public static vicidial_statuses DoNotCall { get; private set; }
		public static vicidial_statuses DoNotCallHopperMatch { get; private set; }
		public static vicidial_statuses SaleMade { get; private set; }
		public static vicidial_statuses SALE { get; private set; }
		public static vicidial_statuses NoAnswer { get; private set; }
		public static vicidial_statuses NotInterested { get; private set; }
		public static vicidial_statuses CallPickedUp { get; private set; }
		public static vicidial_statuses PlayedMessage { get; private set; }
		public static vicidial_statuses CallTransferred { get; private set; }
		public static vicidial_statuses AgentError { get; private set; }
		public static vicidial_statuses SurveySentToExtension { get; private set; }
		public static vicidial_statuses SurveySentToVoiceMail { get; private set; }
		public static vicidial_statuses SurveyHangUp { get; private set; }
		public static vicidial_statuses SurveySentToRecord { get; private set; }
		public static vicidial_statuses QueueAbandonVoicemailLeft { get; private set; }
		public static vicidial_statuses BusyAuto { get; private set; }
		public static vicidial_statuses DisconnectedNumberAuto { get; private set; }
		public static vicidial_statuses InboundQueueTimeoutDrop { get; private set; }
		public static vicidial_statuses InboundAfterHoursDrop { get; private set; }
		public static vicidial_statuses InboundNoAgentNoQueueDrop { get; private set; }

		static vicidial_statuses()
		{

			MainFacade mf = new MainFacade(ConfigManager.ConnectionStrings.VicidialEntities);
			foreach (vicidial_statuses status in mf.GetStatuses())
			{
				switch (status.status)
				{
					case "NEW":
						NewLead = status;
						break;

					case "QUEUE":
						LeadToBeCalled = status;
						break;

					case "INCALL":
						LeadBeingCalled = status;
						break;

					case "DROP":
						AgentNotAvailable = status;
						break;

					case "XDROP":
						AgentNotAvailableIn = status;
						break;

					case "NA":
						NoAnswerAutoDial = status;
						break;

					case "CALLBK":
						CallBack = status;
						break;

					case "CBHOLD":
						CallBackHold = status;
						break;

					case "A":
						AnswerMachine = status;
						break;

					case "AA":
						AnswerMachineAuto = status;
						break;

					case "AM":
						AnswerMachineSentToMesg = status;
						break;

					case "AL":
						AnswerMachineMsgPlayed = status;
						break;

					case "AFAX":
						FaxMachineAuto = status;
						break;

					case "B":
						Busy = status;
						break;

					case "DC":
						DisconnectedNumber = status;
						break;

					case "DNC":
						DoNotCall = status;
						break;

					case "DNCL":
						DoNotCallHopperMatch = status;
						break;

					case "SALE":
						SaleMade = status;
						break;

					case "N":
						NoAnswer = status;
						break;

					case "NI":
						NotInterested = status;
						break;

					case "PU":
						CallPickedUp = status;
						break;

					case "PM":
						PlayedMessage = status;
						break;

					case "XFER":
						CallTransferred = status;
						break;

					case "ERI":
						AgentError = status;
						break;

					case "SVYEXT":
						SurveySentToExtension = status;
						break;

					case "SVYVM":
						SurveySentToVoiceMail = status;
						break;

					case "SVYHU":
						SurveyHangUp = status;
						break;

					case "SVYREC":
						SurveySentToRecord = status;
						break;

					case "QVMAIL":
						QueueAbandonVoicemailLeft = status;
						break;

					case "AB":
						BusyAuto = status;
						break;

					case "ADC":
						DisconnectedNumberAuto = status;
						break;

					case "TIMEOT":
						InboundQueueTimeoutDrop = status;
						break;

					case "AFTHRS":
						InboundAfterHoursDrop = status;
						break;

					case "NANQUE":
						InboundNoAgentNoQueueDrop = status;
						break;



				}
			}
		}
	}
}
