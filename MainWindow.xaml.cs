using PasswordChecker.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Windows.UI.Xaml.Controls;

namespace PasswordChecker
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
        public PasswordRevealMode PasswordRevealMode { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PassChecker check = new PassChecker(password.Password);
                
                Result.Text = check.CheckPassword().Trim().Replace(Environment.NewLine, "");
            if (check.isStrong)
            {
                Result.Foreground = Brushes.Green;
            }
            else
                Result.Foreground = Brushes.Red;
            


        }

        private void CheckBox_Changed(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
