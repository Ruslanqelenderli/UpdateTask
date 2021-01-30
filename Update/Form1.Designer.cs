namespace Update
{
    partial class Form1
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
            this.dgb_test = new System.Windows.Forms.DataGridView();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_JanrId = new System.Windows.Forms.TextBox();
            this.lbl_JanrId = new System.Windows.Forms.Label();
            this.btn_UpdateNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_test)).BeginInit();
            this.SuspendLayout();
            // 
            // dgb_test
            // 
            this.dgb_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_test.Location = new System.Drawing.Point(194, 12);
            this.dgb_test.Name = "dgb_test";
            this.dgb_test.Size = new System.Drawing.Size(327, 198);
            this.dgb_test.TabIndex = 0;
            this.dgb_test.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_test_CellClick);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(276, 227);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(317, 227);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(100, 20);
            this.txb_Name.TabIndex = 2;
            // 
            // txb_JanrId
            // 
            this.txb_JanrId.Location = new System.Drawing.Point(317, 258);
            this.txb_JanrId.Name = "txb_JanrId";
            this.txb_JanrId.Size = new System.Drawing.Size(100, 20);
            this.txb_JanrId.TabIndex = 4;
            // 
            // lbl_JanrId
            // 
            this.lbl_JanrId.AutoSize = true;
            this.lbl_JanrId.Location = new System.Drawing.Point(275, 261);
            this.lbl_JanrId.Name = "lbl_JanrId";
            this.lbl_JanrId.Size = new System.Drawing.Size(36, 13);
            this.lbl_JanrId.TabIndex = 5;
            this.lbl_JanrId.Text = "JanrId";
            // 
            // btn_UpdateNew
            // 
            this.btn_UpdateNew.Location = new System.Drawing.Point(446, 239);
            this.btn_UpdateNew.Name = "btn_UpdateNew";
            this.btn_UpdateNew.Size = new System.Drawing.Size(75, 23);
            this.btn_UpdateNew.TabIndex = 6;
            this.btn_UpdateNew.Text = "Update";
            this.btn_UpdateNew.UseVisualStyleBackColor = true;
            this.btn_UpdateNew.Click += new System.EventHandler(this.btn_UpdateNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 361);
            this.Controls.Add(this.btn_UpdateNew);
            this.Controls.Add(this.lbl_JanrId);
            this.Controls.Add(this.txb_JanrId);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.dgb_test);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgb_test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgb_test;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_JanrId;
        private System.Windows.Forms.Label lbl_JanrId;
        private System.Windows.Forms.Button btn_UpdateNew;
    }
}

