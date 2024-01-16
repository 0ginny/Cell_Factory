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
            PorbOrderDatagrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PorbOrderDatagrid).BeginInit();
            SuspendLayout();
            // 
            // PorbOrderDatagrid
            // 
            PorbOrderDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PorbOrderDatagrid.Location = new Point(0, 0);
            PorbOrderDatagrid.Name = "PorbOrderDatagrid";
            PorbOrderDatagrid.Size = new Size(606, 242);
            PorbOrderDatagrid.TabIndex = 0;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 245);
            Controls.Add(PorbOrderDatagrid);
            Name = "EventForm";
            Text = "상세보기";
            Load += EventForm_Load;
            ((System.ComponentModel.ISupportInitialize)PorbOrderDatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PorbOrderDatagrid;
    }
}