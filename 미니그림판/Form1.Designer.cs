namespace 미니그림판
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.ToolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.도형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripLine = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripRect = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.색상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.ToolStripBtnLine = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnRect = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripBtnBlack = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnRed = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnGreen = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnBlue = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menubar.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menubar
            // 
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripFile,
            this.도형ToolStripMenuItem,
            this.색상ToolStripMenuItem});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(800, 24);
            this.menubar.TabIndex = 0;
            this.menubar.Text = "menuStrip1";
            // 
            // ToolStripFile
            // 
            this.ToolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripNew,
            this.ToolStripExit});
            this.ToolStripFile.Name = "ToolStripFile";
            this.ToolStripFile.Size = new System.Drawing.Size(43, 20);
            this.ToolStripFile.Text = "파일";
            // 
            // ToolStripNew
            // 
            this.ToolStripNew.Name = "ToolStripNew";
            this.ToolStripNew.Size = new System.Drawing.Size(134, 22);
            this.ToolStripNew.Text = "새로만들기";
            this.ToolStripNew.Click += new System.EventHandler(this.ToolStripNew_Click);
            // 
            // ToolStripExit
            // 
            this.ToolStripExit.Name = "ToolStripExit";
            this.ToolStripExit.Size = new System.Drawing.Size(134, 22);
            this.ToolStripExit.Text = "끝내기";
            this.ToolStripExit.Click += new System.EventHandler(this.ToolStripExit_Click);
            // 
            // 도형ToolStripMenuItem
            // 
            this.도형ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLine,
            this.ToolStripRect,
            this.ToolStripCircle});
            this.도형ToolStripMenuItem.Name = "도형ToolStripMenuItem";
            this.도형ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.도형ToolStripMenuItem.Text = "도형";
            // 
            // ToolStripLine
            // 
            this.ToolStripLine.Name = "ToolStripLine";
            this.ToolStripLine.Size = new System.Drawing.Size(110, 22);
            this.ToolStripLine.Text = "선";
            this.ToolStripLine.Click += new System.EventHandler(this.ToolStripLine_Click);
            // 
            // ToolStripRect
            // 
            this.ToolStripRect.Name = "ToolStripRect";
            this.ToolStripRect.Size = new System.Drawing.Size(110, 22);
            this.ToolStripRect.Text = "사각형";
            this.ToolStripRect.Click += new System.EventHandler(this.ToolStripRect_Click);
            // 
            // ToolStripCircle
            // 
            this.ToolStripCircle.Name = "ToolStripCircle";
            this.ToolStripCircle.Size = new System.Drawing.Size(110, 22);
            this.ToolStripCircle.Text = "원";
            this.ToolStripCircle.Click += new System.EventHandler(this.ToolStripCircle_Click);
            // 
            // 색상ToolStripMenuItem
            // 
            this.색상ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripColor});
            this.색상ToolStripMenuItem.Name = "색상ToolStripMenuItem";
            this.색상ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.색상ToolStripMenuItem.Text = "색상";
            // 
            // ToolStripColor
            // 
            this.ToolStripColor.Name = "ToolStripColor";
            this.ToolStripColor.Size = new System.Drawing.Size(180, 22);
            this.ToolStripColor.Text = "색상설정";
            this.ToolStripColor.Click += new System.EventHandler(this.ToolStripColor_Click);
            // 
            // toolbar
            // 
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripBtnLine,
            this.ToolStripBtnRect,
            this.ToolStripBtnCircle,
            this.toolStripSeparator1,
            this.ToolStripBtnBlack,
            this.ToolStripBtnRed,
            this.ToolStripBtnGreen,
            this.ToolStripBtnBlue});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(800, 25);
            this.toolbar.TabIndex = 1;
            this.toolbar.Text = "toolStrip1";
            // 
            // ToolStripBtnLine
            // 
            this.ToolStripBtnLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnLine.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnLine.Image")));
            this.ToolStripBtnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnLine.Name = "ToolStripBtnLine";
            this.ToolStripBtnLine.Size = new System.Drawing.Size(23, 22);
            this.ToolStripBtnLine.Text = "toolStripButton1";
            this.ToolStripBtnLine.Click += new System.EventHandler(this.ToolStripBtnLine_Click);
            // 
            // ToolStripBtnRect
            // 
            this.ToolStripBtnRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnRect.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnRect.Image")));
            this.ToolStripBtnRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnRect.Name = "ToolStripBtnRect";
            this.ToolStripBtnRect.Size = new System.Drawing.Size(23, 22);
            this.ToolStripBtnRect.Text = "toolStripButton2";
            this.ToolStripBtnRect.Click += new System.EventHandler(this.ToolStripBtnRect_Click);
            // 
            // ToolStripBtnCircle
            // 
            this.ToolStripBtnCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnCircle.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnCircle.Image")));
            this.ToolStripBtnCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnCircle.Name = "ToolStripBtnCircle";
            this.ToolStripBtnCircle.Size = new System.Drawing.Size(23, 22);
            this.ToolStripBtnCircle.Text = "toolStripButton3";
            this.ToolStripBtnCircle.Click += new System.EventHandler(this.ToolStripBtnCircle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripBtnBlack
            // 
            this.ToolStripBtnBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnBlack.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnBlack.Image")));
            this.ToolStripBtnBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnBlack.Name = "ToolStripBtnBlack";
            this.ToolStripBtnBlack.Size = new System.Drawing.Size(23, 22);
            this.ToolStripBtnBlack.Text = "toolStripButton4";
            this.ToolStripBtnBlack.Click += new System.EventHandler(this.ToolStripBtnBlack_Click);
            // 
            // ToolStripBtnRed
            // 
            this.ToolStripBtnRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnRed.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnRed.Image")));
            this.ToolStripBtnRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnRed.Name = "ToolStripBtnRed";
            this.ToolStripBtnRed.Size = new System.Drawing.Size(23, 22);
            this.ToolStripBtnRed.Text = "toolStripButton5";
            this.ToolStripBtnRed.Click += new System.EventHandler(this.ToolStripBtnRed_Click);
            // 
            // ToolStripBtnGreen
            // 
            this.ToolStripBtnGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnGreen.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnGreen.Image")));
            this.ToolStripBtnGreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnGreen.Name = "ToolStripBtnGreen";
            this.ToolStripBtnGreen.Size = new System.Drawing.Size(23, 22);
            this.ToolStripBtnGreen.Text = "toolStripButton6";
            this.ToolStripBtnGreen.Click += new System.EventHandler(this.ToolStripBtnGreen_Click);
            // 
            // ToolStripBtnBlue
            // 
            this.ToolStripBtnBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripBtnBlue.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnBlue.Image")));
            this.ToolStripBtnBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnBlue.Name = "ToolStripBtnBlue";
            this.ToolStripBtnBlue.Size = new System.Drawing.Size(23, 22);
            this.ToolStripBtnBlue.Text = "toolStripButton7";
            this.ToolStripBtnBlue.Click += new System.EventHandler(this.ToolStripBtnBlue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.menubar);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainMenuStrip = this.menubar;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripNew;
        private System.Windows.Forms.ToolStripMenuItem 도형ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색상ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripLine;
        private System.Windows.Forms.ToolStripMenuItem ToolStripRect;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCircle;
        private System.Windows.Forms.ToolStripMenuItem ToolStripColor;
        private System.Windows.Forms.ToolStripButton ToolStripBtnLine;
        private System.Windows.Forms.ToolStripButton ToolStripBtnRect;
        private System.Windows.Forms.ToolStripButton ToolStripBtnCircle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolStripBtnBlack;
        private System.Windows.Forms.ToolStripButton ToolStripBtnRed;
        private System.Windows.Forms.ToolStripButton ToolStripBtnGreen;
        private System.Windows.Forms.ToolStripButton ToolStripBtnBlue;
    }
}

