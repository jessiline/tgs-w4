
namespace tgs_w4
{
    partial class FormTampilan
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
            this.labelNama = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelTelp = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxTelp = new System.Windows.Forms.TextBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(33, 28);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(63, 25);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama:";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(33, 80);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(72, 25);
            this.labelAlamat.TabIndex = 1;
            this.labelAlamat.Text = "Alamat:";
            // 
            // labelTelp
            // 
            this.labelTelp.AutoSize = true;
            this.labelTelp.Location = new System.Drawing.Point(33, 136);
            this.labelTelp.Name = "labelTelp";
            this.labelTelp.Size = new System.Drawing.Size(47, 25);
            this.labelTelp.TabIndex = 2;
            this.labelTelp.Text = "Telp:";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Enabled = false;
            this.textBoxNama.Location = new System.Drawing.Point(118, 28);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.ReadOnly = true;
            this.textBoxNama.Size = new System.Drawing.Size(363, 31);
            this.textBoxNama.TabIndex = 3;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Enabled = false;
            this.textBoxAlamat.Location = new System.Drawing.Point(118, 80);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.ReadOnly = true;
            this.textBoxAlamat.Size = new System.Drawing.Size(514, 31);
            this.textBoxAlamat.TabIndex = 4;
            // 
            // textBoxTelp
            // 
            this.textBoxTelp.Enabled = false;
            this.textBoxTelp.Location = new System.Drawing.Point(118, 133);
            this.textBoxTelp.Name = "textBoxTelp";
            this.textBoxTelp.ReadOnly = true;
            this.textBoxTelp.Size = new System.Drawing.Size(206, 31);
            this.textBoxTelp.TabIndex = 5;
            this.textBoxTelp.TextChanged += new System.EventHandler(this.textBoxTelp_TextChanged);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(58, 210);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(112, 34);
            this.btnKembali.TabIndex = 6;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(202, 210);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(112, 34);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "Prev Data";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(352, 210);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 34);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next Data";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // FormTampilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 276);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.textBoxTelp);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.labelTelp);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.labelNama);
            this.Name = "FormTampilan";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelTelp;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxTelp;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
    }
}