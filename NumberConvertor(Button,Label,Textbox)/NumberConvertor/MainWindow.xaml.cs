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

namespace NumberConvertor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<string> result_list = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Result_button_Click(object sender, RoutedEventArgs e)
        {
            
            if(number_textbox.Text != "")
            {
                int number = Convert.ToInt32(number_textbox.Text);
                for (var i = 1; i < 15; i++)
                {
                    OtherNumber num = new OtherNumber(number,i+1);
                    result_list.Add($"Число в {i+1}-системе: {num.GetValueOfNumber()}");                    
                } 
            }

            number_listbox.ItemsSource = result_list;
        }
    }
}
