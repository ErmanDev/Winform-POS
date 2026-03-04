namespace POS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(181, 153);
            button1.TabIndex = 0;
            button1.Text = "New Document";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(201, 3);
            button2.Name = "button2";
            button2.Size = new Size(182, 153);
            button2.TabIndex = 1;
            button2.Text = "Checkout";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(201, 162);
            button3.Name = "button3";
            button3.Size = new Size(182, 120);
            button3.TabIndex = 3;
            button3.Text = "Delete Document";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(3, 162);
            button4.Name = "button4";
            button4.Size = new Size(181, 120);
            button4.TabIndex = 2;
            button4.Text = "Print Document";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Location = new Point(201, 424);
            button5.Name = "button5";
            button5.Size = new Size(182, 153);
            button5.TabIndex = 7;
            button5.Text = "Set Document Percentage";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.Location = new Point(3, 424);
            button6.Name = "button6";
            button6.Size = new Size(181, 153);
            button6.TabIndex = 6;
            button6.Text = "Credit Sale";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaption;
            button7.Location = new Point(201, 288);
            button7.Name = "button7";
            button7.Size = new Size(182, 130);
            button7.TabIndex = 5;
            button7.Text = "Set Salesman";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaption;
            button8.Location = new Point(3, 288);
            button8.Name = "button8";
            button8.Size = new Size(181, 130);
            button8.TabIndex = 4;
            button8.Text = "Set Customize";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveCaption;
            button9.Location = new Point(201, 741);
            button9.Name = "button9";
            button9.Size = new Size(182, 153);
            button9.TabIndex = 11;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ActiveCaption;
            button10.Location = new Point(3, 741);
            button10.Name = "button10";
            button10.Size = new Size(181, 153);
            button10.TabIndex = 10;
            button10.Text = "Settings";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ActiveCaption;
            button11.Location = new Point(201, 583);
            button11.Name = "button11";
            button11.Size = new Size(182, 152);
            button11.TabIndex = 9;
            button11.Text = "Office Ticket";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ActiveCaption;
            button12.Location = new Point(3, 583);
            button12.Name = "button12";
            button12.Size = new Size(181, 152);
            button12.TabIndex = 8;
            button12.Text = "Set Discount Amount";
            button12.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button9, 1, 5);
            tableLayoutPanel1.Controls.Add(button11, 1, 4);
            tableLayoutPanel1.Controls.Add(button10, 0, 5);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button4, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 1, 1);
            tableLayoutPanel1.Controls.Add(button12, 0, 4);
            tableLayoutPanel1.Controls.Add(button8, 0, 2);
            tableLayoutPanel1.Controls.Add(button5, 1, 3);
            tableLayoutPanel1.Controls.Add(button7, 1, 2);
            tableLayoutPanel1.Controls.Add(button6, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(1036, 0);
            tableLayoutPanel1.Margin = new Padding(3, 3, 50, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(397, 1049);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1433, 1049);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
