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

namespace ListBoxWpf
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

        private void AddElement_button_Click(object sender, RoutedEventArgs e)
        {
            string element = element_textbox.Text;
            element_textbox.Clear();
            if (element != "")
            {
                my_listbox.Items.Add(element);
            }          
        }

        private void RemoveElement_button_Click(object sender, RoutedEventArgs e)
        {
            int index = my_listbox.SelectedIndex;
            if (index > -1)
            {
                my_listbox.Items.RemoveAt(index);
            }           
        }
    }
}
