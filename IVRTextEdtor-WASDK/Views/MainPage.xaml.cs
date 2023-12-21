using IVRTextEdtor_WASDK.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace IVRTextEdtor_WASDK.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
