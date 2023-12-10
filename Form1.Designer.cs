namespace Modul_10
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
            lbAsal = new Label();
            tbAsal = new TextBox();
            label1 = new Label();
            tbTujuan = new TextBox();
            lbBerat = new Label();
            tbBerat = new TextBox();
            rbPOS = new RadioButton();
            rbJNE = new RadioButton();
            rbTIKI = new RadioButton();
            btnCek = new Button();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // lbAsal
            // 
            lbAsal.AutoSize = true;
            lbAsal.Location = new Point(43, 31);
            lbAsal.Name = "lbAsal";
            lbAsal.Size = new Size(118, 15);
            lbAsal.TabIndex = 0;
            lbAsal.Text = "Kota/Kabupaten Asal";
            // 
            // tbAsal
            // 
            tbAsal.Location = new Point(43, 62);
            tbAsal.Name = "tbAsal";
            tbAsal.Size = new Size(187, 23);
            tbAsal.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 111);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 2;
            label1.Text = "Kota/Kabupaten Tujuan";
            // 
            // tbTujuan
            // 
            tbTujuan.Location = new Point(43, 147);
            tbTujuan.Name = "tbTujuan";
            tbTujuan.Size = new Size(187, 23);
            tbTujuan.TabIndex = 3;
            // 
            // lbBerat
            // 
            lbBerat.AutoSize = true;
            lbBerat.Location = new Point(43, 196);
            lbBerat.Name = "lbBerat";
            lbBerat.Size = new Size(34, 15);
            lbBerat.TabIndex = 4;
            lbBerat.Text = "Berat";
            // 
            // tbBerat
            // 
            tbBerat.Location = new Point(43, 228);
            tbBerat.Name = "tbBerat";
            tbBerat.Size = new Size(187, 23);
            tbBerat.TabIndex = 5;
            // 
            // rbPOS
            // 
            rbPOS.AutoSize = true;
            rbPOS.Location = new Point(43, 283);
            rbPOS.Name = "rbPOS";
            rbPOS.Size = new Size(47, 19);
            rbPOS.TabIndex = 6;
            rbPOS.TabStop = true;
            rbPOS.Text = "POS";
            rbPOS.UseVisualStyleBackColor = true;
            // 
            // rbJNE
            // 
            rbJNE.AutoSize = true;
            rbJNE.Location = new Point(114, 283);
            rbJNE.Name = "rbJNE";
            rbJNE.Size = new Size(44, 19);
            rbJNE.TabIndex = 7;
            rbJNE.TabStop = true;
            rbJNE.Text = "JNE";
            rbJNE.UseVisualStyleBackColor = true;
            // 
            // rbTIKI
            // 
            rbTIKI.AutoSize = true;
            rbTIKI.Location = new Point(183, 283);
            rbTIKI.Name = "rbTIKI";
            rbTIKI.Size = new Size(44, 19);
            rbTIKI.TabIndex = 8;
            rbTIKI.TabStop = true;
            rbTIKI.Text = "TIKI";
            rbTIKI.UseVisualStyleBackColor = true;
            // 
            // btnCek
            // 
            btnCek.BackColor = SystemColors.Control;
            btnCek.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCek.ForeColor = SystemColors.ControlText;
            btnCek.Location = new Point(43, 329);
            btnCek.Name = "btnCek";
            btnCek.Size = new Size(194, 33);
            btnCek.TabIndex = 10;
            btnCek.Text = "Cek Harga Layanan";
            btnCek.UseVisualStyleBackColor = true;
            btnCek.Click += btnCek_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(318, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 331);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail Layanan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 412);
            Controls.Add(btnCek);
            Controls.Add(groupBox1);
            Controls.Add(rbTIKI);
            Controls.Add(rbJNE);
            Controls.Add(rbPOS);
            Controls.Add(tbBerat);
            Controls.Add(lbBerat);
            Controls.Add(tbTujuan);
            Controls.Add(label1);
            Controls.Add(tbAsal);
            Controls.Add(lbAsal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAsal;
        private TextBox tbAsal;
        private Label label1;
        private TextBox tbTujuan;
        private Label lbBerat;
        private TextBox tbBerat;
        private RadioButton rbPOS;
        private RadioButton rbJNE;
        private RadioButton rbTIKI;
        private Button btnCek;
        private GroupBox groupBox1;
    }
}