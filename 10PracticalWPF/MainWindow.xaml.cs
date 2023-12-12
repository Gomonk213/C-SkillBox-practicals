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
        List<User> users = new List<User>();
        public MainWindow()
        {
            InitializeComponent();
            
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
            if(List.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя в списке выше");
            }
            if(NewInfo.Text == "Данные для изменения" || String.IsNullOrEmpty(NewInfo.Text) || String.IsNullOrWhiteSpace(NewInfo.Text))
            {
                MessageBox.Show("Заполните поле изменений");
            }
            else
            {
                User user = users[List.SelectedIndex];
                users[List.SelectedIndex] = new User(NewInfo.Text, user.Surname, user.PhoneNumber, user.Passport)
                {
                    Edited = "Name",
                    EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                    Editor = "Manager",
                    TypeOfEditing = "Editing"
                };
                List.Items.Refresh();
            }
        }

        private void ChangeSurname(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя в списке выше");
            }
            else if (NewInfo.Text == "Данные для изменения" || String.IsNullOrEmpty(NewInfo.Text) || String.IsNullOrWhiteSpace(NewInfo.Text))
            {
                MessageBox.Show("Заполните поле изменений");
            }
            else
            {
                User user = users[List.SelectedIndex];
                users[List.SelectedIndex] = new User(user.Name, NewInfo.Text, user.PhoneNumber, user.Passport)
                {
                    Edited = "Surname",
                    EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                    Editor = "Manager",
                    TypeOfEditing = "Editing"
                };
                List.Items.Refresh();
            }
        }

        private void ChangePhone(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя в списке выше");
            }
            else if (NewInfo.Text == "Данные для изменения" || String.IsNullOrEmpty(NewInfo.Text) || String.IsNullOrWhiteSpace(NewInfo.Text))
            {
                MessageBox.Show("Заполните поле изменений");
            }
            else
            {
                User user = users[List.SelectedIndex];
                users[List.SelectedIndex] = new User(user.Name, user.Surname, NewInfo.Text, user.Passport)
                {
                    Edited = "Phone",
                    EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                    Editor = "Manager",
                    TypeOfEditing = "Editing"
                };
                List.Items.Refresh();
            }
        }
        private void AssistantChangePhone(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя в списке выше");
            }
            else if (AssistantData.Text == "Введите изменяемые данные" || String.IsNullOrEmpty(AssistantData.Text) || String.IsNullOrWhiteSpace(AssistantData.Text))
            {
                MessageBox.Show("Заполните поле изменений");
            }
            else
            {
                User user = users[List.SelectedIndex];
                users[List.SelectedIndex] = new User(user.Name, user.Surname, AssistantData.Text, user.Passport)
                {
                    Edited = "Phone",
                    EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                    Editor = "Assistant",
                    TypeOfEditing = "Editing"
                };
                List.Items.Refresh();
            }
        }
        private void ChangePassport(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя в списке выше");
            }
            else if (NewInfo.Text == "Данные для изменения" || String.IsNullOrEmpty(NewInfo.Text) || String.IsNullOrWhiteSpace(NewInfo.Text) )
            {
                MessageBox.Show("Заполните поле изменений");
            }
            else
            {
                User user = users[List.SelectedIndex];
                users[List.SelectedIndex] = new User(user.Name, user.Surname, user.PhoneNumber, NewInfo.Text)
                {
                    Edited = "Passport",
                    EditTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm"),
                    Editor = "Manager",
                    TypeOfEditing = "Editing"
                };
                List.Items.Refresh();
            }
        }

        private void User_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List.Visibility= Visibility.Visible;
            if (User.SelectedItem.ToString() == "Менеджер")
            {
                Assistant.Visibility = Visibility.Hidden;
                Manager.Visibility = Visibility.Visible;
                passport.DisplayMemberBinding = new Binding("Passport");
                List.Items.Refresh();
            }
            if (User.SelectedItem.ToString() == "Консультант")
            {
                Manager.Visibility = Visibility.Hidden;
                Assistant.Visibility = Visibility.Visible;
                passport.DisplayMemberBinding = new Binding("ForAssistant");
                List.Items.Refresh();
            }

        }
        private void AddNewRecord(object sender, RoutedEventArgs e)
        {
            
            if(String.IsNullOrEmpty(NewName.Text) 
               || String.IsNullOrEmpty(NewSurname.Text) 
               || String.IsNullOrEmpty(NewPhoneNumber.Text) 
               || String.IsNullOrEmpty(NewPassport.Text) 
               || String.IsNullOrWhiteSpace(NewName.Text)
               || String.IsNullOrWhiteSpace(NewSurname.Text)
               || String.IsNullOrWhiteSpace(NewPhoneNumber.Text)
               || String.IsNullOrWhiteSpace(NewPassport.Text)
               || NewName.Text=="Введите имя" 
               || NewSurname.Text=="Введите фамилию" 
               || NewPhoneNumber.Text=="Введите номер телефона" 
               || NewPassport.Text=="Введите серию и номер паспорта" )
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                User u = new User(NewName.Text, NewSurname.Text, NewPhoneNumber.Text, NewPassport.Text)
                {
                    Editor = "Manager"
                };
                users.Add(u);
                List.Items.Refresh();
            }
        }
        
    }
}
