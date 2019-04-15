﻿using XFStarterKit.Core.Models;
using XFStarterKit.Core.ViewModels;
using Xamarin.Forms;

namespace XFStarterKit.Core.Views
{
    public partial class SettingsView : ContentPage
	{
		public SettingsView()
		{
			InitializeComponent ();

            MessagingCenter.Subscribe<SettingsViewModel<RemoteSettings>>(this, MessengerKeys.LoadSettingsRequested, OnLoadSettingsRequested);
        }

        void OnLoadSettingsRequested(SettingsViewModel<RemoteSettings> settingsViewModel)
        {
            if(!settingsViewModel.IsValid)
            {
                VisualStateManager.GoToState(RemoteJsonEntry, "Invalid");
            }
        }
	}
}