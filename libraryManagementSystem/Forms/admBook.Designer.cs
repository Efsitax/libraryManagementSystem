namespace libraryManagementSystem
{
    partial class admBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admBook));
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.btnBookUptDelOp = new System.Windows.Forms.Button();
            this.btnBookAddOp = new System.Windows.Forms.Button();
            this.btnBookListOp = new System.Windows.Forms.Button();
            this.grpBookAdd = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblBookAddKind = new System.Windows.Forms.Label();
            this.txtBookAddKind = new System.Windows.Forms.TextBox();
            this.lblBookAddAuthor = new System.Windows.Forms.Label();
            this.txtBookAddAuthor = new System.Windows.Forms.TextBox();
            this.lblBookAddName = new System.Windows.Forms.Label();
            this.txtBookAddName = new System.Windows.Forms.TextBox();
            this.grpBookList = new System.Windows.Forms.GroupBox();
            this.txtBookListSearch = new System.Windows.Forms.TextBox();
            this.lblBookListSearch = new System.Windows.Forms.Label();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet = new libraryManagementSystem.libraryManagementDataSet();
            this.grpBookUptDel = new System.Windows.Forms.GroupBox();
            this.txtBookUptDelKind = new System.Windows.Forms.TextBox();
            this.lblBookUptDelKind = new System.Windows.Forms.Label();
            this.txtBookUptDelName = new System.Windows.Forms.TextBox();
            this.btnBookUptDelGet = new System.Windows.Forms.Button();
            this.dgvBookUptDel = new System.Windows.Forms.DataGridView();
            this.lblBookUptDelName = new System.Windows.Forms.Label();
            this.txtBookUptDelAuthor = new System.Windows.Forms.TextBox();
            this.lblBookUptDelID = new System.Windows.Forms.Label();
            this.txtBookUptDelID = new System.Windows.Forms.TextBox();
            this.lblBookUptDelAuthor = new System.Windows.Forms.Label();
            this.btnBookDel = new System.Windows.Forms.Button();
            this.btnBookUpt = new System.Windows.Forms.Button();
            this.btnBookTListOp = new System.Windows.Forms.Button();
            this.grpBookTList = new System.Windows.Forms.GroupBox();
            this.txtBookTListSearch = new System.Windows.Forms.TextBox();
            this.lblBookTListSearch = new System.Windows.Forms.Label();
            this.dgvBookTList = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.booksTableAdapter = new libraryManagementSystem.libraryManagementDataSetTableAdapters.booksTableAdapter();
            this.ıDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBook.SuspendLayout();
            this.grpBookAdd.SuspendLayout();
            this.grpBookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).BeginInit();
            this.grpBookUptDel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookUptDel)).BeginInit();
            this.grpBookTList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookTList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.btnBookUptDelOp);
            this.grpBook.Controls.Add(this.btnBookAddOp);
            this.grpBook.Controls.Add(this.btnBookListOp);
            this.grpBook.Location = new System.Drawing.Point(12, 12);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(132, 176);
            this.grpBook.TabIndex = 0;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // btnBookUptDelOp
            // 
            this.btnBookUptDelOp.Location = new System.Drawing.Point(6, 112);
            this.btnBookUptDelOp.Name = "btnBookUptDelOp";
            this.btnBookUptDelOp.Size = new System.Drawing.Size(120, 57);
            this.btnBookUptDelOp.TabIndex = 2;
            this.btnBookUptDelOp.Text = "Update / Delete";
            this.btnBookUptDelOp.UseVisualStyleBackColor = true;
            this.btnBookUptDelOp.Click += new System.EventHandler(this.btnBookUptDelOp_Click);
            // 
            // btnBookAddOp
            // 
            this.btnBookAddOp.Location = new System.Drawing.Point(6, 26);
            this.btnBookAddOp.Name = "btnBookAddOp";
            this.btnBookAddOp.Size = new System.Drawing.Size(120, 37);
            this.btnBookAddOp.TabIndex = 0;
            this.btnBookAddOp.Text = "Add";
            this.btnBookAddOp.UseVisualStyleBackColor = true;
            this.btnBookAddOp.Click += new System.EventHandler(this.btnBookAddOp_Click);
            // 
            // btnBookListOp
            // 
            this.btnBookListOp.Location = new System.Drawing.Point(6, 69);
            this.btnBookListOp.Name = "btnBookListOp";
            this.btnBookListOp.Size = new System.Drawing.Size(120, 37);
            this.btnBookListOp.TabIndex = 1;
            this.btnBookListOp.Text = "List";
            this.btnBookListOp.UseVisualStyleBackColor = true;
            this.btnBookListOp.Click += new System.EventHandler(this.btnBookListOp_Click);
            // 
            // grpBookAdd
            // 
            this.grpBookAdd.Controls.Add(this.btnAddBook);
            this.grpBookAdd.Controls.Add(this.lblBookAddKind);
            this.grpBookAdd.Controls.Add(this.txtBookAddKind);
            this.grpBookAdd.Controls.Add(this.lblBookAddAuthor);
            this.grpBookAdd.Controls.Add(this.txtBookAddAuthor);
            this.grpBookAdd.Controls.Add(this.lblBookAddName);
            this.grpBookAdd.Controls.Add(this.txtBookAddName);
            this.grpBookAdd.Location = new System.Drawing.Point(150, 12);
            this.grpBookAdd.Name = "grpBookAdd";
            this.grpBookAdd.Size = new System.Drawing.Size(557, 373);
            this.grpBookAdd.TabIndex = 4;
            this.grpBookAdd.TabStop = false;
            this.grpBookAdd.Text = "Add Book";
            this.grpBookAdd.Visible = false;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(279, 231);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 35);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblBookAddKind
            // 
            this.lblBookAddKind.AutoSize = true;
            this.lblBookAddKind.Location = new System.Drawing.Point(193, 199);
            this.lblBookAddKind.Name = "lblBookAddKind";
            this.lblBookAddKind.Size = new System.Drawing.Size(47, 22);
            this.lblBookAddKind.TabIndex = 7;
            this.lblBookAddKind.Text = "Kind:";
            // 
            // txtBookAddKind
            // 
            this.txtBookAddKind.Location = new System.Drawing.Point(250, 196);
            this.txtBookAddKind.Name = "txtBookAddKind";
            this.txtBookAddKind.Size = new System.Drawing.Size(140, 29);
            this.txtBookAddKind.TabIndex = 2;
            // 
            // lblBookAddAuthor
            // 
            this.lblBookAddAuthor.AutoSize = true;
            this.lblBookAddAuthor.Location = new System.Drawing.Point(183, 164);
            this.lblBookAddAuthor.Name = "lblBookAddAuthor";
            this.lblBookAddAuthor.Size = new System.Drawing.Size(61, 22);
            this.lblBookAddAuthor.TabIndex = 5;
            this.lblBookAddAuthor.Text = "Author:";
            // 
            // txtBookAddAuthor
            // 
            this.txtBookAddAuthor.Location = new System.Drawing.Point(250, 161);
            this.txtBookAddAuthor.Name = "txtBookAddAuthor";
            this.txtBookAddAuthor.Size = new System.Drawing.Size(140, 29);
            this.txtBookAddAuthor.TabIndex = 1;
            // 
            // lblBookAddName
            // 
            this.lblBookAddName.AutoSize = true;
            this.lblBookAddName.Location = new System.Drawing.Point(188, 129);
            this.lblBookAddName.Name = "lblBookAddName";
            this.lblBookAddName.Size = new System.Drawing.Size(56, 22);
            this.lblBookAddName.TabIndex = 1;
            this.lblBookAddName.Text = "Name:";
            // 
            // txtBookAddName
            // 
            this.txtBookAddName.Location = new System.Drawing.Point(250, 126);
            this.txtBookAddName.Name = "txtBookAddName";
            this.txtBookAddName.Size = new System.Drawing.Size(140, 29);
            this.txtBookAddName.TabIndex = 0;
            // 
            // grpBookList
            // 
            this.grpBookList.Controls.Add(this.txtBookListSearch);
            this.grpBookList.Controls.Add(this.lblBookListSearch);
            this.grpBookList.Controls.Add(this.dgvBookList);
            this.grpBookList.Location = new System.Drawing.Point(150, 12);
            this.grpBookList.Name = "grpBookList";
            this.grpBookList.Size = new System.Drawing.Size(557, 373);
            this.grpBookList.TabIndex = 5;
            this.grpBookList.TabStop = false;
            this.grpBookList.Text = "List Books";
            this.grpBookList.Visible = false;
            // 
            // txtBookListSearch
            // 
            this.txtBookListSearch.Location = new System.Drawing.Point(144, 30);
            this.txtBookListSearch.Name = "txtBookListSearch";
            this.txtBookListSearch.Size = new System.Drawing.Size(407, 29);
            this.txtBookListSearch.TabIndex = 0;
            this.txtBookListSearch.TextChanged += new System.EventHandler(this.txtBookListSearch_TextChanged);
            // 
            // lblBookListSearch
            // 
            this.lblBookListSearch.AutoSize = true;
            this.lblBookListSearch.Location = new System.Drawing.Point(10, 33);
            this.lblBookListSearch.Name = "lblBookListSearch";
            this.lblBookListSearch.Size = new System.Drawing.Size(128, 22);
            this.lblBookListSearch.TabIndex = 2;
            this.lblBookListSearch.Text = "Search by Name:";
            // 
            // dgvBookList
            // 
            this.dgvBookList.AutoGenerateColumns = false;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.kindDataGridViewTextBoxColumn});
            this.dgvBookList.DataSource = this.booksBindingSource;
            this.dgvBookList.Location = new System.Drawing.Point(6, 63);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.Size = new System.Drawing.Size(545, 304);
            this.dgvBookList.TabIndex = 1;
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
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "Author Name";
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
            // grpBookUptDel
            // 
            this.grpBookUptDel.Controls.Add(this.txtBookUptDelKind);
            this.grpBookUptDel.Controls.Add(this.lblBookUptDelKind);
            this.grpBookUptDel.Controls.Add(this.txtBookUptDelName);
            this.grpBookUptDel.Controls.Add(this.btnBookUptDelGet);
            this.grpBookUptDel.Controls.Add(this.dgvBookUptDel);
            this.grpBookUptDel.Controls.Add(this.lblBookUptDelName);
            this.grpBookUptDel.Controls.Add(this.txtBookUptDelAuthor);
            this.grpBookUptDel.Controls.Add(this.lblBookUptDelID);
            this.grpBookUptDel.Controls.Add(this.txtBookUptDelID);
            this.grpBookUptDel.Controls.Add(this.lblBookUptDelAuthor);
            this.grpBookUptDel.Controls.Add(this.btnBookDel);
            this.grpBookUptDel.Controls.Add(this.btnBookUpt);
            this.grpBookUptDel.Location = new System.Drawing.Point(150, 12);
            this.grpBookUptDel.Name = "grpBookUptDel";
            this.grpBookUptDel.Size = new System.Drawing.Size(557, 373);
            this.grpBookUptDel.TabIndex = 6;
            this.grpBookUptDel.TabStop = false;
            this.grpBookUptDel.Text = "Update / Delete Book:";
            this.grpBookUptDel.Visible = false;
            // 
            // txtBookUptDelKind
            // 
            this.txtBookUptDelKind.Location = new System.Drawing.Point(116, 220);
            this.txtBookUptDelKind.Name = "txtBookUptDelKind";
            this.txtBookUptDelKind.Size = new System.Drawing.Size(140, 29);
            this.txtBookUptDelKind.TabIndex = 4;
            // 
            // lblBookUptDelKind
            // 
            this.lblBookUptDelKind.AutoSize = true;
            this.lblBookUptDelKind.Location = new System.Drawing.Point(63, 223);
            this.lblBookUptDelKind.Name = "lblBookUptDelKind";
            this.lblBookUptDelKind.Size = new System.Drawing.Size(47, 22);
            this.lblBookUptDelKind.TabIndex = 24;
            this.lblBookUptDelKind.Text = "Kind:";
            // 
            // txtBookUptDelName
            // 
            this.txtBookUptDelName.Location = new System.Drawing.Point(116, 150);
            this.txtBookUptDelName.Name = "txtBookUptDelName";
            this.txtBookUptDelName.Size = new System.Drawing.Size(140, 29);
            this.txtBookUptDelName.TabIndex = 2;
            // 
            // btnBookUptDelGet
            // 
            this.btnBookUptDelGet.Location = new System.Drawing.Point(204, 113);
            this.btnBookUptDelGet.Name = "btnBookUptDelGet";
            this.btnBookUptDelGet.Size = new System.Drawing.Size(54, 29);
            this.btnBookUptDelGet.TabIndex = 1;
            this.btnBookUptDelGet.Text = "Get";
            this.btnBookUptDelGet.UseVisualStyleBackColor = true;
            this.btnBookUptDelGet.Click += new System.EventHandler(this.btnBookUptDelGet_Click);
            // 
            // dgvBookUptDel
            // 
            this.dgvBookUptDel.AutoGenerateColumns = false;
            this.dgvBookUptDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookUptDel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.authorNameDataGridViewTextBoxColumn1,
            this.kindDataGridViewTextBoxColumn1});
            this.dgvBookUptDel.DataSource = this.booksBindingSource;
            this.dgvBookUptDel.Location = new System.Drawing.Point(267, 21);
            this.dgvBookUptDel.Name = "dgvBookUptDel";
            this.dgvBookUptDel.Size = new System.Drawing.Size(284, 346);
            this.dgvBookUptDel.TabIndex = 7;
            this.dgvBookUptDel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookUptDel_CellDoubleClick);
            // 
            // lblBookUptDelName
            // 
            this.lblBookUptDelName.AutoSize = true;
            this.lblBookUptDelName.Location = new System.Drawing.Point(54, 153);
            this.lblBookUptDelName.Name = "lblBookUptDelName";
            this.lblBookUptDelName.Size = new System.Drawing.Size(56, 22);
            this.lblBookUptDelName.TabIndex = 14;
            this.lblBookUptDelName.Text = "Name:";
            // 
            // txtBookUptDelAuthor
            // 
            this.txtBookUptDelAuthor.Location = new System.Drawing.Point(116, 185);
            this.txtBookUptDelAuthor.Name = "txtBookUptDelAuthor";
            this.txtBookUptDelAuthor.Size = new System.Drawing.Size(140, 29);
            this.txtBookUptDelAuthor.TabIndex = 3;
            // 
            // lblBookUptDelID
            // 
            this.lblBookUptDelID.AutoSize = true;
            this.lblBookUptDelID.Location = new System.Drawing.Point(7, 115);
            this.lblBookUptDelID.Name = "lblBookUptDelID";
            this.lblBookUptDelID.Size = new System.Drawing.Size(31, 22);
            this.lblBookUptDelID.TabIndex = 22;
            this.lblBookUptDelID.Text = "ID:";
            // 
            // txtBookUptDelID
            // 
            this.txtBookUptDelID.Location = new System.Drawing.Point(58, 112);
            this.txtBookUptDelID.Name = "txtBookUptDelID";
            this.txtBookUptDelID.Size = new System.Drawing.Size(140, 29);
            this.txtBookUptDelID.TabIndex = 0;
            // 
            // lblBookUptDelAuthor
            // 
            this.lblBookUptDelAuthor.AutoSize = true;
            this.lblBookUptDelAuthor.Location = new System.Drawing.Point(49, 188);
            this.lblBookUptDelAuthor.Name = "lblBookUptDelAuthor";
            this.lblBookUptDelAuthor.Size = new System.Drawing.Size(61, 22);
            this.lblBookUptDelAuthor.TabIndex = 16;
            this.lblBookUptDelAuthor.Text = "Author:";
            // 
            // btnBookDel
            // 
            this.btnBookDel.Location = new System.Drawing.Point(169, 255);
            this.btnBookDel.Name = "btnBookDel";
            this.btnBookDel.Size = new System.Drawing.Size(75, 35);
            this.btnBookDel.TabIndex = 6;
            this.btnBookDel.Text = "Delete";
            this.btnBookDel.UseVisualStyleBackColor = true;
            this.btnBookDel.Click += new System.EventHandler(this.btnBookDel_Click);
            // 
            // btnBookUpt
            // 
            this.btnBookUpt.Location = new System.Drawing.Point(81, 255);
            this.btnBookUpt.Name = "btnBookUpt";
            this.btnBookUpt.Size = new System.Drawing.Size(75, 35);
            this.btnBookUpt.TabIndex = 5;
            this.btnBookUpt.Text = "Update";
            this.btnBookUpt.UseVisualStyleBackColor = true;
            this.btnBookUpt.Click += new System.EventHandler(this.btnBookUpt_Click);
            // 
            // btnBookTListOp
            // 
            this.btnBookTListOp.Location = new System.Drawing.Point(18, 194);
            this.btnBookTListOp.Name = "btnBookTListOp";
            this.btnBookTListOp.Size = new System.Drawing.Size(120, 57);
            this.btnBookTListOp.TabIndex = 1;
            this.btnBookTListOp.Text = "Book Transfer Records";
            this.btnBookTListOp.UseVisualStyleBackColor = true;
            this.btnBookTListOp.Click += new System.EventHandler(this.btnBookTListOp_Click);
            // 
            // grpBookTList
            // 
            this.grpBookTList.Controls.Add(this.txtBookTListSearch);
            this.grpBookTList.Controls.Add(this.lblBookTListSearch);
            this.grpBookTList.Controls.Add(this.dgvBookTList);
            this.grpBookTList.Location = new System.Drawing.Point(150, 12);
            this.grpBookTList.Name = "grpBookTList";
            this.grpBookTList.Size = new System.Drawing.Size(557, 373);
            this.grpBookTList.TabIndex = 7;
            this.grpBookTList.TabStop = false;
            this.grpBookTList.Text = "List Book Transfer Records";
            this.grpBookTList.Visible = false;
            // 
            // txtBookTListSearch
            // 
            this.txtBookTListSearch.Location = new System.Drawing.Point(201, 30);
            this.txtBookTListSearch.Name = "txtBookTListSearch";
            this.txtBookTListSearch.Size = new System.Drawing.Size(350, 29);
            this.txtBookTListSearch.TabIndex = 0;
            this.txtBookTListSearch.TextChanged += new System.EventHandler(this.txtBookTListSearch_TextChanged);
            // 
            // lblBookTListSearch
            // 
            this.lblBookTListSearch.AutoSize = true;
            this.lblBookTListSearch.Location = new System.Drawing.Point(10, 33);
            this.lblBookTListSearch.Name = "lblBookTListSearch";
            this.lblBookTListSearch.Size = new System.Drawing.Size(185, 22);
            this.lblBookTListSearch.TabIndex = 2;
            this.lblBookTListSearch.Text = "Search by Student Name:";
            // 
            // dgvBookTList
            // 
            this.dgvBookTList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookTList.Location = new System.Drawing.Point(6, 63);
            this.dgvBookTList.Name = "dgvBookTList";
            this.dgvBookTList.Size = new System.Drawing.Size(545, 304);
            this.dgvBookTList.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(18, 257);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(53, 60);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(85, 257);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(53, 60);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn1
            // 
            this.ıDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn1.Name = "ıDDataGridViewTextBoxColumn1";
            this.ıDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // authorNameDataGridViewTextBoxColumn1
            // 
            this.authorNameDataGridViewTextBoxColumn1.DataPropertyName = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn1.HeaderText = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn1.Name = "authorNameDataGridViewTextBoxColumn1";
            // 
            // kindDataGridViewTextBoxColumn1
            // 
            this.kindDataGridViewTextBoxColumn1.DataPropertyName = "Kind";
            this.kindDataGridViewTextBoxColumn1.HeaderText = "Kind";
            this.kindDataGridViewTextBoxColumn1.Name = "kindDataGridViewTextBoxColumn1";
            // 
            // admBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(715, 397);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBookTListOp);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.grpBookUptDel);
            this.Controls.Add(this.grpBookTList);
            this.Controls.Add(this.grpBookList);
            this.Controls.Add(this.grpBookAdd);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admBook";
            this.Text = "Library Management System";
            this.grpBook.ResumeLayout(false);
            this.grpBookAdd.ResumeLayout(false);
            this.grpBookAdd.PerformLayout();
            this.grpBookList.ResumeLayout(false);
            this.grpBookList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).EndInit();
            this.grpBookUptDel.ResumeLayout(false);
            this.grpBookUptDel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookUptDel)).EndInit();
            this.grpBookTList.ResumeLayout(false);
            this.grpBookTList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookTList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Button btnBookUptDelOp;
        private System.Windows.Forms.Button btnBookAddOp;
        private System.Windows.Forms.Button btnBookListOp;
        private System.Windows.Forms.GroupBox grpBookAdd;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblBookAddKind;
        private System.Windows.Forms.TextBox txtBookAddKind;
        private System.Windows.Forms.Label lblBookAddAuthor;
        private System.Windows.Forms.TextBox txtBookAddAuthor;
        private System.Windows.Forms.Label lblBookAddName;
        private System.Windows.Forms.TextBox txtBookAddName;
        private System.Windows.Forms.GroupBox grpBookList;
        private System.Windows.Forms.TextBox txtBookListSearch;
        private System.Windows.Forms.Label lblBookListSearch;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.GroupBox grpBookUptDel;
        private System.Windows.Forms.Button btnBookUptDelGet;
        private System.Windows.Forms.DataGridView dgvBookUptDel;
        private System.Windows.Forms.Label lblBookUptDelID;
        private System.Windows.Forms.TextBox txtBookUptDelID;
        private System.Windows.Forms.Button btnBookDel;
        private System.Windows.Forms.Button btnBookUpt;
        private System.Windows.Forms.TextBox txtBookUptDelName;
        private System.Windows.Forms.Label lblBookUptDelName;
        private System.Windows.Forms.TextBox txtBookUptDelAuthor;
        private System.Windows.Forms.Label lblBookUptDelAuthor;
        private System.Windows.Forms.TextBox txtBookUptDelKind;
        private System.Windows.Forms.Label lblBookUptDelKind;
        private System.Windows.Forms.Button btnBookTListOp;
        private System.Windows.Forms.GroupBox grpBookTList;
        private System.Windows.Forms.TextBox txtBookTListSearch;
        private System.Windows.Forms.Label lblBookTListSearch;
        private System.Windows.Forms.DataGridView dgvBookTList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogOut;
        private libraryManagementDataSet libraryManagementDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private libraryManagementDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn1;
    }
}