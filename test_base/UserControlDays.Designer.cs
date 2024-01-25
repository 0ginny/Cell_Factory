namespace MES_Project
{
    partial class UserControlDays
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            lbdays = new Label();
            lbevent = new Label();
            SuspendLayout();
            // 
            // lbdays
            // 
            lbdays.AutoSize = true;
            lbdays.Font = new Font("맑은 고딕", 12F);
            lbdays.Location = new Point(77, 0);
            lbdays.Name = "lbdays";
            lbdays.Size = new Size(28, 21);
            lbdays.TabIndex = 0;
            lbdays.Text = "00";
            // 
            // lbevent
            // 
            lbevent.Font = new Font("함초롬바탕", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            lbevent.Location = new Point(20, 31);
            lbevent.Name = "lbevent";
            lbevent.Size = new Size(140, 108);
            lbevent.TabIndex = 1;
            lbevent.TextAlign = ContentAlignment.MiddleCenter;
            lbevent.Click += UserControlDays_Click;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = test_base.Properties.Resources.제목_없음;
            Controls.Add(lbevent);
            Controls.Add(lbdays);
            Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Name = "UserControlDays";
            Size = new Size(183, 153);
            Load += UserControlDays_Load;
            Click += UserControlDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbdays;
        private Label lbevent;
    }
}
