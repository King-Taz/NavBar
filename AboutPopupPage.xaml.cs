using CommunityToolkit.Maui.Views;

namespace NavBar;

public partial class AboutPopupPage : Popup
{
    public AboutPopupPage()
    {
        InitializeComponent();

    }

    private void CloseAboutPopupPage_Clicked(object sender, EventArgs e)
    {
        Close();
    }
}