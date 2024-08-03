using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clipboard_Toast
{
    public partial class RightToast : Form
    {
        private int speed_ppt = 10;
        private int toastX, toastY;
        private int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
        private int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
        private bool up = false;
        private const int VERTICAL_RES = 1080;

        public RightToast(bool up)
        {
            InitializeComponent();
            this.up = up;
        }

        public void SetMessage(string title, string subtitle)
        {
            lb_Title.Text = title;
            lb_message.Text = subtitle;
        }

        private void ToastMessage_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void toastTimer_Tick_1(object sender, EventArgs e)
        {
            toastX -= speed_ppt;
            this.Location = new Point(toastX, toastY);
            this.BringToFront();
            if (toastX <= ScreenWidth - this.Width - 5)
            {
                toastTimer.Stop();
                toastTimerDown.Start();
            }
        }

        int timer = 150;
        private void toastTimerDown_Tick(object sender, EventArgs e)
        {
            timer--;
            this.BringToFront();
            if (timer <= 0)
            {
                this.Location = new Point(toastX += speed_ppt, toastY);
                if (toastX > ScreenWidth + 20)
                {
                    toastTimerDown.Stop();
                    timer = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        { 
            toastX = ScreenWidth + 20;
            if (!up)
                toastY = ScreenHeight - this.Height - (VERTICAL_RES / 260);
            else
                toastY = this.Height - (VERTICAL_RES / 260);

            this.Location = new Point(toastX, toastY);
        }
    }
}
