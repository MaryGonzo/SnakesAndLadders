namespace SnakesAndLadders.Back.Domain.Contracts
{
    /// <summary>
    /// Interface IDice.
    /// Dice for roll in the game.
    /// </summary>
    public interface IDice
    {
        #region Methods
        /// <summary>
        /// Dice roll.
        /// </summary>
        /// <returns>Number between 1 and 6.</returns>
        int Roll();
        #endregion
    }
}
