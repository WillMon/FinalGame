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
    public partial class Combat : Form
    {
        public static List<Player> PlayerChooseList_batt = new List<Player>();

        private void Combat_Load(object sender, EventArgs e)
        {

            PlayerChooseList_batt = Start.PlayerChooseList;
        }

        Player Vill = PlayerChooseList_batt[0];
        Player Hero = PlayerChooseList_batt[1];
        Player Random = PlayerChooseList_batt[2];


        public Combat()
        {
            InitializeComponent();
        }
    }
}
