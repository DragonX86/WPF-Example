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

namespace ExpanderAndCheckBox
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int tech = 0;
        int lang = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Result_button_Click(object sender, RoutedEventArgs e)
        {
            string result = $"Tech: {tech} Lang: {lang}";
            MessageBox.Show(result);
        }

        private void Group1_checkbox_Checked(object sender, RoutedEventArgs e)
        {
            tech += 1;
        }

        private void Group1_checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            tech -= 1;
        }

        private void Group2_checkbox_Checked(object sender, RoutedEventArgs e)
        {
            lang += 1;
        }

        private void Group2_checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            lang -= 1;
        }
    }
}
