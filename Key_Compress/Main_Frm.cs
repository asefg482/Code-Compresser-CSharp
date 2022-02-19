using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Key_Compress
{
    public partial class Main_Frm : Form
    {
        public Main_Frm()
        {
            InitializeComponent();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Tmr_Main.Start();
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            Tmr_Main.Stop();
        }

        int Interval = 0;

        private void Tmr_Main_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
            System.Threading.Thread.Sleep(300);
            SendKeys.Send("+{UP}");
            System.Threading.Thread.Sleep(300);
            SendKeys.Send("+{END}");
            System.Threading.Thread.Sleep(300);
            SendKeys.Send("{BACKSPACE}");
            Interval++;
            Tik_Lbl.Text = "Min Line : " + Interval;
        }

        private void Ch_Top_Most_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = (!this.TopMost);
        }
    }
}
