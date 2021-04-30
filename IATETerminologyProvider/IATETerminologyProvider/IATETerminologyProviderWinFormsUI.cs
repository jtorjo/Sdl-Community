﻿using System;
using System.Windows.Forms;
using Sdl.Community.IATETerminologyProvider.Helpers;
using Sdl.Community.IATETerminologyProvider.Service;
using Sdl.Community.IATETerminologyProvider.View;
using Sdl.Community.IATETerminologyProvider.ViewModel;
using Sdl.Terminology.TerminologyProvider.Core;

namespace Sdl.Community.IATETerminologyProvider
{
	[TerminologyProviderWinFormsUI]
	public class IATETerminologyProviderWinFormsUI : ITerminologyProviderWinFormsUI
	{
		private SettingsViewModel _settingsViewModel;
		private SettingsWindow _settingsWindow;
		public string TypeName => PluginResources.IATETerminologyProviderName;
		public string TypeDescription => PluginResources.IATETerminologyProviderDescription;
		public bool SupportsEditing => true;

		public ITerminologyProvider[] Browse(IWin32Window owner, ITerminologyProviderCredentialStore credentialStore)
		{
			var messageBoxService = new MessageBoxService();

			if (IATEApplication.ConnectionProvider.HttpClient != null)
			{
				_settingsViewModel = new SettingsViewModel(null, IATEApplication.InventoriesProvider, messageBoxService);
				_settingsWindow = new SettingsWindow { DataContext = _settingsViewModel };

				_settingsWindow.ShowDialog();
				if (!_settingsViewModel.DialogResult)
				{
					return null;
				}

				var settings = _settingsViewModel.ProviderSettings;
				var provider = new IATETerminologyProvider(settings, IATEApplication.ConnectionProvider, IATEApplication.InventoriesProvider);

				return new ITerminologyProvider[] { provider };
			}

			throw new Exception("Failed login!");
		}

		public bool Edit(IWin32Window owner, ITerminologyProvider terminologyProvider)
		{
			var provider = terminologyProvider as IATETerminologyProvider;
			if (provider == null)
			{
				return false;
			}

			var messageBoxService = new MessageBoxService();

			_settingsViewModel = new SettingsViewModel(provider.ProviderSettings, provider.InventoriesService, messageBoxService);
			_settingsWindow = new SettingsWindow
			{
				DataContext = _settingsViewModel
			};

			_settingsWindow.ShowDialog();
			if (!_settingsViewModel.DialogResult)
			{
				return false;
			}

			provider.UpdateSettings(_settingsViewModel.ProviderSettings);

			return true;
		}

		public TerminologyProviderDisplayInfo GetDisplayInfo(Uri terminologyProviderUri)
		{
			return new TerminologyProviderDisplayInfo
			{
				Name = Constants.IATEProviderName,
				TooltipText = Constants.IATEProviderDescription
			};
		}

		public bool SupportsTerminologyProviderUri(Uri terminologyProviderUri)
		{
			return terminologyProviderUri.Scheme == Constants.IATEGlossary;
		}
	}
}