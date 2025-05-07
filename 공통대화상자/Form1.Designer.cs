namespace 공통대화상자
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
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnColor = new System.Windows.Forms.Button();
            this.BtnFont = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ofd = new System.Windows.Forms.OpenFileDialog();
            this.Sfd = new System.Windows.Forms.SaveFileDialog();
            this.Fd = new System.Windows.Forms.FontDialog();
            this.Cd = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // BtnOpen
            // 
            this.BtnOpen.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnOpen.Location = new System.Drawing.Point(38, 40);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(140, 42);
            this.BtnOpen.TabIndex = 0;
            this.BtnOpen.Text = "열기";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnColor
            // 
            this.BtnColor.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnColor.Location = new System.Drawing.Point(194, 104);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(140, 42);
            this.BtnColor.TabIndex = 1;
            this.BtnColor.Text = "색상";
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // BtnFont
            // 
            this.BtnFont.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnFont.Location = new System.Drawing.Point(38, 104);
            this.BtnFont.Name = "BtnFont";
            this.BtnFont.Size = new System.Drawing.Size(140, 42);
            this.BtnFont.TabIndex = 2;
            this.BtnFont.Text = "폰트";
            this.BtnFont.UseVisualStyleBackColor = true;
            this.BtnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSave.Location = new System.Drawing.Point(194, 40);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(140, 42);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(38, 195);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 195);
            this.textBox1.TabIndex = 4;
            // 
            // Ofd
            // 
            this.Ofd.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 430);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnFont);
            this.Controls.Add(this.BtnColor);
            this.Controls.Add(this.BtnOpen);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Button BtnFont;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog Ofd;
        private System.Windows.Forms.SaveFileDialog Sfd;
        private System.Windows.Forms.FontDialog Fd;
        private System.Windows.Forms.ColorDialog Cd;
    }
}

