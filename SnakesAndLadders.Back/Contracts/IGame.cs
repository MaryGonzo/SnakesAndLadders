namespace SnakesAndLadders.Back.Contracts
{
    /// <summary>
    /// Interface IGame.
    /// Management the game.
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// Get the number of square where the player stay.
        /// </summary>
        /// <param name="player">Number of player.</param>
        /// <returns>Number of square.</returns>
        int GetPlayerSquare(int player);

        /// <summary>
        /// Move the token the spaces number indicated.
        /// </summary>
        /// <param name="player">Number of player.</param>
        /// <param name="spaces">Number of spaces, die value.</param>
        /// <returns>Number of square.</returns>
        int MoveTokenPlayer(int player, int spaces);

        /// <summary>
        /// Move the token the spaces number indicated for the current player.
        /// </summary>
        /// <param name="player">Number of player.</param>
        /// <param name="spaces">Number of spaces, die value.</param>
        /// <returns>Number of square.</returns>
        int MoveTokenCurrentPlayer(int spaces);

        /// <summary>
        /// Move the token to at square.
        /// </summary>
        /// <param name="player">Number of player.</param>
        /// <param name="square">Number of square.</param>
        void MoveTokenPlayerSquare(int player, int square);

        /// <summary>
        /// Number of the current player.
        /// </summary>
        /// <returns></returns>
        int CurrentPlayer();

        /// <summary>
        /// If the player is the winner.
        /// </summary>
        /// <param name="player">Number of player</param>
        /// <returns>If the player is the winner.</returns>
        bool IsPlayerWinner(int player);

        /// <summary>
        /// Get the board of game.
        /// </summary>
        /// <returns>Matrix that represent the board.</returns>
        int[,] GetBoard();

        /// <summary>
        /// Dice roll.
        /// </summary>
        /// <returns>Number between 1 and 6.</returns>
        int DiceRoll();
    }
}
