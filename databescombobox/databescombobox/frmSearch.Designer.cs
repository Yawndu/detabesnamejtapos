namespace databescombobox
{
    partial class frmSearch
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
            this.grdResult = new System.Windows.Forms.DataGridView();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            this.SuspendLayout();
            // 
            // grdResult
            // 
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Location = new System.Drawing.Point(44, 124);
            this.grdResult.Name = "grdResult";
            this.grdResult.Size = new System.Drawing.Size(466, 263);
            this.grdResult.TabIndex = 0;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(44, 76);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(160, 20);
            this.txtKeyword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your keyword";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(231, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 442);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.grdResult);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdResult;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
    }
}