using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTennis
{
    public class Player
    {
        private string _name;
        Point _score;

        public Player(string name)
        {
            Name = name;
            Score = Point.Love; 
        }

        public string Name { get => _name; set => _name = value; }
        public Point Score { get => _score; set => _score = value; }
    }
}
