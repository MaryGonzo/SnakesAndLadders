namespace SnakesAndLadders.TestGame
{
    [TestFixture, Description("US3-Moves Are Determined By Dice Rolls: As a player, I want to move my token based on the roll of a die, so that there is an element of chance in the game.")]
    public class DiceRoll
    {
        #region Properties
        private IDice _die;
        private IBoard _board;
        private IPlayer _player;
        #endregion

        [SetUp]
        public void Setup()
        {
            _die = new Dice();
            _board = new Board();
            _player = new Player(_board);
        }

        [Test, Description("US3-UAT1: Given the game is started, when the player rolls a die, then the result should be between 1-6 inclusive.")]
        public void ResultDice()
        {
            const int MIN_RESULT = 1;
            const int MAX_RESULT = 6;

            int resultado;

            for (int i = 0; i < 100; i++)
            {
                resultado = _die.Roll();
                Assert.GreaterOrEqual(resultado, MIN_RESULT);
                Assert.LessOrEqual(resultado, MAX_RESULT);
            }
        }

        [Test, Description("US3-UAT2: Given the player rolls a 4, when they move their token, then the token should move 4 spaces.")]
        public void MoveDiceResult()
        {
            const int ROLL = 4;

            int currentSquare = _player.GetSquareToken();

            _player.TokenMove(ROLL);

            int newSquare = _player.GetSquareToken();

            Assert.IsTrue(currentSquare + ROLL == newSquare);
        }
    }
}