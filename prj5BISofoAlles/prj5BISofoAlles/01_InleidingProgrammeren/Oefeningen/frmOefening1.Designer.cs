namespace prj5BISofoAlles._01_InleidingProgrammeren.Oefeningen
{
    partial class frmOefening1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.btnTekstkleur = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAchtergrondkleur = new System.Windows.Forms.Button();
            this.btnSluit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prj5BISofoAlles.Properties.Resources.minion;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam:";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(376, 10);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(343, 20);
            this.txtNaam.TabIndex = 2;
            // 
            // btnTekstkleur
            // 
            this.btnTekstkleur.BackColor = System.Drawing.Color.Red;
            this.btnTekstkleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTekstkleur.ForeColor = System.Drawing.Color.White;
            this.btnTekstkleur.Location = new System.Drawing.Point(376, 37);
            this.btnTekstkleur.Name = "btnTekstkleur";
            this.btnTekstkleur.Size = new System.Drawing.Size(163, 23);
            this.btnTekstkleur.TabIndex = 3;
            this.btnTekstkleur.Text = "Tekstkleur Wijzigen";
            this.btnTekstkleur.UseVisualStyleBackColor = false;
            this.btnTekstkleur.Click += new System.EventHandler(this.btnTekstkleur_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(556, 37);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Maak tekstvak leeg";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAchtergrondkleur
            // 
            this.btnAchtergrondkleur.BackColor = System.Drawing.Color.Red;
            this.btnAchtergrondkleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchtergrondkleur.ForeColor = System.Drawing.Color.White;
            this.btnAchtergrondkleur.Location = new System.Drawing.Point(376, 66);
            this.btnAchtergrondkleur.Name = "btnAchtergrondkleur";
            this.btnAchtergrondkleur.Size = new System.Drawing.Size(163, 23);
            this.btnAchtergrondkleur.TabIndex = 3;
            this.btnAchtergrondkleur.Text = "Achtergrondkleur";
            this.btnAchtergrondkleur.UseVisualStyleBackColor = false;
            this.btnAchtergrondkleur.Click += new System.EventHandler(this.btnAchtergrondkleur_Click);
            // 
            // btnSluit
            // 
            this.btnSluit.BackColor = System.Drawing.Color.Red;
            this.btnSluit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSluit.ForeColor = System.Drawing.Color.White;
            this.btnSluit.Location = new System.Drawing.Point(556, 66);
            this.btnSluit.Name = "btnSluit";
            this.btnSluit.Size = new System.Drawing.Size(163, 23);
            this.btnSluit.TabIndex = 3;
            this.btnSluit.Text = "Sluit het venster";
            this.btnSluit.UseVisualStyleBackColor = false;
            this.btnSluit.Click += new System.EventHandler(this.btnSluit_Click);
            // 
            // frmOefening1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 165);
            this.Controls.Add(this.btnSluit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAchtergrondkleur);
            this.Controls.Add(this.btnTekstkleur);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmOefening1";
            this.Text = "Eenvoudige besturingselementen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Button btnTekstkleur;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAchtergrondkleur;
        private System.Windows.Forms.Button btnSluit;
    }
}