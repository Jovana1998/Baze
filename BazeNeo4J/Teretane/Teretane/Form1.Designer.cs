
namespace Teretane
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
            this.Admin = new System.Windows.Forms.Button();
            this.Trener = new System.Windows.Forms.Button();
            this.Korisnik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Admin.Location = new System.Drawing.Point(12, 153);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(288, 47);
            this.Admin.TabIndex = 0;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // Trener
            // 
            this.Trener.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trener.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Trener.Location = new System.Drawing.Point(12, 240);
            this.Trener.Name = "Trener";
            this.Trener.Size = new System.Drawing.Size(288, 50);
            this.Trener.TabIndex = 1;
            this.Trener.Text = "Trener";
            this.Trener.UseVisualStyleBackColor = true;
            // 
            // Korisnik
            // 
            this.Korisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Korisnik.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Korisnik.Location = new System.Drawing.Point(12, 325);
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.Size = new System.Drawing.Size(288, 51);
            this.Korisnik.TabIndex = 2;
            this.Korisnik.Text = "Korisnik";
            this.Korisnik.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(-2, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "TERETANE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Korisnik);
            this.Controls.Add(this.Trener);
            this.Controls.Add(this.Admin);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Teretane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button Trener;
        private System.Windows.Forms.Button Korisnik;
        private System.Windows.Forms.Label label1;
    }
}