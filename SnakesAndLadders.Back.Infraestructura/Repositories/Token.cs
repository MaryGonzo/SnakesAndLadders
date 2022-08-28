namespace SnakesAndLadders.Back.Infraestructura.Repositories
{
    /// <summary>
    /// Class Token.
    /// Token for move in the board.
    /// </summary>
    public class Token: IToken
    {
        #region Properties
        /// <summary>
        /// Coordinate
        /// </summary>
        private int[] _position;
        #endregion

        #region PublicMethods
        /// <summary>
        /// Get the coordinate of token.
        /// </summary>
        /// <returns>Coordinate, row and col.</returns>
        public int[] GetPosition()
        {
            return _position;
        }

        /// <summary>
        /// Move the token to new square by coordinate.
        /// </summary>
        /// <param name="position">Coordinate, row and col.</param>
        public void SetPosition(int[] position)
        {
            _position = position;
        }
        #endregion
    }
}
