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

namespace ListView
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] family_array =
        {
            "Лоскутов Даниил","Томсин Александр","Жаров Лукьян","Гусляков Гаврила","Соломинцев Остап","Бебнев Филипп",
            "Водоватов Андрон","Сухомлин Кирилл","Абакумов Капитон","Исмайлов Всеслав","Роговский Илья","Мащенко Гавриил",
            "Хрустицкий Юлиан","Гусаров Адриан","Кацен Ефрем","Энтский Мирон","Корнеев Виссарион","Комолов Игорь",
            "Лозанов Андриян","Ястремский Артемий","Яндиев Леондий","Ковалёв Борис","Глухов Юлий","Федин Адам",
            "Яранов Эрнест","Каганович Иосиф","Скуратов Денис","Ерастратов Бронислав","Сластников Кондратий",
            "Прибыльнов Терентий","Неделяев Дмитрий","Головченко Ульян","Ювелев Чеслав","Сыромятников Феликс",
            "Урбановский Евдоким","Кирдань Севастьян","Артамонов Святослав","Котов Павел","Дугин Радион",
            "Свалов Парфен","Кайпанов Валерьян","Густокашин Денис","Примаков Никон","Ярема Артём",
            "Залов Агап","Поздняков Давид"
        };

        int[] point_array =
        {
            50, 19, 72, 69, 66, 98, 53, 39, 54, 35, 88, 75, 33, 10, 7, 77, 17, 72, 90, 47, 21, 67,
            50, 20, 46, 10, 4, 79, 41, 27, 39, 47, 94, 70, 97, 38, 28, 82, 37, 20, 73, 67, 22, 57, 84
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Phones_Loaded(object sender, RoutedEventArgs e)
        {
            People[] array = new People[45];

            for(var i=0;i<array.Length;i++)
            {
                array[i] = new People(family_array[i],point_array[i]);
            }

            phones.ItemsSource = array;
        }
    }
}
