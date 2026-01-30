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
            if (tbxInput.Text == "SecretPassword")
            {
                // disable grid1
                Grid1.IsEnabled = false;
                Grid1.Visibility = Visibility.Hidden;

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
