using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWithDesign.GUI
{
    public partial class MainMenuGUI : Form
    {
        private static MainMenuGUI instance;
        public static MainMenuGUI Instance
        {
            get { if (instance == null) instance = new MainMenuGUI(); return MainMenuGUI.instance; }
            private set { MainMenuGUI.instance = value; }
        }
      
        
        #region Decorate
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
             
        //Constructor
        public MainMenuGUI()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 65);
            panelMenu.Controls.Add(leftBorderBtn);
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //structs for color
        private struct RBGColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Create a new panel and replace 
        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            if(senderBtn!=null)
            {
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.IconColor = color;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //CrurrentTab
                iconTitle.IconChar = currentBtn.IconChar;
                iconTitle.IconColor = color;
                labelTitle.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(41, 39, 40);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void openChildForm(Form childForm)
        {
            if(currentChildForm!=null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }
       
        private void btnMain_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
                currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconTitle.IconChar = IconChar.Home;
            iconTitle.IconColor = Color.MediumPurple;
            labelTitle.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        #endregion


        #region control button
        private void btnExit_Click(object sender, EventArgs e)
        {
            
                DialogResult result = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    Application.Exit();
            
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Tab
       

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void btnTableFood_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color1);
            openChildForm(new TableGUI());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color2);
            openChildForm(new BillGUI());
        }

        private void btnCateNFood_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color3);
            openChildForm(new CategoryGUI());
        }

        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color4);
            openChildForm(new AccountGUI());
        }





        #endregion

        
    }
}
