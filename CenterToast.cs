using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clipboard_Toast
{
    public partial class CenterToast : Form
    {
        private readonly bool _isUp;
        private int _toastX, _toastY;
        private int _timer = 100;


        public CenterToast(bool up)
        {
            InitializeComponent();
            this._isUp = up;
            this.Opacity = 0;
        }

        private void ToastTimer_Tick(object sender, EventArgs e)
        {
            Position();
            this.BringToFront();
            this.Opacity += 0.05;
            Console.WriteLine(this.Opacity);
            if (this.Opacity >= 1.0)
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
                Console.WriteLine(this.Opacity);
                this.Opacity -= 0.05;
                if (this.Opacity <= 0.0)
                {
                    ToastTimerDown.Stop();
                    _timer = 100;
                    this.Close();
                }
            }
        }


        private void Position()
        {
            _toastX = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width/2;

            if (!_isUp)
                _toastY = Screen.PrimaryScreen.WorkingArea.Height - this.Height - (MainWindow.ScreenHeight / 11);
            else
                _toastY = this.Height - (MainWindow.ScreenHeight / 300);

            this.Location = new Point(_toastX, _toastY);
        }
    }
}
