using System;

namespace ManaBoardGame
{
    public class Game
    {
        private static int[,] defaultBoard = new int[,] {
                {2,2,3,1,2,2},
                {1,3,1,3,1,3},
                {3,1,2,2,3,1},
                {2,3,1,3,1,2},
                {2,1,3,1,3,2},
                {1,3,2,2,1,3} };

        private int[,] board;
        public int[,] Board
        {
            get
            {
                return board;
            }
        }
        private int currentPlayer = 1;

        public int CurrentPlayer
        {
            get
            {
                return currentPlayer;
            }
        }

        private int boardSize = 6;
        public int BoardSize
        {
            get
            {
                return boardSize;
            }
        }

        private Pawn[] whitePawn = new Pawn[6];
        private Pawn[] blackPawn = new Pawn[6];
        public Game()
        {
            Initialize();

        }

        public void Initialize()
        {
            board = defaultBoard;
        }


        /// <exception cref="IllegalMoveException">Performing an illegal action on the board.</exception>
        /// <exception cref="ArgumentException">Player must be 1 or 2. Move coords must be 0-5.</exception>
        public void MoveTo(int player, int startX, int startY, int endX, int endY) 
        {
            if (player < 1 || player > 2) throw new ArgumentOutOfRangeException("Player must be either 1 or 2");
            if (IllegalPosition(startX)  || IllegalPosition(endX) ||
                IllegalPosition(startY) || IllegalPosition(endY) ) throw new ArgumentOutOfRangeException("Move coords out of bounds");



            //throw new IllegalMoveException();
        }

        private bool IllegalPosition(int value)
        {
            if (value < 0 || value >= boardSize) return true;
            return false;
        }

        public void RotateBoard()
        {
            int[,] tempBoard = board;




            for(int i = 0; i<boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    board[i, j] = tempBoard[5- (boardSize - j - 1) ,i];

                }
            }
        }
    }
}