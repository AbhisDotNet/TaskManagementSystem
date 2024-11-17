namespace TMS.Maui.Pages;

public partial class OnBoardingPage : ContentPage
{
	public OnBoardingPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync($"//{nameof(DetailsPage)}");
    }

    private async void signup_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SignUpPage));
    }

    private async void signin_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SigInPage));
    }
}