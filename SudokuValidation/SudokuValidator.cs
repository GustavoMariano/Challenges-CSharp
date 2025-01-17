using System.Collections.Generic;

namespace SudokuValidation
{

    /*
     *Each row contains unique values from 1 to 9 (when filled).
     *Each column contains unique values from 1 to 9 (when filled).
     *Each 3x3 region contains unique values from 1 to 9 (when filled).
     *
     *Note: This applies to the current state. 
     */

    public class SudokuValidator
    {
        public static bool Validator(List<List<string>> sudoku)
        {
            HashSet<string>[] rows = new HashSet<string>[9];
            HashSet<string>[] cols = new HashSet<string>[9];
            HashSet<string>[] boxes = new HashSet<string>[9];

            for (int i = 0; i < 9; i++)
            {
                rows[i] = new HashSet<string>();
                cols[i] = new HashSet<string>();
                boxes[i] = new HashSet<string>();
            }

            for (int r = 0; sudoku.Count > r; r++)
                for (int c = 0; sudoku.Count > c; c++)
                {
                    string current = sudoku[r][c];

                    if (current == "")
                        continue;

                    int boxIndex = (r / 3) * 3 + c / 3;

                    if (rows[r].Contains(current) || cols[c].Contains(current) || boxes[boxIndex].Contains(current))
                        return false;

                    rows[r].Add(current);
                    cols[c].Add(current);
                    boxes[boxIndex].Add(current);
                }

            return true;
        }
    }
}
