using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    class CaroChess
    {
        private BanCo _BanCo;
        public CaroChess()
        {
            _BanCo = new BanCo(20, 20);
        }
        public void VeBanCo(Graphics g)
        {
            _BanCo.VeBanCo(g);
        }
    }
}
