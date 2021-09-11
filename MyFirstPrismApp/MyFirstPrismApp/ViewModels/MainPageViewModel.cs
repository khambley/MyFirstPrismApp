using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstPrismApp.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		public DelegateCommand NavigateToSpeakPageCommand { get; }
		public DelegateCommand NavigateToVideoPlayerCommand { get; }

		public MainPageViewModel(INavigationService navigationService)
			: base(navigationService)
		{
			Title = "My Text to Speech App";
			NavigateToSpeakPageCommand = new DelegateCommand(NavigateToSpeakPage);
			NavigateToVideoPlayerCommand = new DelegateCommand(NavigateToVideoPlayer);
		}

		private void NavigateToSpeakPage()
		{
			NavigationService.NavigateAsync("SpeakPage");
		}
		private void NavigateToVideoPlayer()
		{
			NavigationService.NavigateAsync("VideoPlayer");
		}
	}
}
