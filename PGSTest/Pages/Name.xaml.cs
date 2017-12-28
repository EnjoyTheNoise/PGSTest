using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PGSTest.Pages
{
    /// <summary>
    /// Interaction logic for Name.xaml
    /// </summary>
    public partial class Name : Page
    { 
        public Name()
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
            MainWindow.PersonalInfo.UserName = NameTextBox.Text;
            NavigationService?.Navigate(new Surname());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Intro());
        }

        private void NameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            NextBtn_Click(null, null);
        }

        private void NameTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            Keyboard.Focus(NameTextBox);
        }
    }
}
