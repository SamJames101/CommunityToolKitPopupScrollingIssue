using CommunityToolkit.Maui.Views;

namespace CommunityToolKitIssue;

public partial class MyPopupPage : Popup
{
	public MyPopupPage()
	{
		InitializeComponent();
		this.BindingContext = new MyPopupPageViewModel();
	}
}