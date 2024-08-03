namespace Clipboard_Toast
{
    partial class CenterToast
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
            this.components = new System.ComponentModel.Container();
            this.ToastTimer = new System.Windows.Forms.Timer(this.components);
            this.ToastTimerDown = new System.Windows.Forms.Timer(this.components);
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ToastTimer
            // 
            this.ToastTimer.Enabled = true;
            this.ToastTimer.Interval = 10;
            this.ToastTimer.Tick += new System.EventHandler(this.ToastTimer_Tick);
            // 
            // ToastTimerDown
            // 
            this.ToastTimerDown.Interval = 10;
            this.ToastTimerDown.Tick += new System.EventHandler(this.ToastTimerDown_Tick);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::Clipboard_Toast.Properties.Resources.Toast_Center;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbImage.MaximumSize = new System.Drawing.Size(122, 122);
            this.pbImage.MinimumSize = new System.Drawing.Size(122, 122);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(122, 122);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // CenterToast
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(122, 122);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximumSize = new System.Drawing.Size(122, 122);
            this.MinimumSize = new System.Drawing.Size(122, 122);
            this.Name = "CenterToast";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer ToastTimer;
        private System.Windows.Forms.Timer ToastTimerDown;
        private System.Windows.Forms.PictureBox pbImage;
    }
}