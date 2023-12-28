namespace screen_capture
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btSelectScreen = new System.Windows.Forms.Button();
            this.btFullScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSelectScreen
            // 
            this.btSelectScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSelectScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSelectScreen.Location = new System.Drawing.Point(56, 12);
            this.btSelectScreen.Name = "btSelectScreen";
            this.btSelectScreen.Size = new System.Drawing.Size(154, 50);
            this.btSelectScreen.TabIndex = 0;
            this.btSelectScreen.Text = "Select Screen";
            this.btSelectScreen.UseVisualStyleBackColor = false;
            this.btSelectScreen.Click += new System.EventHandler(this.btSelectScreen_Click);
            // 
            // btFullScreen
            // 
            this.btFullScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btFullScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFullScreen.Location = new System.Drawing.Point(241, 12);
            this.btFullScreen.Name = "btFullScreen";
            this.btFullScreen.Size = new System.Drawing.Size(154, 50);
            this.btFullScreen.TabIndex = 1;
            this.btFullScreen.Text = "Full Screen";
            this.btFullScreen.UseVisualStyleBackColor = false;
            this.btFullScreen.Click += new System.EventHandler(this.btFullScreen_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(450, 79);
            this.Controls.Add(this.btFullScreen);
            this.Controls.Add(this.btSelectScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen Capture";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSelectScreen;
        private System.Windows.Forms.Button btFullScreen;
    }
}

