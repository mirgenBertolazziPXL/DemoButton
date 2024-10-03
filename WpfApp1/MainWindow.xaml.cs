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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WachtwoordTextBox.PasswordChar = '*';
        }
       
        private void InlogButton_Click(object sender, RoutedEventArgs e)
        {
            if(GebruikersnaamTextbox.Text == "admin" && WachtwoordTextBox.Password == "admin")
            {
                TextTextbox.Text = "U wordt ingelogd";
            }
        }

        private async void UitlogButton_Click(object sender, RoutedEventArgs e)
        {
            TextTextbox.Text = "U wordt uitgelogd";
            await Task.Delay(1000);
            TextTextbox.Text = "";
        }
    }
}