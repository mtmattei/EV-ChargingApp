using Microsoft.UI.Xaml.Controls;
using ChargingPort.Models; 

namespace ChargingPort;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel { get; } = new MainViewModel();

    public MainPage()
    {
        this.InitializeComponent();
        this.DataContext = ViewModel; 
    }
}
