using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximExample
{
    struct stats
    {
        private float _hp, _poison, _hsv; // хп,оьпянение,чсв
        private int _iq, _money, _force, _authority; // IQ, Деньги, Сила, авторитет

        public float Hp { get => _hp; set => _hp = value; }
        public float Poison { get => _poison; set => _poison = value; }
        public float Hsv { get => _hsv; set => _hsv = value; }
        public int Iq { get => _iq; set => _iq = value; }
        public int Money { get => _money; set => _money = value; }
        public int Force { get => _force; set => _force = value; }
        public int Authority { get => _authority; set => _authority = value; }
    }
}
