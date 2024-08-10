namespace prj5BISofoAlles._02_VariabelenEnConstantenInteractieMetDeGebruiker.Oefeningen
{
    partial class frmOefening2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrijsExclBTW = new System.Windows.Forms.TextBox();
            this.btnPrijsInclBTW = new System.Windows.Forms.Button();
            this.lblBTW = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrijsInclBTW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "BTW berekenen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prijs exclusief BTW:";
            // 
            // txtPrijsExclBTW
            // 
            this.txtPrijsExclBTW.Location = new System.Drawing.Point(175, 101);
            this.txtPrijsExclBTW.Name = "txtPrijsExclBTW";
            this.txtPrijsExclBTW.Size = new System.Drawing.Size(241, 20);
            this.txtPrijsExclBTW.TabIndex = 2;
            // 
            // btnPrijsInclBTW
            // 
            this.btnPrijsInclBTW.Location = new System.Drawing.Point(55, 149);
            this.btnPrijsInclBTW.Name = "btnPrijsInclBTW";
            this.btnPrijsInclBTW.Size = new System.Drawing.Size(361, 49);
            this.btnPrijsInclBTW.TabIndex = 3;
            this.btnPrijsInclBTW.Text = "Bereken prijs inclusief BTW";
            this.btnPrijsInclBTW.UseVisualStyleBackColor = true;
            this.btnPrijsInclBTW.Click += new System.EventHandler(this.btnPrijsInclBTW_Click);
            // 
            // lblBTW
            // 
            this.lblBTW.AutoSize = true;
            this.lblBTW.Location = new System.Drawing.Point(52, 233);
            this.lblBTW.Name = "lblBTW";
            this.lblBTW.Size = new System.Drawing.Size(0, 13);
            this.lblBTW.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // lblPrijsInclBTW
            // 
            this.lblPrijsInclBTW.AutoSize = true;
            this.lblPrijsInclBTW.Location = new System.Drawing.Point(55, 264);
            this.lblPrijsInclBTW.Name = "lblPrijsInclBTW";
            this.lblPrijsInclBTW.Size = new System.Drawing.Size(0, 13);
            this.lblPrijsInclBTW.TabIndex = 5;
            // 
            // frmOefening2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(450, 309);
            this.Controls.Add(this.lblPrijsInclBTW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBTW);
            this.Controls.Add(this.btnPrijsInclBTW);
            this.Controls.Add(this.txtPrijsExclBTW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOefening2";
            this.Text = "BTW berekenen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrijsExclBTW;
        private System.Windows.Forms.Button btnPrijsInclBTW;
        private System.Windows.Forms.Label lblBTW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrijsInclBTW;
    }
}