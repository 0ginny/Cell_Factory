namespace MES_Project
{
    partial class EventForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            PorbOrderDatagrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)PorbOrderDatagrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PorbOrderDatagrid
            // 
            PorbOrderDatagrid.AllowUserToAddRows = false;
            PorbOrderDatagrid.AllowUserToDeleteRows = false;
            PorbOrderDatagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(246, 249, 255);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(60, 78, 113);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(31, 107, 255);
            PorbOrderDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            PorbOrderDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PorbOrderDatagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            PorbOrderDatagrid.BackgroundColor = Color.White;
            PorbOrderDatagrid.BorderStyle = BorderStyle.None;
            PorbOrderDatagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PorbOrderDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(235, 238, 244);
            dataGridViewCellStyle2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 238, 244);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PorbOrderDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            PorbOrderDatagrid.ColumnHeadersHeight = 40;
            PorbOrderDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            PorbOrderDatagrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Column1, Column2, Column4, Column3, Column5 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(60, 78, 113);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(31, 107, 255);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            PorbOrderDatagrid.DefaultCellStyle = dataGridViewCellStyle5;
            PorbOrderDatagrid.Dock = DockStyle.Fill;
            PorbOrderDatagrid.EnableHeadersVisualStyles = false;
            PorbOrderDatagrid.GridColor = Color.FromArgb(235, 238, 244);
            PorbOrderDatagrid.Location = new Point(0, 0);
            PorbOrderDatagrid.Margin = new Padding(0);
            PorbOrderDatagrid.Name = "PorbOrderDatagrid";
            PorbOrderDatagrid.ReadOnly = true;
            PorbOrderDatagrid.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(60, 78, 113);
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(31, 107, 255);
            PorbOrderDatagrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            PorbOrderDatagrid.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PorbOrderDatagrid.RowTemplate.DefaultCellStyle.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            PorbOrderDatagrid.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 5, 0, 10);
            PorbOrderDatagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.White;
            PorbOrderDatagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 107, 255);
            PorbOrderDatagrid.RowTemplate.DividerHeight = 1;
            PorbOrderDatagrid.RowTemplate.Height = 80;
            PorbOrderDatagrid.RowTemplate.Resizable = DataGridViewTriState.True;
            PorbOrderDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PorbOrderDatagrid.Size = new Size(1128, 184);
            PorbOrderDatagrid.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTextBoxColumn1.HeaderText = "주문ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumn2.HeaderText = "회사명";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "제품명";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "주문갯수";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "주문일자";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "착수일자";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "라드타임";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(PorbOrderDatagrid, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(1128, 224);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 184);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 40);
            panel1.TabIndex = 5;
            // 
            // button6
            // 
            button6.Location = new Point(1050, 5);
            button6.Name = "button6";
            button6.Size = new Size(75, 32);
            button6.TabIndex = 0;
            button6.Text = "수정";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 224);
            Controls.Add(tableLayoutPanel1);
            Name = "EventForm";
            Text = "상세보기";
            Load += EventForm_Load;
            ((System.ComponentModel.ISupportInitialize)PorbOrderDatagrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PorbOrderDatagrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button button6;
    }
}