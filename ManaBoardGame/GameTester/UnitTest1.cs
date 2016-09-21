using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManaBoardGame;
using System.Diagnostics;

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
            int currentPlayer = game.CurrentPlayer;
            int expectedPlayer = 1;
            Assert.AreEqual(currentPlayer, expectedPlayer);

 

        }

        [TestMethod]
        public void TestGameplay()
        {
            Game game = new Game();
            int currentPlayer = game.CurrentPlayer;
            int startX = 0, startY = 0, endX = 0, endY = 0;

            int expectedPlayer = 1;
            Assert.AreEqual(currentPlayer, expectedPlayer);
            //Test for normal input
            try
            {
                game.MoveTo(currentPlayer, startX, startY, endX, endY);

            }
            catch(Exception e)
            {
                Assert.Fail("Normal Input Testins: "+e.Message);
            }
            //Test for out of range input for player
            try
            {
                game.MoveTo(3, 0, 0, 0, 0);
                Assert.Fail("Player 3 is not valid input");
            }
            catch(ArgumentOutOfRangeException e) { }

            //Test for out of range input for player
            try
            {
                game.MoveTo(-1, 0, 0, 0, 0);
                Assert.Fail("Player -1 is not valid input");
            }
            catch (ArgumentOutOfRangeException e) { }


            //Test for out of range input for coords
            try
            {
                game.MoveTo(1, 0, 0, 0, 6);
                Assert.Fail("6 is an invalid coord value");
            }
            catch (ArgumentOutOfRangeException e) { }


            //Test for out of range input for coords
            try
            {
                game.MoveTo(1, 0, 0, 0, -1);
                Assert.Fail("-1 is an invalid coord value");
            }
            catch (ArgumentOutOfRangeException e) { }



        }

        [TestMethod]
        public void TestBoard()
        {
            Game game = new Game();
            int[,] expectedBoard = new int[,] {
                {2,2,3,1,2,2},
                {1,3,1,3,1,3},
                {3,1,2,2,3,1},
                {2,3,1,3,1,2},
                {2,1,3,1,3,2},
                {1,3,2,2,1,3} };
            CollectionAssert.AreEqual(expectedBoard, game.Board);
            game.RotateBoard();
            expectedBoard = new int[,] {
                {1,2,2,3,1,2},
                {3,1,3,1,3,2},
                {2,3,1,2,1,3},
                {2,1,3,2,3,1},
                {1,3,1,3,1,2},
                {3,2,2,1,3,2} };

            CollectionAssert.AreEqual(expectedBoard, game.Board);

        }
    }
}
