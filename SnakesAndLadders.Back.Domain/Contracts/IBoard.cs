namespace SnakesAndLadders.Back.Domain.Contracts
{
    /// <summary>
    /// Interface IBoard.
    /// Board used in the game, represented by a matrix.
    /// </summary>
    public interface IBoard
    {
        #region Methods
        /// <summary>
        /// Get the board of game.
        /// </summary>
        /// <returns>Matrix that represent the board.</returns>
        int[,] GetBoard();

        /// <summary>
        /// Get the value of the square by coordinate.
        /// </summary>
        /// <param name="i">Row</param>
        /// <param name="j">Col</param>
        /// <returns>Value number of the square or null if the coordinate not exists in the board.</returns>
        int? GetValueBoard(int i, int j);

        /// <summary>
        /// Get the coordinate of the value of the square.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Coordinate, row and col, of the value or null if the value not in the board.</returns>
        int[] GetPositionBoard(int value);
        #endregion
    }
}
