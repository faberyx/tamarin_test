using System;

using Xamarin.Forms;

namespace Test
{
	public class MainPage : ContentPage
	{
		public MainPage()
		{

			var testButton = new Button
			{
				Text = "Test",
				TextColor = Color.White,
				Margin = new Thickness(20),
				BackgroundColor = Color.FromHex("550088")
			};

			testButton.Clicked += (sender, e) =>
			{
				var webserver = new RestCall();

				var response = webserver.Request(Constants.REST_CALL_TEST);

				if (response == "OK")
					DisplayAlert("Ok", "Webserver ok", "OK");
				else
					DisplayAlert("Errore", "Errore Webserver", "OK");

			};

			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						HorizontalTextAlignment = TextAlignment.Center,
						Text = "Hello Test"
					},
					testButton
				}
			};
		}
	}
}

