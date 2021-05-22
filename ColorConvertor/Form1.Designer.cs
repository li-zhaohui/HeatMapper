namespace ColorConvertor
{
    partial class Form1
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
            this.boxSrc = new System.Windows.Forms.PictureBox();
            this.boxDst = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxDst)).BeginInit();
            this.SuspendLayout();
            // 
            // boxSrc
            // 
            this.boxSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSrc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.boxSrc.Location = new System.Drawing.Point(12, 27);
            this.boxSrc.Name = "boxSrc";
            this.boxSrc.Size = new System.Drawing.Size(421, 490);
            this.boxSrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxSrc.TabIndex = 0;
            this.boxSrc.TabStop = false;
            // 
            // boxDst
            // 
            this.boxDst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxDst.BackColor = System.Drawing.SystemColors.ControlDark;
            this.boxDst.Location = new System.Drawing.Point(439, 27);
            this.boxDst.Name = "boxDst";
            this.boxDst.Size = new System.Drawing.Size(421, 490);
            this.boxDst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxDst.TabIndex = 1;
            this.boxDst.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(867, 529);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.boxDst);
            this.Controls.Add(this.boxSrc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Bitmap Convertor";
            ((System.ComponentModel.ISupportInitialize)(this.boxSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxDst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox boxSrc;
        private System.Windows.Forms.PictureBox boxDst;
        private System.Windows.Forms.Button btnOpen;
    }
}

