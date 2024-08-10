using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clipboard_Toast
{
    public partial class RightToast : Form
    {
        #pragma warning disable IDE0044
        private const int HorizontalSpeed = 10;
        private int _toastX, _toastY;
        private readonly bool _isUp;
        private int _timer = 150;

        public RightToast(bool up)
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

        private void toastTimer_Tick_1(object sender, EventArgs e)
        {
            _toastX -= HorizontalSpeed;
            this.Location = new Point(_toastX, _toastY);
            this.BringToFront();
            if (_toastX <= MainWindow.ScreenWidth - this.Width - 5)
            {
                toastTimer.Stop();
                toastTimerDown.Start();
            }
        }

        private void toastTimerDown_Tick(object sender, EventArgs e)
        {
            _timer--;
            this.BringToFront();
            if (_timer <= 0)
            {
                this.Location = new Point(_toastX += HorizontalSpeed, _toastY);
                if (_toastX > MainWindow.ScreenWidth + 20)
                {
                    toastTimerDown.Stop();
                    _timer = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        { 
            _toastX = MainWindow.ScreenWidth + (MainWindow.ScreenWidth / 96);
            if (!_isUp)
                _toastY = MainWindow.ScreenHeight - this.Height - (MainWindow.ScreenHeight / 260);
            else
                _toastY = this.Height - (MainWindow.ScreenHeight / 260);

            this.Location = new Point(_toastX, _toastY);
        }
    }
}
