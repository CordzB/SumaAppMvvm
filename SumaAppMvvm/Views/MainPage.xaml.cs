using SumaAppMvvm.ViewModels;

namespace SumaAppMvvm.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
            BindingContext = new MainViewModel();
        }
    }
}
