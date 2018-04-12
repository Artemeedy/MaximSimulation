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

namespace MaximExample {
    /// <summary>
    /// Логика взаимодействия для State.xaml
    /// </summary>
    public partial class State : Window {
        public State() {
            InitializeComponent();
        }

        stats StartStats = new stats
        {
            Hp = 100.0F,
            Poison = 0,
            Hsv = 0.0F,
            Iq = 0,
            Money = 1000,
            Force = 0,
            Authority = 0
        };

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void _penzgtu_Click(object sender, RoutedEventArgs e)
        {
        }

        private void _give_money_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
