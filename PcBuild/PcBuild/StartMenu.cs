using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PcBuild
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
            sp.Play();
        }

            SoundPlayer sp = new SoundPlayer(Application.StartupPath + @"\sounds\mainmusic.wav");
       
        
        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loading2 l2 = new Loading2();
            l2.Show();
            sp.Stop();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Может все-таки останешься? ", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        
    }
}
