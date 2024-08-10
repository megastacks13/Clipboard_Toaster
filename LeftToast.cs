using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clipboard_Toast
{
    public partial class LeftToast : Form
    {
        private static readonly int HorizontalSpeed = MainWindow.ScreenWidth / 450;
        private int _toastX, _toastY;
        private int _timer = 200;
        private double _toastTargetX;
        private readonly bool _isUp;

        public LeftToast(bool up)
        {
            InitializeComponent();
            ComputeTargetPosition();
            this._isUp = up;
        }

        private void ToastMessage_Load(object sender, EventArgs e)
        {
            Position();
            lb_Title.Text = MainWindow.Title;
            lb_message.Text = MainWindow.Message;
        }

        private void ToastTimer_Tick(object sender, EventArgs e)
        {
            _toastX += HorizontalSpeed;
            this.Opacity = ComputeOpacity(Math.Max(1,  _toastTargetX - _toastX));
            this.Location = new Point(_toastX, _toastY);

            if (_toastX >= _toastTargetX)
            {
                ToastTimer.Stop();
                ToastTimerDown.Start();
            }
        }

        private void ToastTimerDown_Tick(object sender, EventArgs e)
        {
            _timer--;

            if (_timer <= 0)
            {
                this.Location = new Point(_toastX -= HorizontalSpeed, _toastY);
                this.Opacity = ComputeOpacity((_toastX - _toastTargetX) * 2);
                if (_toastX < -this.Width)
                {
                    ToastTimerDown.Stop();
                    _timer = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        {
            _toastX = -this.Width/2;
            if (!_isUp)
                _toastY = MainWindow.ScreenHeight - this.Height - (MainWindow.ScreenHeight / 260);
            else
                _toastY = this.Height - (MainWindow.ScreenHeight / 260);

            this.Location = new Point(_toastX, _toastY);
        }

        private void ComputeTargetPosition()
        {
            _toastTargetX = 0;
        }
        double ComputeOpacity(double distance) => 1.0 / distance;

    }
}
