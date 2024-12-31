using CommunityToolkit.Maui.Views;

namespace NavBar;

public partial class HelpPopupPage : Popup
{
    public HelpPopupPage()
    {
        InitializeComponent();

    }

    private void CloseHelpPopupPage_Clicked(object sender, EventArgs e)
    {
        Close();
    }
}