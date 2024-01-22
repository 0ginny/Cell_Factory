namespace test_base
{
    partial class Dashboard
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            circleProgressBar1 = new ReaLTaiizor.Controls.CircleProgressBar();
            label3 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            splitContainer2 = new SplitContainer();
            panel4 = new Panel();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            splitContainer3 = new SplitContainer();
            panel5 = new Panel();
            button4 = new Button();
            label5 = new Label();
            button1 = new Button();
            label9 = new Label();
            button3 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            panel6 = new Panel();
            dataGridView2 = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1720, 636);
            splitContainer1.SplitterDistance = 1033;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 20);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 596);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.실시간모니터링_그림;
            pictureBox1.Location = new Point(18, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(976, 521);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(18, 16);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 0;
            label1.Text = "실시간 모니터링";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.42085F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.57915F));
            tableLayoutPanel1.Size = new Size(683, 636);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(circleProgressBar1);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(20, 314);
            panel3.Margin = new Padding(20, 0, 20, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(643, 302);
            panel3.TabIndex = 3;
            // 
            // circleProgressBar1
            // 
            circleProgressBar1.BackColor = Color.White;
            circleProgressBar1.BackgroundImageLayout = ImageLayout.Center;
            circleProgressBar1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            circleProgressBar1.ForeColor = Color.White;
            circleProgressBar1.Location = new Point(183, 3);
            circleProgressBar1.Maximum = 100L;
            circleProgressBar1.MinimumSize = new Size(100, 100);
            circleProgressBar1.Name = "circleProgressBar1";
            circleProgressBar1.PercentColor = Color.White;
            circleProgressBar1.ProgressColor1 = Color.Cyan;
            circleProgressBar1.ProgressColor2 = Color.FromArgb(33, 107, 255);
            circleProgressBar1.ProgressShape = ReaLTaiizor.Controls.CircleProgressBar._ProgressShape.Round;
            circleProgressBar1.Size = new Size(296, 296);
            circleProgressBar1.TabIndex = 2;
            circleProgressBar1.Value = 0L;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(18, 16);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 0;
            label3.Text = "생산량";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(20, 20);
            panel2.Margin = new Padding(20);
            panel2.Name = "panel2";
            panel2.Size = new Size(643, 274);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(607, 199);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(18, 16);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 0;
            label2.Text = "불량 내역";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 636);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(panel4);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(1720, 404);
            splitContainer2.SplitterDistance = 572;
            splitContainer2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(20, 0);
            panel4.Margin = new Padding(20, 0, 20, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(561, 384);
            panel4.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 15F, FontStyle.Bold);
            label8.Location = new Point(82, 240);
            label8.Name = "label8";
            label8.Size = new Size(111, 28);
            label8.TabIndex = 3;
            label8.Text = "작업 설명2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.Location = new Point(18, 16);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 0;
            label4.Text = "스택킹";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 15F, FontStyle.Bold);
            label7.Location = new Point(82, 168);
            label7.Name = "label7";
            label7.Size = new Size(111, 28);
            label7.TabIndex = 2;
            label7.Text = "작업 설명1";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.녹색_2단;
            pictureBox2.Image = Properties.Resources.녹색_1단;
            pictureBox2.InitialImage = Properties.Resources.녹색_3단;
            pictureBox2.Location = new Point(24, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(505, 310);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(panel5);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(panel6);
            splitContainer3.Size = new Size(1144, 404);
            splitContainer3.SplitterDistance = 560;
            splitContainer3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(button4);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(textBox1);
            panel5.Location = new Point(20, 0);
            panel5.Margin = new Padding(12, 0, 12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(548, 383);
            panel5.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(235, 238, 244);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(307, 241);
            button4.Name = "button4";
            button4.Size = new Size(142, 43);
            button4.TabIndex = 6;
            button4.Text = "주문추가";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.Location = new Point(18, 16);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 0;
            label5.Text = "주문추가";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 107, 255);
            button1.FlatAppearance.BorderColor = Color.FromArgb(31, 107, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(69, 125);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(142, 43);
            button1.TabIndex = 0;
            button1.Text = "A 셀";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label9.Location = new Point(283, 136);
            label9.Name = "label9";
            label9.Size = new Size(62, 32);
            label9.TabIndex = 5;
            label9.Text = "수량";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(31, 198, 149);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button3.Location = new Point(69, 277);
            button3.Name = "button3";
            button3.Size = new Size(142, 43);
            button3.TabIndex = 3;
            button3.Text = "C 셀";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 204, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.Location = new Point(69, 203);
            button2.Name = "button2";
            button2.Size = new Size(142, 43);
            button2.TabIndex = 2;
            button2.Text = "B 셀";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 15F);
            textBox1.Location = new Point(374, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 34);
            textBox1.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dataGridView2);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(20, 0);
            panel6.Margin = new Padding(12, 0, 12, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(540, 383);
            panel6.TabIndex = 6;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(18, 60);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(504, 310);
            dataGridView2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label6.Location = new Point(18, 16);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 0;
            label6.Text = "주문관리";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 238, 244);
            ClientSize = new Size(1720, 1040);
            Controls.Add(splitContainer2);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashborad";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private Label label6;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label8;
        private Label label7;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Label label9;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private ReaLTaiizor.Controls.CircleProgressBar circleProgressBar1;
    }
}