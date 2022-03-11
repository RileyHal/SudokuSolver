// See https://aka.ms/new-console-template for more information

namespace SudokuSolver {
    public class Solution {
        static void Main(string[] args)
        {
            //empty values are represented by -1
            int[] testBoard = new int[81] {
            -1, 2, 7, 5, 6, 8, 1,-1, 3,
            -1, 8,-1,-1,-1, 7,-1,-1, 4,
            -1, 1, 5,-1, 4,-1,-1,-1, 7,
             1,-1,-1, 6,-1,-1, 7, 4,-1,
             5,-1,-1,-1,-1, 4,-1, 1, 2,
             7,-1, 4, 2,-1,-1, 3,-1,-1,
            -1, 4,-1,-1,-1, 1,-1, 7,-1,
             8,-1, 1,-1,-1, 6,-1, 3, 5,
            -1,-1, 6, 4, 7,-1, 9,-1,-1
            };

            Solver solver = new Solver(new Board(testBoard));
            solver.SolveLogic();
        }
    }
    
}
