using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form : System.Windows.Forms.Form
    {
        private MaskedTextBox[] number_boxes;

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            number_boxes = new MaskedTextBox[81];
            for (int i = 0; i < 81; i++)
            {
                number_boxes[i] = new MaskedTextBox("0");
                number_boxes[i].Name = "Box" + i.ToString();
                number_boxes[i].TextAlign = HorizontalAlignment.Center;
                number_boxes[i].Click += new EventHandler(remove_text);
                number_boxes[i].PromptChar = ' ';
                tableLayoutPanel1.Controls.Add(number_boxes[i], i%9, i/9);
            }
        }

        private void remove_text (object sender, EventArgs e)
        {
            ((MaskedTextBox)sender).Text = "";
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            int[] board = new int[81];
            for (int i = 0; i < 81; i++)
            {
                if (number_boxes[i].Text != "")
                {
                    board[i] = int.Parse(number_boxes[i].Text);
                }
            }
            Sudoku sudoku = new Sudoku(board);
            sudoku.Solve();
            board = sudoku.Board;
            for (int i = 0; i < 81; i++)
            {
                number_boxes[i].Text = board[i] == 0 ? "" : board[i].ToString();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 81; i++)
            {
                number_boxes[i].Text = "";
            }
        }
    }
}
