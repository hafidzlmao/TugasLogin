
namespace TugasLogin
{
    partial class Form3
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
            this.gambar1 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gambar1)).BeginInit();
            this.SuspendLayout();
            // 
            // gambar1
            // 
            this.gambar1.Image = global::TugasLogin.Properties.Resources.scopslogo1;
            this.gambar1.Location = new System.Drawing.Point(564, 48);
            this.gambar1.Name = "gambar1";
            this.gambar1.Size = new System.Drawing.Size(182, 249);
            this.gambar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gambar1.TabIndex = 4;
            this.gambar1.TabStop = false;
            this.gambar1.Click += new System.EventHandler(this.gambar1_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(91, 134);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(245, 62);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "Back Form 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.gambar1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.gambar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gambar1;
        private System.Windows.Forms.Button btn1;
    }
}