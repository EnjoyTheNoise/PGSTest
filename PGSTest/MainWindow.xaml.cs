using System.Windows;
using PGSTest.Pages;
using PGSTest.ViewModels;

namespace PGSTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static PersonalInfo PersonalInfo = new PersonalInfo();
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new Intro();
        }
    }
}
