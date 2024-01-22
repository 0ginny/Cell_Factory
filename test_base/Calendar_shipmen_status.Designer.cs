namespace MES_Project
{
    partial class Calendar_shipmen_status
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
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            daycontainer = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnnext = new Button();
            btnprevious = new Button();
            panel1 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            panel7 = new Panel();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel9 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(140, 670);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 16;
            label9.Text = "공지사항";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label10.ForeColor = Color.FromArgb(60, 78, 113);
            label10.Location = new Point(141, 344);
            label10.Name = "label10";
            label10.Size = new Size(49, 32);
            label10.TabIndex = 15;
            label10.Text = "Jan";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("맑은 고딕", 90F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label11.Location = new Point(69, 174);
            label11.Name = "label11";
            label11.Size = new Size(207, 159);
            label11.TabIndex = 14;
            label11.Text = "01";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label12.Location = new Point(30, 20);
            label12.Name = "label12";
            label12.Size = new Size(108, 32);
            label12.TabIndex = 13;
            label12.Text = "Calinder";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(1335, 891);
            splitContainer2.SplitterDistance = 25;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(daycontainer);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer3.Size = new Size(1335, 862);
            splitContainer3.SplitterDistance = 798;
            splitContainer3.TabIndex = 0;
            splitContainer3.SplitterMoved += splitContainer3_SplitterMoved;
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(3, 0);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(1329, 796);
            daycontainer.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnnext);
            flowLayoutPanel1.Controls.Add(btnprevious);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1335, 60);
            flowLayoutPanel1.TabIndex = 13;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btnnext
            // 
            btnnext.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnnext.Location = new Point(1232, 3);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(100, 33);
            btnnext.TabIndex = 1;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // btnprevious
            // 
            btnprevious.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnprevious.Location = new Point(1126, 3);
            btnprevious.Name = "btnprevious";
            btnprevious.Size = new Size(100, 33);
            btnprevious.TabIndex = 2;
            btnprevious.Text = "Previous";
            btnprevious.UseVisualStyleBackColor = true;
            btnprevious.Click += btnprevious_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 56);
            panel1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(77, 24);
            label5.Name = "label5";
            label5.Size = new Size(38, 32);
            label5.TabIndex = 20;
            label5.Text = "일";
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(190, 0);
            panel2.Margin = new Padding(20, 3, 3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 56);
            panel2.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 18F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(73, 24);
            label6.Name = "label6";
            label6.Size = new Size(38, 32);
            label6.TabIndex = 21;
            label6.Text = "월";
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(380, 0);
            panel3.Margin = new Padding(20, 3, 3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 56);
            panel3.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 18F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(72, 24);
            label7.Name = "label7";
            label7.Size = new Size(38, 32);
            label7.TabIndex = 22;
            label7.Text = "화";
            // 
            // panel4
            // 
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(570, 0);
            panel4.Margin = new Padding(20, 3, 3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 56);
            panel4.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 18F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(72, 24);
            label8.Name = "label8";
            label8.Size = new Size(38, 32);
            label8.TabIndex = 23;
            label8.Text = "수";
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(760, 0);
            panel5.Margin = new Padding(15, 3, 3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(190, 56);
            panel5.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 18F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(71, 24);
            label4.Name = "label4";
            label4.Size = new Size(38, 32);
            label4.TabIndex = 24;
            label4.Text = "목";
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(950, 0);
            panel6.Margin = new Padding(20, 3, 3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(190, 56);
            panel6.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 18F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(68, 24);
            label3.Name = "label3";
            label3.Size = new Size(38, 32);
            label3.TabIndex = 25;
            label3.Text = "금";
            // 
            // panel7
            // 
            panel7.Controls.Add(label2);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(1140, 0);
            panel7.Margin = new Padding(20, 3, 3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(195, 56);
            panel7.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 18F);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(67, 24);
            label2.Name = "label2";
            label2.Size = new Size(38, 32);
            label2.TabIndex = 26;
            label2.Text = "토";
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.White;
            splitContainer1.Location = new Point(362, 63);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel7);
            splitContainer1.Panel1.Controls.Add(panel6);
            splitContainer1.Panel1.Controls.Add(panel5);
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1335, 951);
            splitContainer1.SplitterDistance = 56;
            splitContainer1.TabIndex = 12;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.White;
            flowLayoutPanel3.Controls.Add(panel9);
            flowLayoutPanel3.Location = new Point(30, 63);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1667, 954);
            flowLayoutPanel3.TabIndex = 17;
            // 
            // panel9
            // 
            panel9.Controls.Add(label10);
            panel9.Controls.Add(label11);
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(326, 948);
            panel9.TabIndex = 1;
            // 
            // Calendar_shipmen_status
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 238, 244);
            ClientSize = new Size(1720, 1040);
            Controls.Add(splitContainer1);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(label9);
            Controls.Add(label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Calendar_shipmen_status";
            Padding = new Padding(20);
            Text = "3";
            Load += Form3_Load;
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private SplitContainer splitContainer2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private SplitContainer splitContainer3;
        private FlowLayoutPanel daycontainer;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnnext;
        private Button btnprevious;
        private SplitContainer splitContainer1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel9;
    }
}