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
        public static List<Player> PlayerChooseList = new List<Player>();
        public static Player Vill, Hero, Ran;
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
            m_gameState.ChangeState(States.Start);

            txt_o1.Text = ""; // ~ Change to reprasent both the char spect that or instructiond at press

        }


        // Responses to clicking on the Villain Picture 
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
                        Vill = new Player("Player", "Oni", 1000, 25, true);
                        break; }
                case 2: { pic_02_Vill.Visible = true;
                        pic_01_Vill.Visible = false;
                        pic_03_Vill.Visible = false;
                        Vill = new Player("Player", "Judgment", 1000, 25, true);
                        break; }
                case 3: { pic_03_Vill.Visible = true;
                        pic_01_Vill.Visible = false;
                        pic_02_Vill.Visible = false;
                        Vill = new Player("Player", "Bloody Marie", 1000, 25, true);
                        break; }
                default: break;
            }

            if (countSlid01 == 3) countSlid01 = 0;
            StateUpdate();

            txt_o1.Text += "Villain-Select has Swaped to: " + Vill._name + "\n";
        }

        private void pic_01_Vill_Click(object sender, EventArgs e)
        {
            butt_01.Enabled = false;
            txt_o1.Text += Vill._name + " Has been selected \n";
            HgLt_01.BackColor = Color.MediumSlateBlue;
        }

        private void pic_03_Vill_Click(object sender, EventArgs e)
        {
            butt_01.Enabled = false;
            txt_o1.Text += Vill._name + " Has been selected \n";
            HgLt_01.BackColor = Color.MediumSlateBlue;
        }

        private void pic_02_Vill_Click(object sender, EventArgs e)
        {
            butt_01.Enabled = false;
            txt_o1.Text += Vill._name + " Has been selected \n";
            HgLt_01.BackColor = Color.MediumSlateBlue;
        }


        // Responses to clicking on the Hero Picture 
        private void butt_02_Click(object sender, EventArgs e)
        {
            ++countSlid02;
            switch (countSlid02)
            {
                case 1:
                    {  pic_01_Hero.Visible = true;
                        pic_02_Hero.Visible = false;
                        pic_03_Hero.Visible = false;
                        Hero = new Player("Player", "Ryu", 1000, 25, true);
                        
                        break;   }
                case 2:
                    {  pic_02_Hero.Visible = true;
                        pic_01_Hero.Visible = false;
                        pic_03_Hero.Visible = false;
                        Hero = new Player("Player", "Dizzy", 1000, 25, true);
                        break; }
                case 3:
                    {  pic_03_Hero.Visible = true;
                        pic_01_Hero.Visible = false;
                        pic_02_Hero.Visible = false;
                        Hero = new Player("Player", "Fortune", 1000, 25, true);
                        break;  }
                default: break;
            }
            if (countSlid02 == 3) countSlid02 = 0;
            StateUpdate();

            txt_o1.Text += "Hero-Select has Swaped to: " + Hero._name + "\n"; 

        }
        
        private void pic_01_Hero_Click(object sender, EventArgs e)
        {
            butt_02.Enabled = false;
            txt_o1.Text += Hero._name + " Has been selected \n";
            HgLt_02.BackColor = Color.Red;
        }

        private void pic_02_Hero_Click(object sender, EventArgs e)
        {
            butt_02.Enabled = false;
            txt_o1.Text += Hero._name + " Has been selected \n";
            HgLt_02.BackColor = Color.Red;
        }

        private void pic_03_Hero_Click(object sender, EventArgs e)
        {
            butt_02.Enabled = false;
            txt_o1.Text += Hero._name + " Has been selected \n";
            HgLt_02.BackColor = Color.Red;
        }

        private void HgLt_03_Click(object sender, EventArgs e)
        {
            HgLt_01.BackColor = Color.MediumSlateBlue;
        }

        // Responses to clicking on the Hero Picture 
        private void butt_03_Click(object sender, EventArgs e)
        {

            ++countSlid03;
            switch (countSlid03)
            {
                case 1:
                    {  pic_01_Ran.Visible = true;
                        pic_02_Ran.Visible = false;
                        pic_03_Ran.Visible = false;
                        Ran = new Player("Player", "Miccu", 1000, 25, true);
                        break; }
                case 2:
                    {  pic_02_Ran.Visible = true;
                        pic_01_Ran.Visible = false;
                        pic_03_Ran.Visible = false;
                        Ran = new Player("Player", "Aigis", 1000, 25, true);
                        break; }
                case 3:
                    { pic_03_Ran.Visible = true;
                        pic_01_Ran.Visible = false;
                        pic_02_Ran.Visible = false;
                        Ran = new Player("Player", "Rise", 1000, 25, true);
                        break;  }
                default: break;
            }
            if (countSlid03 == 3) countSlid03 = 0;
            StateUpdate();

            txt_o1.Text += "Op-Select has Swaped to: " + Ran._name + "\n";
        }

        private void pic_01_Ran_Click(object sender, EventArgs e)
        {
            butt_03.Enabled = false;
            txt_o1.Text += Ran._name + " Has been selected \n";
            HgLt_03.BackColor = Color.LightGreen;
        }

        private void pic_02_Ran_Click(object sender, EventArgs e)
        {
            butt_03.Enabled = false;
            txt_o1.Text += Ran._name + " Has been selected \n";
            HgLt_03.BackColor = Color.LightGreen;
        }

        private void pic_03_Ran_Click(object sender, EventArgs e)
        {
            butt_03.Enabled = false;
            txt_o1.Text += Ran._name + " Has been selected \n";
            HgLt_03.BackColor = Color.LightGreen;
        }

        

        private void butt_06_Click(object sender, EventArgs e)
        {
            m_gameState.ChangeState(States.Combat);
            PlayerChooseList.Add(Vill);
            PlayerChooseList.Add(Hero);
            PlayerChooseList.Add(Ran);
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
