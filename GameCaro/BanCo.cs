using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    class BanCo
    {
        private int _SoDong;
        private int _SoCot;

        public BanCo()
        {
            _SoDong = 0;
            _SoCot = 0;
        }
        public BanCo(int sodong,int socot)
        {
            _SoDong = sodong;
            _SoCot = socot;
        }
        public void VeBanCo(Graphics g)
        {
            for(int i = 0; i <= _SoCot; i++)
            {
                g.DrawLine(Program.pen, i * OCo._ChieuRong, 0, i * OCo._ChieuRong, _SoDong * OCo._ChieuCao);
            }
            for (int j = 0; j <= _SoCot; j++)
            {
                g.DrawLine(Program.pen, 0,j*OCo._ChieuCao,_SoCot*OCo._ChieuRong,j*OCo._ChieuCao);
            }
        }
    }
}
