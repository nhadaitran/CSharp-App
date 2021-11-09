using ProjectWithDesign.BUS;
using ProjectWithDesign.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWithDesign
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtAcc.Text;
            string password = txtPassword.Text;
            string type = LoginBUS.Instance.checkAccount(username, password);
            if (type == "false")
                MessageBox.Show("Bạn nhập sai tên đăng nhập hoặc mật khâu!", " ", MessageBoxButtons.OK);
            else if (type == "admin")
            {
                MainMenuGUI o = new MainMenuGUI();
                this.Hide();
                o.ShowDialog();
            }
            else if (type == "staff")
            {
                TableGUI o = new TableGUI();
                this.Hide();
                o.ShowDialog();
            }
        }
    }
}
