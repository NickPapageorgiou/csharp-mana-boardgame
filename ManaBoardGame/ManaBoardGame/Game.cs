using System;

namespace ManaBoardGame
{
    public class Game
    {
        int[,] board;
        int currentPlayer = 1;
        public Game()
        {
            Initialize();

        }

        public void Initialize()
        {
            board = new int[,] {
                {2,2,3,1,2,2},
                {1,3,1,3,1,3},
                {3,1,2,2,3,1},
                {2,3,1,3,1,2},
                {2,1,3,1,3,2},
                {1,3,2,2,1,3} };

            currentPlayer = 1;
        }

        public int GetCurrentPlayer()
        {
            return currentPlayer;
        }
        /// <exception cref="IllegalMoveException">Performing an illegal action on the board.</exception>
        /// <exception cref="ArgumentException">Player must be 1 or 2. Move coords must be 0-5.</exception>
        public void MoveTo(int player, int startX, int startY, int endX, int endY) 
        {

            throw new IllegalMoveException();
            throw new ArgumentException();
        }
    }
}