namespace MySqlBook
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.txtPulblisher = new System.Windows.Forms.TextBox();
            this.lbPulblisher = new System.Windows.Forms.Label();
            this.lbPulblishDate = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTitle.Location = new System.Drawing.Point(30, 58);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(55, 30);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "제목";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(129, 65);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(360, 23);
            this.txtTitle.TabIndex = 5;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(129, 121);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(360, 23);
            this.txtAuthor.TabIndex = 7;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAuthor.Location = new System.Drawing.Point(30, 114);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(55, 30);
            this.lbAuthor.TabIndex = 6;
            this.lbAuthor.Text = "저자";
            // 
            // txtPulblisher
            // 
            this.txtPulblisher.Location = new System.Drawing.Point(129, 183);
            this.txtPulblisher.Name = "txtPulblisher";
            this.txtPulblisher.Size = new System.Drawing.Size(360, 23);
            this.txtPulblisher.TabIndex = 9;
            // 
            // lbPulblisher
            // 
            this.lbPulblisher.AutoSize = true;
            this.lbPulblisher.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPulblisher.Location = new System.Drawing.Point(30, 176);
            this.lbPulblisher.Name = "lbPulblisher";
            this.lbPulblisher.Size = new System.Drawing.Size(76, 30);
            this.lbPulblisher.TabIndex = 8;
            this.lbPulblisher.Text = "출판사";
            // 
            // lbPulblishDate
            // 
            this.lbPulblishDate.AutoSize = true;
            this.lbPulblishDate.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPulblishDate.Location = new System.Drawing.Point(30, 240);
            this.lbPulblishDate.Name = "lbPulblishDate";
            this.lbPulblishDate.Size = new System.Drawing.Size(76, 30);
            this.lbPulblishDate.TabIndex = 10;
            this.lbPulblishDate.Text = "출판일";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(129, 309);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(360, 23);
            this.txtPrice.TabIndex = 13;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPrice.Location = new System.Drawing.Point(30, 302);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(55, 30);
            this.lbPrice.TabIndex = 12;
            this.lbPrice.Text = "가격";
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Location = new System.Drawing.Point(129, 247);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(360, 23);
            this.dtpPublishDate.TabIndex = 14;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(35, 367);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 47);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "추가";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(158, 367);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(90, 47);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.Location = new System.Drawing.Point(281, 367);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 47);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(399, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 47);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(35, 453);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowTemplate.Height = 23;
            this.dgvBooks.Size = new System.Drawing.Size(786, 219);
            this.dgvBooks.TabIndex = 19;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 714);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtpPublishDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbPulblishDate);
            this.Controls.Add(this.txtPulblisher);
            this.Controls.Add(this.lbPulblisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.TextBox txtPulblisher;
        private System.Windows.Forms.Label lbPulblisher;
        private System.Windows.Forms.Label lbPulblishDate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button button1;
    }
}

