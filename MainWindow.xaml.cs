using System.Windows;
using System.Windows.Controls;

namespace Paw_somePasswordProtector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Variables go here
        int attempts = 5;

        public MainWindow()
        {
            InitializeComponent();

            tbOutput.Text = string.Concat(attempts, " Attempts.");
        }
        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (tbxInput.Text == "Hoppo")
            {
                // disable grid1
                Grid1.IsEnabled = false;
                Grid1.Visibility = Visibility.Hidden;

                tb_Pass1.Text = "ILoveMyDog";
                tb_Pass2.Text = "TL_9anRi#$1p";
                tb_Pass3.Text = "Nl])1l*7jwkl";
                tb_Pass4.Text = "NALLkwdow(181";
                tb_Pass5.Text = "LAlf;l]1+001o";

                // enable grid2
                Grid2.IsEnabled = true;
                Grid2.Visibility = Visibility.Visible;
            }
            else
            {
                if (attempts == 1) { Close(); }
                attempts--;
                tbOutput.Text = string.Concat(attempts, " Attempts.");
                tbxInput.Text = "Try Again...";
            }

            
        }
    }
}
