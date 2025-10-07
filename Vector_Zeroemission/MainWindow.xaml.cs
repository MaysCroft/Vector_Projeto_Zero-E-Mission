using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using Vector_Zeroemission.ViewModel;

namespace Vector_Zeroemission;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : MetroWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Brioche_OnClick(object sender, RoutedEventArgs e)
    {
        Combustivel analise = new Combustivel();
        analise.Show();

        if (analise.IsLoaded)
        {
            Thread.Sleep(1000);
            analise.Close();
        }
    }
}