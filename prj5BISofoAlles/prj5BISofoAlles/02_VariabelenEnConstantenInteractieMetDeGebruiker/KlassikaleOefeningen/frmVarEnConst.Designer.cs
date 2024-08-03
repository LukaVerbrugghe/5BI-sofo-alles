namespace prj5BISofoAlles._02_VariabelenEnConstantenInteractieMetDeGebruiker.KlassikaleOefeningen
{
    partial class frmVarEnConst
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
            this.btnVar1 = new System.Windows.Forms.Button();
            this.btnVar2 = new System.Windows.Forms.Button();
            this.btnVar3 = new System.Windows.Forms.Button();
            this.btnVar4 = new System.Windows.Forms.Button();
            this.btnVar5 = new System.Windows.Forms.Button();
            this.lblGetal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVar1
            // 
            this.btnVar1.Location = new System.Drawing.Point(13, 13);
            this.btnVar1.Name = "btnVar1";
            this.btnVar1.Size = new System.Drawing.Size(206, 61);
            this.btnVar1.TabIndex = 0;
            this.btnVar1.Text = "Var 1";
            this.btnVar1.UseVisualStyleBackColor = true;
            this.btnVar1.Click += new System.EventHandler(this.btnVar1_Click);
            // 
            // btnVar2
            // 
            this.btnVar2.Location = new System.Drawing.Point(13, 80);
            this.btnVar2.Name = "btnVar2";
            this.btnVar2.Size = new System.Drawing.Size(206, 61);
            this.btnVar2.TabIndex = 0;
            this.btnVar2.Text = "Var 2";
            this.btnVar2.UseVisualStyleBackColor = true;
            this.btnVar2.Click += new System.EventHandler(this.btnVar2_Click);
            // 
            // btnVar3
            // 
            this.btnVar3.Location = new System.Drawing.Point(12, 147);
            this.btnVar3.Name = "btnVar3";
            this.btnVar3.Size = new System.Drawing.Size(206, 61);
            this.btnVar3.TabIndex = 0;
            this.btnVar3.Text = "Var 3";
            this.btnVar3.UseVisualStyleBackColor = true;
            this.btnVar3.Click += new System.EventHandler(this.btnVar3_Click);
            // 
            // btnVar4
            // 
            this.btnVar4.Location = new System.Drawing.Point(12, 214);
            this.btnVar4.Name = "btnVar4";
            this.btnVar4.Size = new System.Drawing.Size(206, 61);
            this.btnVar4.TabIndex = 0;
            this.btnVar4.Text = "Var 4";
            this.btnVar4.UseVisualStyleBackColor = true;
            this.btnVar4.Click += new System.EventHandler(this.btnVar4_Click);
            // 
            // btnVar5
            // 
            this.btnVar5.Location = new System.Drawing.Point(12, 281);
            this.btnVar5.Name = "btnVar5";
            this.btnVar5.Size = new System.Drawing.Size(206, 61);
            this.btnVar5.TabIndex = 0;
            this.btnVar5.Text = "Var 5";
            this.btnVar5.UseVisualStyleBackColor = true;
            this.btnVar5.Click += new System.EventHandler(this.btnVar5_Click);
            // 
            // lblGetal
            // 
            this.lblGetal.AutoSize = true;
            this.lblGetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetal.ForeColor = System.Drawing.Color.Red;
            this.lblGetal.Location = new System.Drawing.Point(87, 359);
            this.lblGetal.Name = "lblGetal";
            this.lblGetal.Size = new System.Drawing.Size(0, 13);
            this.lblGetal.TabIndex = 1;
            // 
            // frmVarEnConst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 398);
            this.Controls.Add(this.lblGetal);
            this.Controls.Add(this.btnVar5);
            this.Controls.Add(this.btnVar4);
            this.Controls.Add(this.btnVar3);
            this.Controls.Add(this.btnVar2);
            this.Controls.Add(this.btnVar1);
            this.Name = "frmVarEnConst";
            this.Text = "Variabelen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVar1;
        private System.Windows.Forms.Button btnVar2;
        private System.Windows.Forms.Button btnVar3;
        private System.Windows.Forms.Button btnVar4;
        private System.Windows.Forms.Button btnVar5;
        private System.Windows.Forms.Label lblGetal;
    }
}