using SumaAppMvvm.Views;

namespace SumaAppMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }
    }
}
