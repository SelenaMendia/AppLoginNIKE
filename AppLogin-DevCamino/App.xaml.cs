using AppLogin_DevCamino.Views;

namespace AppLogin_DevCamino
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();
        }
    }
}
