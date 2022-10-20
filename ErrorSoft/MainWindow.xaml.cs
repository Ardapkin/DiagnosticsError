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

namespace DiagnosticsError {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            TextBox1.Text = ("Введите текст");
           



            var l = new List<string>();
            l.Add("1");
            l.Add("2");
            l.Add("3");

            ComboBox1.ItemsSource = l;
            ComboBox1.SelectedIndex = 0;
        
        


        }

        

        private void Button_Click(object sender, RoutedEventArgs e) {
            label1.Content = TextBox1.Text;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {

        }
        private void ComboBox1_Selected(object sender, RoutedEventArgs e) {

        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            
                label2.Content = ComboBox1.SelectedItem;
            
        }
    }
}
