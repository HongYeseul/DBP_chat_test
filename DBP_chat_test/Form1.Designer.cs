﻿namespace DBP_chat_test
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
            this.SuspendLayout();
            // 
            // txtBoxMsg
            // 
            this.txtBoxMsg.Location = new System.Drawing.Point(12, 12);
            this.txtBoxMsg.Name = "txtBoxMsg";
            this.txtBoxMsg.Size = new System.Drawing.Size(619, 574);
            this.txtBoxMsg.TabIndex = 0;
            this.txtBoxMsg.Text = "";
            // 
            // txtUserMsg
            // 
            this.txtUserMsg.Location = new System.Drawing.Point(139, 605);
            this.txtUserMsg.Name = "txtUserMsg";
            this.txtUserMsg.Size = new System.Drawing.Size(358, 32);
            this.txtUserMsg.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(523, 605);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(108, 32);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 658);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserMsg);
            this.Controls.Add(this.txtBoxMsg);
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
    }
}

