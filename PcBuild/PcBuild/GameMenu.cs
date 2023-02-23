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

namespace PcBuild
{
    
    public partial class GameMenu : Form
    {
        Button actB = null;
        #region perem
        string person = " ";
        int x = 2, y = 2;
        int day = 1;
        int cash = 1000;
        int cost;
        int reputation;
        int timeElapse = 8;
        int numButton;
        int rightAns;
        int c = 0;
        int countmes = 0;
        #endregion perem
        public GameMenu(string person)
        {
            this.person = person;
            InitializeComponent();
            person_name.Text = person;
            FillLists();
            PostCreator();
        }

        private void PostCreator()
        {
            for (int i = 0; i < mes.Count; i++)
            {
                this.view1.Controls.Add(new Button { Name = "v1b" + i, Location = new Point(x, y), Size = new Size(210, 44), Text = mes[i][0], BackColor = Color.White, FlatStyle = FlatStyle.Flat });
                y += 40;
                this.view1.Controls["v1b" + i].Click += new EventHandler(this.task_Click);
            }
        }

        private void LoadAnswers(List<string[]> mes, List<string[]> ans, int num)
        {
            
            cost = Convert.ToInt32(mes[num][3]);
            DialogResult result = MessageBox.Show(mes[num][1] + "\n  О работе:" + "\n Плата: " + mes[num][3]+ "\n Требуется времени: " + mes[num][4] + "\n  Принять задание?",
                mes[num][2],
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                if(Convert.ToInt32(mes[num][4]) > timeElapse)    //Если не достаточно времени, то задание будет не возможно взять.
                {
                    MessageBox.Show("Недостаточно времени...");
                    yv_endDay.Image = PcBuild.Properties.Resources.pic_yved;
                    yv_mail.Image = null;
                    return;
                }
                this.view1.Controls["v1b" + numButton].Enabled = false;
                timeElapse -= Convert.ToInt32(mes[numButton][4]);
                lab_time.Text = timeElapse.ToString();
                x = 2; y = 2;
                for (int i = 0; i < ans.Count; i++)
                {
                    this.view2.Controls.Add(new Button { Name = "v2b" + i, Location = new Point(x, y), Size = new Size(700, 51), Text = ans[i][0], BackColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Arial", 8)});
                    y += 70;
                    this.view2.Controls["v2b" + i].Click += new EventHandler(this.ans_Click);
                }
            }
        }

        private void CheckRightAnswer(List<string[]> ans)
        {
            for (int i = 0; i < ans.Count; i++)
            {
                if (ans[i][1] == "1")
                {
                    rightAns = i;
                    break;
                }
            }
        }

        private void btn_onoff_Click(object sender, EventArgs e)
        {
            monitor_workspace.Visible = !monitor_workspace.Visible;
        }

        private void person_name_TextChanged(object sender, EventArgs e)
        {
            if (person_name.Text == "Ilon") pic_avatar.Image = PcBuild.Properties.Resources.male_avatar;
            else pic_avatar.Image = PcBuild.Properties.Resources.girls_avatar;
        }

        private void pic_profile_Click(object sender, EventArgs e)
        {
            panel_profile.Visible = !panel_profile.Visible;
            
        }

        private void pic_menu_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = !panel_menu.Visible;
        }

        private void pic_mail_DoubleClick(object sender, EventArgs e)
        {
            panel_mail.Visible = !panel_mail.Visible;
            view2.Controls.Clear();
            x = 3; y = 3;
            PostCreator();
        }
        #region taskClick
        //Событие клика на вопрос
        private void task_Click(object sender, EventArgs e)
        {
            actB = (sender as Button);
            //this.Focus();
            //actB.Dispose();
            switch ((sender as Button).Name.ToString())
            {
                case "v1b0":
                    numButton = 0;
                    CheckRightAnswer(ans0);
                    LoadAnswers(mes, ans0, numButton);
                    break;
                case "v1b1":
                    numButton = 1;
                    CheckRightAnswer(ans1);
                    LoadAnswers(mes, ans1, numButton);
                    break;
                case "v1b2":
                    numButton = 2;
                    CheckRightAnswer(ans2);
                    LoadAnswers(mes, ans2, numButton);
                    break;
                case "v1b3":
                    numButton = 3;
                    CheckRightAnswer(ans3);
                    LoadAnswers(mes, ans3, numButton);
                    break;
            }
        }
        #endregion taskClick
        #region ansClick
        //Событие клика на вопрос
        private void ans_Click(object sender, EventArgs e)
        {
            string otv = (sender as Button).Name.ToString();
            otv = otv.Substring(3, otv.Length - 3);
            int numOtv = Convert.ToInt32(otv);
            if(numOtv == rightAns)
            {
                cash += cost; lab_money.Text = cash.ToString();
                reputation += 10; lab_rep.Text = reputation.ToString();
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + @"\sounds\pravilno.wav");
                sp.Play();
                pic_vyp.Image = PcBuild.Properties.Resources.galochka;
                lab_vyp.Visible = true;  //djsdgffsjfhdghsgfhjasdgfhjdghfjsahasfjgjhffgsadjfhsdjfgsdhjfgf
                lab_vyp.Text = "Выполнено!";
                view2.Controls.Clear();
                timer1.Start();
            }
            else
            {
                reputation -= 10; lab_rep.Text = reputation.ToString();
                SoundPlayer sp = new SoundPlayer(Application.StartupPath + @"\sounds\oshibka.wav");
                sp.Play();
                pic_vyp.Image = PcBuild.Properties.Resources.error;
                lab_vyp.Visible = true;
                lab_vyp.Text = "Ошибка!";
                view2.Controls.Clear();
                timer1.Start();
            }
            MeessageExist();
            
        }
        #endregion ansClick

        private void MeessageExist()
        {
            foreach (var but in view1.Controls.OfType<Button>())
            {
                if (but.Enabled == true) countmes++;
            }
            if (countmes > 0)
            {
                yv_mail.Image = PcBuild.Properties.Resources.pic_yved;
                yv_endDay.Image = null;
            }
            else
            {
                yv_mail.Image = null;
                yv_endDay.Image = PcBuild.Properties.Resources.pic_yved;
            }
            countmes = 0;
        }

        #region vstyplenie
        private void GameMenu_Load(object sender, EventArgs e)
        {
            if (person_name.Text == "Ilon") MessageBox.Show(GameMenu.intro1, "Вступление:");
            else MessageBox.Show(GameMenu.intro2, "Вступление:");
        }
        #endregion vstyplenie

        private void timer1_Tick(object sender, EventArgs e)
        {
            c++;
            if(c > 2)
            {
                pic_vyp.Image = null;
                lab_vyp.Text = " ";
                c = 0;
                timer1.Stop();
            }
        }

        private void pic_shop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Магазин временно закрыт, проблемы с операцией доставки. Приносим свои извинения.");
        }

        private void pic_details_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Список заказов пуст.");
        }

        #region EndDay
        private void pic_endDay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены что, хотите закончить день?",
                "Внимание!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if(result == DialogResult.Yes)
            {
                x = 3; y = 3;
                view1.Controls.Clear(); view2.Controls.Clear();
                ans0.Clear(); ans1.Clear(); ans2.Clear(); ans3.Clear();
                day++; lab_day.Text = day.ToString(); timeElapse = 8; lab_time.Text = timeElapse.ToString();
                yv_mail.Image = PcBuild.Properties.Resources.pic_yved;
                yv_endDay.Image = null;
                FillLists();
                PostCreator();
            }
        }
        #endregion EndDay
        #region ChangeLabProfile
        //Условия выигрыша/проигрыша.
        private void lab_day_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(lab_day.Text) > 4)
            {
                cash -= 1400; lab_money.Text = cash.ToString();
                MessageBox.Show("Сумма счета за электричество и аренды, составила - 1400.", "Оплата комунальных и аренды.");
                if (cash > 1000)
                {
                    DialogResult result = MessageBox.Show(
                        "Поздравляем, ваш бизнес начал процветать, и вы начали выходить в плюс! \nМастерская ваша!",
                        "Вы выиграли!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    if (result == DialogResult.OK)
                        Application.Exit();
                    else Application.Exit();
                }
                else
                {
                    DialogResult result2 = MessageBox.Show("К сожалению вам не удалось выйти в плюс! \nВам придется покинуть мастерскую!",
                        "Вы проиграли!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    if (result2 == DialogResult.OK)
                        Application.Exit();
                    else Application.Exit();
                }
            }
        }

        private void lab_rep_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lab_rep.Text) < 0)
            {
                DialogResult result = MessageBox.Show(
                        "К сожалению вы допускали много ошибок, и репутация мастерской снизилась к нулю, теперь люди будут обходить мастерскую стороной! \nВам придется покинуть мастерскую!",
                        "Lose!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.OK)
                    Application.Exit();
                else Application.Exit();
            }
        }
        #endregion ChangeLabProfile

        private void FillLists()
        {
            switch (day)
            {
                case 1:
                    fmes1();
                    break;
                case 2:
                    fmes2();
                    break;
                case 3:
                    fmes3();
                    break;
                case 4:
                    fmes4();
                    break;
                case 5:
                    fmes5();
                    break;
                case 6:
                    fmes6();
                    break;
            }
        }

        private void pic_settings_Click(object sender, EventArgs e)
        {
            panel_settings.Visible = !panel_settings.Visible;
        }

        private void btn_mm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти в главное меню игры?", "Весь прогресс будет утерян.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Loading3 l3 = new Loading3();
                l3.Show();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти из игры?", "Весь прогресс будет утерян.",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
