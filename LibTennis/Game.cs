using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTennis
{
    public class Game
    {
        private Player _player1;
        private Player _player2;
        private bool game_finished;

        public Game(string player1 , string player2)
        {
            Player1 = new Player(player1);
            Player2 = new Player(player2);
            Game_finished = false; 
        }

        public Game(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
            Game_finished = false;
        }

        public Player Player1 { get => _player1; set => _player1 = value; }
        public Player Player2 { get => _player2; set => _player2 = value; }
        public bool Game_finished { get => game_finished; set => game_finished = value; }
        public event Action GameFinished;
        public event Action BallPlayed;

        public void AddPoint(Player winner, Player looser)
        {
            if (Game_finished)
                return;

            if (looser.Score < Point.Forthy)
            {
                winner.Score = winner.Score == Point.Forthy ?  Point.Win : ++winner.Score;
            }
            else
            {
                if (looser.Score == Point.Advantage && winner.Score == Point.Forthy)
                    looser.Score = winner.Score = Point.Forthy;
                else
                    winner.Score++;
            }
            BallPlayed?.Invoke();
            if (winner.Score == Point.Win)
            {
                Game_finished = true;
                OnGameFinished();
            }
        }

        private void OnGameFinished()
        {
            GameFinished?.Invoke();
        }

        public void Reset()
        {
            Player1.Score = Point.Love;
            Player2.Score = Point.Love;
            Game_finished = false; 
        }

    }
}
