namespace TreeView
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
            this.txtNode = new System.Windows.Forms.TextBox();
            this.BtbAdd = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExpandAll = new System.Windows.Forms.Button();
            this.BtnCollapseAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNode
            // 
            this.txtNode.Location = new System.Drawing.Point(450, 22);
            this.txtNode.Name = "txtNode";
            this.txtNode.Size = new System.Drawing.Size(100, 33);
            this.txtNode.TabIndex = 0;
            // 
            // BtbAdd
            // 
            this.BtbAdd.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtbAdd.Location = new System.Drawing.Point(450, 61);
            this.BtbAdd.Name = "BtbAdd";
            this.BtbAdd.Size = new System.Drawing.Size(100, 54);
            this.BtbAdd.TabIndex = 1;
            this.BtbAdd.Text = "추가";
            this.BtbAdd.UseVisualStyleBackColor = true;
            this.BtbAdd.Click += new System.EventHandler(this.BtbAdd_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(432, 725);
            this.treeView1.TabIndex = 2;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDelete.Location = new System.Drawing.Point(450, 121);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 54);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnExpandAll
            // 
            this.BtnExpandAll.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnExpandAll.Location = new System.Drawing.Point(450, 181);
            this.BtnExpandAll.Name = "BtnExpandAll";
            this.BtnExpandAll.Size = new System.Drawing.Size(100, 54);
            this.BtnExpandAll.TabIndex = 4;
            this.BtnExpandAll.Text = "확장";
            this.BtnExpandAll.UseVisualStyleBackColor = true;
            this.BtnExpandAll.Click += new System.EventHandler(this.BtnExpandAll_Click);
            // 
            // BtnCollapseAll
            // 
            this.BtnCollapseAll.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnCollapseAll.Location = new System.Drawing.Point(450, 241);
            this.BtnCollapseAll.Name = "BtnCollapseAll";
            this.BtnCollapseAll.Size = new System.Drawing.Size(100, 54);
            this.BtnCollapseAll.TabIndex = 5;
            this.BtnCollapseAll.Text = "축소";
            this.BtnCollapseAll.UseVisualStyleBackColor = true;
            this.BtnCollapseAll.Click += new System.EventHandler(this.BtnCollapseAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 749);
            this.Controls.Add(this.BtnCollapseAll);
            this.Controls.Add(this.BtnExpandAll);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.BtbAdd);
            this.Controls.Add(this.txtNode);
            this.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNode;
        private System.Windows.Forms.Button BtbAdd;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExpandAll;
        private System.Windows.Forms.Button BtnCollapseAll;
    }
}

