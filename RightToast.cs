using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clipboard_Toast
{
    public partial class RightToast : Form
    {
        #pragma warning disable IDE0044
        private static int horizontalSpeed = MainWindow.screenWidth/960;
        private int timer = 200;
        private int _toastX, _toastY;
        private double _toastTargetX;
        private bool isUp;

        public RightToast(bool up)
        {
            InitializeComponent();
            this.isUp = up;
            this.Opacity = 0.0;
        }

        private void ToastMessage_Load(object sender, EventArgs e)
        {
            Position();
            ComputeTargetPosition();
            lb_Title.Text = MainWindow.title;
            lb_message.Text = MainWindow.message;
        }

        private void toastTimer_Tick_1(object sender, EventArgs e)
        {
            this.Location = new Point(_toastX -= horizontalSpeed, _toastY);
            
            this.Opacity = ComputeOpacity(Math.Max(1, _toastX - _toastTargetX));

            if (_toastX <= MainWindow.screenWidth - this.Width * 11/10)
            {
                toastTimer.Stop();
                toastTimerDown.Start();
            }
        }

        private void toastTimerDown_Tick(object sender, EventArgs e)
        {
            timer--;
            if (timer <= 0)
            {
                this.Location = new Point(_toastX += horizontalSpeed, _toastY);
                this.Opacity = ComputeOpacity((_toastX - _toastTargetX)*2);
                if (_toastX > MainWindow.screenWidth)
                {
                    toastTimerDown.Stop();
                    timer = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        { 
            _toastX = MainWindow.screenWidth - this.Width;
            if (!isUp)
                _toastY = MainWindow.screenHeight - this.Height - (MainWindow.screenHeight / 260);
            else
                _toastY = this.Height - (MainWindow.screenHeight / 260);

            this.Location = new Point(_toastX, _toastY);
        }

        private void ComputeTargetPosition()
        {
            _toastTargetX = MainWindow.screenWidth - this.Width * 11.0 / 10.0;   
        }

        double ComputeOpacity(double distance) => 1.0/distance;
}
}
