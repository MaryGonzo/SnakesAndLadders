namespace SnakesAndLadders.Back.Domain.Contracts
{
    /// <summary>
    /// Interface IToken.
    /// Token for move in the board.
    /// </summary>
    public interface IToken
    {
        #region Methods
        /// <summary>
        /// Get the coordinate of token.
        /// </summary>
        /// <returns>Coordinate, row and col.</returns>
        int[] GetPosition();

        /// <summary>
        /// Move the token to new square by coordinate.
        /// </summary>
        /// <param name="position">Coordinate, row and col.</param>
        void SetPosition(int[] position);
        #endregion
    }
}
