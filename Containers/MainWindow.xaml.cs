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

namespace Containers
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

        private void Cell_MouseEnter(object sender, MouseEventArgs e)
        {
            Border cell = sender as Border;
            if (cell != null)
            {
                cell.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Cell_MouseLeave(object sender, MouseEventArgs e)
        {
            Border cell = sender as Border;
            if (cell != null)
            {
                int row = Grid.GetRow(cell);
                int column = Grid.GetColumn(cell);

                if ((row + column) % 2 == 0)
                {
                    cell.Background = new SolidColorBrush(Colors.White);
                }
                else
                {
                    cell.Background = new SolidColorBrush(Colors.Black);
                }
            }
        }
    }
}