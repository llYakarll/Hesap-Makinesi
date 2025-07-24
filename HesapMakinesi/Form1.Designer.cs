namespace HesapMakinesi
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
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            btnTopla = new Button();
            btnCikarma = new Button();
            btnCarpma = new Button();
            btnBolme = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lstSonuclar = new ListBox();
            btnTemizle = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(64, 47);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(125, 27);
            txtSayi1.TabIndex = 0;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(241, 47);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(125, 27);
            txtSayi2.TabIndex = 1;
            // 
            // btnTopla
            // 
            btnTopla.Location = new Point(95, 23);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(94, 29);
            btnTopla.TabIndex = 3;
            btnTopla.Text = "Topla ";
            btnTopla.UseVisualStyleBackColor = true;
            btnTopla.Click += btnTopla_Click;
            // 
            // btnCikarma
            // 
            btnCikarma.Location = new Point(241, 23);
            btnCikarma.Name = "btnCikarma";
            btnCikarma.Size = new Size(94, 29);
            btnCikarma.TabIndex = 4;
            btnCikarma.Text = "Cikarma";
            btnCikarma.UseVisualStyleBackColor = true;
            btnCikarma.Click += btnCikarma_Click;
            // 
            // btnCarpma
            // 
            btnCarpma.Location = new Point(95, 78);
            btnCarpma.Name = "btnCarpma";
            btnCarpma.Size = new Size(94, 29);
            btnCarpma.TabIndex = 5;
            btnCarpma.Text = "Carpma";
            btnCarpma.UseVisualStyleBackColor = true;
            btnCarpma.Click += btnCarpma_Click;
            // 
            // btnBolme
            // 
            btnBolme.Location = new Point(241, 78);
            btnBolme.Name = "btnBolme";
            btnBolme.Size = new Size(94, 29);
            btnBolme.TabIndex = 6;
            btnBolme.Text = "Bolme";
            btnBolme.UseVisualStyleBackColor = true;
            btnBolme.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTopla);
            groupBox1.Controls.Add(btnBolme);
            groupBox1.Controls.Add(btnCikarma);
            groupBox1.Controls.Add(btnCarpma);
            groupBox1.Location = new Point(27, 184);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 125);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSayi1);
            groupBox2.Controls.Add(txtSayi2);
            groupBox2.Location = new Point(27, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(423, 125);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // lstSonuclar
            // 
            lstSonuclar.FormattingEnabled = true;
            lstSonuclar.Location = new Point(27, 384);
            lstSonuclar.Name = "lstSonuclar";
            lstSonuclar.Size = new Size(423, 104);
            lstSonuclar.TabIndex = 9;
            lstSonuclar.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(356, 331);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(94, 29);
            btnTemizle.TabIndex = 10;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(482, 553);
            Controls.Add(btnTemizle);
            Controls.Add(lstSonuclar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private Label lblSonuc;
        private Button btnTopla;
        private Button btnCikarma;
        private Button btnCarpma;
        private Button btnBolme;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox lstSonuclar;
        private Button btnTemizle;
    }
}
