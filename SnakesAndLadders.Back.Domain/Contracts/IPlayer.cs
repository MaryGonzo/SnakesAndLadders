namespace SnakesAndLadders.Back.Domain.Contracts
{
    /// <summary>
    /// Interface Player.
    /// Move the token by the board depend value dice result.
    /// </summary>
    public interface IPlayer
    {
        #region Methods
        /// <summary>
        /// Move the token the spaces number indicated.
        /// </summary>
        /// <param name="spaces">Number of spaces, die value.</param>
        /// <param name="board">Board.</param>
        /// <returns>Number of square.</returns>
        int TokenMove(int spaces);

        /// <summary>
        /// Get the square of token.
        /// </summary>
        /// <param name="board">Board.</param>
        /// <returns>Number of square</returns>
        int GetSquareToken();

        /// <summary>
        /// Move the token to new number of square.
        /// </summary>
        /// <param name="square">Number of square</param>
        /// <param name="board">Board</param>
        void SetSquareToken(int square);

        /// <summary>
        /// Check if player is winner.
        /// </summary>
        /// <returns></returns>
        bool IsWinner();
        #endregion
    }
}
