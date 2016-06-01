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
        float _health { get; set; }
        float _dmg { get; set; }
        bool _alive { get; set; }

    }
    class Player: ISpects
    {
        public string _name { get; set; }
        public float _health { get; set; }
        public float _dmg { get; set; }  
        public bool _alive { get; set; }

        public  Player() {
            string _name = "";
            float _health = 0;
            float _dmg = 0;
            bool _alive = true;
        }

        public Player(string name, float health, float dmg, bool alive) {
            _name = name;
            _health = health;
            _dmg = dmg;
            _alive = alive;
        }

    }
}
