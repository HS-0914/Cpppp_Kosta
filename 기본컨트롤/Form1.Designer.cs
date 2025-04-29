namespace 기본컨트롤
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
            this.ckbA = new System.Windows.Forms.CheckBox();
            this.ckbB = new System.Windows.Forms.CheckBox();
            this.ckbC = new System.Windows.Forms.CheckBox();
            this.ckbD = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequire = new System.Windows.Forms.TextBox();
            this.btnReci = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckbA
            // 
            this.ckbA.AutoSize = true;
            this.ckbA.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ckbA.Location = new System.Drawing.Point(15, 61);
            this.ckbA.Name = "ckbA";
            this.ckbA.Size = new System.Drawing.Size(103, 24);
            this.ckbA.TabIndex = 0;
            this.ckbA.Text = "아메리카노";
            this.ckbA.UseVisualStyleBackColor = true;
            // 
            // ckbB
            // 
            this.ckbB.AutoSize = true;
            this.ckbB.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ckbB.Location = new System.Drawing.Point(30, 91);
            this.ckbB.Name = "ckbB";
            this.ckbB.Size = new System.Drawing.Size(88, 24);
            this.ckbB.TabIndex = 1;
            this.ckbB.Text = "카페라떼";
            this.ckbB.UseVisualStyleBackColor = true;
            // 
            // ckbC
            // 
            this.ckbC.AutoSize = true;
            this.ckbC.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ckbC.Location = new System.Drawing.Point(30, 121);
            this.ckbC.Name = "ckbC";
            this.ckbC.Size = new System.Drawing.Size(88, 24);
            this.ckbC.TabIndex = 2;
            this.ckbC.Text = "카페모카";
            this.ckbC.UseVisualStyleBackColor = true;
            this.ckbC.CheckedChanged += new System.EventHandler(this.ckbC_CheckedChanged);
            // 
            // ckbD
            // 
            this.ckbD.AutoSize = true;
            this.ckbD.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ckbD.Location = new System.Drawing.Point(30, 151);
            this.ckbD.Name = "ckbD";
            this.ckbD.Size = new System.Drawing.Size(73, 24);
            this.ckbD.TabIndex = 3;
            this.ckbD.Text = "밀크티";
            this.ckbD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "주문하세요";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "주문";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(44, 200);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 12);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "주문결과";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(46, 306);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 16);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(159, 306);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 16);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(51, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(318, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 83);
            this.button2.TabIndex = 10;
            this.button2.Text = "응모";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(11, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "주문시 요구사항";
            // 
            // txtRequire
            // 
            this.txtRequire.Location = new System.Drawing.Point(15, 434);
            this.txtRequire.Multiline = true;
            this.txtRequire.Name = "txtRequire";
            this.txtRequire.Size = new System.Drawing.Size(341, 83);
            this.txtRequire.TabIndex = 12;
            // 
            // btnReci
            // 
            this.btnReci.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReci.Location = new System.Drawing.Point(362, 434);
            this.btnReci.Name = "btnReci";
            this.btnReci.Size = new System.Drawing.Size(162, 83);
            this.btnReci.TabIndex = 13;
            this.btnReci.Text = "접수";
            this.btnReci.UseVisualStyleBackColor = true;
            this.btnReci.Click += new System.EventHandler(this.btnReci_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(11, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "결재방법";
            // 
            // cbPay
            // 
            this.cbPay.FormattingEnabled = true;
            this.cbPay.Items.AddRange(new object[] {
            "현금결제",
            "카카오페이",
            "삼성페이"});
            this.cbPay.Location = new System.Drawing.Point(17, 570);
            this.cbPay.Name = "cbPay";
            this.cbPay.Size = new System.Drawing.Size(121, 20);
            this.cbPay.TabIndex = 15;
            this.cbPay.SelectedIndexChanged += new System.EventHandler(this.cbPay_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(191, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "결재정보";
            // 
            // lbArea
            // 
            this.lbArea.FormattingEnabled = true;
            this.lbArea.ItemHeight = 12;
            this.lbArea.Items.AddRange(new object[] {
            "일시불",
            "3개월할부",
            "6개월할부"});
            this.lbArea.Location = new System.Drawing.Point(195, 570);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(120, 88);
            this.lbArea.TabIndex = 17;
            this.lbArea.SelectedIndexChanged += new System.EventHandler(this.lbArea_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(362, 570);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 83);
            this.button3.TabIndex = 18;
            this.button3.Text = "결제";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 795);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReci);
            this.Controls.Add(this.txtRequire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbD);
            this.Controls.Add(this.ckbC);
            this.Controls.Add(this.ckbB);
            this.Controls.Add(this.ckbA);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbA;
        private System.Windows.Forms.CheckBox ckbB;
        private System.Windows.Forms.CheckBox ckbC;
        private System.Windows.Forms.CheckBox ckbD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRequire;
        private System.Windows.Forms.Button btnReci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbArea;
        private System.Windows.Forms.Button button3;
    }
}

