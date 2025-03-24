namespace LibrarySystem
{
    partial class Main
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
            this.Member = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.MemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.member_name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteMemberBtn = new System.Windows.Forms.Button();
            this.UpdateMemberBtn = new System.Windows.Forms.Button();
            this.AddMemberBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DeleteAuthorBtn = new System.Windows.Forms.Button();
            this.UpdateAuthorBtn = new System.Windows.Forms.Button();
            this.AddAuthorBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.BookRating = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BookID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BookTiitle = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.DeleteBookBtn = new System.Windows.Forms.Button();
            this.UpdateBookBtn = new System.Windows.Forms.Button();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TimesBorrowed = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MemberIDFK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RecordID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BookIDFK = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.DeleteRecordBtn = new System.Windows.Forms.Button();
            this.UpdateRecordBtn = new System.Windows.Forms.Button();
            this.AddRecordBtn = new System.Windows.Forms.Button();
            this.AuthorIDFK = new System.Windows.Forms.NumericUpDown();
            this.TimeBorrowed = new System.Windows.Forms.TextBox();
            this.Member.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimesBorrowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorIDFK)).BeginInit();
            this.SuspendLayout();
            // 
            // Member
            // 
            this.Member.Controls.Add(this.tabPage1);
            this.Member.Controls.Add(this.tabPage2);
            this.Member.Controls.Add(this.tabPage3);
            this.Member.Controls.Add(this.tabPage4);
            this.Member.Location = new System.Drawing.Point(1, 1);
            this.Member.Name = "Member";
            this.Member.SelectedIndex = 0;
            this.Member.Size = new System.Drawing.Size(892, 522);
            this.Member.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.MemberID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.member_name);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.DeleteMemberBtn);
            this.tabPage1.Controls.Add(this.UpdateMemberBtn);
            this.tabPage1.Controls.Add(this.AddMemberBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(884, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Member";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Member ID";
            // 
            // MemberID
            // 
            this.MemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberID.Location = new System.Drawing.Point(31, 251);
            this.MemberID.Multiline = true;
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            this.MemberID.Size = new System.Drawing.Size(223, 42);
            this.MemberID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Member Name";
            // 
            // member_name
            // 
            this.member_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_name.Location = new System.Drawing.Point(31, 331);
            this.member_name.Multiline = true;
            this.member_name.Name = "member_name";
            this.member_name.Size = new System.Drawing.Size(223, 42);
            this.member_name.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 374);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // DeleteMemberBtn
            // 
            this.DeleteMemberBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteMemberBtn.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteMemberBtn.Location = new System.Drawing.Point(31, 149);
            this.DeleteMemberBtn.Name = "DeleteMemberBtn";
            this.DeleteMemberBtn.Size = new System.Drawing.Size(150, 50);
            this.DeleteMemberBtn.TabIndex = 9;
            this.DeleteMemberBtn.Text = "DELETE";
            this.DeleteMemberBtn.UseVisualStyleBackColor = false;
            this.DeleteMemberBtn.Click += new System.EventHandler(this.DeleteMemberBtn_Click);
            // 
            // UpdateMemberBtn
            // 
            this.UpdateMemberBtn.BackColor = System.Drawing.Color.Blue;
            this.UpdateMemberBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateMemberBtn.Location = new System.Drawing.Point(31, 90);
            this.UpdateMemberBtn.Name = "UpdateMemberBtn";
            this.UpdateMemberBtn.Size = new System.Drawing.Size(150, 50);
            this.UpdateMemberBtn.TabIndex = 8;
            this.UpdateMemberBtn.Text = "UPDATE";
            this.UpdateMemberBtn.UseVisualStyleBackColor = false;
            this.UpdateMemberBtn.Click += new System.EventHandler(this.UpdateMemberBtn_Click);
            // 
            // AddMemberBtn
            // 
            this.AddMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddMemberBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AddMemberBtn.Location = new System.Drawing.Point(31, 27);
            this.AddMemberBtn.Name = "AddMemberBtn";
            this.AddMemberBtn.Size = new System.Drawing.Size(150, 50);
            this.AddMemberBtn.TabIndex = 7;
            this.AddMemberBtn.Text = "ADD";
            this.AddMemberBtn.UseVisualStyleBackColor = false;
            this.AddMemberBtn.Click += new System.EventHandler(this.AddMemberBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.AuthorID);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.AuthorName);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.DeleteAuthorBtn);
            this.tabPage2.Controls.Add(this.UpdateAuthorBtn);
            this.tabPage2.Controls.Add(this.AddAuthorBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(884, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Author";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Author ID";
            // 
            // AuthorID
            // 
            this.AuthorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorID.Location = new System.Drawing.Point(30, 248);
            this.AuthorID.Multiline = true;
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.ReadOnly = true;
            this.AuthorID.Size = new System.Drawing.Size(223, 42);
            this.AuthorID.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Author Name";
            // 
            // AuthorName
            // 
            this.AuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorName.Location = new System.Drawing.Point(30, 328);
            this.AuthorName.Multiline = true;
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(223, 42);
            this.AuthorName.TabIndex = 24;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(291, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(472, 374);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // DeleteAuthorBtn
            // 
            this.DeleteAuthorBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteAuthorBtn.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteAuthorBtn.Location = new System.Drawing.Point(30, 146);
            this.DeleteAuthorBtn.Name = "DeleteAuthorBtn";
            this.DeleteAuthorBtn.Size = new System.Drawing.Size(150, 50);
            this.DeleteAuthorBtn.TabIndex = 22;
            this.DeleteAuthorBtn.Text = "DELETE";
            this.DeleteAuthorBtn.UseVisualStyleBackColor = false;
            this.DeleteAuthorBtn.Click += new System.EventHandler(this.DeleteAuthorBtn_Click);
            // 
            // UpdateAuthorBtn
            // 
            this.UpdateAuthorBtn.BackColor = System.Drawing.Color.Blue;
            this.UpdateAuthorBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateAuthorBtn.Location = new System.Drawing.Point(30, 87);
            this.UpdateAuthorBtn.Name = "UpdateAuthorBtn";
            this.UpdateAuthorBtn.Size = new System.Drawing.Size(150, 50);
            this.UpdateAuthorBtn.TabIndex = 21;
            this.UpdateAuthorBtn.Text = "UPDATE";
            this.UpdateAuthorBtn.UseVisualStyleBackColor = false;
            this.UpdateAuthorBtn.Click += new System.EventHandler(this.UpdateAuthorBtn_Click);
            // 
            // AddAuthorBtn
            // 
            this.AddAuthorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddAuthorBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AddAuthorBtn.Location = new System.Drawing.Point(30, 24);
            this.AddAuthorBtn.Name = "AddAuthorBtn";
            this.AddAuthorBtn.Size = new System.Drawing.Size(150, 50);
            this.AddAuthorBtn.TabIndex = 20;
            this.AddAuthorBtn.Text = "ADD";
            this.AddAuthorBtn.UseVisualStyleBackColor = false;
            this.AddAuthorBtn.Click += new System.EventHandler(this.AddAuthorBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.AuthorIDFK);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.BookRating);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.BookID);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.BookTiitle);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.DeleteBookBtn);
            this.tabPage3.Controls.Add(this.UpdateBookBtn);
            this.tabPage3.Controls.Add(this.AddBookBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(884, 496);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Book";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Author Id";
            // 
            // BookRating
            // 
            this.BookRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookRating.Location = new System.Drawing.Point(30, 335);
            this.BookRating.Multiline = true;
            this.BookRating.Name = "BookRating";
            this.BookRating.Size = new System.Drawing.Size(223, 42);
            this.BookRating.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Book Rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Book ID";
            // 
            // BookID
            // 
            this.BookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookID.Location = new System.Drawing.Point(30, 207);
            this.BookID.Multiline = true;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Size = new System.Drawing.Size(223, 42);
            this.BookID.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Book Name";
            // 
            // BookTiitle
            // 
            this.BookTiitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTiitle.Location = new System.Drawing.Point(30, 271);
            this.BookTiitle.Multiline = true;
            this.BookTiitle.Name = "BookTiitle";
            this.BookTiitle.Size = new System.Drawing.Size(223, 42);
            this.BookTiitle.TabIndex = 32;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(291, 24);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(530, 423);
            this.dataGridView3.TabIndex = 31;
            this.dataGridView3.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_RowHeaderMouseClick);
            // 
            // DeleteBookBtn
            // 
            this.DeleteBookBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBookBtn.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteBookBtn.Location = new System.Drawing.Point(30, 126);
            this.DeleteBookBtn.Name = "DeleteBookBtn";
            this.DeleteBookBtn.Size = new System.Drawing.Size(150, 50);
            this.DeleteBookBtn.TabIndex = 30;
            this.DeleteBookBtn.Text = "DELETE";
            this.DeleteBookBtn.UseVisualStyleBackColor = false;
            this.DeleteBookBtn.Click += new System.EventHandler(this.DeleteBookBtn_Click);
            // 
            // UpdateBookBtn
            // 
            this.UpdateBookBtn.BackColor = System.Drawing.Color.Blue;
            this.UpdateBookBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateBookBtn.Location = new System.Drawing.Point(30, 70);
            this.UpdateBookBtn.Name = "UpdateBookBtn";
            this.UpdateBookBtn.Size = new System.Drawing.Size(150, 50);
            this.UpdateBookBtn.TabIndex = 29;
            this.UpdateBookBtn.Text = "UPDATE";
            this.UpdateBookBtn.UseVisualStyleBackColor = false;
            this.UpdateBookBtn.Click += new System.EventHandler(this.UpdateBookBtn_Click);
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddBookBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AddBookBtn.Location = new System.Drawing.Point(30, 14);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(150, 50);
            this.AddBookBtn.TabIndex = 28;
            this.AddBookBtn.Text = "ADD";
            this.AddBookBtn.UseVisualStyleBackColor = false;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.TimeBorrowed);
            this.tabPage4.Controls.Add(this.TimesBorrowed);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.MemberIDFK);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.RecordID);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.BookIDFK);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.DeleteRecordBtn);
            this.tabPage4.Controls.Add(this.UpdateRecordBtn);
            this.tabPage4.Controls.Add(this.AddRecordBtn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(884, 496);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Borrowing Record";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TimesBorrowed
            // 
            this.TimesBorrowed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesBorrowed.Location = new System.Drawing.Point(30, 453);
            this.TimesBorrowed.Maximum = new decimal(new int[] {
            6091,
            0,
            0,
            0});
            this.TimesBorrowed.Name = "TimesBorrowed";
            this.TimesBorrowed.Size = new System.Drawing.Size(223, 25);
            this.TimesBorrowed.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "Times Borrowed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "Time Borrowed";
            // 
            // MemberIDFK
            // 
            this.MemberIDFK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDFK.Location = new System.Drawing.Point(30, 326);
            this.MemberIDFK.Multiline = true;
            this.MemberIDFK.Name = "MemberIDFK";
            this.MemberIDFK.Size = new System.Drawing.Size(223, 42);
            this.MemberIDFK.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Member ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Record ID";
            // 
            // RecordID
            // 
            this.RecordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordID.Location = new System.Drawing.Point(30, 198);
            this.RecordID.Multiline = true;
            this.RecordID.Name = "RecordID";
            this.RecordID.ReadOnly = true;
            this.RecordID.Size = new System.Drawing.Size(223, 42);
            this.RecordID.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Book ID";
            // 
            // BookIDFK
            // 
            this.BookIDFK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDFK.Location = new System.Drawing.Point(30, 262);
            this.BookIDFK.Multiline = true;
            this.BookIDFK.Name = "BookIDFK";
            this.BookIDFK.Size = new System.Drawing.Size(223, 42);
            this.BookIDFK.TabIndex = 32;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(291, 24);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(582, 457);
            this.dataGridView4.TabIndex = 31;
            this.dataGridView4.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView4_RowHeaderMouseClick);
            // 
            // DeleteRecordBtn
            // 
            this.DeleteRecordBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteRecordBtn.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteRecordBtn.Location = new System.Drawing.Point(30, 126);
            this.DeleteRecordBtn.Name = "DeleteRecordBtn";
            this.DeleteRecordBtn.Size = new System.Drawing.Size(150, 50);
            this.DeleteRecordBtn.TabIndex = 30;
            this.DeleteRecordBtn.Text = "DELETE";
            this.DeleteRecordBtn.UseVisualStyleBackColor = false;
            this.DeleteRecordBtn.Click += new System.EventHandler(this.DeleteRecordBtn_Click);
            // 
            // UpdateRecordBtn
            // 
            this.UpdateRecordBtn.BackColor = System.Drawing.Color.Blue;
            this.UpdateRecordBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateRecordBtn.Location = new System.Drawing.Point(30, 70);
            this.UpdateRecordBtn.Name = "UpdateRecordBtn";
            this.UpdateRecordBtn.Size = new System.Drawing.Size(150, 50);
            this.UpdateRecordBtn.TabIndex = 29;
            this.UpdateRecordBtn.Text = "UPDATE";
            this.UpdateRecordBtn.UseVisualStyleBackColor = false;
            this.UpdateRecordBtn.Click += new System.EventHandler(this.UpdateRecordBtn_Click);
            // 
            // AddRecordBtn
            // 
            this.AddRecordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddRecordBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AddRecordBtn.Location = new System.Drawing.Point(30, 14);
            this.AddRecordBtn.Name = "AddRecordBtn";
            this.AddRecordBtn.Size = new System.Drawing.Size(150, 50);
            this.AddRecordBtn.TabIndex = 28;
            this.AddRecordBtn.Text = "ADD";
            this.AddRecordBtn.UseVisualStyleBackColor = false;
            this.AddRecordBtn.Click += new System.EventHandler(this.AddRecordBtn_Click);
            // 
            // AuthorIDFK
            // 
            this.AuthorIDFK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorIDFK.Location = new System.Drawing.Point(30, 403);
            this.AuthorIDFK.Maximum = new decimal(new int[] {
            6091,
            0,
            0,
            0});
            this.AuthorIDFK.Name = "AuthorIDFK";
            this.AuthorIDFK.Size = new System.Drawing.Size(223, 25);
            this.AuthorIDFK.TabIndex = 44;
            // 
            // TimeBorrowed
            // 
            this.TimeBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBorrowed.Location = new System.Drawing.Point(30, 390);
            this.TimeBorrowed.Multiline = true;
            this.TimeBorrowed.Name = "TimeBorrowed";
            this.TimeBorrowed.Size = new System.Drawing.Size(223, 42);
            this.TimeBorrowed.TabIndex = 44;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 516);
            this.Controls.Add(this.Member);
            this.Name = "Main";
            this.Text = "Library System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Member.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimesBorrowed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorIDFK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Member;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox member_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteMemberBtn;
        private System.Windows.Forms.Button UpdateMemberBtn;
        private System.Windows.Forms.Button AddMemberBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MemberID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AuthorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AuthorName;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button DeleteAuthorBtn;
        private System.Windows.Forms.Button UpdateAuthorBtn;
        private System.Windows.Forms.Button AddAuthorBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BookID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BookTiitle;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button DeleteBookBtn;
        private System.Windows.Forms.Button UpdateBookBtn;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RecordID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BookIDFK;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button DeleteRecordBtn;
        private System.Windows.Forms.Button UpdateRecordBtn;
        private System.Windows.Forms.Button AddRecordBtn;
        private System.Windows.Forms.TextBox BookRating;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox MemberIDFK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown TimesBorrowed;
        private System.Windows.Forms.NumericUpDown AuthorIDFK;
        private System.Windows.Forms.TextBox TimeBorrowed;
    }
}