namespace Car_Rental
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSatıs = new System.Windows.Forms.ComboBox();
            this.cmbAlıs = new System.Windows.Forms.ComboBox();
            this.dtTeslimTarih = new System.Windows.Forms.DateTimePicker();
            this.dtAlısSaat = new System.Windows.Forms.DateTimePicker();
            this.dtAlısTarih = new System.Windows.Forms.DateTimePicker();
            this.dtTeslimSaat = new System.Windows.Forms.DateTimePicker();
            this.btnDevam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alış Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teslim Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alış Ofisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teslim Ofisi";
            // 
            // cmbSatıs
            // 
            this.cmbSatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSatıs.FormattingEnabled = true;
            this.cmbSatıs.Location = new System.Drawing.Point(16, 170);
            this.cmbSatıs.Name = "cmbSatıs";
            this.cmbSatıs.Size = new System.Drawing.Size(121, 28);
            this.cmbSatıs.TabIndex = 4;
            // 
            // cmbAlıs
            // 
            this.cmbAlıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlıs.FormattingEnabled = true;
            this.cmbAlıs.Location = new System.Drawing.Point(16, 74);
            this.cmbAlıs.Name = "cmbAlıs";
            this.cmbAlıs.Size = new System.Drawing.Size(121, 28);
            this.cmbAlıs.TabIndex = 5;
            // 
            // dtTeslimTarih
            // 
            this.dtTeslimTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTeslimTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTeslimTarih.Location = new System.Drawing.Point(251, 171);
            this.dtTeslimTarih.Name = "dtTeslimTarih";
            this.dtTeslimTarih.Size = new System.Drawing.Size(200, 27);
            this.dtTeslimTarih.TabIndex = 6;
            // 
            // dtAlısSaat
            // 
            this.dtAlısSaat.CustomFormat = "HH:MM ";
            this.dtAlısSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAlısSaat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAlısSaat.Location = new System.Drawing.Point(470, 75);
            this.dtAlısSaat.Name = "dtAlısSaat";
            this.dtAlısSaat.ShowUpDown = true;
            this.dtAlısSaat.Size = new System.Drawing.Size(200, 27);
            this.dtAlısSaat.TabIndex = 7;
            // 
            // dtAlısTarih
            // 
            this.dtAlısTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAlısTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAlısTarih.Location = new System.Drawing.Point(251, 75);
            this.dtAlısTarih.Name = "dtAlısTarih";
            this.dtAlısTarih.Size = new System.Drawing.Size(200, 27);
            this.dtAlısTarih.TabIndex = 8;
            // 
            // dtTeslimSaat
            // 
            this.dtTeslimSaat.CustomFormat = "HH:MM ";
            this.dtTeslimSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTeslimSaat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTeslimSaat.Location = new System.Drawing.Point(470, 171);
            this.dtTeslimSaat.Name = "dtTeslimSaat";
            this.dtTeslimSaat.ShowUpDown = true;
            this.dtTeslimSaat.Size = new System.Drawing.Size(200, 27);
            this.dtTeslimSaat.TabIndex = 9;
            // 
            // btnDevam
            // 
            this.btnDevam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevam.Location = new System.Drawing.Point(16, 235);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(654, 38);
            this.btnDevam.TabIndex = 10;
            this.btnDevam.Text = "Devam";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 301);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.dtTeslimSaat);
            this.Controls.Add(this.dtAlısTarih);
            this.Controls.Add(this.dtAlısSaat);
            this.Controls.Add(this.dtTeslimTarih);
            this.Controls.Add(this.cmbAlıs);
            this.Controls.Add(this.cmbSatıs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSatıs;
        private System.Windows.Forms.ComboBox cmbAlıs;
        private System.Windows.Forms.DateTimePicker dtTeslimTarih;
        private System.Windows.Forms.DateTimePicker dtAlısSaat;
        private System.Windows.Forms.DateTimePicker dtAlısTarih;
        private System.Windows.Forms.DateTimePicker dtTeslimSaat;
        private System.Windows.Forms.Button btnDevam;
    }
}

