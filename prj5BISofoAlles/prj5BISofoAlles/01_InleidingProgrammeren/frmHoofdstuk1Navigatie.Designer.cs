namespace prj5BISofoAlles._01_InleidingProgrammeren
{
    partial class frmHoofdstuk1Navigatie
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
            this.btnInleidingProgrammerenPwp = new System.Windows.Forms.Button();
            this.btnBasiscode = new System.Windows.Forms.Button();
            this.btnExtraVenster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInleidingProgrammerenPwp
            // 
            this.btnInleidingProgrammerenPwp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInleidingProgrammerenPwp.Location = new System.Drawing.Point(12, 12);
            this.btnInleidingProgrammerenPwp.Name = "btnInleidingProgrammerenPwp";
            this.btnInleidingProgrammerenPwp.Size = new System.Drawing.Size(392, 31);
            this.btnInleidingProgrammerenPwp.TabIndex = 1;
            this.btnInleidingProgrammerenPwp.Text = "Powerpoint inleiding programmeren";
            this.btnInleidingProgrammerenPwp.UseVisualStyleBackColor = true;
            this.btnInleidingProgrammerenPwp.Click += new System.EventHandler(this.btnInleidingProgrammerenPwp_Click);
            // 
            // btnBasiscode
            // 
            this.btnBasiscode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasiscode.Location = new System.Drawing.Point(12, 49);
            this.btnBasiscode.Name = "btnBasiscode";
            this.btnBasiscode.Size = new System.Drawing.Size(392, 31);
            this.btnBasiscode.TabIndex = 1;
            this.btnBasiscode.Text = "Basiscode (syntax)";
            this.btnBasiscode.UseVisualStyleBackColor = true;
            this.btnBasiscode.Click += new System.EventHandler(this.btnBasiscode_Click);
            // 
            // btnExtraVenster
            // 
            this.btnExtraVenster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraVenster.Location = new System.Drawing.Point(12, 86);
            this.btnExtraVenster.Name = "btnExtraVenster";
            this.btnExtraVenster.Size = new System.Drawing.Size(392, 31);
            this.btnExtraVenster.TabIndex = 1;
            this.btnExtraVenster.Text = "Toevoegen extra venster";
            this.btnExtraVenster.UseVisualStyleBackColor = true;
            this.btnExtraVenster.Click += new System.EventHandler(this.btnExtraVenster_Click);
            // 
            // frmHoofdstuk1Navigatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.btnExtraVenster);
            this.Controls.Add(this.btnBasiscode);
            this.Controls.Add(this.btnInleidingProgrammerenPwp);
            this.Name = "frmHoofdstuk1Navigatie";
            this.Text = "Hoofdstuk 1 - Navigatie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInleidingProgrammerenPwp;
        private System.Windows.Forms.Button btnBasiscode;
        private System.Windows.Forms.Button btnExtraVenster;
    }
}