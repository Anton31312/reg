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
using System.IO;

namespace StrakhFed2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        string path = @"C:\Users\WSR\source\repos\StrakhFed2\ListName.txt";

        public StartWindow()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Фамилия: {tbLastName.Text} Имя: {tbFirstName.Text} Возраст: {tbAge.Text}");

            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.Write(tbLastName.Text);
            streamWriter.Write(tbFirstName.Text);
            streamWriter.Write(tbAge.Text);
            streamWriter.Close();
            
        }

        private void tbAge_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void tbLastName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void tbFirstName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }
    }
}
