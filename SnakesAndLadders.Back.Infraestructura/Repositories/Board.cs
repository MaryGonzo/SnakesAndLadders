namespace SnakesAndLadders.Back.Infraestructura.Repositories
{
    /// <summary>
    /// Class Board.
    /// Board used in the game, represented by a matrix.
    /// </summary>
    public class Board : IBoard
    {
        #region Properties
        /// <summary>
        /// Matrix that represent the board.
        /// </summary>
        private static int[,] _squares;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor.
        /// Initialize the board.
        /// </summary>
        public Board()
        {
            InitializeBoard();
        }
        #endregion

        #region PublicMethods
        /// <summary>
        /// Get the board of game.
        /// </summary>
        /// <returns>Matrix that represent the board.</returns>
        public int[,] GetBoard()
        {
            return _squares;
        }

        /// <summary>
        /// Get the value of the square by coordinate.
        /// </summary>
        /// <param name="i">Row</param>
        /// <param name="j">Col</param>
        /// <returns>Value number of the square or null if the coordinate not exists in the board.</returns>
        public int? GetValueBoard(int i, int j)
        {
            try
            {
                if (i > Constants.ROWS || j > Constants.COLS)
                {
                    return null;
                }
                else
                {
                    return _squares[i, j];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get the coordinate of the value of the square.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Coordinate, row and col, of the value or null if the value not in the board.</returns>
        public int[] GetPositionBoard(int value)
        {
            int[] position = null;

            try
            {
                if (value > 0 && value <= Constants.MAX_VALUE)
                {
                    position = new int[2];

                    int rowLength = _squares.GetLength(0);
                    int colLength = _squares.GetLength(1);

                    //Rows
                    for (int i = 0; i < rowLength; i++)
                    {
                        //Cols
                        for (int j = 0; j < colLength; j++)
                        {
                            if (GetValueBoard(i, j) == value)
                            {
                                position = new int[2] { i, j };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return position;
        }
        #endregion

        #region PrivateMethods
        /// <summary>
        /// Initializer the board, size and fill the values.
        /// </summary>
        private void InitializeBoard()
        {
            try
            {
                _squares = new int[Constants.ROWS, Constants.COLS];

                int rowLength = _squares.GetLength(0);
                int colLength = _squares.GetLength(1);

                var value = Constants.MAX_VALUE;

                //Rows
                for (int i = 0; i < rowLength; i++)
                {
                    if (i != 0)
                    {
                        if (i % 2 == 0)
                        {
                            value -= Constants.ROWS + 1;
                        }
                        else
                        {
                            value -= Constants.COLS - 1;
                        }
                    }

                    //Cols
                    for (int j = 0; j < colLength; j++)
                    {
                        if (i % 2 == 0)
                        {
                            _squares.SetValue(value--, new[] { i, j });
                        }
                        else
                        {
                            _squares.SetValue(value++, new[] { i, j });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}