using SnakesAndLadders.Back.Infraestructura.Repositories;

namespace SnakesAndLadders.TestGame
{
    [TestFixture, Description("US2-Player Can Win the Game: As a player, I want to be able to win the game, so that I can gloat to everyone around.")]
    public class PlayerWinGame
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
        [Test, Description("US2-UAT1: Given the token is on square 97, when the token is moved 3 spaces, then the token is on square 100, and the player has won the game.")]
        public void ExactNumberToWin(int player)
        {
            const int STARTED_SQUARE = 97;
            const int ROLL = 3;
            const int CURRENT_SQUARE = 100;

            _game.MoveTokenPlayerSquare(player, STARTED_SQUARE);

            int currentSquare = _game.GetPlayerSquare(player);
            _game.MoveTokenPlayer(player, ROLL);

            int newSquare = _game.GetPlayerSquare(player);

            Assert.That(currentSquare, Is.EqualTo(STARTED_SQUARE));
            Assert.That(newSquare, Is.EqualTo(CURRENT_SQUARE));
            Assert.IsTrue(_game.IsPlayerWinner(player));
        }

        [TestCase(0)]
        [TestCase(1)]
        [Test, Description("US2-UAT2: Given the token is on square 97, when the token is moved 4 spaces, then the token is on square 97, and the player has not won the game.")]
        public void StayPlace(int player)
        {
            const int STARTED_SQUARE = 97;
            const int ROLL = 4;
            const int CURRENT_SQUARE = 97;

            _game.MoveTokenPlayerSquare(player, STARTED_SQUARE);

            int currentSquare = _game.GetPlayerSquare(player);
            _game.MoveTokenPlayer(player, ROLL);

            int newSquare = _game.GetPlayerSquare(player);

            Assert.That(currentSquare, Is.EqualTo(STARTED_SQUARE));
            Assert.That(newSquare, Is.EqualTo(CURRENT_SQUARE));
            Assert.IsFalse(_game.IsPlayerWinner(player));
        }
    }
}
