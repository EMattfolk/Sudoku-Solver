using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Sudoku
    {
        private List<int>[] possibilities;
        private int numbers_left;
        private int[] board;
        private int[][] row_indexes, col_indexes, box_indexes;

        public Sudoku(int[] board)
        {
            create_indexes();
            possibilities = new List<int>[81];
            numbers_left = 81;
            this.board = board;
            for (int i = 0; i < 81; i++)
            {
                if (board[i] == 0) //add empty indexes to possibilities
                {
                    possibilities[i] = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                }
            }
            for (int i = 0; i < 81; i++)
            {
                if (board[i] != 0)
                {
                    simple_remove_possibilities(board[i], i);
                    numbers_left--;
                }
            }
        }

        public void Solve () //solves the Sudoku
        {
            while (numbers_left > 0)
            {
                lone_possibility_check();
                lone_in_region_check(row_indexes);
                lone_in_region_check(col_indexes);
                lone_in_region_check(box_indexes);
            }
        }

        private void simple_remove_possibilities(int n, int index) //removes the number n from the possibilities within the column, row and box.
        {
            int row = row_number(index), col = col_number(index), box = box_number(index);
            for (int i = 0; i < 9; i++)
            {
                if (board[row_indexes[row][i]] == 0) { possibilities[row_indexes[row][i]].Remove(n); }
                if (board[col_indexes[col][i]] == 0) { possibilities[col_indexes[col][i]].Remove(n); }
                if (board[box_indexes[box][i]] == 0) { possibilities[box_indexes[box][i]].Remove(n); }
            }
        }

        private void lone_possibility_check () //finds indexes with possibilities of length 1
        {
            for (int i = 0; i < 81; i++)
            {
                if (board[i] == 0)
                {
                    if (possibilities[i].Count == 1) { found_at(possibilities[i][0], i); }
                }
            }
        }

        private void lone_in_region_check (int [][] container) //finds lone possibilities in a container
        {
            List<int> possibility_counter;
            foreach (int[] region in container)
            {
                possibility_counter = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (int i in region)
                {
                    if (board[i] == 0)
                    {
                        foreach (int n in possibilities[i])
                        {
                            possibility_counter[n]++;
                        }
                    }
                }
                for (int n = 1; n < 10; n++)
                {
                    if (possibility_counter[n] == 1)
                    {
                        foreach (int i in region)
                        {
                            if (board[i] == 0 && possibilities[i].Contains(n))
                            {
                                found_at(n, i);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void found_at (int number, int index) //use when a number is found
        {
            board[index] = number;
            possibilities[index] = null;
            simple_remove_possibilities(number, index);
            numbers_left--;
        }

        private int row_number(int index)
        {
            return index / 9;
        }

        private int col_number(int index)
        {
            return index % 9;
        }

        private int box_number(int index)
        {
            return 3 * (index / 27) + (index % 9) / 3;
        }

        private void create_indexes()
        {
            row_indexes = new int[9][];
            col_indexes = new int[9][];
            box_indexes = new int[9][];
            for (int i = 0; i < 9; i++)
            {
                row_indexes[i] = new int[9];
                col_indexes[i] = new int[9];
                for (int j = 0; j < 9; j++)
                {
                    row_indexes[i][j] = i * 9 + j;
                    col_indexes[i][j] = i + 9 * j;
                }
                int box_row = i / 3;
                int box_col = i % 3;
                int[] temp = new int[] { box_row * 27 + box_col * 3, box_row * 27 + box_col * 3 + 9, box_row * 27 + box_col * 3 + 18 };
                box_indexes[i] = new int[] { temp[0], temp[0] + 1, temp[0] + 2, temp[1], temp[1] + 1, temp[1] + 2, temp[2], temp[2] + 1, temp[2] + 2 };
            }
        }

        public int[] Board
        {
            get { return board; }
        }
    }
}
