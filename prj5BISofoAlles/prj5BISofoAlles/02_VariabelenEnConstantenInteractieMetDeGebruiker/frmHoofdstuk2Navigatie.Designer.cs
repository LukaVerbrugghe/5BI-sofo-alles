namespace prj5BISofoAlles._02_VariabelenEnConstantenInteractieMetDeGebruiker
{
    partial class frmHoofdstuk2Navigatie
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
            this.btnKlassikaal1 = new System.Windows.Forms.Button();
            this.btnKlassikaal2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKlassikaal1
            // 
            this.btnKlassikaal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlassikaal1.Location = new System.Drawing.Point(12, 12);
            this.btnKlassikaal1.Name = "btnKlassikaal1";
            this.btnKlassikaal1.Size = new System.Drawing.Size(392, 31);
            this.btnKlassikaal1.TabIndex = 1;
            this.btnKlassikaal1.Text = "Klassikaal 1: Interactie";
            this.btnKlassikaal1.UseVisualStyleBackColor = true;
            this.btnKlassikaal1.Click += new System.EventHandler(this.btnHoofdstuk1_Click);
            // 
            // btnKlassikaal2
            // 
            this.btnKlassikaal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlassikaal2.Location = new System.Drawing.Point(12, 49);
            this.btnKlassikaal2.Name = "btnKlassikaal2";
            this.btnKlassikaal2.Size = new System.Drawing.Size(392, 31);
            this.btnKlassikaal2.TabIndex = 1;
            this.btnKlassikaal2.Text = "Klassikaal 2: Var en Const";
            this.btnKlassikaal2.UseVisualStyleBackColor = true;
            this.btnKlassikaal2.Click += new System.EventHandler(this.btnKlassikaal2_Click);
            // 
            // frmHoofdstuk2Navigatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKlassikaal2);
            this.Controls.Add(this.btnKlassikaal1);
            this.Name = "frmHoofdstuk2Navigatie";
            this.Text = "Hoofdstuk 2 - Navigatie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlassikaal1;
        private System.Windows.Forms.Button btnKlassikaal2;
    }
}