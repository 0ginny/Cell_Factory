namespace test_base.Properties
{
    partial class Product
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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            panel1 = new Panel();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label10 = new Label();
            label11 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1720, 1040);
            splitContainer1.SplitterDistance = 134;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(panel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button3);
            splitContainer2.Size = new Size(1720, 134);
            splitContainer2.SplitterDistance = 1414;
            splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 128);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(60, 78, 113);
            button2.Location = new Point(1590, 75);
            button2.Name = "button2";
            button2.Size = new Size(86, 28);
            button2.TabIndex = 4;
            button2.Text = "검색";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(134, 139, 150);
            label3.Location = new Point(203, 36);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "LOT 검색";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 87);
            label2.Name = "label2";
            label2.Size = new Size(212, 15);
            label2.TabIndex = 1;
            label2.Text = "오늘 날자 표시 예시 2024년 1월 12일";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(60, 78, 113);
            button1.Location = new Point(20, 79);
            button1.Name = "button1";
            button1.Size = new Size(86, 28);
            button1.TabIndex = 0;
            button1.Text = "Today";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 0;
            label1.Text = "ProductData";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(60, 78, 113);
            button3.Location = new Point(196, 82);
            button3.Name = "button3";
            button3.Size = new Size(86, 28);
            button3.TabIndex = 2;
            button3.Text = "검색";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(23, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1677, 879);
            panel2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1048, 61);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(608, 798);
            dataGridView2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1005, 798);
            dataGridView1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.Location = new Point(24, 18);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 1;
            label5.Text = "Stacking List";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(23, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(484, 345);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Location = new Point(24, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(435, 232);
            panel4.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(190, 11);
            label10.Name = "label10";
            label10.Size = new Size(44, 30);
            label10.TabIndex = 17;
            label10.Text = "Jan";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label11.Location = new Point(240, 11);
            label11.Name = "label11";
            label11.Size = new Size(37, 30);
            label11.TabIndex = 16;
            label11.Text = "01";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(36, 61);
            label4.Name = "label4";
            label4.Size = new Size(31, 25);
            label4.TabIndex = 21;
            label4.Text = "일";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(96, 61);
            label6.Name = "label6";
            label6.Size = new Size(31, 25);
            label6.TabIndex = 22;
            label6.Text = "월";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(161, 61);
            label7.Name = "label7";
            label7.Size = new Size(31, 25);
            label7.TabIndex = 23;
            label7.Text = "화";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(229, 61);
            label8.Name = "label8";
            label8.Size = new Size(31, 25);
            label8.TabIndex = 24;
            label8.Text = "수";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(296, 61);
            label9.Name = "label9";
            label9.Size = new Size(31, 25);
            label9.TabIndex = 25;
            label9.Text = "목";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(361, 61);
            label12.Name = "label12";
            label12.Size = new Size(31, 25);
            label12.TabIndex = 26;
            label12.Text = "금";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(421, 61);
            label13.Name = "label13";
            label13.Size = new Size(31, 25);
            label13.TabIndex = 27;
            label13.Text = "토";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 238, 244);
            ClientSize = new Size(1720, 1040);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Product";
            Text = "x`";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Button button2;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label1;
        private SplitContainer splitContainer2;
        private Button button3;
        private Panel panel2;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Panel panel3;
        private Panel panel4;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label12;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
    }
}