using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using InktelX.Engine;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			MainFacade mf = new MainFacade(ConfigManager.ConnectionStrings.VicidialEntities);


			//add another user by cloning an existing user with auto generated username & password
			//====================================================================================
			vicidial_users existingUser = mf.GetUsers().First();
			mf.AddUserByCloning(existingUser, "John", "Doe");


			//add user from scratch
			//=====================

			//get a reference to the QA group he will participate in
			vicidial_user_groups QAGroup = mf.GetUserGroup("QA"); //the user group name


			//add the user with user level 5 with automatic username and password
			mf.AddUser("John", "Doe", 5, QAGroup);


			//add the user with user level 5 with automatic username & explicit password
			mf.AddUser("password1", "John", "Doe", 5, QAGroup);

			//add the user with user level 5 with automatic explicit username & password
			mf.AddUser("usernameA", "passwordB", "John", "Doe", 5, QAGroup);

		}

		public void AddAndUpdateLeadRecycleSample()
		{
			MainFacade mf = new MainFacade(ConfigManager.ConnectionStrings.VicidialEntities);

			//get the campaign instance
			vicidial_campaigns walmartCampaign = mf.GetCampaign("Wal-Mart");


			//ADD LEAD RECYCLE SAMPLE USING SYSTEM STATUS
			//===========================================
			//this is adding a leady recycle rule of 1 day for SYSTEM NO ANSWER status, up to 10 times for no answer
			mf.AddLeadRecycle(walmartCampaign, vicidial_statuses.NoAnswer, TimeSpan.FromDays(1), 10);


			//ADD FOR A CUSTOM STATUS
			mf.AddLeadRecycle(walmartCampaign, "WM_RETURN", TimeSpan.FromHours(1), 5);


			//UPDATE SAMPLE
			//=============
			//there are various overload combinations with instance types and primitive to make it easy to reach, here
			//we'll use the campaign ID as string and status instance to update a system status recycle rule
			vicidial_lead_recycle rule = mf.GetLeadRecycle(walmartCampaign.campaign_id, vicidial_statuses.NoAnswer);
			rule.attempt_maximum = 10;
			mf.UpdateLeadRecycle(rule);


			//UPDATE FOR CUSTOM STATUS using the campaign instance and the known status name
			rule = mf.GetLeadRecycle(walmartCampaign, "WM_RETURN");
			rule.attempt_maximum = 10;


		}
	}
}

