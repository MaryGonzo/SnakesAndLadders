namespace SnakesAndLadders.Back.Infraestructura.Repositories
{
    /// <summary>
    /// Class Dice.
    /// Dice for roll in the game.
    /// </summary>
    public class Dice : IDice
    {
        #region Properties
        /// <summary>
        /// Random for the roll.
        /// </summary>
        private readonly Random _random;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor.
        /// Initializer the properties.
        /// </summary>
        public Dice()
        {
            _random = new Random();
        }
        #endregion

        #region PublicMethods
        /// <summary>
        /// Dice roll.
        /// </summary>
        /// <returns>Number between 1 and 6.</returns>
        public int Roll()
        {
            return _random.Next(Constants.MINIMUN_DIE_VALUE, Constants.MAXIMUN_DIE_VALUE + 1);
        }
        #endregion
    }
}
