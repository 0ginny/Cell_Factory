﻿namespace test_base
{
    partial class Calinder
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 1;
            label1.Text = "Calinder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 90F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(65, 149);
            label2.Name = "label2";
            label2.Size = new Size(207, 159);
            label2.TabIndex = 2;
            label2.Text = "01";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.FromArgb(60, 78, 113);
            label3.Location = new Point(134, 324);
            label3.Name = "label3";
            label3.Size = new Size(49, 32);
            label3.TabIndex = 3;
            label3.Text = "Jan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 548);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 4;
            label4.Text = "공지사항";
            // 
            // button1
            // 
            button1.Location = new Point(304, 84);
            button1.Name = "button1";
            button1.Size = new Size(1339, 804);
            button1.TabIndex = 5;
            button1.Text = "달력";
            button1.UseVisualStyleBackColor = true;
            // 
            // Calinder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 238, 244);
            ClientSize = new Size(1688, 922);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Calinder";
            Text = "Calinder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}