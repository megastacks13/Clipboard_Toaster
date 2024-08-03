namespace Clipboard_Toast
{
    partial class MainWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Right = new System.Windows.Forms.RadioButton();
            this.rb_Center = new System.Windows.Forms.RadioButton();
            this.rb_Left = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Down = new System.Windows.Forms.RadioButton();
            this.rb_Up = new System.Windows.Forms.RadioButton();
            this.pb_ScreenImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScreenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Right);
            this.groupBox1.Controls.Add(this.rb_Center);
            this.groupBox1.Controls.Add(this.rb_Left);
            this.groupBox1.Location = new System.Drawing.Point(41, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position/Posición";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb_Right
            // 
            this.rb_Right.AutoSize = true;
            this.rb_Right.Checked = true;
            this.rb_Right.Location = new System.Drawing.Point(6, 75);
            this.rb_Right.Name = "rb_Right";
            this.rb_Right.Size = new System.Drawing.Size(96, 17);
            this.rb_Right.TabIndex = 2;
            this.rb_Right.TabStop = true;
            this.rb_Right.Text = "Right/Derecha";
            this.rb_Right.UseVisualStyleBackColor = true;
            this.rb_Right.CheckedChanged += new System.EventHandler(this.rb_Right_CheckedChanged);
            // 
            // rb_Center
            // 
            this.rb_Center.AutoSize = true;
            this.rb_Center.Location = new System.Drawing.Point(6, 52);
            this.rb_Center.Name = "rb_Center";
            this.rb_Center.Size = new System.Drawing.Size(92, 17);
            this.rb_Center.TabIndex = 1;
            this.rb_Center.Text = "Center/Centro";
            this.rb_Center.UseVisualStyleBackColor = true;
            this.rb_Center.CheckedChanged += new System.EventHandler(this.rb_Center_CheckedChanged);
            // 
            // rb_Left
            // 
            this.rb_Left.AutoSize = true;
            this.rb_Left.Location = new System.Drawing.Point(6, 29);
            this.rb_Left.Name = "rb_Left";
            this.rb_Left.Size = new System.Drawing.Size(91, 17);
            this.rb_Left.TabIndex = 0;
            this.rb_Left.Text = "Left/Izquierda";
            this.rb_Left.UseVisualStyleBackColor = true;
            this.rb_Left.CheckedChanged += new System.EventHandler(this.rb_Left_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Down);
            this.groupBox2.Controls.Add(this.rb_Up);
            this.groupBox2.Location = new System.Drawing.Point(363, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Height/Altura";
            // 
            // rb_Down
            // 
            this.rb_Down.AutoSize = true;
            this.rb_Down.Checked = true;
            this.rb_Down.Location = new System.Drawing.Point(6, 63);
            this.rb_Down.Name = "rb_Down";
            this.rb_Down.Size = new System.Drawing.Size(85, 17);
            this.rb_Down.TabIndex = 1;
            this.rb_Down.TabStop = true;
            this.rb_Down.Text = "Down/Abajo";
            this.rb_Down.UseVisualStyleBackColor = true;
            this.rb_Down.CheckedChanged += new System.EventHandler(this.rb_Down_CheckedChanged);
            // 
            // rb_Up
            // 
            this.rb_Up.AutoSize = true;
            this.rb_Up.Location = new System.Drawing.Point(6, 40);
            this.rb_Up.Name = "rb_Up";
            this.rb_Up.Size = new System.Drawing.Size(71, 17);
            this.rb_Up.TabIndex = 0;
            this.rb_Up.Text = "Up/Arriba";
            this.rb_Up.UseVisualStyleBackColor = true;
            this.rb_Up.CheckedChanged += new System.EventHandler(this.rb_Up_CheckedChanged);
            // 
            // pb_ScreenImage
            // 
            this.pb_ScreenImage.Image = global::Clipboard_Toast.Properties.Resources.Scr_Up_Center;
            this.pb_ScreenImage.Location = new System.Drawing.Point(41, 37);
            this.pb_ScreenImage.Name = "pb_ScreenImage";
            this.pb_ScreenImage.Size = new System.Drawing.Size(425, 238);
            this.pb_ScreenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ScreenImage.TabIndex = 2;
            this.pb_ScreenImage.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 424);
            this.Controls.Add(this.pb_ScreenImage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClipCall";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ScreenImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Right;
        private System.Windows.Forms.RadioButton rb_Center;
        private System.Windows.Forms.RadioButton rb_Left;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Down;
        private System.Windows.Forms.RadioButton rb_Up;
        private System.Windows.Forms.PictureBox pb_ScreenImage;
    }
}

