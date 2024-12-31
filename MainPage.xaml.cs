using CommunityToolkit.Maui.Views;

namespace NavBar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Update the AppShell title dynamically
            //AppShell.Current.Title = "new title";
        }

        private void SettingsPopupPageClicked(object sender, EventArgs e)
        {
            this.ShowPopup(new SettingsPopupPage());
        }

        private void AboutPopupPageClicked(object sender, EventArgs e)
        {
            this.ShowPopup(new AboutPopupPage());
        }

        private void HelpPopupPageClicked(object sender, EventArgs e)
        {
            this.ShowPopup(new HelpPopupPage());
        }

        private void SolveAll_Clicked(object sender, EventArgs e)
        {
            
        }

        private void FormButton_CheckedChanged(object sender, EventArgs e)
        {

        }

    }

}
