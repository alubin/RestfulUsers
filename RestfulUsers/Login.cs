using System;

using Xamarin.Forms;

namespace RestfulUsers
{
	/**
	 * This view class is responsible for displaying the GUI elements for the Login Portions of the mobile application. 
	 **/
	public class Login : ContentPage
	{
		public Login()
		{
			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			Label title = new Label
			{
				Text = "Login",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
			Label email = new Label
			{
				Text = "Enter Email:",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Start
			};

			Entry inputEmail = new Entry
			{
				Placeholder = "Enter Email"
			};

			Label password = new Label
			{
				Text = "Enter Password:",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Start
			};

			Entry inputPassword = new Entry
			{
				Placeholder = "Enter Password"
			};

			Button submitBtn = new Button
			{
				Text = "Submit",
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
				HorizontalOptions = LayoutOptions.End
			};

			submitBtn.Clicked += onRegisterSubmit;

			Button registerBtn = new Button
			{
				Text = "Register",
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
				HorizontalOptions = LayoutOptions.End,
			};
			registerBtn.Clicked += onRegisterPage;

			Content = new StackLayout
			{
				Children = {
					title,
					email,
					inputEmail,
					password,
					inputPassword,
					submitBtn,
					registerBtn
				}
			};
		}

		void onRegisterPage(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Register());
			//Navigation.PushModalAsync(new Login());
		}

		void onRegisterSubmit(object sender, EventArgs e)
		{
		}
	}
}


