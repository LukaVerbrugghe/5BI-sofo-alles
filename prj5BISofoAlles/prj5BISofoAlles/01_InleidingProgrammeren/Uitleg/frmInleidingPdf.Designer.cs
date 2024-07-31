namespace prj5BISofoAlles._01_InleidingProgrammeren.Uitleg
{
    partial class frmInleidingPdf
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
            this.btnPreviousSlide = new System.Windows.Forms.Button();
            this.btnNextSlide = new System.Windows.Forms.Button();
            this.picSlide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPreviousSlide
            // 
            this.btnPreviousSlide.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousSlide.Location = new System.Drawing.Point(12, 225);
            this.btnPreviousSlide.Name = "btnPreviousSlide";
            this.btnPreviousSlide.Size = new System.Drawing.Size(59, 167);
            this.btnPreviousSlide.TabIndex = 0;
            this.btnPreviousSlide.Text = "<";
            this.btnPreviousSlide.UseVisualStyleBackColor = true;
            this.btnPreviousSlide.Click += new System.EventHandler(this.btnPreviousSlide_Click);
            // 
            // btnNextSlide
            // 
            this.btnNextSlide.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextSlide.Location = new System.Drawing.Point(1071, 225);
            this.btnNextSlide.Name = "btnNextSlide";
            this.btnNextSlide.Size = new System.Drawing.Size(59, 167);
            this.btnNextSlide.TabIndex = 0;
            this.btnNextSlide.Text = ">";
            this.btnNextSlide.UseVisualStyleBackColor = true;
            this.btnNextSlide.Click += new System.EventHandler(this.btnNextSlide_Click);
            // 
            // picSlide
            // 
            this.picSlide.Image = global::prj5BISofoAlles.Properties.Resources.Screenshot_2024_07_31_200642;
            this.picSlide.Location = new System.Drawing.Point(88, 39);
            this.picSlide.Name = "picSlide";
            this.picSlide.Size = new System.Drawing.Size(965, 541);
            this.picSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSlide.TabIndex = 1;
            this.picSlide.TabStop = false;
            // 
            // frmInleidingPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 630);
            this.Controls.Add(this.picSlide);
            this.Controls.Add(this.btnNextSlide);
            this.Controls.Add(this.btnPreviousSlide);
            this.Name = "frmInleidingPdf";
            this.Text = "Inleiding (pwp)";
            ((System.ComponentModel.ISupportInitialize)(this.picSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPreviousSlide;
        private System.Windows.Forms.PictureBox picSlide;
        private System.Windows.Forms.Button btnNextSlide;
    }
}