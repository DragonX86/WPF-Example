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

namespace Bk_tree
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string input = "";
        Tree tree = new Tree();

        string[] array = {"abstract","as","base","bool", "break", "byte","case","catch",
                "char","checked","class","continue","decimal","default","delegate","do",
                "double","else","enum","event","explicit","extern","false","finally","fixed","float",
                "for","foreach","goto","if","implicit","in","int","interface","internal","is",
                "lock","long","namespace","new","null","object","operator","out","override","params",
                "private","protected","public","readonly","ref","return","sbyte","sealed","short",
                "sizeof","stackalloc","static","string","struct","switch","this","throw","true",
                "try","typeof","uint","ulong","unchecked","unsafe","ushort","using","virtual",
                "void","volatile","while"
        };        

        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < array.Length; i++)
            {
                tree.Add(array[i]);
            }
        }

        private void Search_button_Click(object sender, RoutedEventArgs e)
        {
            if (listword.Items.Count >= 1)
            {
                listword.Items.Clear();
            }
            List<string> output = tree.Search(key_textBox.Text, Convert.ToInt32(dist_textBox.Text));
            for (int i=0;i<output.Count;i++)
            {
                listword.Items.Add(output[i]);
            }
            
        }
        private void list_Selected(object sender, RoutedEventArgs e)
        {
            input = (String)listword.SelectedValue;
        }

        private void Info_button_Click(object sender, RoutedEventArgs e)
        {
            string infoword = Info.GetINFO(input);
            MessageBox.Show(infoword);
        }

        private void Improvement_button_Click(object sender, RoutedEventArgs e)
        {
            listword.Items.Clear();
            int distance = Convert.ToInt32(dist_textBox.Text);
            List<string> output = tree.Search(key_textBox.Text,distance/2);
            for (int i = 0; i < output.Count; i++)
            {
                listword.Items.Add(output[i]);
            }
        }
    }
}
