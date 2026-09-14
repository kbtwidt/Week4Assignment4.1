namespace Week4Assignment4._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PhoneBookGrid = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblFName = new Label();
            lblLName = new Label();
            lblMobile = new Label();
            lblOffice = new Label();
            lblAddress = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtMobile = new TextBox();
            txtOffice = new TextBox();
            txtAddress = new TextBox();
            btnAdd2 = new Button();
            ((System.ComponentModel.ISupportInitialize)PhoneBookGrid).BeginInit();
            SuspendLayout();
            // 
            // PhoneBookGrid
            // 
            PhoneBookGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PhoneBookGrid.Location = new Point(12, 12);
            PhoneBookGrid.Name = "PhoneBookGrid";
            PhoneBookGrid.RowHeadersWidth = 62;
            PhoneBookGrid.Size = new Size(761, 335);
            PhoneBookGrid.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 380);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 35);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Entry";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 440);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Entry";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(280, 380);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 35);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(452, 384);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(321, 31);
            txtSearch.TabIndex = 4;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(825, 25);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(101, 25);
            lblFName.TabIndex = 5;
            lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(827, 75);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(99, 25);
            lblLName.TabIndex = 6;
            lblLName.Text = "Last Name:";
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Location = new Point(839, 125);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(87, 25);
            lblMobile.TabIndex = 7;
            lblMobile.Text = "Mobile #:";
            // 
            // lblOffice
            // 
            lblOffice.AutoSize = true;
            lblOffice.Location = new Point(852, 175);
            lblOffice.Name = "lblOffice";
            lblOffice.Size = new Size(74, 25);
            lblOffice.TabIndex = 8;
            lblOffice.Text = "Office#:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(795, 225);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(131, 25);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Street Address:";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(932, 19);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(275, 31);
            txtFName.TabIndex = 10;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(932, 69);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(275, 31);
            txtLName.TabIndex = 11;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(932, 119);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(275, 31);
            txtMobile.TabIndex = 12;
            // 
            // txtOffice
            // 
            txtOffice.Location = new Point(932, 169);
            txtOffice.Name = "txtOffice";
            txtOffice.Size = new Size(275, 31);
            txtOffice.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(932, 219);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(275, 31);
            txtAddress.TabIndex = 14;
            // 
            // btnAdd2
            // 
            btnAdd2.Location = new Point(932, 275);
            btnAdd2.Name = "btnAdd2";
            btnAdd2.Size = new Size(200, 35);
            btnAdd2.TabIndex = 15;
            btnAdd2.Text = "Add Entry";
            btnAdd2.UseVisualStyleBackColor = true;
            btnAdd2.Click += btnAdd2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 497);
            Controls.Add(btnAdd2);
            Controls.Add(txtAddress);
            Controls.Add(txtOffice);
            Controls.Add(txtMobile);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(lblAddress);
            Controls.Add(lblOffice);
            Controls.Add(lblMobile);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(PhoneBookGrid);
            Name = "Form1";
            Text = "Phone Book";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PhoneBookGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PhoneBookGrid;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblFName;
        private Label lblLName;
        private Label lblMobile;
        private Label lblOffice;
        private Label lblAddress;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtMobile;
        private TextBox txtOffice;
        private TextBox txtAddress;
        private Button btnAdd2;
    }
}
