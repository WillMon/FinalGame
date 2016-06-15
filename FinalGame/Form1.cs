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
        public Start()
        {
            InitializeComponent();

            var s = Enum.GetValues(typeof(States));
            foreach (States f in s)
                m_gameState.AddStat(f);


        }
        //Combat 

        private void Form1_Load(object sender, EventArgs e)
        {
            Player Pug01 = new Player("PlaceHolder01", 1000, 25, true);
            Player Pug02 = new Player("PlaceHolder02", 1000, 25, true);
            Player Pug03 = new Player("PlaceHolder03", 1000, 25, true);

            

            PugList.Add(Pug01);
            PugList.Add(Pug02);
            PugList.Add(Pug03);

            m_gameState.ChangeState(States.Start);

            txt_o1.Text = "";
            pic_01.BackgroundImage = Properties.Resources.plhd;
        }

        private void butt_01_Click(object sender, EventArgs e)
        {
            butt_02.Enabled = true;
            butt_01.Enabled = false;
            butt_03.Enabled = false;
        }

        private void butt_02_Click(object sender, EventArgs e)
        {
            butt_03.Enabled = true;
            butt_02.Enabled = false;
            butt_01.Enabled = false; 
        }

        private void butt_03_Click(object sender, EventArgs e)
        {
            butt_01.Enabled = true;
            butt_02.Enabled = false;
            butt_03.Enabled = false;
        }

        private void butt_06_Click(object sender, EventArgs e)
        {
            
        }

        void StateUpdate() {
            switch (m_gameState.CurrentStat) {
                case States.Start: { break; }



            }
        }
    }   
}
