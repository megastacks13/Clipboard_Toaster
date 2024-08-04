namespace Clipboard_Toast
{
    partial class RightToast
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean _isUp any resources being used.
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_message = new System.Windows.Forms.Label();
            this.toastTimer = new System.Windows.Forms.Timer(this.components);
            this.toastTimerDown = new System.Windows.Forms.Timer(this.components);
            this.pb_Icon = new System.Windows.Forms.PictureBox();
            this.pb_Triangle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Triangle)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(97, 9);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(38, 17);
            this.lb_Title.TabIndex = 2;
            this.lb_Title.Text = "Type";
            // 
            // lb_message
            // 
            this.lb_message.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.Location = new System.Drawing.Point(97, 33);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(173, 17);
            this.lb_message.TabIndex = 3;
            this.lb_message.Text = "Toast Message";
            this.lb_message.UseCompatibleTextRendering = true;
            // 
            // toastTimer
            // 
            this.toastTimer.Enabled = true;
            this.toastTimer.Interval = 1;
            this.toastTimer.Tick += new System.EventHandler(this.toastTimer_Tick_1);
            // 
            // toastTimerDown
            // 
            this.toastTimerDown.Enabled = true;
            this.toastTimerDown.Interval = 1;
            this.toastTimerDown.Tick += new System.EventHandler(this.toastTimerDown_Tick);
            // 
            // pb_Icon
            // 
            this.pb_Icon.Image = global::Clipboard_Toast.Properties.Resources.AnotarIc;
            this.pb_Icon.Location = new System.Drawing.Point(49, 12);
            this.pb_Icon.Name = "pb_Icon";
            this.pb_Icon.Size = new System.Drawing.Size(31, 31);
            this.pb_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Icon.TabIndex = 1;
            this.pb_Icon.TabStop = false;
            // 
            // pb_Triangle
            // 
            this.pb_Triangle.BackColor = System.Drawing.Color.Transparent;
            this.pb_Triangle.Image = global::Clipboard_Toast.Properties.Resources.Triangle_Sideways_Soft_Green_GPT;
            this.pb_Triangle.Location = new System.Drawing.Point(-35, -43);
            this.pb_Triangle.Name = "pb_Triangle";
            this.pb_Triangle.Size = new System.Drawing.Size(100, 122);
            this.pb_Triangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Triangle.TabIndex = 4;
            this.pb_Triangle.TabStop = false;
            // 
            // RightToast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 59);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.pb_Icon);
            this.Controls.Add(this.pb_Triangle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(282, 59);
            this.Name = "RightToast";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ToastMessage";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ToastMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Triangle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.PictureBox pb_Icon;
        private System.Windows.Forms.PictureBox pb_Triangle;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer toastTimerDown;
    }
}