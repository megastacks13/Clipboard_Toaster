using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipboard_Toast
{
    public partial class MainWindow : Form
    {
        // Clipboard Stalker Variables
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        private const int WM_DRAWCLIPBOARD = 0x0308;        // WM_DRAWCLIPBOARD message
        private IntPtr _clipboardViewerNext;                // Our variable that will hold the value to identify the next window in the clipboard viewer chain

        // Toast-related variables
        // widht constants
        private const string POS_LEFT = "Left";
        private const string POS_CENTER = "Center";
        private const string POS_RIGHT = "Right";
        // height constants
        private const string HE_UP = "Up";
        private const string HE_DOWN = "Down";

        private static string title = "";
        private Form toast;
        private ToastType toastType;
        string clipboard_value = "";
        string clipboard_old = "";

        private string height_state = HE_DOWN;
        private string position_state = POS_LEFT;
        private string img_name;


        private enum ToastType
        {
            RIGHT,
            CENTER,
            LEFT,
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);    // Process the message 

            if (m.Msg == WM_DRAWCLIPBOARD)
            {
                IDataObject iData = Clipboard.GetDataObject();      // Clipboard's data

                if (iData.GetDataPresent(DataFormats.Text))
                {
                    title = "Text Copied!";      // Clipboard text
                    clipboard_value = Clipboard.GetText();

                }
                else if (iData.GetDataPresent(DataFormats.Bitmap))
                {
                    title = "Image Copied";  // Clipboard image
                    // TO-DO: Change to show unique text per image but consistent for each image
                    clipboard_value = "Image"; 

                }
                ShowToast();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            _clipboardViewerNext = SetClipboardViewer(this.Handle);      // Adds our form to the chain of clipboard viewers.
        }


        private void ShowToast()
        {
            // TO-DO: This will depend on the selection of the radio buttons
            initializeToast();

            if (!clipboard_value.Equals(clipboard_old))
            {
                clipboard_old = clipboard_value;
                toast.Show();
            }
  
        }

        private void Bg_toastFormat_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // Not a need of detecting when the value of the Down button is marked
        private void rb_Up_CheckedChanged(object sender, EventArgs e)
        {
            changeScreenImage();
        }
        private void rb_Down_CheckedChanged(object sender, EventArgs e)
        {
            changeScreenImage();
        }


        // TO-DO: Change the "toast" object so it shows the corresponding toast for every case
        private void rb_Left_CheckedChanged(object sender, EventArgs e)
        {
            toastType = ToastType.LEFT;
            changeScreenImage();
        }

        private void rb_Center_CheckedChanged(object sender, EventArgs e)
        {
            toastType = ToastType.CENTER;
            changeScreenImage();
        }

        private void rb_Right_CheckedChanged(object sender, EventArgs e)
        {
            toastType = ToastType.RIGHT;
            changeScreenImage();
        }

        private void changeScreenImage()
        {
            updateStates();
            img_name = $"Scr_{height_state}_{position_state}";
            pb_ScreenImage.Image = (Image) Properties.Resources.ResourceManager.GetObject(img_name);
        }

        private void updateStates()
        {
            if (rb_Left.Checked)
            {
                position_state = POS_LEFT;
            }
            else if (rb_Center.Checked)
            {
                position_state = POS_CENTER;
            }
            else // when the right button is checked...
            {
                position_state = POS_RIGHT;
            }

            if (rb_Up.Checked)
            {
                height_state = HE_UP;
            }
            else // when the Down Button is checked...
            {
                height_state = HE_DOWN;
            }
        }
        private void initializeToast()
        {
            switch (toastType)
            {
                case ToastType.RIGHT:
                    toast = new RightToast(height_state == HE_UP);
                    ((RightToast)toast).SetMessage(title, clipboard_value);
                    break;
                case ToastType.CENTER:
                    toast = new CenterToast(height_state == HE_UP);
                    break;
                case ToastType.LEFT:
                    toast = new LeftToast(height_state == HE_UP);
                    ((LeftToast)toast).SetMessage(title, clipboard_value);
                    break;

            }

        }
    }
}
