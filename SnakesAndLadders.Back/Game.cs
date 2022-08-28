namespace SnakesAndLadders.Back
{
    /// <summary>
    /// Class Game.
    /// Management the game.
    /// </summary>
    public class Game : IGame
    {
        #region Properties
        /// <summary>
        /// Board of game.
        /// </summary>
        private readonly IBoard _board;
        /// <summary>
        /// Game die.
        /// </summary>
        private readonly IDice _die;
        /// <summary>
        /// Players of the game.
        /// </summary>
        private List<IPlayer> _players;
        /// <summary>
        /// Player that have the turn.
        /// </summary>
        private int _currentPlayer;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor.
        /// 
        /// </summary>
        /// <param name="numberPlayers"></param>
        public Game(int numberPlayers)
        {
            //Board
            _board = new Board();
            _die = new Dice();
            _players = new List<IPlayer>();
            PutPlayersInBoard(numberPlayers);
        }
        #endregion

        #region PublicMethods
        /// <summary>
        /// Get the number of square where the player stay.
        /// </summary>
        /// <param name="player">Number of player.</param>
        /// <returns>Number of square.</returns>
        public int GetPlayerSquare(int player)
        {
            try
            {
                return _players.ElementAt(player).GetSquareToken();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Move the token the spaces number indicated.
        /// </summary>
        /// <param name="player">Number of player.</param>
        /// <param name="spaces">Number of spaces, die value.</param>
        /// <returns>Number of square.</returns>
        public int MoveTokenPlayer(int player, int spaces)
        {
            try
            {
                int square = GetPlayerSquare(player);
                //if (_currentPlayer == player)
                //{
                if(square + spaces <= Constants.MAX_VALUE)
                {
                    square = _players.ElementAt(player).TokenMove(spaces);
                }
                //    _currentPlayer = _currentPlayer + 1 > _players.Count() - 1 ? 0 : _currentPlayer + 1;
                //}
                return square;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Move the token the spaces number indicated for the current player.
        /// </summary>
        /// <param name="player">Number of player.</param>
        /// <param name="spaces">Number of spaces, die value.</param>
        /// <returns>Number of square.</returns>
        public int MoveTokenCurrentPlayer(int spaces)
        {
            try
            {
                int square = GetPlayerSquare(_currentPlayer);
                if (square + spaces <= Constants.MAX_VALUE)
                {
                    square = _players.ElementAt(_currentPlayer).TokenMove(spaces);
                }
                _currentPlayer = _currentPlayer + 1 > _players.Count() - 1 ? 0 : _currentPlayer + 1;
                return square;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Move the token to at square.
        /// </summary>
        /// <param name="player">Number of player.</param>
        /// <param name="square">Number of square.</param>
        public void MoveTokenPlayerSquare(int player, int square)
        {
            try
            {
                _players.ElementAt(player).SetSquareToken(square);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Number of the current player.
        /// </summary>
        /// <returns></returns>
        public int CurrentPlayer()
        {
            return _currentPlayer;
        }

        /// <summary>
        /// If the player is the winner.
        /// </summary>
        /// <param name="player">Number of player</param>
        /// <returns>If the player is the winner.</returns>
        public bool IsPlayerWinner(int player)
        {
            try
            {
                return _players.ElementAt(player).IsWinner();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get the board of game.
        /// </summary>
        /// <returns>Matrix that represent the board.</returns>
        public int[,] GetBoard()
        {
            return _board.GetBoard();
        }

        /// <summary>
        /// Dice roll.
        /// </summary>
        /// <returns>Number between 1 and 6.</returns>
        public int DiceRoll()
        {
            return _die.Roll();
        }
        #endregion

        #region PrivateMethods
        public void PutPlayersInBoard(int numberPlayers)
        {
            try
            {
                while (numberPlayers > 0)
                {
                    _players.Add(new Player(_board));
                    numberPlayers--;
                };

                _currentPlayer = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
