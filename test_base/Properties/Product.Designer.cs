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

            hopeDatePicker1 = new ReaLTaiizor.Controls.HopeDatePicker();

            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            label5 = new Label();
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
            panel2.Controls.Add(hopeDatePicker1);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(23, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1677, 879);
            panel2.TabIndex = 0;
            // 

            // hopeDatePicker1
            // 
            hopeDatePicker1.BackColor = Color.White;
            hopeDatePicker1.BorderColor = Color.FromArgb(220, 223, 230);
            hopeDatePicker1.Date = new DateTime(2024, 1, 22, 0, 0, 0, 0);
            hopeDatePicker1.DayNames = "MTWTFSS";
            hopeDatePicker1.DaysTextColor = Color.FromArgb(96, 98, 102);
            hopeDatePicker1.DayTextColorA = Color.FromArgb(48, 49, 51);
            hopeDatePicker1.DayTextColorB = Color.FromArgb(144, 147, 153);
            hopeDatePicker1.HeaderFormat = "{0} Y - {1} M";
            hopeDatePicker1.HeaderTextColor = Color.FromArgb(48, 49, 51);
            hopeDatePicker1.HeadLineColor = Color.FromArgb(228, 231, 237);
            hopeDatePicker1.HoverColor = Color.FromArgb(235, 238, 245);
            hopeDatePicker1.Location = new Point(0, 0);
            hopeDatePicker1.Name = "hopeDatePicker1";
            hopeDatePicker1.NMColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.NMHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.NYColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.NYHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.PMColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.PMHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.PYColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.PYHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.SelectedBackColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.SelectedTextColor = Color.White;
            hopeDatePicker1.Size = new Size(250, 270);
            hopeDatePicker1.TabIndex = 5;
            hopeDatePicker1.Text = "hopeDatePicker1";
            hopeDatePicker1.ValueTextColor = Color.FromArgb(43, 133, 228);

            // 

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
        private ReaLTaiizor.Controls.HopeDatePicker hopeDatePicker1;
    }
}