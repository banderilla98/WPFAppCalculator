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

namespace WpfAppCalculator
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

        string CalTotal;
        int num1;
        int num2;
        string options;
        int result;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_Click1(object sender, RoutedEventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void btn_Click2(object sender, RoutedEventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void btn_Click3(object sender, RoutedEventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";

        }

        private void btn_Click4(object sender, RoutedEventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";

        }

        private void btn_Click5(object sender, RoutedEventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";

        }

        private void btn_Click6(object sender, RoutedEventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";

        }

        private void btn_Click7(object sender, RoutedEventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";

        }

        private void btn_Click8(object sender, RoutedEventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";

        }

        private void btn_Click9(object sender, RoutedEventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";

        }

        private void btn_Click0(object sender, RoutedEventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";

        }

        private void btn_ClickPlus(object sender, RoutedEventArgs e)
        {
            options = "+";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btn_ClickMinus(object sender, RoutedEventArgs e)
        {
            options = "-";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btn_ClickMultiplication(object sender, RoutedEventArgs e)
        {
            options = "*";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btn_ClickDiv(object sender, RoutedEventArgs e)
        {
            options = "/";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btn_ClickClear(object sender, RoutedEventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void btn_ClickEqual(object sender, RoutedEventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);
            if (options.Equals("+"))
                result = num1 + num2;
            if (options.Equals("-"))
                result = num1 - num2;
            if (options.Equals("*"))
                result = num1 * num2;
            if (options.Equals("/"))
                result = num1 / num2;
            txtTotal.Text = result + "";
        }
    }
}