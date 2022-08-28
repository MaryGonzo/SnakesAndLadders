using SnakesAndLadders.Back;
using SnakesAndLadders.Back.Contracts;

namespace SnakesAndLadders.Front.PlayGame
{
    class Program
    {
        #region Properties
        /// <summary>
        /// Minimum number of players.
        /// </summary>
        private const int MINIMUN_NUMBER_PLAYERS = 2;
        /// <summary>
        /// Maximun number of players.
        /// </summary>
        private const int MAXIMUN_NUMBER_PLAYERS = 6;
        /// <summary>
        /// Game.
        /// </summary>
        private static IGame _game;
        /// <summary>
        /// Is a player won the game.
        /// </summary>
        private static bool _haveWinner;
        #endregion

        #region PublicMethods
        private static void Main(string[] args)
        {
            //PrintBoard();
            InitializeGame();
        }
        #endregion

        #region PrivateMethods
        private static void InitializeGame()
        {
            Console.WriteLine("Wellcome to the game Snakes and Ladders!!!.");

            do
            {
                Console.WriteLine("Press ENTER to start.");
            } while (Console.ReadKey().Key != ConsoleKey.Enter);

            int numberPlayers = GetNumberPlayers();

            Console.WriteLine($"Start the game.");
            Console.WriteLine();

            _game = new Game(numberPlayers);

            TurnPlayer();
        }

        private static int GetNumberPlayers()
        {
            int numberPlayers = 0;

            do
            {
                Console.WriteLine($"Enter the number of players. Minimun {MINIMUN_NUMBER_PLAYERS} and maximun {MAXIMUN_NUMBER_PLAYERS}.");
                int.TryParse(Console.ReadLine(), out numberPlayers);
                Console.WriteLine();
            } while (numberPlayers < MINIMUN_NUMBER_PLAYERS || numberPlayers > MAXIMUN_NUMBER_PLAYERS);

            Console.WriteLine($"Number of players: {numberPlayers}");
            Console.WriteLine();
            return numberPlayers;
        }

        private static int DiceRoll()
        {
            int roll = 0;

            do
            {
                Console.WriteLine($"Roll the dice press ENTER.");
            } while (Console.ReadKey().Key != ConsoleKey.Enter);

            roll = _game.DiceRoll();
            Console.WriteLine($"Dice roll: {roll}");

            return roll;
        }

        private static void TurnPlayer()
        {
            do
            {
                Console.WriteLine(new string('-', 50));

                int currentPlayer = _game.CurrentPlayer();

                Console.WriteLine($"Player {currentPlayer + 1}:");
                Console.WriteLine($"Position: {_game.GetPlayerSquare(currentPlayer)}");

                int roll = DiceRoll();

                int newPosition = _game.MoveTokenCurrentPlayer(roll);
                Console.WriteLine($"New position: {_game.GetPlayerSquare(currentPlayer)}");
                
                Console.WriteLine(new string('-', 50));

                _haveWinner = _game.IsPlayerWinner(currentPlayer);
                if (_haveWinner)
                {
                    Console.WriteLine($"Player {currentPlayer + 1} is the WINNER!!!");

                    PrintFireWorks();
                }
            }
            while (!_haveWinner);
        }

        private static void PrintBoard()
        {
            Console.WriteLine(new string('-', 41));
            for (int i = 0; i < _game.GetBoard().GetLength(0); i++)
            {
                for (int j = 0; j < _game.GetBoard().GetLength(1); j++)
                {
                    if (_game.GetBoard()[i, j] == 100)
                    {
                        Console.Write(string.Format("|{0}", _game.GetBoard()[i, j]));
                    }
                    else if (_game.GetBoard()[i, j] >= 10)
                    {
                        Console.Write(string.Format("| {0}", _game.GetBoard()[i, j]));
                    }
                    else
                    {
                        Console.Write(string.Format("|  {0}", _game.GetBoard()[i, j]));
                    }
                }
                Console.Write("|");
                Console.Write(Environment.NewLine);
                Console.WriteLine(new string('-', 41));
            }
            Console.ReadLine();
        }

        private static void PrintFireWorks()
        {
            Console.WriteLine();
            Console.WriteLine("                                   .''.       ");
            Console.WriteLine("       .''.      .        *''*    :_\\/_:     . ");
            Console.WriteLine("      :_\\/_:   _\\(/_  .:.*_\\/_*   : /\\ :  .'.:.'.");
            Console.WriteLine("  .''.: /\\ :   ./)\\   ':'* /\\ * :  '..'.  -=:o:=-");
            Console.WriteLine(" :_\\/_:'.:::.    ' *''*    * '.\\'/.' _\\(/_'.':'.'");
            Console.WriteLine(" : /\\ : :::::     *_\\/_*     -= o =-  /)\\    '  *");
            Console.WriteLine("  '..'  ':::'     * /\\ *     .'/.\\'.   '");
            Console.WriteLine("      *            *..*         :");
            Console.WriteLine("        *");
            Console.WriteLine("       *");
            Console.WriteLine();
        }
        #endregion
    }
}