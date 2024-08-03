using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clipboard_Toast
{
    public partial class RightToast : Form
    {
        #pragma warning disable IDE0044
        private int _horizontalSpeed = 10, timer = 150;
        private int _toastX, _toastY;
        private bool isUp;

        public RightToast(bool up)
        {
            InitializeComponent();
            this.isUp = up;
        }

        private void ToastMessage_Load(object sender, EventArgs e)
        {
            Position();
            lb_Title.Text = MainWindow.title;
            lb_message.Text = MainWindow.message;
        }

        private void toastTimer_Tick_1(object sender, EventArgs e)
        {
            _toastX -= _horizontalSpeed;
            this.Location = new Point(_toastX, _toastY);
            this.BringToFront();
            if (_toastX <= MainWindow.screenWidth - this.Width - 5)
            {
                toastTimer.Stop();
                toastTimerDown.Start();
            }
        }

        private void toastTimerDown_Tick(object sender, EventArgs e)
        {
            timer--;
            this.BringToFront();
            if (timer <= 0)
            {
                this.Location = new Point(_toastX += _horizontalSpeed, _toastY);
                if (_toastX > MainWindow.screenWidth + 20)
                {
                    toastTimerDown.Stop();
                    timer = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        { 
            _toastX = MainWindow.screenWidth + (MainWindow.screenWidth / 96);
            if (!isUp)
                _toastY = MainWindow.screenHeight - this.Height - (MainWindow.screenHeight / 260);
            else
                _toastY = this.Height - (MainWindow.screenHeight / 260);

            this.Location = new Point(_toastX, _toastY);
        }
    }
}
