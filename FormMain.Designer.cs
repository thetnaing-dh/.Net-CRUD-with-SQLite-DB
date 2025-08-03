namespace Cafe_Menu_Item_CRUD_with_SQLite
{
    partial class FormMain
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pnTitle = new Panel();
            label8 = new Label();
            btnClose = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel1 = new Panel();
            btnAddPrinter = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            pbDelete = new Button();
            pbImage = new PictureBox();
            cbInActive = new CheckBox();
            txtCost = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            txtCode = new TextBox();
            btnAddGroup = new Button();
            cboPrinter = new ComboBox();
            cboCategory = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            sr = new DataGridViewTextBoxColumn();
            colCode = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCate = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colCost = new DataGridViewTextBoxColumn();
            colInactive = new DataGridViewCheckBoxColumn();
            colImage = new DataGridViewTextBoxColumn();
            colPrinter = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            pnTitle.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnTitle
            // 
            pnTitle.BackColor = Color.FromArgb(83, 47, 15);
            pnTitle.Controls.Add(label8);
            pnTitle.Controls.Add(btnClose);
            pnTitle.Dock = DockStyle.Top;
            pnTitle.Location = new Point(0, 0);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(1280, 40);
            pnTitle.TabIndex = 0;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(230, 40);
            label8.TabIndex = 4;
            label8.Text = "Menu Item Setup";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1245, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 40);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(83, 47, 15);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 540);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(83, 47, 15);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1278, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 540);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(83, 47, 15);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(2, 578);
            panel5.Name = "panel5";
            panel5.Size = new Size(1276, 2);
            panel5.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAddPrinter);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(pbDelete);
            panel1.Controls.Add(pbImage);
            panel1.Controls.Add(cbInActive);
            panel1.Controls.Add(txtCost);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtCode);
            panel1.Controls.Add(btnAddGroup);
            panel1.Controls.Add(cboPrinter);
            panel1.Controls.Add(cboCategory);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(8, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 520);
            panel1.TabIndex = 4;
            // 
            // btnAddPrinter
            // 
            btnAddPrinter.BackgroundImage = Properties.Resources.add;
            btnAddPrinter.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddPrinter.Cursor = Cursors.Hand;
            btnAddPrinter.FlatAppearance.BorderSize = 0;
            btnAddPrinter.FlatStyle = FlatStyle.Flat;
            btnAddPrinter.Location = new Point(227, 386);
            btnAddPrinter.Name = "btnAddPrinter";
            btnAddPrinter.Size = new Size(30, 30);
            btnAddPrinter.TabIndex = 15;
            btnAddPrinter.TabStop = false;
            btnAddPrinter.UseVisualStyleBackColor = true;
            btnAddPrinter.Click += btnAddPrinter_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(160, 217);
            label7.Name = "label7";
            label7.Size = new Size(46, 19);
            label7.TabIndex = 14;
            label7.Text = "Image";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 358);
            label6.Name = "label6";
            label6.Size = new Size(100, 19);
            label6.TabIndex = 13;
            label6.Text = "Kitchen Printer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 289);
            label5.Name = "label5";
            label5.Size = new Size(73, 19);
            label5.TabIndex = 12;
            label5.Text = "Cost Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 150);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 11;
            label4.Text = "Item Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 217);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 10;
            label3.Text = "Item Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 83);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 9;
            label2.Text = "Item Code";
            // 
            // btnCancel
            // 
            btnCancel.BackgroundImage = Properties.Resources.btnCancel;
            btnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(147, 470);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 40);
            btnCancel.TabIndex = 8;
            btnCancel.TabStop = false;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = Properties.Resources.btnSave;
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(20, 470);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 40);
            btnSave.TabIndex = 6;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pbDelete
            // 
            pbDelete.BackColor = SystemColors.Info;
            pbDelete.BackgroundImage = Properties.Resources.delete;
            pbDelete.BackgroundImageLayout = ImageLayout.Zoom;
            pbDelete.Cursor = Cursors.Hand;
            pbDelete.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            pbDelete.FlatStyle = FlatStyle.Flat;
            pbDelete.Location = new Point(232, 316);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(30, 30);
            pbDelete.TabIndex = 6;
            pbDelete.UseVisualStyleBackColor = false;
            pbDelete.Visible = false;
            pbDelete.Click += pbDelete_Click;
            // 
            // pbImage
            // 
            pbImage.BackColor = SystemColors.Info;
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Cursor = Cursors.Hand;
            pbImage.Image = Properties.Resources.browse;
            pbImage.Location = new Point(162, 246);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(100, 100);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 5;
            pbImage.TabStop = false;
            pbImage.Click += pbImage_Click;
            // 
            // cbInActive
            // 
            cbInActive.AutoSize = true;
            cbInActive.Location = new Point(20, 433);
            cbInActive.Name = "cbInActive";
            cbInActive.Size = new Size(82, 23);
            cbInActive.TabIndex = 5;
            cbInActive.TabStop = false;
            cbInActive.Text = "In Active";
            cbInActive.UseVisualStyleBackColor = true;
            // 
            // txtCost
            // 
            txtCost.BackColor = SystemColors.Info;
            txtCost.Font = new Font("Times New Roman", 12F);
            txtCost.Location = new Point(20, 318);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(136, 26);
            txtCost.TabIndex = 4;
            txtCost.KeyPress += txtPrice_KeyPress;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Info;
            txtPrice.Font = new Font("Times New Roman", 12F);
            txtPrice.Location = new Point(20, 246);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(136, 26);
            txtPrice.TabIndex = 3;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Info;
            txtName.Font = new Font("Times New Roman", 12F);
            txtName.Location = new Point(20, 179);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 26);
            txtName.TabIndex = 2;
            // 
            // txtCode
            // 
            txtCode.BackColor = SystemColors.Info;
            txtCode.Font = new Font("Times New Roman", 12F);
            txtCode.Location = new Point(20, 112);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(242, 26);
            txtCode.TabIndex = 1;
            txtCode.KeyPress += txtID_KeyPress;
            // 
            // btnAddGroup
            // 
            btnAddGroup.BackgroundImage = Properties.Resources.add;
            btnAddGroup.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddGroup.Cursor = Cursors.Hand;
            btnAddGroup.FlatAppearance.BorderSize = 0;
            btnAddGroup.FlatStyle = FlatStyle.Flat;
            btnAddGroup.Location = new Point(227, 39);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(30, 30);
            btnAddGroup.TabIndex = 2;
            btnAddGroup.TabStop = false;
            btnAddGroup.UseVisualStyleBackColor = true;
            btnAddGroup.Click += btnAddGroup_Click;
            // 
            // cboPrinter
            // 
            cboPrinter.BackColor = SystemColors.Info;
            cboPrinter.FlatStyle = FlatStyle.Popup;
            cboPrinter.Font = new Font("Times New Roman", 12F);
            cboPrinter.FormattingEnabled = true;
            cboPrinter.Location = new Point(20, 387);
            cboPrinter.Name = "cboPrinter";
            cboPrinter.Size = new Size(201, 27);
            cboPrinter.TabIndex = 1;
            cboPrinter.TabStop = false;
            cboPrinter.Enter += cboPrinter_Enter;
            cboPrinter.KeyDown += cboPrinter_KeyDown;
            // 
            // cboCategory
            // 
            cboCategory.BackColor = SystemColors.Info;
            cboCategory.FlatStyle = FlatStyle.Popup;
            cboCategory.Font = new Font("Times New Roman", 12F);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(20, 40);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(201, 27);
            cboCategory.TabIndex = 0;
            cboCategory.Enter += cboCategory_Enter;
            cboCategory.KeyPress += cboCategory_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(106, 19);
            label1.TabIndex = 0;
            label1.Text = "Category Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, sr, colCode, colName, colCate, colPrice, colCost, colInactive, colImage, colPrinter, colEdit, colDelete });
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Location = new Point(298, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FloralWhite;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(970, 520);
            dataGridView1.TabIndex = 5;
            dataGridView1.TabStop = false;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            // 
            // sr
            // 
            sr.HeaderText = "Sr";
            sr.Name = "sr";
            sr.ReadOnly = true;
            sr.Width = 40;
            // 
            // colCode
            // 
            colCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCode.HeaderText = "Item Code";
            colCode.Name = "colCode";
            colCode.ReadOnly = true;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Item Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCate
            // 
            colCate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCate.HeaderText = "Category";
            colCate.Name = "colCate";
            colCate.ReadOnly = true;
            // 
            // colPrice
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPrice.DefaultCellStyle = dataGridViewCellStyle5;
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colCost
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCost.DefaultCellStyle = dataGridViewCellStyle6;
            colCost.HeaderText = "Cost";
            colCost.Name = "colCost";
            colCost.ReadOnly = true;
            // 
            // colInactive
            // 
            colInactive.HeaderText = "Inactive";
            colInactive.Name = "colInactive";
            colInactive.ReadOnly = true;
            colInactive.Width = 80;
            // 
            // colImage
            // 
            colImage.HeaderText = "Image";
            colImage.Name = "colImage";
            colImage.ReadOnly = true;
            colImage.Visible = false;
            // 
            // colPrinter
            // 
            colPrinter.HeaderText = "Printer";
            colPrinter.Name = "colPrinter";
            colPrinter.ReadOnly = true;
            colPrinter.Visible = false;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Edit";
            colEdit.Image = Properties.Resources.edit;
            colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Resizable = DataGridViewTriState.True;
            colEdit.Width = 40;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Del";
            colDelete.Image = Properties.Resources.delete;
            colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Resizable = DataGridViewTriState.True;
            colDelete.Width = 40;
            // 
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(226, 205, 168);
            ClientSize = new Size(1280, 580);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnTitle);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormMain_Load;
            pnTitle.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTitle;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnAddGroup;
        private ComboBox cboCategory;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private Button pbDelete;
        private PictureBox pbImage;
        private CheckBox cbInActive;
        private TextBox txtCost;
        private TextBox txtPrice;
        private TextBox txtName;
        private TextBox txtCode;
        private ComboBox cboPrinter;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Button btnAddPrinter;
        private Label label7;
        private Label label8;
        private Button btnClose;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn sr;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCate;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colCost;
        private DataGridViewCheckBoxColumn colInactive;
        private DataGridViewTextBoxColumn colImage;
        private DataGridViewTextBoxColumn colPrinter;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDelete;
    }
}
