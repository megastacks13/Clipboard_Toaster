using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Clipboard_Toast
{
    public partial class MainWindow : Form
    {
        // Clipboard Stalker Variables
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
        
        private const int WmDrawClipboard = 0x0308;        // WmDrawClipboard message
        // ReSharper disable once NotAccessedField.Local
        private IntPtr _clipboardViewerNext;                // Our variable that will hold the value to identify the next window in the clipboard viewer chain

        // Toast-related variables
        /// <summary>
        /// Title of the toast notification
        /// </summary>
        public static string Title = "";

        /// <summary>
        /// Message of the toast notification
        /// </summary>
        public static string Message = "";

        /// <summary>
        /// Width of the Main Screen -> Same as horizontal resolution
        /// </summary>
        public static readonly int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;

        /// <summary>
        /// Height of the Main Screen -> Same as vertical resolution
        /// </summary>
        public static readonly int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

        // Strings are used rather than an enum because they contain string data needed for data finding
        // Width constants
        private const string PosLeft = "Left";
        private const string PosCenter = "Center";
        private const string PosRight = "Right";

        // Height constants
        private const string HeUp = "Up";
        private const string HeDown = "Down";

        /// <summary>
        /// Variable for storing the toast that will be displayed
        /// </summary>
        private Form _toast;

        private string _verticalPositioning = HeDown;
        private string _horizontalPositioning = PosLeft;
        private string _scrImageName;

        private string _clipboardOld = "";
        private string _clipboardValue = "";

        private bool _first = true;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);    // Process the message 

            if (m.Msg == WmDrawClipboard)
            {
                IDataObject iData = Clipboard.GetDataObject();      // Clipboard's data

                if (iData != null && iData.GetDataPresent(DataFormats.Text))
                {
                    Title = "Text Copied!";      // Clipboard text
                    _clipboardValue = Clipboard.GetText();

                }
                else if (iData != null && iData.GetDataPresent(DataFormats.Bitmap))
                {
                    Title = "Image Copied";  // Clipboard image
                    // TO-DO: Change to show unique text per image but consistent for each image
                    _clipboardValue = "Image"; 

                }

                // Control Structure for fixing the issue with toast showing on app running
                if (!_first)
                    ShowToast();
                else _first = false;
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

            Title = _clipboardValue.Equals(_clipboardOld) ? "Repeated Data" : Title;
            Message = _clipboardValue;
            _clipboardOld = _clipboardValue;
            _toast.Show();

        }

        private void InitializeToast()
        {
            switch (_horizontalPositioning)
            {
                case PosRight:
                    _toast = new RightToast(_verticalPositioning == HeUp);
                    break;
                case PosCenter:
                    _toast = new CenterToast(_verticalPositioning == HeUp);
                    break;
                case PosLeft:
                    _toast = new LeftToast(_verticalPositioning == HeUp);
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
            _scrImageName = $"Scr_{_verticalPositioning}_{_horizontalPositioning}";
            Pb_ScreenImage.Image = (Image)Properties.Resources.ResourceManager.GetObject(_scrImageName);
        }

        private void UpdateStates()
        {
            if (Rb_Left.Checked)
            {
                _horizontalPositioning = PosLeft;
            }
            else if (Rb_Center.Checked)
            {
                _horizontalPositioning = PosCenter;
            }
            else // when the right button is checked...
            {
                _horizontalPositioning = PosRight;
            }

            _verticalPositioning = Rb_Up.Checked ? HeUp : HeDown;
            
        }
    }
}
