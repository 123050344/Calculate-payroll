namespace Calculate_payroll
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtname = new TextBox();
            txtid = new TextBox();
            txtsalaryday = new TextBox();
            txtworkeddays = new TextBox();
            btnsave = new Button();
            btncalculate = new Button();
            label6 = new Label();
            txttotal = new TextBox();
            btnnew = new Button();
            btnsalir = new Button();
            error1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 22);
            label1.Name = "label1";
            label1.Size = new Size(249, 33);
            label1.TabIndex = 0;
            label1.Text = "Calculate payroll";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 80);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonShadow;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 133);
            label3.Name = "label3";
            label3.Size = new Size(35, 30);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonShadow;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(31, 188);
            label4.Name = "label4";
            label4.Size = new Size(149, 30);
            label4.TabIndex = 3;
            label4.Text = "Salary for day";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonShadow;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 242);
            label5.Name = "label5";
            label5.Size = new Size(140, 30);
            label5.TabIndex = 4;
            label5.Text = "Worked days";
            label5.Click += label5_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(127, 80);
            txtname.Name = "txtname";
            txtname.Size = new Size(343, 23);
            txtname.TabIndex = 5;
            // 
            // txtid
            // 
            txtid.Location = new Point(96, 133);
            txtid.Name = "txtid";
            txtid.Size = new Size(374, 23);
            txtid.TabIndex = 6;
            // 
            // txtsalaryday
            // 
            txtsalaryday.Location = new Point(207, 188);
            txtsalaryday.Name = "txtsalaryday";
            txtsalaryday.Size = new Size(263, 23);
            txtsalaryday.TabIndex = 7;
            // 
            // txtworkeddays
            // 
            txtworkeddays.ForeColor = SystemColors.WindowText;
            txtworkeddays.Location = new Point(199, 242);
            txtworkeddays.Name = "txtworkeddays";
            txtworkeddays.Size = new Size(271, 23);
            txtworkeddays.TabIndex = 8;
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.ControlLight;
            btnsave.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnsave.Location = new Point(31, 284);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(439, 39);
            btnsave.TabIndex = 9;
            btnsave.Text = "Save record";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btncalculate
            // 
            btncalculate.BackColor = SystemColors.ScrollBar;
            btncalculate.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btncalculate.Location = new Point(31, 336);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(195, 46);
            btncalculate.TabIndex = 10;
            btncalculate.Text = "calculate ";
            btncalculate.UseVisualStyleBackColor = false;
            btncalculate.Click += btncalculate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonShadow;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(232, 351);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 11;
            label6.Text = "Total payroll";
            // 
            // txttotal
            // 
            txttotal.Location = new Point(337, 349);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(133, 23);
            txttotal.TabIndex = 12;
            // 
            // btnnew
            // 
            btnnew.BackColor = SystemColors.ControlLight;
            btnnew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnnew.Location = new Point(31, 398);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(219, 47);
            btnnew.TabIndex = 13;
            btnnew.Text = "New registration";
            btnnew.UseVisualStyleBackColor = false;
            btnnew.Click += btnnew_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = SystemColors.ControlLight;
            btnsalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalir.Location = new Point(256, 398);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(216, 47);
            btnsalir.TabIndex = 14;
            btnsalir.Text = "Go out";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(770, 457);
            Controls.Add(btnsalir);
            Controls.Add(btnnew);
            Controls.Add(txttotal);
            Controls.Add(label6);
            Controls.Add(btncalculate);
            Controls.Add(btnsave);
            Controls.Add(txtworkeddays);
            Controls.Add(txtsalaryday);
            Controls.Add(txtid);
            Controls.Add(txtname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtname;
        private TextBox txtid;
        private TextBox txtsalaryday;
        private TextBox txtworkeddays;
        private Button btnsave;
        private Button btncalculate;
        private Label label6;
        private TextBox txttotal;
        private Button btnnew;
        private Button btnsalir;
        private ErrorProvider error1;
    }
}