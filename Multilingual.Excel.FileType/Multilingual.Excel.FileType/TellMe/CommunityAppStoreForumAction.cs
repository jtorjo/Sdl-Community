﻿using System.Diagnostics;
using System.Drawing;
using Sdl.TellMe.ProviderApi;

namespace Multilingual.Excel.FileType.TellMe
{
	public class CommunityAppStoreForumAction : AbstractTellMeAction
	{
		public override bool IsAvailable => true;

		public override string Category => string.Format(PluginResources.TellMe_String_Results, PluginResources.Plugin_Name);

		public override Icon Icon => PluginResources.ForumIcon;

		public CommunityAppStoreForumAction()
		{
			Name = "RWS Community AppStore Forum";
		}

		public override void Execute()
		{
			Process.Start("https://community.rws.com/appsupport");
		}
	}
}
