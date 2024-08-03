namespace Clipboard_Toast
{
    partial class MainWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rb_Right = new System.Windows.Forms.RadioButton();
            this.Rb_Center = new System.Windows.Forms.RadioButton();
            this.Rb_Left = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rb_Down = new System.Windows.Forms.RadioButton();
            this.Rb_Up = new System.Windows.Forms.RadioButton();
            this.Pb_ScreenImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ScreenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rb_Right);
            this.groupBox1.Controls.Add(this.Rb_Center);
            this.groupBox1.Controls.Add(this.Rb_Left);
            this.groupBox1.Location = new System.Drawing.Point(41, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position/Posición";
            // 
            // Rb_Right
            // 
            this.Rb_Right.AutoSize = true;
            this.Rb_Right.Checked = true;
            this.Rb_Right.Location = new System.Drawing.Point(6, 75);
            this.Rb_Right.Name = "Rb_Right";
            this.Rb_Right.Size = new System.Drawing.Size(96, 17);
            this.Rb_Right.TabIndex = 2;
            this.Rb_Right.TabStop = true;
            this.Rb_Right.Text = "Right/Derecha";
            this.Rb_Right.UseVisualStyleBackColor = true;
            this.Rb_Right.CheckedChanged += new System.EventHandler(this.Rb_Right_CheckedChanged);
            // 
            // Rb_Center
            // 
            this.Rb_Center.AutoSize = true;
            this.Rb_Center.Location = new System.Drawing.Point(6, 52);
            this.Rb_Center.Name = "Rb_Center";
            this.Rb_Center.Size = new System.Drawing.Size(92, 17);
            this.Rb_Center.TabIndex = 1;
            this.Rb_Center.Text = "Center/Centro";
            this.Rb_Center.UseVisualStyleBackColor = true;
            this.Rb_Center.CheckedChanged += new System.EventHandler(this.Rb_Center_CheckedChanged);
            // 
            // Rb_Left
            // 
            this.Rb_Left.AutoSize = true;
            this.Rb_Left.Location = new System.Drawing.Point(6, 29);
            this.Rb_Left.Name = "Rb_Left";
            this.Rb_Left.Size = new System.Drawing.Size(91, 17);
            this.Rb_Left.TabIndex = 0;
            this.Rb_Left.Text = "Left/Izquierda";
            this.Rb_Left.UseVisualStyleBackColor = true;
            this.Rb_Left.CheckedChanged += new System.EventHandler(this.Rb_Left_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rb_Down);
            this.groupBox2.Controls.Add(this.Rb_Up);
            this.groupBox2.Location = new System.Drawing.Point(363, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Height/Altura";
            // 
            // Rb_Down
            // 
            this.Rb_Down.AutoSize = true;
            this.Rb_Down.Checked = true;
            this.Rb_Down.Location = new System.Drawing.Point(6, 63);
            this.Rb_Down.Name = "Rb_Down";
            this.Rb_Down.Size = new System.Drawing.Size(85, 17);
            this.Rb_Down.TabIndex = 1;
            this.Rb_Down.TabStop = true;
            this.Rb_Down.Text = "Down/Abajo";
            this.Rb_Down.UseVisualStyleBackColor = true;
            this.Rb_Down.CheckedChanged += new System.EventHandler(this.Rb_Down_CheckedChanged);
            // 
            // Rb_Up
            // 
            this.Rb_Up.AutoSize = true;
            this.Rb_Up.Location = new System.Drawing.Point(6, 40);
            this.Rb_Up.Name = "Rb_Up";
            this.Rb_Up.Size = new System.Drawing.Size(71, 17);
            this.Rb_Up.TabIndex = 0;
            this.Rb_Up.Text = "Up/Arriba";
            this.Rb_Up.UseVisualStyleBackColor = true;
            this.Rb_Up.CheckedChanged += new System.EventHandler(this.Rb_Up_CheckedChanged);
            // 
            // Pb_ScreenImage
            // 
            this.Pb_ScreenImage.Image = global::Clipboard_Toast.Properties.Resources.Scr_Up_Center;
            this.Pb_ScreenImage.Location = new System.Drawing.Point(41, 37);
            this.Pb_ScreenImage.Name = "Pb_ScreenImage";
            this.Pb_ScreenImage.Size = new System.Drawing.Size(425, 238);
            this.Pb_ScreenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_ScreenImage.TabIndex = 2;
            this.Pb_ScreenImage.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 424);
            this.Controls.Add(this.Pb_ScreenImage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClipCall";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ScreenImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb_Right;
        private System.Windows.Forms.RadioButton Rb_Center;
        private System.Windows.Forms.RadioButton Rb_Left;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rb_Down;
        private System.Windows.Forms.RadioButton Rb_Up;
        private System.Windows.Forms.PictureBox Pb_ScreenImage;
    }
}

