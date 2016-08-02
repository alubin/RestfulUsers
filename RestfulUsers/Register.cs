using System;

using Xamarin.Forms;

namespace RestfulUsers
{
	public class Register : ContentPage
	{
		public Register()
		{

			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			Label name = new Label
			{
				Text = "Enter Name:",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Start
			};

			Entry inputName = new Entry
			{
				Placeholder = "Enter Name"
			};

			Label userName = new Label
			{
				Text = "Enter User Name:",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Start
			};

			Entry inputUserName = new Entry
			{
				Placeholder = "Enter User Name"
			};

			Label password = new Label
			{
				Text = "Enter Password:",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Start
			};

			Entry inputPassword = new Entry
			{
				Placeholder = "Enter Passsword"
			};

			Button submitBtn = new Button
			{
				Text = "Submit",
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
				HorizontalOptions = LayoutOptions.End
			};

			Button loginBtn = new Button
			{
				Text = "Login",
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
				HorizontalOptions = LayoutOptions.End
			};
			loginBtn.Clicked += onLoginPage;

			Content = new StackLayout
			{
				Children = {
					name,
					inputName,
					userName,
					inputUserName,
					password,
					inputPassword,
					submitBtn,
					loginBtn
				}
			};
		}

		void onLoginPage(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Login());
			//Navigation.PushModalAsync(new Login());
		}


	}
}


