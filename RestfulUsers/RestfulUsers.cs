using System;

using Xamarin.Forms;

namespace RestfulUsers
{
	public class App : Application
	{
		public App()
		{
			//// The root page of your application
			//var content = new ContentPage
			//{
			//	Title = "RestfulUsers",
			//	Content = new StackLayout
			//	{
			//		VerticalOptions = LayoutOptions.Center,
			//		Children = {
			//			new Label {
			//				HorizontalTextAlignment = TextAlignment.Center,
			//				Text = "Welcome to Xamarin Forms!"
			//			}
			//		}
			//	}
			//};

			//MainPage = new NavigationPage(content);

			// The root page of your application
			MainPage = new NavigationPage(new RestfulUsers.Register());
			//MainPage = new RestfulUsers.SimplestKeypadPage();
			//MainPage = new RestfulUsers.Clock();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

