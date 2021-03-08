namespace Brkovi
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ImeTekst = new System.Windows.Forms.TextBox();
            this.PrezimeTekst = new System.Windows.Forms.TextBox();
            this.GodinaTekst = new System.Windows.Forms.TextBox();
            this.RodTekst = new System.Windows.Forms.ComboBox();
            this.Unesi = new System.Windows.Forms.Button();
            this.Ispisi = new System.Windows.Forms.Button();
            this.Obradi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 181);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(688, 230);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // ImeTekst
            // 
            this.ImeTekst.Location = new System.Drawing.Point(33, 76);
            this.ImeTekst.Name = "ImeTekst";
            this.ImeTekst.Size = new System.Drawing.Size(145, 20);
            this.ImeTekst.TabIndex = 1;
            // 
            // PrezimeTekst
            // 
            this.PrezimeTekst.Location = new System.Drawing.Point(33, 102);
            this.PrezimeTekst.Name = "PrezimeTekst";
            this.PrezimeTekst.Size = new System.Drawing.Size(145, 20);
            this.PrezimeTekst.TabIndex = 2;
            this.PrezimeTekst.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // GodinaTekst
            // 
            this.GodinaTekst.Location = new System.Drawing.Point(33, 128);
            this.GodinaTekst.Name = "GodinaTekst";
            this.GodinaTekst.Size = new System.Drawing.Size(145, 20);
            this.GodinaTekst.TabIndex = 3;
            // 
            // RodTekst
            // 
            this.RodTekst.FormattingEnabled = true;
            this.RodTekst.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.RodTekst.Location = new System.Drawing.Point(33, 154);
            this.RodTekst.Name = "RodTekst";
            this.RodTekst.Size = new System.Drawing.Size(145, 21);
            this.RodTekst.TabIndex = 4;
            // 
            // Unesi
            // 
            this.Unesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Unesi.Location = new System.Drawing.Point(184, 74);
            this.Unesi.Name = "Unesi";
            this.Unesi.Size = new System.Drawing.Size(175, 101);
            this.Unesi.TabIndex = 5;
            this.Unesi.Text = "Unesi";
            this.Unesi.UseVisualStyleBackColor = false;
            this.Unesi.Click += new System.EventHandler(this.Unesi_Click);
            // 
            // Ispisi
            // 
            this.Ispisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ispisi.Location = new System.Drawing.Point(365, 74);
            this.Ispisi.Name = "Ispisi";
            this.Ispisi.Size = new System.Drawing.Size(175, 101);
            this.Ispisi.TabIndex = 6;
            this.Ispisi.Text = "Ispiši";
            this.Ispisi.UseVisualStyleBackColor = false;
            this.Ispisi.Click += new System.EventHandler(this.Ispisi_Click);
            // 
            // Obradi
            // 
            this.Obradi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Obradi.Location = new System.Drawing.Point(546, 74);
            this.Obradi.Name = "Obradi";
            this.Obradi.Size = new System.Drawing.Size(175, 101);
            this.Obradi.TabIndex = 7;
            this.Obradi.Text = "Obradi";
            this.Obradi.UseVisualStyleBackColor = false;
            this.Obradi.Click += new System.EventHandler(this.Obradi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Obradi);
            this.Controls.Add(this.Ispisi);
            this.Controls.Add(this.Unesi);
            this.Controls.Add(this.RodTekst);
            this.Controls.Add(this.GodinaTekst);
            this.Controls.Add(this.PrezimeTekst);
            this.Controls.Add(this.ImeTekst);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox ImeTekst;
        private System.Windows.Forms.TextBox PrezimeTekst;
        private System.Windows.Forms.TextBox GodinaTekst;
        private System.Windows.Forms.ComboBox RodTekst;
        private System.Windows.Forms.Button Unesi;
        private System.Windows.Forms.Button Ispisi;
        private System.Windows.Forms.Button Obradi;
    }
}

