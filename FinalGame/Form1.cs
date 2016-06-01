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
    public partial class Form1 : Form
    {
        List<Player> PugList = new List<Player>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Player Pug01 = new Player("PlaceHolder01", 1000, 25, true);
            Player Pug02 = new Player("PlaceHolder02", 1000, 25, true);
            Player Pug03 = new Player("PlaceHolder03", 1000, 25, true);

            PugList.Add(Pug01);
            PugList.Add(Pug02);
            PugList.Add(Pug03);

            txt_02.Text = "";
            pic_01.BackgroundImage = Properties.Resources.plhd;
        }

        private void butt_01_Click(object sender, EventArgs e)
        {
            butt_02.Visible = true;
            butt_01.Visible = false;
            butt_03.Visible = false;
        }

        private void butt_02_Click(object sender, EventArgs e)
        {
            butt_03.Visible = true;
            butt_02.Visible = false;
            butt_01.Visible = false; 
        }

        private void butt_03_Click(object sender, EventArgs e)
        {
            butt_01.Visible = true;
            butt_02.Visible = false;
            butt_03.Visible = false;
        }

       
    }   
}
