using System.Data;
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

namespace cw_18_09_2024
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(textbox1.Text == "bye")
            {
                Close();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string d1 = DateTime.Now.ToString("dd - MM - yyy");
            string g1 = DateTime.Now.ToString("HH - mm - ss");
            MessageBox.Show(d1);
            MessageBox.Show(g1);
        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            int a = int.Parse(textbox2.Text);
            int b = int.Parse(textbox3.Text);
            int NWD(int a, int b)
            {
                while (a != b)
                {
                    if (a > b) a -= b;
                    else b = -a;
                }
                return a;
            }
            MessageBox.Show("NWD: " + NWD(a, b));
        }
    }
}
