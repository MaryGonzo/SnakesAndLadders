namespace SnakesAndLadders.Back.Infraestructura.Repositories
{
    /// <summary>
    /// Class Player.
    /// Move the token by the board depend value dice result.
    /// </summary>
    public class Player : IPlayer
    {
        #region Properties
        /// <summary>
        /// Token of the player.
        /// </summary>
        private IToken _token { get; set; }
        /// <summary>
        /// Game board.
        /// </summary>
        private readonly IBoard _board;
        /// <summary>
        /// Indicate is player is the winner.
        /// </summary>
        private bool _isWinner { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor.
        /// Put the token in start square.
        /// </summary>
        public Player(IBoard board)
        {
            _token = new Token();
            _board = board;
            _isWinner = false;
            SetSquareToken(1);
        }
        #endregion

        #region PublicMethods
        /// <summary>
        /// Move the token the spaces number indicated.
        /// </summary>
        /// <param name="spaces">Number of spaces, die value.</param>
        /// <param name="board">Board.</param>
        /// <returns>Number of square.</returns>
        public int TokenMove(int spaces)
        {
            int newCurrentValue = 0;

            try
            {
                int? currentValue = GetSquareToken();

                int? nexValue = currentValue.HasValue ? currentValue.Value + spaces : null;

                if (nexValue.HasValue)
                {
                    SetSquareToken(nexValue.Value);
                    int newValue = GetSquareToken();

                    newCurrentValue = newValue;
                }
                else
                {
                    newCurrentValue = currentValue.Value;
                }

                _isWinner = newCurrentValue == Constants.MAX_VALUE ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return newCurrentValue;
        }

        /// <summary>
        /// Get the square of token.
        /// </summary>
        /// <param name="board">Board.</param>
        /// <returns>Number of square</returns>
        public int GetSquareToken()
        {
            int currentValue = 0;

            try
            {
                int[] currentPosition = _token.GetPosition();
                currentValue = _board.GetValueBoard(currentPosition[0], currentPosition[1]).Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return currentValue;
        }

        /// <summary>
        /// Move the token to new number of square.
        /// </summary>
        /// <param name="square">Number of square</param>
        /// <param name="board">Board</param>
        public void SetSquareToken(int square)
        {
            try
            {
                int[] newPosition = _board.GetPositionBoard(square);
                _token.SetPosition(newPosition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Check if player is winner.
        /// </summary>
        /// <returns></returns>
        public bool IsWinner()
        {
            return _isWinner;
        }
        #endregion
    }
}
