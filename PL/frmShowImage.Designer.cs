namespace SalesManagementSystem_wf.PL
{
    partial class frmShowImage
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
            this.ptbProductImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbProductImage
            // 
            this.ptbProductImage.Location = new System.Drawing.Point(43, 24);
            this.ptbProductImage.Name = "ptbProductImage";
            this.ptbProductImage.Size = new System.Drawing.Size(794, 648);
            this.ptbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProductImage.TabIndex = 0;
            this.ptbProductImage.TabStop = false;
            // 
            // frmShowImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 684);
            this.Controls.Add(this.ptbProductImage);
            this.Name = "frmShowImage";
            this.Text = "frmShowImage";
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox ptbProductImage;
    }
}