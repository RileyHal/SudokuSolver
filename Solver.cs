using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Solver{
        Board board;
        public Solver(Board board) {
            this.board = board;
        }

        //this method of solving goes through each empty square and tests if only 1 number can go there,
        //if so then set the number and scan the entire board again and repeat until board is full
        public void SolveLogic() {
            //the main loop for the brute algorithm
            Boolean solved = false;
            printBoard();
            while (!solved) {
                solved = checkBoard();
            }
        }

        //this method will do the testing and setting of the numbers
        public Boolean checkBoard() {

            //create a matrix that is 81 long for all indices, and 10 deep for nums 0-9
            int[,] possibleSolutions = new int[81,10];

            //this will store all values that are in the square, column, and row of any given index position
            List<int> tempValues;

            //fill the possibleSolutions matrix
            for (int x = 0; x < 9; x++) {
                for (int y = 0; y < 9; y++) {
                    if (this.board.isEmpty(x, y))
                    {
                        //check row given y value
                        List<int> rowValues = this.board.getRow(y);

                        //check column given x value
                        List<int> colValues = this.board.getColumn(x);

                        //check the square values given x and y
                        List<int> squareValues = this.board.getSquare(x, y);

                        //combine them all using union
                        tempValues = rowValues.Union(colValues).Union(squareValues).ToList();

                        //if -1 is a value in the list then remove it
                        if (tempValues.Contains(-1)) { tempValues.Remove(-1); }

                        //if there are 9 values then there is only 1 possible solution, 0-9 = 10 nums
                        if (tempValues.Count == 8)
                        {
                            //search the list for the missing value 0-9
                            for (int i = 1; i < 10; i++)
                            {
                                //set the missing value at xy coordinate
                                if (!tempValues.Contains(i))
                                {
                                    Console.WriteLine("Found missing num " + i + " at coordinate x: " + x + ", y: " + y);
                                    this.board.setNum(i, x, y);
                                }
                            }
                        }
                    }
                }
            }
            //Console.WriteLine("After");
            printBoard();
            //Console.WriteLine(this.board.isComplete());

            return this.board.isComplete();
        }

        public void printBoard() { this.board.printBoard(); }
    }
}
