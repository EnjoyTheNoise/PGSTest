using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PGSTest.Pages
{
    /// <summary>
    /// Interaction logic for PhoneNumber.xaml
    /// </summary>
    public partial class PhoneNumber : Page
    {
        public PhoneNumber()
        {
            InitializeComponent();
            DataContext = MainWindow.PersonalInfo;
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void FinishBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IsAnyPropEmpty() && string.IsNullOrEmpty(NumberTextBox.Text))
            {
                MessageBox.Show("Nie podano wszystkich danych!");
                return;
            }
            if (!IsNumberValid())
            {
                MessageBox.Show("Podany numer jest niewłaściwy:\n" + NumberTextBox.Text);
                NumberTextBox.Text = "";
                Keyboard.Focus(NumberTextBox);
                return;
            }
            NavigationService?.Navigate(new Results());
        }

        private bool IsNumberValid()
        {
            return Regex.IsMatch(NumberTextBox.Text, NumberTextBox.Text.StartsWith("+") ? @"^[+]\d{11}$" : @"^\d{9}$");
        }

        private static bool IsAnyPropEmpty()
        {
            return MainWindow.PersonalInfo.GetType().GetProperties()
                .Any(x => string.IsNullOrEmpty(x.GetValue(MainWindow.PersonalInfo) as string));
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Adress());
        }

        private void NumberTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            FinishBtn_Click(null, null);
        }

        private void NumberTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            Keyboard.Focus(NumberTextBox);
        }
    }
}
