using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clipboard_Toast
{
    public partial class RightToast : Form
    {
        private static readonly int HorizontalSpeed = MainWindow.ScreenWidth/300;
        private int _timer = 200;
        private int _toastX, _toastY;
        private double _toastTargetX;
        private readonly bool _isUp;

        public RightToast(bool up)
        {
            InitializeComponent();
            this._isUp = up;
            this.Opacity = 0.0;
        }

        private void ToastMessage_Load(object sender, EventArgs e)
        {
            Position();
            ComputeTargetPosition();
            lb_Title.Text = MainWindow.Title;
            lb_message.Text = MainWindow.Message;
        }

        private void toastTimer_Tick_1(object sender, EventArgs e)
        {
            this.Location = new Point(_toastX -= HorizontalSpeed, _toastY);
            
            this.Opacity = ComputeOpacity(Math.Max(1, _toastX - _toastTargetX));

            if (_toastX <= _toastTargetX)
            {
                toastTimer.Stop();
                toastTimerDown.Start();
            }
        }

        private void toastTimerDown_Tick(object sender, EventArgs e)
        {
            _timer--;
            if (_timer <= 0)
            {
                this.Location = new Point(_toastX += HorizontalSpeed, _toastY);
                this.Opacity = ComputeOpacity((_toastX - _toastTargetX)*2);
                if (_toastX > MainWindow.ScreenWidth)
                {
                    toastTimerDown.Stop();
                    _timer = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        { 
            _toastX = MainWindow.ScreenWidth - this.Width/2;
            if (!_isUp)
                _toastY = MainWindow.ScreenHeight - this.Height - (MainWindow.ScreenHeight / 260);
            else
                _toastY = this.Height - (MainWindow.ScreenHeight / 260);

            this.Location = new Point(_toastX, _toastY);
        }

        private void ComputeTargetPosition()
        {
            _toastTargetX = MainWindow.ScreenWidth - this.Width;   
        }

        double ComputeOpacity(double distance) => 1.0/distance;
}
}
