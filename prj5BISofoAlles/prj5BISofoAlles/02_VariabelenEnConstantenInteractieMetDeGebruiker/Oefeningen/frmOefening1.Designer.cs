namespace prj5BISofoAlles._02_VariabelenEnConstantenInteractieMetDeGebruiker.Oefeningen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGewicht = new System.Windows.Forms.TextBox();
            this.txtLengte = new System.Windows.Forms.TextBox();
            this.btnBerekenBMI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI berekenen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gewicht";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lengte (in meter)";
            // 
            // txtGewicht
            // 
            this.txtGewicht.Location = new System.Drawing.Point(165, 88);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.Size = new System.Drawing.Size(192, 20);
            this.txtGewicht.TabIndex = 2;
            // 
            // txtLengte
            // 
            this.txtLengte.Location = new System.Drawing.Point(165, 132);
            this.txtLengte.Name = "txtLengte";
            this.txtLengte.Size = new System.Drawing.Size(192, 20);
            this.txtLengte.TabIndex = 2;
            // 
            // btnBerekenBMI
            // 
            this.btnBerekenBMI.Location = new System.Drawing.Point(165, 181);
            this.btnBerekenBMI.Name = "btnBerekenBMI";
            this.btnBerekenBMI.Size = new System.Drawing.Size(192, 23);
            this.btnBerekenBMI.TabIndex = 3;
            this.btnBerekenBMI.Text = "Bereken";
            this.btnBerekenBMI.UseVisualStyleBackColor = true;
            this.btnBerekenBMI.Click += new System.EventHandler(this.btnBerekenBMI_Click);
            // 
            // frmOefening1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 260);
            this.Controls.Add(this.btnBerekenBMI);
            this.Controls.Add(this.txtLengte);
            this.Controls.Add(this.txtGewicht);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOefening1";
            this.Text = "BMI berekenen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGewicht;
        private System.Windows.Forms.TextBox txtLengte;
        private System.Windows.Forms.Button btnBerekenBMI;
    }
}