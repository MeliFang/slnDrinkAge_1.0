namespace DrinkAge_1._0
{
    partial class FrmLuck
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
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategoryDetail = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnGoodLuck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStore = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "類別細項選擇";
            // 
            // cboCategoryDetail
            // 
            this.cboCategoryDetail.FormattingEnabled = true;
            this.cboCategoryDetail.Location = new System.Drawing.Point(179, 113);
            this.cboCategoryDetail.Name = "cboCategoryDetail";
            this.cboCategoryDetail.Size = new System.Drawing.Size(121, 26);
            this.cboCategoryDetail.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "類別選擇";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(45, 113);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 26);
            this.cboCategory.TabIndex = 15;
            // 
            // btnGoodLuck
            // 
            this.btnGoodLuck.Location = new System.Drawing.Point(489, 87);
            this.btnGoodLuck.Name = "btnGoodLuck";
            this.btnGoodLuck.Size = new System.Drawing.Size(75, 52);
            this.btnGoodLuck.TabIndex = 14;
            this.btnGoodLuck.Text = "好手氣";
            this.btnGoodLuck.UseVisualStyleBackColor = true;
            this.btnGoodLuck.Click += new System.EventHandler(this.btnGoodLuck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "店家選擇";
            // 
            // cboStore
            // 
            this.cboStore.FormattingEnabled = true;
            this.cboStore.Location = new System.Drawing.Point(335, 113);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(121, 26);
            this.cboStore.TabIndex = 12;
            // 
            // FrmLuck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 250);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCategoryDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.btnGoodLuck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStore);
            this.Name = "FrmLuck";
            this.Text = "FrmLuck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCategoryDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnGoodLuck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStore;
    }
}