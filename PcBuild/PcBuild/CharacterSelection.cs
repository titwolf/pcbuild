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
    public partial class CharacterSelection : Form
    {
        int count;

        public CharacterSelection()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти в главное меню игры?", "Выход.", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                this.Hide();
                Loading3 l3 = new Loading3();
                l3.Show();
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            while (count < 5)
            {
                count++;
                int a = this.Controls["pictureBox1"].Size.Width + 5;
                int b = this.Controls["pictureBox1"].Size.Height + 5;
                this.Controls["pictureBox1"].Size = new Size(a, b);
            }
            count = 0;
            label1.Visible= true;
            label1.Text = "Илон, 50 лет. Большие знания в области техники, но маленький уровень харизмы!";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            while (count < 5)
            {
                count++;
                int a = this.Controls["pictureBox1"].Size.Width - 5;
                int b = this.Controls["pictureBox1"].Size.Height - 5;
                this.Controls["pictureBox1"].Size = new Size(a, b);
            }
            count = 0;
            label1.Visible= false;
            label1.Text = "";
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            while (count < 5)
            {
                count++;
                int a = this.Controls["pictureBox2"].Size.Width + 5;
                int b = this.Controls["pictureBox2"].Size.Height + 5;
                this.Controls["pictureBox2"].Size = new Size(a, b);
            }
            count = 0;
            label1.Visible= true;
            label1.Text = "Ева и Гретта, 20 и 19 лет. Не профи в ремонте компьютеров, зато обладают большой и сильной харизмой!";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            while (count < 5)
            {
                count++;
                int a = this.Controls["pictureBox2"].Size.Width - 5;
                int b = this.Controls["pictureBox2"].Size.Height - 5;
                this.Controls["pictureBox2"].Size = new Size(a, b);
            }
            count = 0;
            label1.Visible = false; 
            label1.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GameMenu gm = new GameMenu("Ilon");
            this.Hide();
            gm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GameMenu gm = new GameMenu("Eva & Gretta");
            this.Hide();
            gm.Show();
        }
    }
}
