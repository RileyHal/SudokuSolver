using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Board
    {
        private int[] board;

        public Board(int[] board) {
            this.board = board;
        }

        public void printBoard()
        {
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < 81; i++)
            {
                if (this.board[i] != -1)
                {
                    Console.Write(" ");
                }

                Console.Write(this.board[i] + " ");
                if ((i + 1) % 3 == 0)
                {
                    Console.Write(" | ");
                }

                if ((i + 1) % 9 == 0)
                {
                    Console.Write("\n");
                }

                if ((i + 1) % 27 == 0)
                {
                    Console.WriteLine("-----------------------------------");
                }
            }
        }

        public List<int> getSquare(decimal xCoord, decimal yCoord)
        {
            List<int> square = new List<int>();
            int xSquareCoord, ySquareCoord;

            //get starting positions for both the x and y axis
            int xStartPos = (int)Math.Floor((xCoord / 3) % 3) * 3;
            int yStartPos = (int)Math.Floor((yCoord / 3) % 3) * 3;

            //starting position in array = yStartPosition * 9 + xStartPos
            int arrayPos = (yStartPos * 9) + xStartPos;

            for (int i = 0; i < 9; i++)
            {
                if (this.board[arrayPos] != -1) {
                    square.Add(this.board[arrayPos]);
                }
                if ((i + 1) % 3 == 0)
                {
                    arrayPos += 7;
                }
                else
                {
                    arrayPos += 1;
                }
            }
            return square;
        }

        public List<int> getColumn(int xCoord)
        {
            List<int> column = new List<int>();
            int arrayPos = xCoord;

            for (int i = 0; i < 9; i++)
            {
                if (this.board[arrayPos] != -1) {
                    column.Add(this.board[arrayPos]);
                }
                arrayPos += 9;
            }
            return column;
        }

        public List<int> getRow(int yCoord)
        {
            List<int> row = new List<int>();
            int arrayPos = yCoord * 9;

            for (int i = 0; i < 9; i++)
            {
                if (this.board[arrayPos] != -1) {
                    row.Add(this.board[arrayPos]);
                }
                arrayPos++;
            }
            return row;
        }

        public void setNum(int num, int xCoord, int yCoord) {
            int arrayPos = (yCoord * 9) + xCoord;
            this.board[arrayPos] = num;
        }

        //checks to see if an element at xy position is empty
        public Boolean isEmpty(int xCoord, int yCoord) {
            int arrayPos = (yCoord * 9) + xCoord;
            if (this.board[arrayPos] == -1) {
                return true;
            }
            return false;
        }

        //checks to see if the board is complete
        public Boolean isComplete() {
            if (this.board.Contains(-1)) {
                return false;
            }
            return true;
        }
    }
}
