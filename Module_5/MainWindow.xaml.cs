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
using System.Collections.ObjectModel;
using System.Data;

namespace Module_5
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> tasks = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            listBoxTasks.ItemsSource = tasks;
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            // получаем текст из текстового поля и удаляем лишние пробелы
            string task = textBoxTask.Text.Trim();

            // проверка, что текст не пустой
            if (!string.IsNullOrEmpty(task))
            {
                tasks.Add(task + "\t" + currentTime);
                textBoxTask.Clear();
            }
        }
        private void RemoveTask_Click(object sender, RoutedEventArgs e)
        {
            // проверка, что выбрана задача для удаления
            if (listBoxTasks.SelectedIndex > -1)
            {
                tasks.RemoveAt(listBoxTasks.SelectedIndex);
            }
        }
    }
}
