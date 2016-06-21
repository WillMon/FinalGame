using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGame
{
    public  enum States { Inite, Start, Combat, Save, Load, End}

    public partial class Start : Form
    {
        List<Player> PugList = new List<Player>();
        public static FinistateStatMachine<States> m_gameState = new FinistateStatMachine<States>(States.Inite);
        int countSlid01, countSlid02, countSlid03;

        public Start()
        {
            InitializeComponent();

            var s = Enum.GetValues(typeof(States));
            foreach (States f in s)
                m_gameState.AddStat(f);

            m_gameState.AddTransiton(States.Inite, States.Start);
            m_gameState.AddTransiton(States.Start, States.Combat);
            m_gameState.AddTransiton(States.Start, States.Load);
            m_gameState.AddTransiton(States.Start, States.End);
            m_gameState.AddTransiton(States.Combat, States.Load);
            m_gameState.AddTransiton(States.Combat, States.End);

            

        }
        Combat _combot = new Combat();

        private void Form1_Load(object sender, EventArgs e)
        {
            Player Hero01 = new Player("Oni", 1000, 25, true);
            Player Herp02 = new Player("Bloody Marie", 1000, 25, true);
            Player Hero03 = new Player("Judgment", 1000, 25, true);

            PugList.Add(Hero01);
            PugList.Add(Herp02);
            PugList.Add(Hero03);

            m_gameState.ChangeState(States.Start);

            txt_o1.Text = ""; // ~ Change to reprasent both the char spect that or instructiond at press

        }

        private void butt_01_Click(object sender, EventArgs e)
        {

            //Bitmap Ryu = new Bitmap(@"C:\\Users\\william.montero\\Pictures\\Ryu.gif");
            //pic_01_Vill.BackgroundImage = Ryu;
            ++countSlid01;
            switch (countSlid01)
            {
                case 1: { pic_01_Vill.Visible = true;
                        pic_02_Vill.Visible = false;
                        pic_03_Vill.Visible = false;
                        break; }
                case 2: { pic_02_Vill.Visible = true;
                        pic_01_Vill.Visible = false;
                        pic_03_Vill.Visible = false;
                        break; }
                case 3: { pic_03_Vill.Visible = true;
                        pic_01_Vill.Visible = false;
                        pic_02_Vill.Visible = false;
                        break; }
                default: break;
            }
            if (countSlid01 == 3) countSlid01 = 0;
            StateUpdate();
            
        }

        private void pic_01_Vill_Click(object sender, EventArgs e)
        {
            HgLt_01.BackColor = Color.MediumSlateBlue;
        }

        private void pic_03_Vill_Click(object sender, EventArgs e)
        {
            HgLt_01.BackColor = Color.MediumSlateBlue;
        }

        private void pic_02_Vill_Click(object sender, EventArgs e)
        {
            HgLt_01.BackColor = Color.MediumSlateBlue;
        }

        private void butt_02_Click(object sender, EventArgs e)
        {
            ++countSlid02;
            switch (countSlid02)
            {
                case 1:
                    {
                        pic_01_Hero.Visible = true;
                        pic_02_Hero.Visible = false;
                        pic_03_Hero.Visible = false;
                        break;
                    }
                case 2:
                    {
                        pic_02_Hero.Visible = true;
                        pic_01_Hero.Visible = false;
                        pic_03_Hero.Visible = false;
                        break;
                    }
                case 3:
                    {
                        pic_03_Hero.Visible = true;
                        pic_01_Hero.Visible = false;
                        pic_02_Hero.Visible = false;
                        break;
                    }
                default: break;
            }
            if (countSlid02 == 3) countSlid02 = 0;
            StateUpdate();

        }

        private void pic_01_Hero_Click(object sender, EventArgs e)
        {
            HgLt_02.BackColor = Color.Red;
        }

        private void pic_02_Hero_Click(object sender, EventArgs e)
        {
            HgLt_02.BackColor = Color.Red;
        }

        private void pic_03_Hero_Click(object sender, EventArgs e)
        {
            HgLt_02.BackColor = Color.Red;
        }

        private void HgLt_03_Click(object sender, EventArgs e)
        {
            HgLt_01.BackColor = Color.MediumSlateBlue;
        }

        private void butt_03_Click(object sender, EventArgs e)
        {

            ++countSlid03;
            switch (countSlid03)
            {
                case 1:
                    {
                        pic_01_Ran.Visible = true;
                        pic_02_Ran.Visible = false;
                        pic_03_Ran.Visible = false;
                        break;
                    }
                case 2:
                    {
                        pic_02_Ran.Visible = true;
                        pic_01_Ran.Visible = false;
                        pic_03_Ran.Visible = false;
                        break;
                    }
                case 3:
                    {
                        pic_03_Ran.Visible = true;
                        pic_01_Ran.Visible = false;
                        pic_02_Ran.Visible = false;
                        break;
                    }
                default: break;
            }
            if (countSlid03 == 3) countSlid03 = 0;
            StateUpdate();
        }

        private void pic_01_Ran_Click(object sender, EventArgs e)
        {

        }

        private void pic_02_Ran_Click(object sender, EventArgs e)
        {

        }

        private void pic_03_Ran_Click(object sender, EventArgs e)
        {

        }

        

        private void butt_06_Click(object sender, EventArgs e)
        {
            m_gameState.ChangeState(States.Combat);
             
            
            StateUpdate();            
        }

        void StateUpdate() {
            switch (m_gameState.CurrentStat) {
                case States.Start: { break; }
                case States.Combat: { _combot.Show(); break; }
                case States.Load: {  break; }
                case States.Save: { break; }
                case States.End: { Close(); _combot.Close(); break;  }

            }
        }
    }   
}
