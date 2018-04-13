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
using static MaximExample.Shared;

namespace MaximExample {
    /// <summary>
    /// Логика взаимодействия для State.xaml
    /// </summary>
    public partial class State : Window {
        public State() {
            InitializeComponent();
        }
        //в твоем случае этот listbox уже описан в designer, используешь свое имя.
        ChatBufferType chat_bt = ChatBufferType.Limited;

        Maxim maxim = null;

        void CreateMaxim()
        {
            maxim = new Maxim(window: this);
            maxim.Blame();
            //TODO: че-то еще
        }

        public void SendMessage(string text, Color color)
        {
            var item = new ListBoxItem();
            item.Content = text;
            item.Foreground = new SolidColorBrush(color);
            ListBox1.Items.Add(item);
            //Если буффер переполнен, удаляем первое сообщение
            if (chat_bt == ChatBufferType.Limited && ListBox1.Items.Count > CHAT_BUFFER_SIZE)
                ListBox1.Items.RemoveAt(0);
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
            SendMessage("csadas", Color.FromArgb(255,0,255,0));
        }

        private void _give_money_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
