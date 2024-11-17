using TMS.Maui.Pages;

namespace TMS.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRotes();
        }

        private readonly static Type[] _routablePageTypes =
            [
                 typeof(SignUpPage),
                 typeof(SigInPage)
            ];

       private static void RegisterRotes()
       { 
            foreach(var pageType in _routablePageTypes)
            {
                Routing.RegisterRoute(pageType.Name,pageType);
            }
       }

        private async void logout_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.DisplayAlert("Alert", "Signout menu has been clicked", "Ok");
        }
    }
}
