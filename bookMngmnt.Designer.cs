namespace Book_borrowing
{
    partial class bookMngmnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookMngmnt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoryLink = new System.Windows.Forms.LinkLabel();
            this.newBook = new System.Windows.Forms.LinkLabel();
            this.publisherLink = new System.Windows.Forms.LinkLabel();
            this.bookTypeCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bookDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.bookId = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteBook = new Guna.UI2.WinForms.Guna2Button();
            this.updateBook = new Guna.UI2.WinForms.Guna2Button();
            this.addBook = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryTxt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.publisherTxt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.publisherCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.categoryCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bookPublisher = new Guna.UI2.WinForms.Guna2TextBox();
            this.bookCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.bookTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.updatingTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.bookDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCategory = new System.Windows.Forms.Label();
            this.searchPublisher = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(106)))), ((int)(((byte)(182)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.bookDgv);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1748, 896);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.groupBox1.Controls.Add(this.categoryLink);
            this.groupBox1.Controls.Add(this.newBook);
            this.groupBox1.Controls.Add(this.publisherLink);
            this.groupBox1.Controls.Add(this.bookTypeCb);
            this.groupBox1.Controls.Add(this.bookDate);
            this.groupBox1.Controls.Add(this.bookId);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.categoryTxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.publisherTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.publisherCb);
            this.groupBox1.Controls.Add(this.categoryCb);
            this.groupBox1.Controls.Add(this.bookPublisher);
            this.groupBox1.Controls.Add(this.bookCategory);
            this.groupBox1.Controls.Add(this.bookTitle);
            this.groupBox1.Controls.Add(this.updatingTitle);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1740, 477);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // categoryLink
            // 
            this.categoryLink.AutoSize = true;
            this.categoryLink.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLink.Location = new System.Drawing.Point(1140, 178);
            this.categoryLink.Name = "categoryLink";
            this.categoryLink.Size = new System.Drawing.Size(101, 28);
            this.categoryLink.TabIndex = 4;
            this.categoryLink.TabStop = true;
            this.categoryLink.Text = "Click here";
            this.categoryLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.categoryLink_LinkClicked);
            // 
            // newBook
            // 
            this.newBook.AutoSize = true;
            this.newBook.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBook.Location = new System.Drawing.Point(502, 181);
            this.newBook.Name = "newBook";
            this.newBook.Size = new System.Drawing.Size(101, 28);
            this.newBook.TabIndex = 4;
            this.newBook.TabStop = true;
            this.newBook.Text = "Click here";
            this.newBook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newBook_LinkClicked);
            // 
            // publisherLink
            // 
            this.publisherLink.AutoSize = true;
            this.publisherLink.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLink.Location = new System.Drawing.Point(502, 268);
            this.publisherLink.Name = "publisherLink";
            this.publisherLink.Size = new System.Drawing.Size(101, 28);
            this.publisherLink.TabIndex = 4;
            this.publisherLink.TabStop = true;
            this.publisherLink.Text = "Click here";
            this.publisherLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.publisherLink_LinkClicked);
            // 
            // bookTypeCb
            // 
            this.bookTypeCb.AutoRoundedCorners = true;
            this.bookTypeCb.BackColor = System.Drawing.Color.Transparent;
            this.bookTypeCb.BorderRadius = 17;
            this.bookTypeCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookTypeCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bookTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookTypeCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookTypeCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookTypeCb.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.bookTypeCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.bookTypeCb.ItemHeight = 30;
            this.bookTypeCb.Items.AddRange(new object[] {
            "Select Type",
            "Read Only",
            "Borrow"});
            this.bookTypeCb.Location = new System.Drawing.Point(762, 306);
            this.bookTypeCb.Name = "bookTypeCb";
            this.bookTypeCb.Size = new System.Drawing.Size(492, 36);
            this.bookTypeCb.StartIndex = 0;
            this.bookTypeCb.TabIndex = 3;
            this.bookTypeCb.SelectedIndexChanged += new System.EventHandler(this.bookTypeCb_SelectedIndexChanged);
            // 
            // bookDate
            // 
            this.bookDate.AutoRoundedCorners = true;
            this.bookDate.BorderRadius = 20;
            this.bookDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookDate.DefaultText = "";
            this.bookDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookDate.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookDate.Location = new System.Drawing.Point(762, 123);
            this.bookDate.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.bookDate.Name = "bookDate";
            this.bookDate.PasswordChar = '\0';
            this.bookDate.PlaceholderText = "";
            this.bookDate.SelectedText = "";
            this.bookDate.Size = new System.Drawing.Size(492, 42);
            this.bookDate.TabIndex = 2;
            this.bookDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bookDate_KeyPress);
            // 
            // bookId
            // 
            this.bookId.AutoRoundedCorners = true;
            this.bookId.BorderRadius = 20;
            this.bookId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookId.DefaultText = "";
            this.bookId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookId.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookId.Location = new System.Drawing.Point(130, 123);
            this.bookId.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.bookId.Name = "bookId";
            this.bookId.PasswordChar = '\0';
            this.bookId.PlaceholderText = "";
            this.bookId.SelectedText = "";
            this.bookId.Size = new System.Drawing.Size(492, 42);
            this.bookId.TabIndex = 2;
            this.bookId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bookId_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.panel3.Controls.Add(this.deleteBook);
            this.panel3.Controls.Add(this.updateBook);
            this.panel3.Controls.Add(this.addBook);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.guna2Button3);
            this.panel3.Controls.Add(this.guna2Button2);
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Location = new System.Drawing.Point(1333, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 426);
            this.panel3.TabIndex = 1;
            // 
            // deleteBook
            // 
            this.deleteBook.AutoRoundedCorners = true;
            this.deleteBook.BackColor = System.Drawing.Color.Transparent;
            this.deleteBook.BorderRadius = 37;
            this.deleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(106)))), ((int)(((byte)(182)))));
            this.deleteBook.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.deleteBook.ForeColor = System.Drawing.Color.White;
            this.deleteBook.Image = ((System.Drawing.Image)(resources.GetObject("deleteBook.Image")));
            this.deleteBook.ImageSize = new System.Drawing.Size(50, 50);
            this.deleteBook.Location = new System.Drawing.Point(42, 273);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(287, 77);
            this.deleteBook.TabIndex = 2;
            this.deleteBook.Text = "DELETE BOOK";
            this.deleteBook.UseTransparentBackground = true;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // updateBook
            // 
            this.updateBook.AutoRoundedCorners = true;
            this.updateBook.BackColor = System.Drawing.Color.Transparent;
            this.updateBook.BorderRadius = 37;
            this.updateBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(106)))), ((int)(((byte)(182)))));
            this.updateBook.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.updateBook.ForeColor = System.Drawing.Color.White;
            this.updateBook.Image = ((System.Drawing.Image)(resources.GetObject("updateBook.Image")));
            this.updateBook.ImageSize = new System.Drawing.Size(50, 50);
            this.updateBook.Location = new System.Drawing.Point(42, 175);
            this.updateBook.Name = "updateBook";
            this.updateBook.Size = new System.Drawing.Size(287, 77);
            this.updateBook.TabIndex = 2;
            this.updateBook.Text = "UPDATE BOOK";
            this.updateBook.UseTransparentBackground = true;
            this.updateBook.Click += new System.EventHandler(this.updateBook_Click);
            // 
            // addBook
            // 
            this.addBook.AutoRoundedCorners = true;
            this.addBook.BackColor = System.Drawing.Color.Transparent;
            this.addBook.BorderRadius = 37;
            this.addBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(106)))), ((int)(((byte)(182)))));
            this.addBook.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.addBook.ForeColor = System.Drawing.Color.White;
            this.addBook.Image = ((System.Drawing.Image)(resources.GetObject("addBook.Image")));
            this.addBook.ImageSize = new System.Drawing.Size(50, 50);
            this.addBook.Location = new System.Drawing.Point(42, 78);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(287, 77);
            this.addBook.TabIndex = 2;
            this.addBook.Text = "  ADD BOOK";
            this.addBook.UseTransparentBackground = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "Control";
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderRadius = 37;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(68)))), ((int)(((byte)(145)))));
            this.guna2Button3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2Button3.Location = new System.Drawing.Point(46, 267);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(287, 77);
            this.guna2Button3.TabIndex = 2;
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 37;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(68)))), ((int)(((byte)(145)))));
            this.guna2Button2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2Button2.Location = new System.Drawing.Point(46, 170);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(287, 77);
            this.guna2Button2.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 37;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(68)))), ((int)(((byte)(145)))));
            this.guna2Button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2Button1.Location = new System.Drawing.Point(46, 73);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(287, 77);
            this.guna2Button1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(744, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date";
            // 
            // categoryTxt
            // 
            this.categoryTxt.AutoSize = true;
            this.categoryTxt.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTxt.Location = new System.Drawing.Point(996, 181);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(138, 25);
            this.categoryTxt.TabIndex = 0;
            this.categoryTxt.Text = "New Category?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(351, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Add New Book?";
            // 
            // publisherTxt
            // 
            this.publisherTxt.AutoSize = true;
            this.publisherTxt.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherTxt.Location = new System.Drawing.Point(354, 268);
            this.publisherTxt.Name = "publisherTxt";
            this.publisherTxt.Size = new System.Drawing.Size(141, 25);
            this.publisherTxt.TabIndex = 0;
            this.publisherTxt.Text = "New Publisher?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Publisher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(744, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Book Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(744, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book ID";
            // 
            // publisherCb
            // 
            this.publisherCb.AutoRoundedCorners = true;
            this.publisherCb.BackColor = System.Drawing.Color.Transparent;
            this.publisherCb.BorderRadius = 17;
            this.publisherCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.publisherCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.publisherCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publisherCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.publisherCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.publisherCb.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.publisherCb.ItemHeight = 30;
            this.publisherCb.Items.AddRange(new object[] {
            "Select Publisher"});
            this.publisherCb.Location = new System.Drawing.Point(130, 306);
            this.publisherCb.Name = "publisherCb";
            this.publisherCb.Size = new System.Drawing.Size(492, 36);
            this.publisherCb.StartIndex = 0;
            this.publisherCb.TabIndex = 3;
            this.publisherCb.SelectedValueChanged += new System.EventHandler(this.publisherCb_SelectedValueChanged);
            // 
            // categoryCb
            // 
            this.categoryCb.AutoRoundedCorners = true;
            this.categoryCb.BackColor = System.Drawing.Color.Transparent;
            this.categoryCb.BorderRadius = 17;
            this.categoryCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryCb.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.categoryCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.categoryCb.ItemHeight = 30;
            this.categoryCb.Items.AddRange(new object[] {
            "Select Category"});
            this.categoryCb.Location = new System.Drawing.Point(762, 216);
            this.categoryCb.Name = "categoryCb";
            this.categoryCb.Size = new System.Drawing.Size(492, 36);
            this.categoryCb.StartIndex = 0;
            this.categoryCb.TabIndex = 3;
            this.categoryCb.SelectedValueChanged += new System.EventHandler(this.categoryCb_SelectedValueChanged);
            // 
            // bookPublisher
            // 
            this.bookPublisher.AutoRoundedCorners = true;
            this.bookPublisher.BorderRadius = 20;
            this.bookPublisher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookPublisher.DefaultText = "";
            this.bookPublisher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookPublisher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookPublisher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookPublisher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookPublisher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookPublisher.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookPublisher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookPublisher.Location = new System.Drawing.Point(130, 303);
            this.bookPublisher.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bookPublisher.Name = "bookPublisher";
            this.bookPublisher.PasswordChar = '\0';
            this.bookPublisher.PlaceholderText = "";
            this.bookPublisher.SelectedText = "";
            this.bookPublisher.Size = new System.Drawing.Size(492, 42);
            this.bookPublisher.TabIndex = 2;
            // 
            // bookCategory
            // 
            this.bookCategory.AutoRoundedCorners = true;
            this.bookCategory.BorderRadius = 20;
            this.bookCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookCategory.DefaultText = "";
            this.bookCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookCategory.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookCategory.Location = new System.Drawing.Point(762, 213);
            this.bookCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookCategory.Name = "bookCategory";
            this.bookCategory.PasswordChar = '\0';
            this.bookCategory.PlaceholderText = "";
            this.bookCategory.SelectedText = "";
            this.bookCategory.Size = new System.Drawing.Size(492, 42);
            this.bookCategory.TabIndex = 2;
            // 
            // bookTitle
            // 
            this.bookTitle.AutoRoundedCorners = true;
            this.bookTitle.BorderRadius = 20;
            this.bookTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookTitle.DefaultText = "";
            this.bookTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookTitle.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookTitle.Location = new System.Drawing.Point(130, 213);
            this.bookTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.PasswordChar = '\0';
            this.bookTitle.PlaceholderText = "";
            this.bookTitle.SelectedText = "";
            this.bookTitle.Size = new System.Drawing.Size(492, 42);
            this.bookTitle.TabIndex = 2;
            this.bookTitle.TextChanged += new System.EventHandler(this.bookTitle_TextChanged);
            // 
            // updatingTitle
            // 
            this.updatingTitle.AutoRoundedCorners = true;
            this.updatingTitle.BorderRadius = 20;
            this.updatingTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updatingTitle.DefaultText = "";
            this.updatingTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.updatingTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.updatingTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updatingTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updatingTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updatingTitle.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.updatingTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updatingTitle.Location = new System.Drawing.Point(130, 213);
            this.updatingTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updatingTitle.Name = "updatingTitle";
            this.updatingTitle.PasswordChar = '\0';
            this.updatingTitle.PlaceholderText = "";
            this.updatingTitle.SelectedText = "";
            this.updatingTitle.Size = new System.Drawing.Size(492, 42);
            this.updatingTitle.TabIndex = 2;
            // 
            // bookDgv
            // 
            this.bookDgv.AllowUserToAddRows = false;
            this.bookDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.bookDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bookDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.bookDgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bookDgv.ColumnHeadersHeight = 18;
            this.bookDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.bookDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.bookDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.bookDgv.Location = new System.Drawing.Point(0, 561);
            this.bookDgv.Name = "bookDgv";
            this.bookDgv.ReadOnly = true;
            this.bookDgv.RowHeadersVisible = false;
            this.bookDgv.RowHeadersWidth = 51;
            this.bookDgv.RowTemplate.Height = 24;
            this.bookDgv.Size = new System.Drawing.Size(1744, 331);
            this.bookDgv.TabIndex = 3;
            this.bookDgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Amethyst;
            this.bookDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
            this.bookDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.bookDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.bookDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.bookDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.bookDgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.bookDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.bookDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.bookDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bookDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bookDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.bookDgv.ThemeStyle.HeaderStyle.Height = 18;
            this.bookDgv.ThemeStyle.ReadOnly = true;
            this.bookDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.bookDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bookDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bookDgv.ThemeStyle.RowsStyle.Height = 24;
            this.bookDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.bookDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bookDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookDgv_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "book_id";
            this.Column1.HeaderText = "Book ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "book_title";
            this.Column2.HeaderText = "Book Title";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "publisher_name";
            this.Column3.HeaderText = "Publisher";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "date_added";
            this.Column4.HeaderText = "Date added";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "category_name";
            this.Column5.HeaderText = "Category";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "booktype_desc";
            this.Column6.HeaderText = "Book Type";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(106)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1746, 79);
            this.panel2.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageRotate = 0F;
            this.exit.Location = new System.Drawing.Point(1681, 14);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(51, 48);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 3;
            this.exit.TabStop = false;
            this.exit.UseTransparentBackground = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Management";
            // 
            // searchCategory
            // 
            this.searchCategory.AutoSize = true;
            this.searchCategory.Location = new System.Drawing.Point(649, 967);
            this.searchCategory.Name = "searchCategory";
            this.searchCategory.Size = new System.Drawing.Size(44, 16);
            this.searchCategory.TabIndex = 2;
            this.searchCategory.Text = "label9";
            // 
            // searchPublisher
            // 
            this.searchPublisher.AutoSize = true;
            this.searchPublisher.Location = new System.Drawing.Point(788, 979);
            this.searchPublisher.Name = "searchPublisher";
            this.searchPublisher.Size = new System.Drawing.Size(44, 16);
            this.searchPublisher.TabIndex = 2;
            this.searchPublisher.Text = "label9";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bookMngmnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1800, 1072);
            this.Controls.Add(this.searchPublisher);
            this.Controls.Add(this.searchCategory);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookMngmnt";
            this.Text = "bookMngmnt";
            this.Load += new System.EventHandler(this.bookMngmnt_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox exit;
        private Guna.UI2.WinForms.Guna2DataGridView bookDgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox publisherCb;
        private Guna.UI2.WinForms.Guna2TextBox bookPublisher;
        private Guna.UI2.WinForms.Guna2TextBox bookTitle;
        private Guna.UI2.WinForms.Guna2TextBox bookId;
        private Guna.UI2.WinForms.Guna2TextBox bookCategory;
        private Guna.UI2.WinForms.Guna2TextBox date;
        private Guna.UI2.WinForms.Guna2ComboBox bookTypeCb;
        private Guna.UI2.WinForms.Guna2ComboBox categoryCb;
        private Guna.UI2.WinForms.Guna2Button addBook;
        private Guna.UI2.WinForms.Guna2Button updateBook;
        private Guna.UI2.WinForms.Guna2Button deleteBook;
        private System.Windows.Forms.LinkLabel categoryLink;
        private System.Windows.Forms.LinkLabel publisherLink;
        private System.Windows.Forms.Label categoryTxt;
        private System.Windows.Forms.Label publisherTxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox bookDate;
        private System.Windows.Forms.Label searchCategory;
        private System.Windows.Forms.Label searchPublisher;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Guna.UI2.WinForms.Guna2TextBox updatingTitle;
        private System.Windows.Forms.LinkLabel newBook;
        private System.Windows.Forms.Label label9;
    }
}