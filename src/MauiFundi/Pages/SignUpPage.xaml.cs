namespace MauiFundi.Pages;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}
    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    private async void Login_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}