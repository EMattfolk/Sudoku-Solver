namespace Sudoku
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.horizline1 = new System.Windows.Forms.Label();
            this.horizline2 = new System.Windows.Forms.Label();
            this.verticalline1 = new System.Windows.Forms.Label();
            this.verticalline2 = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 252);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // horizline1
            // 
            this.horizline1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.horizline1.Location = new System.Drawing.Point(4, 86);
            this.horizline1.Name = "horizline1";
            this.horizline1.Size = new System.Drawing.Size(252, 2);
            this.horizline1.TabIndex = 1;
            // 
            // horizline2
            // 
            this.horizline2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.horizline2.Location = new System.Drawing.Point(4, 170);
            this.horizline2.Name = "horizline2";
            this.horizline2.Size = new System.Drawing.Size(252, 2);
            this.horizline2.TabIndex = 2;
            // 
            // verticalline1
            // 
            this.verticalline1.BackColor = System.Drawing.SystemColors.Control;
            this.verticalline1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verticalline1.Location = new System.Drawing.Point(87, 4);
            this.verticalline1.Name = "verticalline1";
            this.verticalline1.Size = new System.Drawing.Size(2, 252);
            this.verticalline1.TabIndex = 3;
            // 
            // verticalline2
            // 
            this.verticalline2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verticalline2.Location = new System.Drawing.Point(171, 4);
            this.verticalline2.Name = "verticalline2";
            this.verticalline2.Size = new System.Drawing.Size(2, 252);
            this.verticalline2.TabIndex = 4;
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(44, 283);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(86, 23);
            this.solveButton.TabIndex = 5;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(136, 283);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 336);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.verticalline2);
            this.Controls.Add(this.verticalline1);
            this.Controls.Add(this.horizline2);
            this.Controls.Add(this.horizline1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form";
            this.Text = "Sudoku Solver";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label horizline1;
        private System.Windows.Forms.Label horizline2;
        private System.Windows.Forms.Label verticalline1;
        private System.Windows.Forms.Label verticalline2;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Button resetButton;
    }
}

