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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, RoutedEventArgs e)
        {
            // Wijzig de achtergrondkleur van de label
            lblMessage.Background = new SolidColorBrush(Colors.Yellow);
        }

        // Event handler voor het wijzigen van de tekst
        private void btnChangeText_Click(object sender, RoutedEventArgs e)
        {
            // Wijzig de tekst van de label op basis van de tekst in de TextBox
            lblMessage.Content = txtInput.Text;
        }

        // Event handler voor TextBox tekstverandering
        private void txtInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            // Hier kan je extra functionaliteit toevoegen als je dat wilt
        }
    }
}