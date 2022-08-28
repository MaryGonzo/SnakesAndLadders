namespace SnakesAndLadders.TestGame
{
    [TestFixture, Description("US1-Token Can Move Across the Board: As a player, I want to be able to move my token, so that I can get closer to the goal.")]
    public class MoveAcrossBoard
    {
        #region Properties
        private IGame _game;
        #endregion

        [SetUp]
        public void Setup()
        {
            _game = new Game(2);
        }

        [TestCase(0)]
        [TestCase(1)]
        [Test, Description("US1-UAT1: Given the game is started, when the token is placed on the board, then the token is on square 1.")]
        public void StartedPlace(int player)
        {
            const int STARTED_SQUARE = 1;

            int currentSquare = _game.GetPlayerSquare(player);

            Assert.That(currentSquare, Is.EqualTo(STARTED_SQUARE));
        }

        [TestCase(0)]
        [TestCase(1)]
        [Test, Description("US1-UAT2: Given the token is on square 1, when the token is moved 3 spaces, then the token is on square 4.")]
        public void TokenMoveSpaces(int player)
        {
            const int STARTED_SQUARE = 1;
            const int ROLL = 3;
            const int CURRENT_SQUARE = 4;

            int currentSquare = _game.GetPlayerSquare(player);

            _game.MoveTokenPlayer(player, ROLL);

            int newSquare = _game.GetPlayerSquare(player);

            Assert.That(currentSquare, Is.EqualTo(STARTED_SQUARE));
            Assert.That(newSquare, Is.EqualTo(CURRENT_SQUARE));
        }

        [TestCase(0)]
        [TestCase(1)]
        [Test, Description("US1-UAT3: Given the token is on square 1, when the token is moved 3 spaces, and then it is moved 4 spaces, then the token is on square 8.")]
        public void TokenPositionSquare(int player)
        {
            const int STARTED_SQUARE = 1;
            int[] ROLL = { 3, 4 };
            const int CURRENT_SQUARE = 8;

            int currentSquare = _game.GetPlayerSquare(player);

            foreach (int spaces in ROLL)
            {
                _game.MoveTokenPlayer(player, spaces);
            }

            int newSquare = _game.GetPlayerSquare(player);

            Assert.That(currentSquare, Is.EqualTo(STARTED_SQUARE));
            Assert.That(newSquare, Is.EqualTo(CURRENT_SQUARE));
        }
    }
}
