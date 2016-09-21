using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManaBoardGame;

namespace GameTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInitialization()
        {
            Game game = new Game();
            game.Initialize();

        }

        [TestMethod]
        public void TestPlayerInteraction()
        {
            Game game = new Game();
            int currentPlayer = game.GetCurrentPlayer();
            int expectedPlayer = 1;
            Assert.AreEqual(currentPlayer, expectedPlayer);

 

        }

        [TestMethod]
        public void TestGameplay()
        {
            Game game = new Game();
            int currentPlayer = game.GetCurrentPlayer();
            int startX = 0, startY = 0, endX = 0, endY = 0;

            int expectedPlayer = 1;
            Assert.AreEqual(currentPlayer, expectedPlayer);
            try
            {
                game.MoveTo(currentPlayer, startX, startY, endX, endY);

            }
            catch(IllegalMoveException e)
            {
                Assert.Fail(e.Message);
            }
            
        }
    }
}
