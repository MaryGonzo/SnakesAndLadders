namespace SnakesAndLadders.Back.Domain.Constants
{
    /// <summary>
    /// Class Constants.
    /// </summary>
    public static class Constants
    {
        #region Properties
            #region Board
            /// <summary>
            /// Number of rows.
            /// </summary>
            public const int ROWS = 10;
            /// <summary>
            /// Number of columns.
            /// </summary>
            public const int COLS = 10;
            /// <summary>
            /// Value of the last square.
            /// </summary>
            public const int MAX_VALUE = 100;
            #endregion

            #region Dice
            /// <summary>
            /// Minimum dce value.
            /// </summary>
            public const int MINIMUN_DIE_VALUE = 1;
            /// <summary>
            /// Maximun die value.
            /// </summary>
            public const int MAXIMUN_DIE_VALUE = 6;
            #endregion
        #endregion
    }
}
