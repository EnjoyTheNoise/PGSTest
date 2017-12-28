using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PGSTest.Pages
{
    /// <summary>
    /// Interaction logic for Adress.xaml
    /// </summary>
    public partial class Adress : Page
    {
        public Adress()
        {
            InitializeComponent();
            DataContext = MainWindow.PersonalInfo;
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new PhoneNumber());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Surname());
        }

        private void AdressTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            NextBtn_Click(null, null);
        }

        private void AdressTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            Keyboard.Focus(AdressTextBox);
        }
    }
}
