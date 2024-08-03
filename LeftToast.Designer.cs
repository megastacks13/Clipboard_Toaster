namespace Clipboard_Toast
{
    partial class LeftToast
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
            this.pb_Triangle = new System.Windows.Forms.PictureBox();
            this.pb_Anotar = new System.Windows.Forms.PictureBox();
            this.lb_message = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.ToastTimer = new System.Windows.Forms.Timer(this.components);
            this.ToastTimerDown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Triangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Anotar)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Triangle
            // 
            this.pb_Triangle.Image = global::Clipboard_Toast.Properties.Resources.Triangle_Sideways_Soft_Green_GPT___Inverted;
            this.pb_Triangle.Location = new System.Drawing.Point(205, -7);
            this.pb_Triangle.Name = "pb_Triangle";
            this.pb_Triangle.Size = new System.Drawing.Size(98, 92);
            this.pb_Triangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Triangle.TabIndex = 0;
            this.pb_Triangle.TabStop = false;
            // 
            // pb_Anotar
            // 
            this.pb_Anotar.Image = global::Clipboard_Toast.Properties.Resources.AnotarIc;
            this.pb_Anotar.Location = new System.Drawing.Point(12, 12);
            this.pb_Anotar.Name = "pb_Anotar";
            this.pb_Anotar.Size = new System.Drawing.Size(31, 31);
            this.pb_Anotar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Anotar.TabIndex = 1;
            this.pb_Anotar.TabStop = false;
            // 
            // lb_message
            // 
            this.lb_message.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.Location = new System.Drawing.Point(55, 33);
            this.lb_message.MaximumSize = new System.Drawing.Size(173, 17);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(173, 17);
            this.lb_message.TabIndex = 5;
            this.lb_message.Text = "Toast Message";
            this.lb_message.UseCompatibleTextRendering = true;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(55, 9);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(38, 17);
            this.lb_Title.TabIndex = 4;
            this.lb_Title.Text = "Type";
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
            // LeftToast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 59);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.pb_Anotar);
            this.Controls.Add(this.pb_Triangle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(282, 59);
            this.MinimumSize = new System.Drawing.Size(282, 59);
            this.Name = "LeftToast";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "LeftToast";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ToastMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Triangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Anotar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Triangle;
        private System.Windows.Forms.PictureBox pb_Anotar;
        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Timer ToastTimer;
        private System.Windows.Forms.Timer ToastTimerDown;
    }
}