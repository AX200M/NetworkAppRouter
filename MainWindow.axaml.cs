using Avalonia.Controls;
using Avalonia.Interactivity;

namespace NetworkAppRouter;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void BeginButton(object sender, RoutedEventArgs args)
    {
        var window = new BeginPage();
        window.Show();
        this.Hide();
    }
}