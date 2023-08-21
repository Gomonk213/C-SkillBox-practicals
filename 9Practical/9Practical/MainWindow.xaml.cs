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

namespace _9Practical
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private string ReverseText(string text)
        {
            string Result = "";
            string[] words = text.Split(' ');
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Result += words[i] + " ";
            }
            return Result;
        }
        private void SplitOnWords(object sender, RoutedEventArgs e)
        {
            Result1.ItemsSource = (FirstTaskString.Text as string).Split(' ');
        }
        private void ReverseSentence(object sender, RoutedEventArgs e)
        {
            Result2.Content=ReverseText(SecondTaskString.Text);
        }
    }
}
