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

namespace WpfTasking
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
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            Pages.Task1 taskObj = new Pages.Task1();
            showPage1.Children.Add(taskObj);
        }
        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            Pages.Task2 taskObj = new Pages.Task2();
            showPage2.Children.Add(taskObj);
        }
        private void Task3Button_Click(object sender, RoutedEventArgs e)
        {
            Pages.Task3 taskObj = new Pages.Task3();
            showPage3.Children.Add(taskObj);
        }
        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

    }
}
