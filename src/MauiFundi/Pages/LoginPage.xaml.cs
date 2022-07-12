namespace MauiFundi.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void CreateAccount_Tapped(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new SignUpPage());
	}

	private async void BackButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopToRootAsync();
	}
}