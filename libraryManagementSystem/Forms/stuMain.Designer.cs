namespace libraryManagementSystem
{
    partial class stuMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stuMain));
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.btnStuGetBook = new System.Windows.Forms.Button();
            this.btnStuReturnBook = new System.Windows.Forms.Button();
            this.grpStuGetBook = new System.Windows.Forms.GroupBox();
            this.lbGetBookKind = new System.Windows.Forms.Label();
            this.txtGetBookKind = new System.Windows.Forms.TextBox();
            this.btnGetBook = new System.Windows.Forms.Button();
            this.lblGetBookAuthor = new System.Windows.Forms.Label();
            this.txtGetBookAuthor = new System.Windows.Forms.TextBox();
            this.lblGetBookName = new System.Windows.Forms.Label();
            this.txtGetBookName = new System.Windows.Forms.TextBox();
            this.txtGetBookListSearch = new System.Windows.Forms.TextBox();
            this.lblGetBookListSearch = new System.Windows.Forms.Label();
            this.dgvGetBookList = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet = new libraryManagementSystem.libraryManagementDataSet();
            this.booksTableAdapter = new libraryManagementSystem.libraryManagementDataSetTableAdapters.booksTableAdapter();
            this.grpStuReturnBook = new System.Windows.Forms.GroupBox();
            this.dgvReturnBookList = new System.Windows.Forms.DataGridView();
            this.lblReturnBookKind = new System.Windows.Forms.Label();
            this.txtReturnBookKind = new System.Windows.Forms.TextBox();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.lblReturnBookAuthor = new System.Windows.Forms.Label();
            this.txtReturnBookAuthor = new System.Windows.Forms.TextBox();
            this.lblReturnBookName = new System.Windows.Forms.Label();
            this.txtReturnBookName = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.grpBook.SuspendLayout();
            this.grpStuGetBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).BeginInit();
            this.grpStuReturnBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.btnStuGetBook);
            this.grpBook.Controls.Add(this.btnStuReturnBook);
            this.grpBook.Location = new System.Drawing.Point(12, 12);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(132, 117);
            this.grpBook.TabIndex = 0;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // btnStuGetBook
            // 
            this.btnStuGetBook.Location = new System.Drawing.Point(6, 26);
            this.btnStuGetBook.Name = "btnStuGetBook";
            this.btnStuGetBook.Size = new System.Drawing.Size(120, 37);
            this.btnStuGetBook.TabIndex = 0;
            this.btnStuGetBook.Text = "Get a Book";
            this.btnStuGetBook.UseVisualStyleBackColor = true;
            this.btnStuGetBook.Click += new System.EventHandler(this.btnStuGetBook_Click);
            // 
            // btnStuReturnBook
            // 
            this.btnStuReturnBook.Location = new System.Drawing.Point(6, 69);
            this.btnStuReturnBook.Name = "btnStuReturnBook";
            this.btnStuReturnBook.Size = new System.Drawing.Size(120, 37);
            this.btnStuReturnBook.TabIndex = 1;
            this.btnStuReturnBook.Text = "Return a Book";
            this.btnStuReturnBook.UseVisualStyleBackColor = true;
            this.btnStuReturnBook.Click += new System.EventHandler(this.btnStuReturnBook_Click);
            // 
            // grpStuGetBook
            // 
            this.grpStuGetBook.Controls.Add(this.lbGetBookKind);
            this.grpStuGetBook.Controls.Add(this.txtGetBookKind);
            this.grpStuGetBook.Controls.Add(this.btnGetBook);
            this.grpStuGetBook.Controls.Add(this.lblGetBookAuthor);
            this.grpStuGetBook.Controls.Add(this.txtGetBookAuthor);
            this.grpStuGetBook.Controls.Add(this.lblGetBookName);
            this.grpStuGetBook.Controls.Add(this.txtGetBookName);
            this.grpStuGetBook.Controls.Add(this.txtGetBookListSearch);
            this.grpStuGetBook.Controls.Add(this.lblGetBookListSearch);
            this.grpStuGetBook.Controls.Add(this.dgvGetBookList);
            this.grpStuGetBook.Location = new System.Drawing.Point(150, 12);
            this.grpStuGetBook.Name = "grpStuGetBook";
            this.grpStuGetBook.Size = new System.Drawing.Size(557, 376);
            this.grpStuGetBook.TabIndex = 5;
            this.grpStuGetBook.TabStop = false;
            this.grpStuGetBook.Text = "Get a Book";
            this.grpStuGetBook.Visible = false;
            // 
            // lbGetBookKind
            // 
            this.lbGetBookKind.AutoSize = true;
            this.lbGetBookKind.Location = new System.Drawing.Point(38, 209);
            this.lbGetBookKind.Name = "lbGetBookKind";
            this.lbGetBookKind.Size = new System.Drawing.Size(47, 22);
            this.lbGetBookKind.TabIndex = 21;
            this.lbGetBookKind.Text = "Kind:";
            // 
            // txtGetBookKind
            // 
            this.txtGetBookKind.Enabled = false;
            this.txtGetBookKind.Location = new System.Drawing.Point(91, 206);
            this.txtGetBookKind.Name = "txtGetBookKind";
            this.txtGetBookKind.Size = new System.Drawing.Size(140, 29);
            this.txtGetBookKind.TabIndex = 20;
            // 
            // btnGetBook
            // 
            this.btnGetBook.Location = new System.Drawing.Point(125, 241);
            this.btnGetBook.Name = "btnGetBook";
            this.btnGetBook.Size = new System.Drawing.Size(75, 35);
            this.btnGetBook.TabIndex = 19;
            this.btnGetBook.Text = "Get";
            this.btnGetBook.UseVisualStyleBackColor = true;
            this.btnGetBook.Click += new System.EventHandler(this.btnGetBook_Click);
            // 
            // lblGetBookAuthor
            // 
            this.lblGetBookAuthor.AutoSize = true;
            this.lblGetBookAuthor.Location = new System.Drawing.Point(24, 174);
            this.lblGetBookAuthor.Name = "lblGetBookAuthor";
            this.lblGetBookAuthor.Size = new System.Drawing.Size(61, 22);
            this.lblGetBookAuthor.TabIndex = 18;
            this.lblGetBookAuthor.Text = "Author:";
            // 
            // txtGetBookAuthor
            // 
            this.txtGetBookAuthor.Enabled = false;
            this.txtGetBookAuthor.Location = new System.Drawing.Point(91, 171);
            this.txtGetBookAuthor.Name = "txtGetBookAuthor";
            this.txtGetBookAuthor.Size = new System.Drawing.Size(140, 29);
            this.txtGetBookAuthor.TabIndex = 17;
            // 
            // lblGetBookName
            // 
            this.lblGetBookName.AutoSize = true;
            this.lblGetBookName.Location = new System.Drawing.Point(29, 140);
            this.lblGetBookName.Name = "lblGetBookName";
            this.lblGetBookName.Size = new System.Drawing.Size(56, 22);
            this.lblGetBookName.TabIndex = 16;
            this.lblGetBookName.Text = "Name:";
            // 
            // txtGetBookName
            // 
            this.txtGetBookName.Enabled = false;
            this.txtGetBookName.Location = new System.Drawing.Point(91, 137);
            this.txtGetBookName.Name = "txtGetBookName";
            this.txtGetBookName.Size = new System.Drawing.Size(140, 29);
            this.txtGetBookName.TabIndex = 15;
            // 
            // txtGetBookListSearch
            // 
            this.txtGetBookListSearch.Location = new System.Drawing.Point(392, 30);
            this.txtGetBookListSearch.Name = "txtGetBookListSearch";
            this.txtGetBookListSearch.Size = new System.Drawing.Size(159, 29);
            this.txtGetBookListSearch.TabIndex = 3;
            this.txtGetBookListSearch.TextChanged += new System.EventHandler(this.txtGetBookListSearch_TextChanged);
            // 
            // lblGetBookListSearch
            // 
            this.lblGetBookListSearch.AutoSize = true;
            this.lblGetBookListSearch.Location = new System.Drawing.Point(258, 33);
            this.lblGetBookListSearch.Name = "lblGetBookListSearch";
            this.lblGetBookListSearch.Size = new System.Drawing.Size(128, 22);
            this.lblGetBookListSearch.TabIndex = 2;
            this.lblGetBookListSearch.Text = "Search by Name:";
            // 
            // dgvGetBookList
            // 
            this.dgvGetBookList.AutoGenerateColumns = false;
            this.dgvGetBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.kindDataGridViewTextBoxColumn});
            this.dgvGetBookList.DataSource = this.booksBindingSource;
            this.dgvGetBookList.Location = new System.Drawing.Point(262, 63);
            this.dgvGetBookList.Name = "dgvGetBookList";
            this.dgvGetBookList.Size = new System.Drawing.Size(289, 304);
            this.dgvGetBookList.TabIndex = 0;
            this.dgvGetBookList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGetBookList_CellDoubleClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            // 
            // kindDataGridViewTextBoxColumn
            // 
            this.kindDataGridViewTextBoxColumn.DataPropertyName = "Kind";
            this.kindDataGridViewTextBoxColumn.HeaderText = "Kind";
            this.kindDataGridViewTextBoxColumn.Name = "kindDataGridViewTextBoxColumn";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.libraryManagementDataSet;
            // 
            // libraryManagementDataSet
            // 
            this.libraryManagementDataSet.DataSetName = "libraryManagementDataSet";
            this.libraryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // grpStuReturnBook
            // 
            this.grpStuReturnBook.Controls.Add(this.dgvReturnBookList);
            this.grpStuReturnBook.Controls.Add(this.lblReturnBookKind);
            this.grpStuReturnBook.Controls.Add(this.txtReturnBookKind);
            this.grpStuReturnBook.Controls.Add(this.btnReturnBook);
            this.grpStuReturnBook.Controls.Add(this.lblReturnBookAuthor);
            this.grpStuReturnBook.Controls.Add(this.txtReturnBookAuthor);
            this.grpStuReturnBook.Controls.Add(this.lblReturnBookName);
            this.grpStuReturnBook.Controls.Add(this.txtReturnBookName);
            this.grpStuReturnBook.Location = new System.Drawing.Point(150, 12);
            this.grpStuReturnBook.Name = "grpStuReturnBook";
            this.grpStuReturnBook.Size = new System.Drawing.Size(557, 376);
            this.grpStuReturnBook.TabIndex = 6;
            this.grpStuReturnBook.TabStop = false;
            this.grpStuReturnBook.Text = "Return a Book";
            this.grpStuReturnBook.Visible = false;
            // 
            // dgvReturnBookList
            // 
            this.dgvReturnBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnBookList.Location = new System.Drawing.Point(262, 26);
            this.dgvReturnBookList.Name = "dgvReturnBookList";
            this.dgvReturnBookList.Size = new System.Drawing.Size(289, 341);
            this.dgvReturnBookList.TabIndex = 22;
            this.dgvReturnBookList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnBookList_CellDoubleClick);
            // 
            // lblReturnBookKind
            // 
            this.lblReturnBookKind.AutoSize = true;
            this.lblReturnBookKind.Location = new System.Drawing.Point(38, 209);
            this.lblReturnBookKind.Name = "lblReturnBookKind";
            this.lblReturnBookKind.Size = new System.Drawing.Size(47, 22);
            this.lblReturnBookKind.TabIndex = 21;
            this.lblReturnBookKind.Text = "Kind:";
            // 
            // txtReturnBookKind
            // 
            this.txtReturnBookKind.Enabled = false;
            this.txtReturnBookKind.Location = new System.Drawing.Point(91, 206);
            this.txtReturnBookKind.Name = "txtReturnBookKind";
            this.txtReturnBookKind.Size = new System.Drawing.Size(140, 29);
            this.txtReturnBookKind.TabIndex = 20;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(125, 241);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(75, 35);
            this.btnReturnBook.TabIndex = 19;
            this.btnReturnBook.Text = "Return";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // lblReturnBookAuthor
            // 
            this.lblReturnBookAuthor.AutoSize = true;
            this.lblReturnBookAuthor.Location = new System.Drawing.Point(24, 174);
            this.lblReturnBookAuthor.Name = "lblReturnBookAuthor";
            this.lblReturnBookAuthor.Size = new System.Drawing.Size(61, 22);
            this.lblReturnBookAuthor.TabIndex = 18;
            this.lblReturnBookAuthor.Text = "Author:";
            // 
            // txtReturnBookAuthor
            // 
            this.txtReturnBookAuthor.Enabled = false;
            this.txtReturnBookAuthor.Location = new System.Drawing.Point(91, 171);
            this.txtReturnBookAuthor.Name = "txtReturnBookAuthor";
            this.txtReturnBookAuthor.Size = new System.Drawing.Size(140, 29);
            this.txtReturnBookAuthor.TabIndex = 17;
            // 
            // lblReturnBookName
            // 
            this.lblReturnBookName.AutoSize = true;
            this.lblReturnBookName.Location = new System.Drawing.Point(29, 140);
            this.lblReturnBookName.Name = "lblReturnBookName";
            this.lblReturnBookName.Size = new System.Drawing.Size(56, 22);
            this.lblReturnBookName.TabIndex = 16;
            this.lblReturnBookName.Text = "Name:";
            // 
            // txtReturnBookName
            // 
            this.txtReturnBookName.Enabled = false;
            this.txtReturnBookName.Location = new System.Drawing.Point(91, 137);
            this.txtReturnBookName.Name = "txtReturnBookName";
            this.txtReturnBookName.Size = new System.Drawing.Size(140, 29);
            this.txtReturnBookName.TabIndex = 15;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(18, 135);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(120, 37);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // stuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(715, 397);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.grpStuReturnBook);
            this.Controls.Add(this.grpStuGetBook);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "stuMain";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.stuMain_Load);
            this.grpBook.ResumeLayout(false);
            this.grpStuGetBook.ResumeLayout(false);
            this.grpStuGetBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).EndInit();
            this.grpStuReturnBook.ResumeLayout(false);
            this.grpStuReturnBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Button btnStuGetBook;
        private System.Windows.Forms.Button btnStuReturnBook;
        private System.Windows.Forms.GroupBox grpStuGetBook;
        private System.Windows.Forms.TextBox txtGetBookListSearch;
        private System.Windows.Forms.Label lblGetBookListSearch;
        private System.Windows.Forms.DataGridView dgvGetBookList;
        private System.Windows.Forms.Label lbGetBookKind;
        private System.Windows.Forms.TextBox txtGetBookKind;
        private System.Windows.Forms.Button btnGetBook;
        private System.Windows.Forms.Label lblGetBookAuthor;
        private System.Windows.Forms.TextBox txtGetBookAuthor;
        private System.Windows.Forms.Label lblGetBookName;
        private System.Windows.Forms.TextBox txtGetBookName;
        private libraryManagementDataSet libraryManagementDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private libraryManagementDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grpStuReturnBook;
        private System.Windows.Forms.Label lblReturnBookKind;
        private System.Windows.Forms.TextBox txtReturnBookKind;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Label lblReturnBookAuthor;
        private System.Windows.Forms.TextBox txtReturnBookAuthor;
        private System.Windows.Forms.Label lblReturnBookName;
        private System.Windows.Forms.TextBox txtReturnBookName;
        private System.Windows.Forms.DataGridView dgvReturnBookList;
        private System.Windows.Forms.Button btnLogOut;
    }
}