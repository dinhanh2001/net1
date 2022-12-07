namespace BTL_NET1
{
    partial class FormQliLopThi
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TextFieldName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextFieldSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSearch = new System.Windows.Forms.Button();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(64, 58);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Tên lớp :";
            // 
            // TextFieldName
            // 
            this.TextFieldName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextFieldName.Depth = 0;
            this.TextFieldName.Hint = "";
            this.TextFieldName.Location = new System.Drawing.Point(155, 54);
            this.TextFieldName.MaxLength = 32767;
            this.TextFieldName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldName.Name = "TextFieldName";
            this.TextFieldName.PasswordChar = '\0';
            this.TextFieldName.SelectedText = "";
            this.TextFieldName.SelectionLength = 0;
            this.TextFieldName.SelectionStart = 0;
            this.TextFieldName.Size = new System.Drawing.Size(182, 23);
            this.TextFieldName.TabIndex = 1;
            this.TextFieldName.TabStop = false;
            this.TextFieldName.UseSystemPasswordChar = false;
            // 
            // TextFieldSearch
            // 
            this.TextFieldSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextFieldSearch.Depth = 0;
            this.TextFieldSearch.Hint = "";
            this.TextFieldSearch.Location = new System.Drawing.Point(432, 54);
            this.TextFieldSearch.MaxLength = 32767;
            this.TextFieldSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldSearch.Name = "TextFieldSearch";
            this.TextFieldSearch.PasswordChar = '\0';
            this.TextFieldSearch.SelectedText = "";
            this.TextFieldSearch.SelectionLength = 0;
            this.TextFieldSearch.SelectionStart = 0;
            this.TextFieldSearch.Size = new System.Drawing.Size(151, 23);
            this.TextFieldSearch.TabIndex = 2;
            this.TextFieldSearch.TabStop = false;
            this.TextFieldSearch.Text = "Tìm kiếm";
            this.TextFieldSearch.UseSystemPasswordChar = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.Location = new System.Drawing.Point(614, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(68, 142);
            this.materialRaisedButton1.MinimumSize = new System.Drawing.Size(100, 0);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(100, 36);
            this.materialRaisedButton1.TabIndex = 4;
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
            this.materialRaisedButton2.Location = new System.Drawing.Point(191, 142);
            this.materialRaisedButton2.MinimumSize = new System.Drawing.Size(100, 0);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(100, 36);
            this.materialRaisedButton2.TabIndex = 5;
            this.materialRaisedButton2.Text = "Sửa";
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
            this.materialRaisedButton3.Location = new System.Drawing.Point(308, 142);
            this.materialRaisedButton3.MinimumSize = new System.Drawing.Size(100, 0);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(100, 36);
            this.materialRaisedButton3.TabIndex = 6;
            this.materialRaisedButton3.Text = "Xóa";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 164);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormQliLopThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TextFieldSearch);
            this.Controls.Add(this.TextFieldName);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FormQliLopThi";
            this.Text = "FormQliLopThi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldName;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldSearch;
        private System.Windows.Forms.Button btnSearch;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}