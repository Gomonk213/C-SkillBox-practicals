using _10Practical;
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


namespace _10PracticalWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            List<User> users = new List<User>(30);
            for(int i = 0; i < 30; i++)
            {
                users.Add(new User());
            }
            List.ItemsSource = users;
            
            User.ItemsSource = new List<string>()
            {
                "Менеджер",
                "Консультант"
            };
            
                
            
        }

        private void ChangeName(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeSurname(object sender, RoutedEventArgs e)
        {

        }

        private void ChangePhone(object sender, RoutedEventArgs e)
        {

        }

        private void ChangePassport(object sender, RoutedEventArgs e)
        {

        }

        private void User_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (User.SelectedItem.ToString() == "Менеджер")
            {
                passport.DisplayMemberBinding = new Binding("Passport");
                List.Items.Refresh();
            }
            if (User.SelectedItem.ToString() == "Консультант" || User.SelectedItem == null)
            {
                passport.DisplayMemberBinding = new Binding("ForAssistant");
                List.Items.Refresh();
            }
        }
    }
}
