namespace CustomerCRUD_WFA
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
            dgvOrderList = new DataGridView();
            lstbxEmployees = new ListBox();
            lstbxShippers = new ListBox();
            btnGetOrderList = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderList
            // 
            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderList.BackgroundColor = SystemColors.Window;
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(360, 90);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 29;
            dgvOrderList.Size = new Size(643, 575);
            dgvOrderList.TabIndex = 0;
            dgvOrderList.CellContentClick += dgvOrderList_CellContentClick;
            // 
            // lstbxEmployees
            // 
            lstbxEmployees.FormattingEnabled = true;
            lstbxEmployees.ItemHeight = 20;
            lstbxEmployees.Location = new Point(22, 90);
            lstbxEmployees.Name = "lstbxEmployees";
            lstbxEmployees.Size = new Size(301, 364);
            lstbxEmployees.TabIndex = 1;
            lstbxEmployees.SelectedIndexChanged += lstbxEmployees_SelectedIndexChanged;
            lstbxEmployees.MouseDown += lstbxEmployees_MouseDown;
            // 
            // lstbxShippers
            // 
            lstbxShippers.FormattingEnabled = true;
            lstbxShippers.ItemHeight = 20;
            lstbxShippers.Location = new Point(22, 481);
            lstbxShippers.Name = "lstbxShippers";
            lstbxShippers.Size = new Size(301, 184);
            lstbxShippers.TabIndex = 2;
            lstbxShippers.SelectedIndexChanged += lstbxShippers_SelectedIndexChanged;
            lstbxShippers.MouseDown += lstbxShippers_MouseDown;
            // 
            // btnGetOrderList
            // 
            btnGetOrderList.Location = new Point(22, 24);
            btnGetOrderList.Name = "btnGetOrderList";
            btnGetOrderList.Size = new Size(301, 42);
            btnGetOrderList.TabIndex = 3;
            btnGetOrderList.Text = "Get Order List";
            btnGetOrderList.UseVisualStyleBackColor = true;
            btnGetOrderList.Click += btnGetOrderList_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(360, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(180, 42);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(591, 24);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(180, 42);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(822, 24);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 42);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 690);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnGetOrderList);
            Controls.Add(lstbxShippers);
            Controls.Add(lstbxEmployees);
            Controls.Add(dgvOrderList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrderList;
        private ListBox lstbxEmployees;
        private ListBox lstbxShippers;
        private Button btnGetOrderList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}