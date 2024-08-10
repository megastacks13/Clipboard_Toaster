using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clipboard_Toast
{
    public partial class LeftToast : Form
    {
        private const int HorizontalSpeed = 10;
        private int _toastX, _toastY;
        private readonly bool _isUp;
        private int _timer = 150;

        public LeftToast(bool up)
        {
            InitializeComponent();
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
            this.Location = new Point(_toastX, _toastY);
            this.BringToFront();
            if (_toastX >= 0)
            {
                ToastTimer.Stop();
                ToastTimerDown.Start();
            }
        }

        private void ToastTimerDown_Tick(object sender, EventArgs e)
        {
            _timer--;
            this.BringToFront();
            if (_timer <= 0)
            {
                this.Location = new Point(_toastX -= HorizontalSpeed, _toastY);
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
            _toastX = -this.Width;
            if (!_isUp)
                _toastY = MainWindow.ScreenHeight - this.Height - (MainWindow.ScreenHeight / 260);
            else
                _toastY = this.Height - (MainWindow.ScreenHeight / 260);

            this.Location = new Point(_toastX, _toastY);
        }


    }
}
