using CommunityToolkit.Maui.Views;

namespace NavBar;

public partial class SettingsPopupPage : Popup
{
    public SettingsPopupPage()
    {
        InitializeComponent();

    }

    private void CloseSettingsPopupPage_Clicked(object sender, EventArgs e)
    {
        Close();
    }
}