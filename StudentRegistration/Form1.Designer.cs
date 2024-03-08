namespace StudentRegistration
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
            lblname = new Label();
            lblpatername = new Label();
            lblmothername = new Label();
            lblbirthday = new Label();
            lblregistration = new Label();
            lblaverager = new Label();
            btncreate = new Button();
            txtname = new TextBox();
            txtpaternal = new TextBox();
            txtmothernal = new TextBox();
            txtregistration = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtavergeer = new NumericUpDown();
            lblstudent = new Label();
            label1 = new Label();
            txtcareer = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtavergeer).BeginInit();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(76, 65);
            lblname.Name = "lblname";
            lblname.Size = new Size(52, 20);
            lblname.TabIndex = 0;
            lblname.Text = "Name:";
            // 
            // lblpatername
            // 
            lblpatername.AutoSize = true;
            lblpatername.Location = new Point(385, 65);
            lblpatername.Name = "lblpatername";
            lblpatername.Size = new Size(123, 20);
            lblpatername.TabIndex = 1;
            lblpatername.Text = "PaternalSurname:";
            // 
            // lblmothername
            // 
            lblmothername.AutoSize = true;
            lblmothername.Location = new Point(655, 65);
            lblmothername.Name = "lblmothername";
            lblmothername.Size = new Size(134, 20);
            lblmothername.TabIndex = 2;
            lblmothername.Text = "MaternalLastname:";
            // 
            // lblbirthday
            // 
            lblbirthday.AutoSize = true;
            lblbirthday.Location = new Point(265, 263);
            lblbirthday.Name = "lblbirthday";
            lblbirthday.Size = new Size(67, 20);
            lblbirthday.TabIndex = 3;
            lblbirthday.Text = "Birthday:";
            // 
            // lblregistration
            // 
            lblregistration.AutoSize = true;
            lblregistration.Location = new Point(551, 261);
            lblregistration.Name = "lblregistration";
            lblregistration.Size = new Size(92, 20);
            lblregistration.TabIndex = 4;
            lblregistration.Text = "Registration:";
            // 
            // lblaverager
            // 
            lblaverager.AutoSize = true;
            lblaverager.Location = new Point(808, 263);
            lblaverager.Name = "lblaverager";
            lblaverager.Size = new Size(72, 20);
            lblaverager.TabIndex = 5;
            lblaverager.Text = "Avergeer:";
            // 
            // btncreate
            // 
            btncreate.ForeColor = Color.Black;
            btncreate.Location = new Point(812, 380);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(193, 87);
            btncreate.TabIndex = 6;
            btncreate.Text = "StudentCreate";
            btncreate.UseVisualStyleBackColor = true;
            btncreate.Click += btncreate_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(76, 102);
            txtname.Name = "txtname";
            txtname.Size = new Size(189, 27);
            txtname.TabIndex = 7;
            // 
            // txtpaternal
            // 
            txtpaternal.Location = new Point(371, 102);
            txtpaternal.Name = "txtpaternal";
            txtpaternal.Size = new Size(189, 27);
            txtpaternal.TabIndex = 8;
            // 
            // txtmothernal
            // 
            txtmothernal.Location = new Point(655, 102);
            txtmothernal.Name = "txtmothernal";
            txtmothernal.Size = new Size(189, 27);
            txtmothernal.TabIndex = 9;
            // 
            // txtregistration
            // 
            txtregistration.Location = new Point(551, 289);
            txtregistration.Name = "txtregistration";
            txtregistration.Size = new Size(189, 27);
            txtregistration.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(265, 289);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // txtavergeer
            // 
            txtavergeer.Location = new Point(808, 289);
            txtavergeer.Name = "txtavergeer";
            txtavergeer.Size = new Size(197, 27);
            txtavergeer.TabIndex = 12;
            // 
            // lblstudent
            // 
            lblstudent.AutoSize = true;
            lblstudent.Location = new Point(66, 384);
            lblstudent.Name = "lblstudent";
            lblstudent.Size = new Size(18, 20);
            lblstudent.TabIndex = 13;
            lblstudent.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 267);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 14;
            label1.Text = "Career:";
            // 
            // txtcareer
            // 
            txtcareer.Location = new Point(23, 291);
            txtcareer.Name = "txtcareer";
            txtcareer.Size = new Size(184, 27);
            txtcareer.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1030, 492);
            Controls.Add(txtcareer);
            Controls.Add(label1);
            Controls.Add(lblstudent);
            Controls.Add(txtavergeer);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtregistration);
            Controls.Add(txtmothernal);
            Controls.Add(txtpaternal);
            Controls.Add(txtname);
            Controls.Add(btncreate);
            Controls.Add(lblaverager);
            Controls.Add(lblregistration);
            Controls.Add(lblbirthday);
            Controls.Add(lblmothername);
            Controls.Add(lblpatername);
            Controls.Add(lblname);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)txtavergeer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private Label lblpatername;
        private Label lblmothername;
        private Label lblbirthday;
        private Label lblregistration;
        private Label lblaverager;
        private Button btncreate;
        private TextBox txtname;
        private TextBox txtpaternal;
        private TextBox txtmothernal;
        private TextBox txtregistration;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown txtavergeer;
        private Label lblstudent;
        private Label label1;
        private TextBox txtcareer;
    }
}
