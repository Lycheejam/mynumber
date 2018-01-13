namespace mynumber
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.myNumBtn = new System.Windows.Forms.Button();
            this.comNumBtn = new System.Windows.Forms.Button();
            this.juCdBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // myNumBtn
            // 
            this.myNumBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.myNumBtn.Location = new System.Drawing.Point(8, 11);
            this.myNumBtn.Name = "myNumBtn";
            this.myNumBtn.Size = new System.Drawing.Size(60, 65);
            this.myNumBtn.TabIndex = 0;
            this.myNumBtn.Text = "個人番号";
            this.myNumBtn.UseVisualStyleBackColor = true;
            this.myNumBtn.Click += new System.EventHandler(this.myNumBtn_Click);
            // 
            // comNumBtn
            // 
            this.comNumBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comNumBtn.Location = new System.Drawing.Point(74, 11);
            this.comNumBtn.Name = "comNumBtn";
            this.comNumBtn.Size = new System.Drawing.Size(60, 65);
            this.comNumBtn.TabIndex = 1;
            this.comNumBtn.Text = "法人番号";
            this.comNumBtn.UseVisualStyleBackColor = true;
            this.comNumBtn.Click += new System.EventHandler(this.comNumBtn_Click);
            // 
            // juCdBtn
            // 
            this.juCdBtn.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.juCdBtn.Location = new System.Drawing.Point(140, 11);
            this.juCdBtn.Name = "juCdBtn";
            this.juCdBtn.Size = new System.Drawing.Size(60, 65);
            this.juCdBtn.TabIndex = 2;
            this.juCdBtn.Text = "住民票CD";
            this.juCdBtn.UseVisualStyleBackColor = true;
            this.juCdBtn.Click += new System.EventHandler(this.juCdBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "結果";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(58, 80);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(142, 19);
            this.resultBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 108);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.juCdBtn);
            this.Controls.Add(this.comNumBtn);
            this.Controls.Add(this.myNumBtn);
            this.Name = "Form1";
            this.Text = "マイナンバー計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myNumBtn;
        private System.Windows.Forms.Button comNumBtn;
        private System.Windows.Forms.Button juCdBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultBox;
    }
}

