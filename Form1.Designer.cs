namespace RpgMakerOkienkowa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.wybierz = new System.Windows.Forms.Button();
            this.Pytanie = new System.Windows.Forms.Label();
            this.pytanie1 = new System.Windows.Forms.RadioButton();
            this.pytanie2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // wybierz
            // 
            this.wybierz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wybierz.Location = new System.Drawing.Point(390, 493);
            this.wybierz.Name = "wybierz";
            this.wybierz.Size = new System.Drawing.Size(133, 97);
            this.wybierz.TabIndex = 3;
            this.wybierz.Text = "WYBIERZ";
            this.wybierz.UseVisualStyleBackColor = true;
            this.wybierz.Click += new System.EventHandler(this.wybierz_Click);
            // 
            // Pytanie
            // 
            this.Pytanie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pytanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pytanie.Location = new System.Drawing.Point(0, 16);
            this.Pytanie.Name = "Pytanie";
            this.Pytanie.Size = new System.Drawing.Size(885, 149);
            this.Pytanie.TabIndex = 0;
            this.Pytanie.Text = "pytanie";
            this.Pytanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pytanie1
            // 
            this.pytanie1.AutoSize = true;
            this.pytanie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pytanie1.Location = new System.Drawing.Point(6, 168);
            this.pytanie1.Name = "pytanie1";
            this.pytanie1.Size = new System.Drawing.Size(73, 17);
            this.pytanie1.TabIndex = 1;
            this.pytanie1.TabStop = true;
            this.pytanie1.Text = "pytanie1";
            this.pytanie1.UseVisualStyleBackColor = true;
            // 
            // pytanie2
            // 
            this.pytanie2.AutoSize = true;
            this.pytanie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pytanie2.Location = new System.Drawing.Point(6, 215);
            this.pytanie2.Name = "pytanie2";
            this.pytanie2.Size = new System.Drawing.Size(73, 17);
            this.pytanie2.TabIndex = 2;
            this.pytanie2.TabStop = true;
            this.pytanie2.Text = "pytanie2";
            this.pytanie2.UseVisualStyleBackColor = true;
            this.pytanie2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.Pytanie);
            this.groupBox1.Controls.Add(this.pytanie2);
            this.groupBox1.Controls.Add(this.pytanie1);
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 251);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::RpgMakerOkienkowa.Properties.Resources.pytanie11;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(885, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wybierz);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button wybierz;
        private System.Windows.Forms.Label Pytanie;
        private System.Windows.Forms.RadioButton pytanie1;
        private System.Windows.Forms.RadioButton pytanie2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

