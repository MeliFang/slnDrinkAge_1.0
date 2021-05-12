
namespace DrinkAge_1._0
{
    partial class FrmSearch_Fang
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
            this.da_DataSet1 = new DrinkAge_1._0.da_DataSet();
            this.storeTableAdapter1 = new DrinkAge_1._0.da_DataSetTableAdapters.StoreTableAdapter();
            this.categoryTableAdapter1 = new DrinkAge_1._0.da_DataSetTableAdapters.CategoryTableAdapter();
            this.categoryDetailTableAdapter1 = new DrinkAge_1._0.da_DataSetTableAdapters.CategoryDetailTableAdapter();
            this.productsTableAdapter1 = new DrinkAge_1._0.da_DataSetTableAdapters.ProductsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategoryDetail = new System.Windows.Forms.ComboBox();
            this.commentTableAdapter1 = new DrinkAge_1._0.da_DataSetTableAdapters.CommentTableAdapter();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnGPRank = new System.Windows.Forms.Button();
            this.btnComment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_store = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cboStore = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.dataGrid_Comment = new System.Windows.Forms.DataGridView();
            this.da_DataSet2 = new DrinkAge_1._0.da_DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.da_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Comment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.da_DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // da_DataSet1
            // 
            this.da_DataSet1.DataSetName = "da_DataSet";
            this.da_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeTableAdapter1
            // 
            this.storeTableAdapter1.ClearBeforeFill = true;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // categoryDetailTableAdapter1
            // 
            this.categoryDetailTableAdapter1.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(8, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "類別細項";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(46, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "類別";
            // 
            // cboCategoryDetail
            // 
            this.cboCategoryDetail.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboCategoryDetail.FormattingEnabled = true;
            this.cboCategoryDetail.Location = new System.Drawing.Point(115, 210);
            this.cboCategoryDetail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cboCategoryDetail.Name = "cboCategoryDetail";
            this.cboCategoryDetail.Size = new System.Drawing.Size(169, 33);
            this.cboCategoryDetail.TabIndex = 23;
            this.cboCategoryDetail.SelectedIndexChanged += new System.EventHandler(this.cboCategoryDetail_SelectedIndexChanged);
            // 
            // commentTableAdapter1
            // 
            this.commentTableAdapter1.ClearBeforeFill = true;
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoadData.Location = new System.Drawing.Point(196, 13);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(117, 56);
            this.btnLoadData.TabIndex = 22;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = false;
            // 
            // btnGPRank
            // 
            this.btnGPRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGPRank.Location = new System.Drawing.Point(525, 163);
            this.btnGPRank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGPRank.Name = "btnGPRank";
            this.btnGPRank.Size = new System.Drawing.Size(117, 56);
            this.btnGPRank.TabIndex = 21;
            this.btnGPRank.Text = "GP RANK";
            this.btnGPRank.UseVisualStyleBackColor = false;
            this.btnGPRank.Click += new System.EventHandler(this.btnGPRank_Click_1);
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnComment.Location = new System.Drawing.Point(525, 92);
            this.btnComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(117, 56);
            this.btnComment.TabIndex = 20;
            this.btnComment.Text = "熱門討論";
            this.btnComment.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(527, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "熱門排行";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "DrinkAge  Search";
            // 
            // lbl_store
            // 
            this.lbl_store.AutoSize = true;
            this.lbl_store.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_store.Location = new System.Drawing.Point(320, 116);
            this.lbl_store.Name = "lbl_store";
            this.lbl_store.Size = new System.Drawing.Size(117, 26);
            this.lbl_store.TabIndex = 17;
            this.lbl_store.Text = "依店家搜尋";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_category.Location = new System.Drawing.Point(15, 116);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(117, 26);
            this.lbl_category.TabIndex = 16;
            this.lbl_category.Text = "依分類搜尋";
            // 
            // cboStore
            // 
            this.cboStore.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboStore.FormattingEnabled = true;
            this.cboStore.Location = new System.Drawing.Point(326, 158);
            this.cboStore.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(183, 33);
            this.cboStore.TabIndex = 15;
            this.cboStore.SelectedIndexChanged += new System.EventHandler(this.cboStore_SelectedIndexChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(115, 158);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(169, 33);
            this.cboCategory.TabIndex = 14;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // dataGrid_Comment
            // 
            this.dataGrid_Comment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_Comment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_Comment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Comment.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Comment.ColumnHeadersHeight = 29;
            this.dataGrid_Comment.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGrid_Comment.Location = new System.Drawing.Point(12, 268);
            this.dataGrid_Comment.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dataGrid_Comment.Name = "dataGrid_Comment";
            this.dataGrid_Comment.RowHeadersWidth = 51;
            this.dataGrid_Comment.RowTemplate.Height = 27;
            this.dataGrid_Comment.Size = new System.Drawing.Size(667, 276);
            this.dataGrid_Comment.TabIndex = 13;
            // 
            // da_DataSet2
            // 
            this.da_DataSet2.DataSetName = "da_DataSet";
            this.da_DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmSearch_Fang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 570);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCategoryDetail);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnGPRank);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_store);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.cboStore);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.dataGrid_Comment);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSearch_Fang";
            this.Text = "FrmSearch";
            ((System.ComponentModel.ISupportInitialize)(this.da_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Comment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.da_DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private da_DataSet da_DataSet1;
        private da_DataSetTableAdapters.StoreTableAdapter storeTableAdapter1;
        private da_DataSetTableAdapters.CategoryTableAdapter categoryTableAdapter1;
        private da_DataSetTableAdapters.CategoryDetailTableAdapter categoryDetailTableAdapter1;
        private da_DataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategoryDetail;
        private da_DataSetTableAdapters.CommentTableAdapter commentTableAdapter1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnGPRank;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_store;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cboStore;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.DataGridView dataGrid_Comment;
        private da_DataSet da_DataSet2;
    }
}