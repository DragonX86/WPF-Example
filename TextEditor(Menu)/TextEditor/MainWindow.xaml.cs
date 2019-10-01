using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace TextEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path;
        bool isPresenceFile = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "(*.txt)|*.txt";

            string text = main_textbox.Text;
            

            if (saveFile1.ShowDialog() == true)
            {
                path = saveFile1.FileName;
                isPresenceFile = true;
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
            }
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.DefaultExt = "*.txt";
            openFile1.Filter = "(*.txt)|*.txt";
            openFile1.CheckFileExists = true;
            openFile1.CheckPathExists = true;
            openFile1.Multiselect = false;

            string text = null;

            if (openFile1.ShowDialog() == true)
            {
                path = openFile1.FileName;
                isPresenceFile = true;
                using (StreamReader sr = new StreamReader(openFile1.FileName, System.Text.Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }

            }
            main_textbox.Text = text;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if(isPresenceFile == true)
            {                
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(main_textbox.Text);
                }               
            }
            else
            {
                SaveFileDialog saveFile1 = new SaveFileDialog();
                saveFile1.DefaultExt = "*.txt";
                saveFile1.Filter = "(*.txt)|*.txt";

                string text = main_textbox.Text;

                if (saveFile1.ShowDialog() == true)
                {
                    path = saveFile1.FileName;
                    isPresenceFile = true;
                    using (StreamWriter sw = new StreamWriter(saveFile1.FileName, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(text);
                    }
                }
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Select_All_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GetInfo_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com");
        }        
    }
}
