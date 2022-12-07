namespace BTL_NET1
{
    partial class FormQliMonThi
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
            this.TextFieldName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NameStudy = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextFieldName
            // 
            this.TextFieldName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextFieldName.Depth = 0;
            this.TextFieldName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextFieldName.Hint = "";
            this.TextFieldName.Location = new System.Drawing.Point(139, 43);
            this.TextFieldName.Margin = new System.Windows.Forms.Padding(2);
            this.TextFieldName.MaxLength = 32767;
            this.TextFieldName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldName.Name = "TextFieldName";
            this.TextFieldName.PasswordChar = '\0';
            this.TextFieldName.SelectedText = "";
            this.TextFieldName.SelectionLength = 0;
            this.TextFieldName.SelectionStart = 0;
            this.TextFieldName.Size = new System.Drawing.Size(133, 23);
            this.TextFieldName.TabIndex = 0;
            this.TextFieldName.TabStop = false;
            this.TextFieldName.UseSystemPasswordChar = false;
            // 
            // NameStudy
            // 
            this.NameStudy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameStudy.AutoSize = true;
            this.NameStudy.Depth = 0;
            this.NameStudy.Font = new System.Drawing.Font("Roboto", 11F);
            this.NameStudy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameStudy.Location = new System.Drawing.Point(31, 43);
            this.NameStudy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameStudy.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameStudy.Name = "NameStudy";
            this.NameStudy.Size = new System.Drawing.Size(97, 19);
            this.NameStudy.TabIndex = 1;
            this.NameStudy.Text = "Tên môn thi :";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(34, 97);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton1.MinimumSize = new System.Drawing.Size(112, 0);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(112, 36);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Thêm";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(283, 97);
            this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton2.MinimumSize = new System.Drawing.Size(112, 0);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(112, 36);
            this.materialRaisedButton2.TabIndex = 3;
            this.materialRaisedButton2.Text = "Xóa";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(159, 97);
            this.materialRaisedButton3.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton3.MinimumSize = new System.Drawing.Size(112, 0);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(112, 36);
            this.materialRaisedButton3.TabIndex = 4;
            this.materialRaisedButton3.Text = "Sửa";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // Search
            // 
            this.Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Search.Depth = 0;
            this.Search.Hint = "";
            this.Search.Location = new System.Drawing.Point(307, 43);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.MaxLength = 32767;
            this.Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.Search.Name = "Search";
            this.Search.PasswordChar = '\0';
            this.Search.SelectedText = "";
            this.Search.SelectionLength = 0;
            this.Search.SelectionStart = 0;
            this.Search.Size = new System.Drawing.Size(158, 23);
            this.Search.TabIndex = 6;
            this.Search.TabStop = false;
            this.Search.Text = "Tìm kiếm";
            this.Search.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(141, 184);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(323, 133);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(469, 37);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 31);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormQliMonThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.NameStudy);
            this.Controls.Add(this.TextFieldName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormQliMonThi";
            this.Text = "FormQliMonThi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldName;
        private MaterialSkin.Controls.MaterialLabel NameStudy;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialSingleLineTextField Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
    }
}