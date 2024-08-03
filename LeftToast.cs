using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipboard_Toast
{
    public partial class LeftToast : Form
    {
        private int _horizontalSpeed = 10;
        private int toastX, toastY;
        private bool _isUp = false;

        public LeftToast(bool up)
        {
            InitializeComponent();
            this._isUp = up;
        }

        private void ToastMessage_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void ToastTimer_Tick(object sender, EventArgs e)
        {
            toastX += _horizontalSpeed;
            this.Location = new Point(toastX, toastY);
            this.BringToFront();
            if (toastX >= 0)
            {
                ToastTimer.Stop();
                ToastTimerDown.Start();
            }
        }

        int timer = 150;

        private void ToastTimerDown_Tick(object sender, EventArgs e)
        {
            timer--;
            this.BringToFront();
            if (timer <= 0)
            {
                this.Location = new Point(toastX -= _horizontalSpeed, toastY);
                if (toastX < -this.Width)
                {
                    ToastTimerDown.Stop();
                    timer = 100;
                    this.Close();
                }
            }
        }

        public void SetMessage(string title, string subtitle)
        {
            lb_Title.Text = title;
            lb_message.Text = subtitle;
        }

        private void Position()
        {
            toastX = -this.Width;
            if (!_isUp)
                toastY = MainWindow.screenHeight - this.Height - (MainWindow.screenHeight / 260);
            else
                toastY = this.Height - (MainWindow.screenHeight / 260);

            this.Location = new Point(toastX, toastY);
        }


    }
}
