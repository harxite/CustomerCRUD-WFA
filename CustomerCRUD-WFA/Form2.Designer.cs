namespace CustomerCRUD_WFA
{
    partial class Form2
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
            label1 = new Label();
            cbEmployees = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtShipCity = new TextBox();
            cbShipper = new ComboBox();
            btnIslem = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 79);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // cbEmployees
            // 
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(176, 77);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(253, 28);
            cbEmployees.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(176, 145);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(253, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // txtShipCity
            // 
            txtShipCity.Location = new Point(176, 218);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.Size = new Size(253, 27);
            txtShipCity.TabIndex = 3;
            // 
            // cbShipper
            // 
            cbShipper.FormattingEnabled = true;
            cbShipper.Location = new Point(176, 295);
            cbShipper.Name = "cbShipper";
            cbShipper.Size = new Size(253, 28);
            cbShipper.TabIndex = 4;
            // 
            // btnIslem
            // 
            btnIslem.Location = new Point(176, 370);
            btnIslem.Name = "btnIslem";
            btnIslem.Size = new Size(253, 59);
            btnIslem.TabIndex = 5;
            btnIslem.Text = "Add";
            btnIslem.UseVisualStyleBackColor = true;
            btnIslem.Click += btnIslem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 152);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 0;
            label2.Text = "Order Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 225);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 0;
            label3.Text = "Ship City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 303);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 0;
            label4.Text = "Shipper";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 493);
            Controls.Add(btnIslem);
            Controls.Add(cbShipper);
            Controls.Add(txtShipCity);
            Controls.Add(dateTimePicker1);
            Controls.Add(cbEmployees);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbEmployees;
        private DateTimePicker dateTimePicker1;
        private TextBox txtShipCity;
        private ComboBox cbShipper;
        private Button btnIslem;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}