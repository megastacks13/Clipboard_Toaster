using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipboard_Toast
{
    public partial class LeftToast : Form
    {
        private int speed_ppt = 10;
        private int toastX, toastY;
        private int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
        private int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
        private bool up = false;
        private const int VERTICAL_RES = 1080;
        public LeftToast(bool up)
        {
            InitializeComponent();
            this.up = up;
        }

        private void ToastMessage_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void ToastTimer_Tick(object sender, EventArgs e)
        {
            toastX += speed_ppt;
            this.Location = new Point(toastX, toastY);
            this.BringToFront();
            if (toastX >= 0)
            {
                ToastTimer.Stop();
                ToastTimerDown.Start();
            }
        }

        int timer = 150;

        private void ToastTimerDown_Tick(object sender, EventArgs e)
        {
            timer--;
            this.BringToFront();
            if (timer <= 0)
            {
                this.Location = new Point(toastX -= speed_ppt, toastY);
                if (toastX < -this.Width)
                {
                    ToastTimerDown.Stop();
                    timer = 100;
                    this.Close();
                }
            }
        }

        public void SetMessage(string title, string subtitle)
        {
            lb_Title.Text = title;
            lb_message.Text = subtitle;
        }

        private void Position()
        {
            toastX = -this.Width;
            if (!up)
                toastY = ScreenHeight - this.Height - (VERTICAL_RES / 260);
            else
                toastY = this.Height - (VERTICAL_RES / 260);

            this.Location = new Point(toastX, toastY);
        }


    }
}
