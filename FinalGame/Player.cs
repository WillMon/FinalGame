using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGame
{
    interface ISpects
    {
        string _name { get; set; }
        float _startingHP { get; set; }
        float _HP { get; set; }
        float _startingDmg { get; set; }
        float _dmg { get; set; }
        bool _alive { get; set; }
        
    }
    [Serializable]
    class Player: ISpects
    {
        public string _name { get; set; }
        public float _startingHP { get; set; }
        public float _HP { get; set; }
        public float _startingDmg { get; set; }
        public float _dmg { get; set; }  
        public bool _alive { get; set; }

        public  Player() {
        }

        public Player(string classification, string name, float health, float dmg, bool alive) {
            _name = name;
            _startingHP = health;
            _HP = _startingHP;
            _startingDmg = dmg;
            _dmg = _startingDmg;
            _alive = alive;
        }

        /// <summary>
        /// Set Health deplision when collision to dmg haf been meet 
        /// </summary>
        /// <param name="dmg"> int being taken from total health</param>
        void TakDmg(int dmg) {
            _HP -= dmg;
        }
        /// <summary>
        ///This Function shoul trigger on activation with the players _currentHP 
        ///
        /// </summary>
         void RTSR() {
            float buff = _startingHP * .05f;

            if (_HP <= buff)
                _dmg += _startingDmg * .2f;   
        }


    }
}
