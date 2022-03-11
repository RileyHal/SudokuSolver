// See https://aka.ms/new-console-template for more information

namespace SudokuSolver {
    public class Solution {
        static void Main(string[] args)
        {
            int[] testBoard = new int[81] {
             4, 2, 7, 5, 6, 8, 1, 9, 3,
            -1, 8,-1,-1,-1, 7, 5,-1, 4,
            -1, 1, 5, 3, 4,-1,-1,-1, 7,
             1,-1,-1, 6,-1, 5, 7, 4,-1,
             5,-1, 8, 7, 3, 4, 6, 1, 2,
             7,-1, 4, 2,-1,-1, 3, 5, 8,
            -1, 4, 9,-1,-1, 1,-1, 7, 6,
             8,-1, 1, 9,-1, 6, 4, 3, 5,
            -1,-1, 6, 4, 7, 3, 9, 8,-1
            };

            Solver solver = new Solver(new Board(testBoard));
            solver.SolveLogic();
        }
    }
    
}
