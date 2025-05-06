namespace FirstApp
{
    partial class _250428
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.input_1 = new System.Windows.Forms.TextBox();
            this.result_1 = new System.Windows.Forms.TextBox();
            this.button_1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_1);
            this.groupBox1.Controls.Add(this.input_1);
            this.groupBox1.Controls.Add(this.result_1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1";
            // 
            // input_1
            // 
            this.input_1.Location = new System.Drawing.Point(6, 20);
            this.input_1.Name = "input_1";
            this.input_1.Size = new System.Drawing.Size(100, 21);
            this.input_1.TabIndex = 1;
            // 
            // result_1
            // 
            this.result_1.Location = new System.Drawing.Point(6, 76);
            this.result_1.Name = "result_1";
            this.result_1.ReadOnly = true;
            this.result_1.Size = new System.Drawing.Size(100, 21);
            this.result_1.TabIndex = 2;
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(6, 47);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(100, 23);
            this.button_1.TabIndex = 3;
            this.button_1.Text = "할인여부확인";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // _250428
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(142, 158);
            this.Controls.Add(this.groupBox1);
            this.Name = "_250428";
            this.Text = "_250428";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox input_1;
        private System.Windows.Forms.TextBox result_1;
        private System.Windows.Forms.Button button_1;
    }
}