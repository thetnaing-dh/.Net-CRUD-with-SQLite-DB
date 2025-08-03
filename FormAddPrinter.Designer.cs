namespace Cafe_Menu_Item_CRUD_with_SQLite
{
    partial class FormAddPrinter
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
            panel3 = new Panel();
            pnTitle = new Panel();
            label8 = new Label();
            btnClose = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            txtName = new TextBox();
            btnAdd = new Button();
            cboSystemPrinter = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            colID = new DataGridViewTextBoxColumn();
            sr = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPrinter = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(83, 47, 15);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(536, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 345);
            panel3.TabIndex = 11;
            // 
            // pnTitle
            // 
            pnTitle.BackColor = Color.FromArgb(83, 47, 15);
            pnTitle.Controls.Add(label8);
            pnTitle.Controls.Add(btnClose);
            pnTitle.Dock = DockStyle.Top;
            pnTitle.Location = new Point(0, 0);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(538, 40);
            pnTitle.TabIndex = 10;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(182, 40);
            label8.TabIndex = 4;
            label8.Text = "Printer Setup";
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
            btnClose.Location = new Point(503, 0);
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
            panel2.Size = new Size(2, 343);
            panel2.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(83, 47, 15);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 383);
            panel5.Name = "panel5";
            panel5.Size = new Size(536, 2);
            panel5.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 50);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 23;
            label2.Text = "Printer Name";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Info;
            txtName.Font = new Font("Times New Roman", 12F);
            txtName.Location = new Point(28, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 26);
            txtName.TabIndex = 21;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Location = new Point(435, 76);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 22;
            btnAdd.TabStop = false;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboSystemPrinter
            // 
            cboSystemPrinter.BackColor = SystemColors.Info;
            cboSystemPrinter.FlatStyle = FlatStyle.Popup;
            cboSystemPrinter.Font = new Font("Times New Roman", 12F);
            cboSystemPrinter.FormattingEnabled = true;
            cboSystemPrinter.Location = new Point(228, 78);
            cboSystemPrinter.Name = "cboSystemPrinter";
            cboSystemPrinter.Size = new Size(201, 27);
            cboSystemPrinter.TabIndex = 19;
            cboSystemPrinter.Enter += cboSystemPrinter_DropDown;
            cboSystemPrinter.KeyPress += cboSystemPrinter_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 50);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 20;
            label1.Text = "System Printer";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, sr, colName, colPrinter, colEdit, colDelete });
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Location = new Point(28, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FloralWhite;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(487, 216);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = Properties.Resources.btnSave;
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(219, 333);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 40);
            btnSave.TabIndex = 25;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.Visible = false;
            // 
            // sr
            // 
            sr.HeaderText = "Sr";
            sr.Name = "sr";
            sr.Width = 40;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Printer Name";
            colName.Name = "colName";
            // 
            // colPrinter
            // 
            colPrinter.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPrinter.HeaderText = "System Printer";
            colPrinter.Name = "colPrinter";
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Edit";
            colEdit.Image = Properties.Resources.edit;
            colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEdit.Name = "colEdit";
            colEdit.Width = 40;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Del";
            colDelete.Image = Properties.Resources.delete;
            colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colDelete.Name = "colDelete";
            colDelete.Resizable = DataGridViewTriState.True;
            colDelete.Width = 40;
            // 
            // FormAddPrinter
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(226, 205, 168);
            ClientSize = new Size(538, 385);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(btnAdd);
            Controls.Add(cboSystemPrinter);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(pnTitle);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddPrinter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddPrinter";
            Load += FormAddPrinter_Load;
            pnTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Panel pnTitle;
        private Label label8;
        private Button btnClose;
        private Panel panel2;
        private Panel panel5;
        private Label label2;
        private TextBox txtName;
        private Button btnAdd;
        private ComboBox cboSystemPrinter;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnSave;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn sr;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrinter;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDelete;
    }
}