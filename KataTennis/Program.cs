using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibTennis;

namespace KataTennis
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            Console.WriteLine("Wemanity Tennis Kata - Oussama Meziani ");
            Console.WriteLine("Case 1 : Player 2 Win");
            Console.ReadKey();
       
            Game game = new Game("Nadal" , "Federer");
            game.GameFinished += () => 
            {
                Console.WriteLine("Game Finished");
            };
            //while (true)
            //{
            //    game.Reset();
            //    while (!game.Game_finished)
            //    {
            //        int n = r.Next(2);
            //        if (n == 0)
            //            game.AddPoint(game.Player1, game.Player2);
            //        else
            //            game.AddPoint(game.Player2, game.Player1);
            //        Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score + " " + n);
            //    }
            //    Console.ReadKey();
            //}

            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer1();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer2();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer2();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer2();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer2();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);


            Console.WriteLine("Case 2 : Deuce for 2 balls then Player 2 Win");
            Console.ReadKey();
            game.Reset();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer1();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer2();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer1();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer1();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer2();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer2();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer2();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer1();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer2();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer1();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer2();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer2();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);


            Console.WriteLine("Case 3 : Player 1 Win");
            Console.ReadKey();
            game.Reset();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer1();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer2();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer1();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer2();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer1();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
            game.AddPointPlayer1();
            Console.WriteLine("Joueur 1 :  " + game.Player1.Score + "   Joueur 2 :  " + game.Player2.Score);
        }
    }
}
