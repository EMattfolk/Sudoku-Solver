using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Sudoku
    {
        private List<int> board_list;
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
            int old_numbers_left = int.MaxValue;
            while (numbers_left < old_numbers_left)
            {
                old_numbers_left = numbers_left;
                lone_possibility_check();
                lone_in_region_check(row_indexes);
                lone_in_region_check(col_indexes);
                lone_in_region_check(box_indexes);
            }
            if (numbers_left != 0)
            {
                board_list = board.ToList();
                brute_force();
            }
        }

        private void simple_remove_possibilities(int number, int index) //removes the number n from the possibilities within the column, row and box.
        {
            int row = row_number(index), col = col_number(index), box = box_number(index);
            for (int i = 0; i < 9; i++)
            {
                if (board[row_indexes[row][i]] == 0) { possibilities[row_indexes[row][i]].Remove(number); }
                if (board[col_indexes[col][i]] == 0) { possibilities[col_indexes[col][i]].Remove(number); }
                if (board[box_indexes[box][i]] == 0) { possibilities[box_indexes[box][i]].Remove(number); }
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

        private bool brute_force () //find solution through brute force. requires board_list to be initialized
        {
            if (board_list.Contains(0))
            {
                int index = board_list.IndexOf(0);
                foreach (int number in possibilities[index])
                {
                    if (is_legal(number, index))
                    {
                        board_list[index] = number;
                        if (brute_force())
                        {
                            return true;
                        }
                    }
                }
                board_list[index] = 0;
                return false;
            }
            else
            {
                board = board_list.ToArray();
                return true;
            }
        }

        private bool is_legal (int number, int index) //check if number can be placed at index. requires board_list
        {
            int row = row_number(index), col = col_number(index), box = box_number(index);
            for (int i = 0; i < 9; i++)
            {
                if (board_list[row_indexes[row][i]] == number) { return false; }
                if (board_list[col_indexes[col][i]] == number) { return false; }
                if (board_list[box_indexes[box][i]] == number) { return false; }
            }
            return true;
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
