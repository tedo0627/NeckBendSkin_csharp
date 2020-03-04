namespace NeckBendSkin
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.basePath = new System.Windows.Forms.TextBox();
            this.execute = new System.Windows.Forms.Button();
            this.selectPath1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectPath2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // basePath
            // 
            this.basePath.Location = new System.Drawing.Point(43, 68);
            this.basePath.Name = "basePath";
            this.basePath.Size = new System.Drawing.Size(308, 19);
            this.basePath.TabIndex = 0;
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(43, 205);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(75, 23);
            this.execute.TabIndex = 1;
            this.execute.Text = "実行";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // selectPath1
            // 
            this.selectPath1.Location = new System.Drawing.Point(357, 67);
            this.selectPath1.Name = "selectPath1";
            this.selectPath1.Size = new System.Drawing.Size(20, 20);
            this.selectPath1.TabIndex = 2;
            this.selectPath1.Text = "...";
            this.selectPath1.UseVisualStyleBackColor = true;
            this.selectPath1.Click += new System.EventHandler(this.SelectPath1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "元のスキンを選択してください";
            // 
            // createPath
            // 
            this.createPath.Location = new System.Drawing.Point(43, 150);
            this.createPath.Name = "createPath";
            this.createPath.Size = new System.Drawing.Size(308, 19);
            this.createPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "出力先を選択してください";
            // 
            // selectPath2
            // 
            this.selectPath2.Location = new System.Drawing.Point(357, 150);
            this.selectPath2.Name = "selectPath2";
            this.selectPath2.Size = new System.Drawing.Size(20, 20);
            this.selectPath2.TabIndex = 6;
            this.selectPath2.Text = "...";
            this.selectPath2.UseVisualStyleBackColor = true;
            this.selectPath2.Click += new System.EventHandler(this.SelectPath2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 333);
            this.Controls.Add(this.selectPath2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectPath1);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.basePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox basePath;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Button selectPath1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox createPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectPath2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

