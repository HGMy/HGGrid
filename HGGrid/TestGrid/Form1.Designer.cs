namespace TestGrid
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.updateDataButton = new System.Windows.Forms.Button();
            this.hgGrid1 = new HGGrid.HGGrid();
            this.SuspendLayout();
            // 
            // updateDataButton
            // 
            this.updateDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateDataButton.Location = new System.Drawing.Point(629, 415);
            this.updateDataButton.Name = "updateDataButton";
            this.updateDataButton.Size = new System.Drawing.Size(159, 23);
            this.updateDataButton.TabIndex = 1;
            this.updateDataButton.Text = "UpdateData";
            this.updateDataButton.UseVisualStyleBackColor = true;
            this.updateDataButton.Click += new System.EventHandler(this.updateDataButton_Click);
            // 
            // hgGrid1
            // 
            this.hgGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hgGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hgGrid1.ColumnHeaderHeight = 30;
            this.hgGrid1.IsReadOnly = false;
            this.hgGrid1.Location = new System.Drawing.Point(12, 12);
            this.hgGrid1.Name = "hgGrid1";
            this.hgGrid1.RowHeaderWidth = 100;
            this.hgGrid1.Size = new System.Drawing.Size(776, 388);
            this.hgGrid1.Sytle = null;
            this.hgGrid1.TabIndex = 0;
            this.hgGrid1.Table = null;
            this.hgGrid1.ViewStyle = HGGrid.HGGridViewStyle.Excel2016;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateDataButton);
            this.Controls.Add(this.hgGrid1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HGGrid.HGGrid hgGrid1;
        private System.Windows.Forms.Button updateDataButton;
    }
}

