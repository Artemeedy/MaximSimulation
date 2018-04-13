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
    class Maxim
    {
        State window = null;

        public Maxim(State window)
        {
            //...(init)
            this.window = window;
        }

        //Предъява
        public void Blame()
        {
            if (window == null)
                return;
            var phrase = Shared.GeneratePhrase();
            window.SendMessage(text: phrase, color: Colors.DarkRed);
        }
    }
}
