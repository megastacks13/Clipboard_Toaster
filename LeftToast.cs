using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clipboard_Toast
{
    public partial class LeftToast : Form
    {
        private int _horizontalSpeed = MainWindow.screenWidth / 450;
        private int toastX, toastY;
        private int timer = 200;
        private double toastTargetX;
        private bool _isUp = false;

        public LeftToast(bool up)
        {
            InitializeComponent();
            ComputeTargetPosition();
            this._isUp = up;
        }

        private void ToastMessage_Load(object sender, EventArgs e)
        {
            Position();
            lb_Title.Text = MainWindow.title;
            lb_message.Text = MainWindow.message;
        }

        private void ToastTimer_Tick(object sender, EventArgs e)
        {
            toastX += _horizontalSpeed;
            this.Opacity = ComputeOpacity(Math.Max(1,  toastTargetX - toastX));
            this.Location = new Point(toastX, toastY);

            if (toastX >= toastTargetX)
            {
                ToastTimer.Stop();
                ToastTimerDown.Start();
            }
        }

        private void ToastTimerDown_Tick(object sender, EventArgs e)
        {
            timer--;

            if (timer <= 0)
            {
                this.Location = new Point(toastX -= _horizontalSpeed, toastY);
                this.Opacity = ComputeOpacity((toastX - toastTargetX) * 2);
                if (toastX < -this.Width)
                {
                    ToastTimerDown.Stop();
                    timer = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        {
            toastX = -this.Width/2;
            if (!_isUp)
                toastY = MainWindow.screenHeight - this.Height - (MainWindow.screenHeight / 260);
            else
                toastY = this.Height - (MainWindow.screenHeight / 260);

            this.Location = new Point(toastX, toastY);
        }

        private void ComputeTargetPosition()
        {
            toastTargetX = 0;
        }
        double ComputeOpacity(double distance) => 1.0 / distance;

    }
}
