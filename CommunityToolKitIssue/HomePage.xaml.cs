using CommunityToolkit.Maui.Views;

namespace CommunityToolKitIssue;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await this.ShowPopupAsync(new MyPopupPage());
    }
}