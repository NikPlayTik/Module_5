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

namespace Module_5
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> tasks = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            listTasks.ItemsSource = tasks;
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            // получаем текст из текстового поля и удаляем лишние пробелы
            string task = textTask.Text.Trim();

            // проверка, что текст не пустой
            if (!string.IsNullOrEmpty(task))
            {
                tasks.Add(task);
                textTask.Clear();
            }
        }
        private void RemoveTask_Click(object sender, RoutedEventArgs e)
        {
            
            if (listTasks.SelectedIndex > -1)
            {
                tasks.RemoveAt(listTasks.SelectedIndex);
            }
        }
    }
}
