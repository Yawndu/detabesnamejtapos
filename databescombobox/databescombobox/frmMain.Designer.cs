namespace databescombobox
{
    partial class frmMain
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
            this.btnMainAdd = new System.Windows.Forms.Button();
            this.btnMainUpdate = new System.Windows.Forms.Button();
            this.btnMainSearch = new System.Windows.Forms.Button();
            this.btnMainDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainAdd
            // 
            this.btnMainAdd.Location = new System.Drawing.Point(46, 70);
            this.btnMainAdd.Name = "btnMainAdd";
            this.btnMainAdd.Size = new System.Drawing.Size(99, 52);
            this.btnMainAdd.TabIndex = 0;
            this.btnMainAdd.Text = "ADD";
            this.btnMainAdd.UseVisualStyleBackColor = true;
            this.btnMainAdd.Click += new System.EventHandler(this.btnMainAdd_Click);
            // 
            // btnMainUpdate
            // 
            this.btnMainUpdate.Location = new System.Drawing.Point(168, 70);
            this.btnMainUpdate.Name = "btnMainUpdate";
            this.btnMainUpdate.Size = new System.Drawing.Size(99, 52);
            this.btnMainUpdate.TabIndex = 1;
            this.btnMainUpdate.Text = "Update";
            this.btnMainUpdate.UseVisualStyleBackColor = true;
            this.btnMainUpdate.Click += new System.EventHandler(this.btnMainUpdate_Click);
            // 
            // btnMainSearch
            // 
            this.btnMainSearch.Location = new System.Drawing.Point(168, 152);
            this.btnMainSearch.Name = "btnMainSearch";
            this.btnMainSearch.Size = new System.Drawing.Size(99, 52);
            this.btnMainSearch.TabIndex = 3;
            this.btnMainSearch.Text = "Search";
            this.btnMainSearch.UseVisualStyleBackColor = true;
            this.btnMainSearch.Click += new System.EventHandler(this.btnMainSearch_Click);
            // 
            // btnMainDelete
            // 
            this.btnMainDelete.Location = new System.Drawing.Point(46, 152);
            this.btnMainDelete.Name = "btnMainDelete";
            this.btnMainDelete.Size = new System.Drawing.Size(99, 52);
            this.btnMainDelete.TabIndex = 2;
            this.btnMainDelete.Text = "Delete";
            this.btnMainDelete.UseVisualStyleBackColor = true;
            this.btnMainDelete.Click += new System.EventHandler(this.btnMainDelete_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 280);
            this.Controls.Add(this.btnMainSearch);
            this.Controls.Add(this.btnMainDelete);
            this.Controls.Add(this.btnMainUpdate);
            this.Controls.Add(this.btnMainAdd);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainAdd;
        private System.Windows.Forms.Button btnMainUpdate;
        private System.Windows.Forms.Button btnMainSearch;
        private System.Windows.Forms.Button btnMainDelete;
    }
}

