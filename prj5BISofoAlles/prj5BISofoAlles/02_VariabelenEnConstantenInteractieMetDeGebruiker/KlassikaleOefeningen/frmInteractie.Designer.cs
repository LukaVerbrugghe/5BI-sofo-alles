namespace prj5BISofoAlles._02_VariabelenEnConstantenInteractieMetDeGebruiker.KlassikaleOefeningen
{
    partial class frmInteractie
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
            this.btnMessagebox = new System.Windows.Forms.Button();
            this.btnInputbox = new System.Windows.Forms.Button();
            this.btnMsgb2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMsgb2Waarde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMessagebox
            // 
            this.btnMessagebox.Location = new System.Drawing.Point(13, 13);
            this.btnMessagebox.Name = "btnMessagebox";
            this.btnMessagebox.Size = new System.Drawing.Size(109, 48);
            this.btnMessagebox.TabIndex = 0;
            this.btnMessagebox.Text = "Messagebox";
            this.btnMessagebox.UseVisualStyleBackColor = true;
            this.btnMessagebox.Click += new System.EventHandler(this.btnMessagebox_Click);
            // 
            // btnInputbox
            // 
            this.btnInputbox.Location = new System.Drawing.Point(128, 13);
            this.btnInputbox.Name = "btnInputbox";
            this.btnInputbox.Size = new System.Drawing.Size(109, 48);
            this.btnInputbox.TabIndex = 0;
            this.btnInputbox.Text = "Inputbox";
            this.btnInputbox.UseVisualStyleBackColor = true;
            this.btnInputbox.Click += new System.EventHandler(this.btnInputbox_Click);
            // 
            // btnMsgb2
            // 
            this.btnMsgb2.Location = new System.Drawing.Point(243, 12);
            this.btnMsgb2.Name = "btnMsgb2";
            this.btnMsgb2.Size = new System.Drawing.Size(109, 48);
            this.btnMsgb2.TabIndex = 0;
            this.btnMsgb2.Text = "Messagebox 2";
            this.btnMsgb2.UseVisualStyleBackColor = true;
            this.btnMsgb2.Click += new System.EventHandler(this.btnMsgb2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Je naam is:";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.ForeColor = System.Drawing.Color.Red;
            this.lblNaam.Location = new System.Drawing.Point(79, 86);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(0, 37);
            this.lblNaam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "De gekozen waarde is:";
            // 
            // lblMsgb2Waarde
            // 
            this.lblMsgb2Waarde.AutoSize = true;
            this.lblMsgb2Waarde.Location = new System.Drawing.Point(139, 174);
            this.lblMsgb2Waarde.Name = "lblMsgb2Waarde";
            this.lblMsgb2Waarde.Size = new System.Drawing.Size(0, 13);
            this.lblMsgb2Waarde.TabIndex = 4;
            // 
            // frmInteractie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 234);
            this.Controls.Add(this.lblMsgb2Waarde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMsgb2);
            this.Controls.Add(this.btnInputbox);
            this.Controls.Add(this.btnMessagebox);
            this.Name = "frmInteractie";
            this.Text = "Interactie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessagebox;
        private System.Windows.Forms.Button btnInputbox;
        private System.Windows.Forms.Button btnMsgb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMsgb2Waarde;
    }
}