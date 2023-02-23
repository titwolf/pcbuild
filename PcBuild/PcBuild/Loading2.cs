using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcBuild
{
    public partial class Loading2 : Form
    {
        int count;
        public Loading2()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count < 18)
            {
                count++;
                this.panel1.Controls["pictureBox" + count].Visible = true;
            }
            else
            {
                timer1.Stop();
                CharacterSelection cs = new CharacterSelection();
                this.Hide();
                cs.Show();
            }
        }
    }
}
