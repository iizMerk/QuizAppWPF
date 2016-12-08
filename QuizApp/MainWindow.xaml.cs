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
namespace QuizApp
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        public void Login(string Username, string Password)
        {
            using (var db = new Database())
            {
                var query = from p in db.Users
                            where p.Username == Username && p.Password == Password
                            select p;
                if (query.Any())
                {
                    var user = query.SingleOrDefault();
                    if (user.UserRole == UserRole.Admin)
                    {
                        var AdminWindows = new AdminWindow(); 
                        this.Hide();
                        AdminWindows.Show();
                    }
                    else
                    {
                        var QuizWindows = new QuizWindow();
                        this.Hide();
                        QuizWindows.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Your Password or Username Are incorrect");
                    Username = "";
                    Password = "";
                }
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = Width * 2;
            Application.Current.MainWindow.Height = Height * 2;
            
        }
    }
}
