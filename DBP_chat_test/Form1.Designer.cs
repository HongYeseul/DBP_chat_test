namespace DBP_chat_test
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxMsg = new System.Windows.Forms.RichTextBox();
            this.txtUserMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxMsg
            // 
            this.txtBoxMsg.Location = new System.Drawing.Point(8, 29);
            this.txtBoxMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxMsg.Name = "txtBoxMsg";
            this.txtBoxMsg.Size = new System.Drawing.Size(395, 308);
            this.txtBoxMsg.TabIndex = 0;
            this.txtBoxMsg.Text = "";
            // 
            // txtUserMsg
            // 
            this.txtUserMsg.Location = new System.Drawing.Point(88, 346);
            this.txtUserMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserMsg.Name = "txtUserMsg";
            this.txtUserMsg.Size = new System.Drawing.Size(229, 21);
            this.txtUserMsg.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(333, 346);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(69, 18);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Location = new System.Drawing.Point(333, 4);
            this.txtRoomNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(70, 21);
            this.txtRoomNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "방 번호";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomNum);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserMsg);
            this.Controls.Add(this.txtBoxMsg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "TestChat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxMsg;
        private System.Windows.Forms.TextBox txtUserMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label label1;
    }
}

