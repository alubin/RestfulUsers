using System;

using Xamarin.Forms;

namespace RestfulUsers
{
	public class Login : ContentPage
	{
		public Login()
		{
			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


