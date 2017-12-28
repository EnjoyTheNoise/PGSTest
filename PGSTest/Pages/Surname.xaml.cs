using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PGSTest.Pages
{
    /// <summary>
    /// Interaction logic for Surname.xaml
    /// </summary>
    public partial class Surname : Page
    {
        public Surname()
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
            NavigationService?.Navigate(new Adress());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Name());
        }

        private void SurnameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            NextBtn_Click(null, null);
        }

        private void SurnameTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            Keyboard.Focus(SurnameTextBox);
        }
    }
}
