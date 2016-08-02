using System;

using Xamarin.Forms;

namespace RestfulUsers
{
	public class Clock : ContentPage
	{
		public Clock()
		{
			//Content = new StackLayout
			//{
			//	VerticalOptions = LayoutOptions.Center,
			//	Children = {
			//			new Label {
			//				HorizontalTextAlignment = TextAlignment.Center,
			//				Text = "Welcome to Xamarin Forms!"
			//			}
			//		}
			//};

			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			Label clockLabel = new Label { 
				HorizontalOptions = LayoutOptions.Center, 
				VerticalOptions = LayoutOptions.Start 
			};

			Content = clockLabel; 
			// Handle the SizeChanged event for the page. 
			SizeChanged += (object sender, EventArgs args) => { 
				// Scale the font size to the page width 
				// (based on 11 characters in the displayed string). 
				if (this.Width > 0) clockLabel.FontSize = this.Width / 6; }; 
			// Start the timer going. 
			Device.StartTimer(TimeSpan.FromSeconds(1), () => { 
				// Set the Text property of the Label. 
				clockLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
				return true;
			});
		}
	}
}


