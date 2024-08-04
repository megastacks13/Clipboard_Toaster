using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clipboard_Toast
{
    public partial class CenterToast : Form
    {
        #pragma warning disable IDE0044
        private bool _isUp = false;
        private int toastX, toastY;

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

        int timer = 100;

        private void ToastTimerDown_Tick(object sender, EventArgs e)
        {
            timer--;
            this.BringToFront();
            if (timer <= 0)
            {
                Console.WriteLine(this.Opacity);
                this.Opacity -= 0.05;
                if (this.Opacity <= 0.0)
                {
                    ToastTimerDown.Stop();
                    timer = 100;
                    this.Close();
                }
            }
        }


        private void Position()
        {
            toastX = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width/2;

            if (!_isUp)
                toastY = Screen.PrimaryScreen.WorkingArea.Height - this.Height - (MainWindow.screenHeight / 11);
            else
                toastY = this.Height - (MainWindow.screenHeight / 300);

            this.Location = new Point(toastX, toastY);
        }
    }
}
