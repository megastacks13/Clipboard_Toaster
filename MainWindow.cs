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
        public static string title = "";
        public static string message = "";

        /// <summary>
        /// Width of the Main Screen -> Same as horizontal resolution
        /// </summary>
        public static int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
        /// <summary>
        /// Height of the Main Screen -> Same as vertical resolution
        /// </summary>
        public static int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

        // Strings are used rather than an enum because they contain string data needed for data finding
        // Width constants
        private const string POS_LEFT = "Left";
        private const string POS_CENTER = "Center";
        private const string POS_RIGHT = "Right";

        // Height constants
        private const string HE_UP = "Up";
        private const string HE_DOWN = "Down";

        /// <summary>
        /// Variable for storing the toast that will be displayed
        /// </summary>
        private Form _toast;

        private string verticalPositioning = HE_DOWN;
        private string horizontalPositioning = POS_LEFT;
        private string scrImageName;

        private string clipboardOld = "";
        private string clipboardValue = "";

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);    // Process the message 

            if (m.Msg == WM_DRAWCLIPBOARD)
            {
                IDataObject iData = Clipboard.GetDataObject();      // Clipboard's data

                if (iData.GetDataPresent(DataFormats.Text))
                {
                    title = "Text Copied!";      // Clipboard text
                    clipboardValue = Clipboard.GetText();

                }
                else if (iData.GetDataPresent(DataFormats.Bitmap))
                {
                    title = "Image Copied";  // Clipboard image
                    // TO-DO: Change to show unique text per image but consistent for each image
                    clipboardValue = "Image"; 

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
            InitializeToast();

            title = clipboardValue.Equals(clipboardOld) == true ? "Repeated Data" : "Copied!";
            message = clipboardValue;
            clipboardOld = clipboardValue;
            _toast.Show();

        }

        private void InitializeToast()
        {
            switch (horizontalPositioning)
            {
                case POS_RIGHT:
                    _toast = new RightToast(verticalPositioning == HE_UP);
                    break;
                case POS_CENTER:
                    _toast = new CenterToast(verticalPositioning == HE_UP);
                    break;
                case POS_LEFT:
                    _toast = new LeftToast(verticalPositioning == HE_UP);
                    break;

            }

        }

        // Interaction with radio buttons
        private void Rb_Up_CheckedChanged(object sender, EventArgs e)
        {
            ChangeScreenImage();
        }
        private void Rb_Down_CheckedChanged(object sender, EventArgs e)
        {
            ChangeScreenImage();
        }

        private void Rb_Left_CheckedChanged(object sender, EventArgs e)
        {
            ChangeScreenImage();
        }

        private void Rb_Center_CheckedChanged(object sender, EventArgs e)
        {
            ChangeScreenImage();
        }

        private void Rb_Right_CheckedChanged(object sender, EventArgs e)
        {
            ChangeScreenImage();
        }

        // UI management

        private void ChangeScreenImage()
        {
            UpdateStates();
            scrImageName = $"Scr_{verticalPositioning}_{horizontalPositioning}";
            Pb_ScreenImage.Image = (Image)Properties.Resources.ResourceManager.GetObject(scrImageName);
        }

        private void UpdateStates()
        {
            if (Rb_Left.Checked)
            {
                horizontalPositioning = POS_LEFT;
            }
            else if (Rb_Center.Checked)
            {
                horizontalPositioning = POS_CENTER;
            }
            else // when the right button is checked...
            {
                horizontalPositioning = POS_RIGHT;
            }

            if (Rb_Up.Checked)
            {
                verticalPositioning = HE_UP;
            }
            else // when the Down Button is checked...
            {
                verticalPositioning = HE_DOWN;
            }
        }
    }
}
