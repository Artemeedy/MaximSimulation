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
using System.Windows.Shapes;

namespace MaximExample
{
    /// <summary>
    /// Логика взаимодействия для disclaimer.xaml
    /// </summary>
    public partial class disclaimer : Window
    {
        public disclaimer()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            var window = new State();
            window.Show();
            Application.Current.MainWindow = window;
            Close();
        }
    }
}
