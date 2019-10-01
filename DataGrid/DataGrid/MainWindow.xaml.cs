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

namespace DataGrid
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Items[] result = new Items[45];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Dtgrid_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (new Items(i + 1, People.family_array[i],People.point_array[i]));
            }

            dtgrid.ItemsSource = result;
        }
    }
}
