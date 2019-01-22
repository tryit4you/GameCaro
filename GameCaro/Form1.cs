using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private CaroChess caroChess;
        private Graphics grs;
        public frmMain()
        {
            InitializeComponent();
            caroChess = new CaroChess();
            grs = pnlBanCo.CreateGraphics();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlBanCo_Paint(object sender, PaintEventArgs e)
        {
            caroChess.VeBanCo(grs);
        }

        private void pnlBanCo_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
