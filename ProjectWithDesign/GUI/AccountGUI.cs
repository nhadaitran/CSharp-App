using ProjectWithDesign.BUS;
using ProjectWithDesign.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWithDesign.GUI
{
    public partial class AccountGUI : Form
    {

        static LinkedListAccount LinkedList = AccountBUS.getLinkedListAccount();
        List<AccountDTO> listAccount = AccountBUS.Instance.toListAccount(LinkedList);
        ArrayAccount arrayAccount = AccountBUS.Instance.toArrayAccount(LinkedList);

        public AccountGUI()
        {
            InitializeComponent();
            loadlvAccount(LinkedList);
            panelPassword.Visible = false;
            panelUserName.Visible = false;
        }

        #region chọn ds
        private void cboTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTypeList.Text == "Danh sách đơn")
            {
                loadlvAccount(listAccount);
            }
            else if (cboTypeList.Text == "Danh sách liên kết")
            {
                loadlvAccount(LinkedList);
            }
            else if (cboTypeList.Text == "Danh sách đặc")
            {
                loadlvAccount(arrayAccount);
            }
        }
        #endregion

        #region btnPassword
        private void BtnPassword_Click(object sender, EventArgs e)
        {
            panelUserName.Visible = false;
            if (panelPassword.Visible == true)
                panelPassword.Visible = false;
            else panelPassword.Visible = true;
        }
        #endregion

        #region btnUsername
        private void btnUsername_Click(object sender, EventArgs e)
        {
            panelPassword.Visible = false;
            if(panelUserName.Visible == true)
                panelUserName.Visible = false;
            else panelUserName.Visible = true;
        }

        #endregion

        #region Xử lý account

        #region Linked List
        private void loadlvAccount(LinkedListAccount linkedList)
        {
            lvAccount.Items.Clear();
            while (linkedList.next != null)
            {
                ListViewItem lvi = new ListViewItem(linkedList.data.Id);
                lvi.SubItems.Add(linkedList.data.Account);
                lvi.SubItems.Add(linkedList.data.Password);
                lvi.SubItems.Add(linkedList.data.Nameuser);
                lvAccount.Items.Add(lvi);
                linkedList = linkedList.next;
            }
        }
        #endregion

        #region List
        private void loadlvAccount(List<AccountDTO> list)
        {
            lvAccount.Items.Clear();
            foreach (AccountDTO data in list)
            {
                ListViewItem lvi = new ListViewItem(data.Id);
                lvi.SubItems.Add(data.Account);
                lvi.SubItems.Add(data.Password);
                lvi.SubItems.Add(data.Nameuser);
                lvAccount.Items.Add(lvi);
            }
        }
        #endregion

        #region Array
        private void loadlvAccount(ArrayAccount array)
        {
            lvAccount.Items.Clear();
            for (int i = 0; i < array.count; i++)
            {
                ListViewItem lvi = new ListViewItem(array.ArrayListAccount[i].Id);
                lvi.SubItems.Add(array.ArrayListAccount[i].Account);
                lvi.SubItems.Add(array.ArrayListAccount[i].Password);
                lvi.SubItems.Add(array.ArrayListAccount[i].Nameuser);
                lvAccount.Items.Add(lvi);
            }
        }
        #endregion

        private void lvAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvAccount.SelectedItems)
            {
                txbUsername.Text = lvi.SubItems[1].Text;
                txbPassword.Text = lvi.SubItems[2].Text;
                TxbName.Text = lvi.SubItems[3].Text;
            }
        }

        #endregion

        #region UpdatePassword
        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "")
                MessageBox.Show("Chọn tài khoản");
            else
            {
                if (string.IsNullOrWhiteSpace(txbNewPassword.Text))
                    MessageBox.Show("Nhập mật khẩu mới");
                else
                {
                    if (txbNewPassword.Text.Equals(TxbRenewPassword.Text))
                    {
                        if (cboTypeList.Text == "Danh sách liên kết")
                        {
                            AccountBUS.Instance.changePassword(ref LinkedList, txbUsername.Text, txbNewPassword.Text);
                            txbPassword.Text = txbNewPassword.Text;
                            listAccount = AccountBUS.Instance.toListAccount(LinkedList);
                            arrayAccount = AccountBUS.Instance.toArrayAccount(LinkedList);
                            loadlvAccount(LinkedList);
                            MessageBox.Show("Thây đổi thành công!");
                        }
                        else if (cboTypeList.Text == "Danh sách đơn")
                        {
                            AccountBUS.Instance.changePasswordinList(ref listAccount, txbUsername.Text, txbNewPassword.Text);
                            txbPassword.Text = txbNewPassword.Text;
                            LinkedList = AccountBUS.Instance.toLinkedListAccount(listAccount);
                            arrayAccount = AccountBUS.Instance.toArrayAccount(listAccount);
                            loadlvAccount(listAccount);
                            MessageBox.Show("Thây đổi thành công!");
                        }
                        else if (cboTypeList.Text == "Danh sách đặc")
                        {
                            AccountBUS.Instance.changePasswordinArray(ref arrayAccount, txbUsername.Text, txbNewPassword.Text);
                            LinkedList = AccountBUS.Instance.toLinkedListAccount(arrayAccount);
                            listAccount = AccountBUS.Instance.toListAccount(arrayAccount);
                            txbPassword.Text = txbNewPassword.Text;
                            loadlvAccount(arrayAccount);
                            MessageBox.Show("Thây đổi thành công!");
                        }
                        else MessageBox.Show("Chọn loại danh sách!");
                    }
                    else MessageBox.Show("Nhập lại mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region Update Username
        private void btnEditUserName_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "")
                MessageBox.Show("Chọn tài khoản");
            else
            {
                if (TxbNewName.Text == "")
                    MessageBox.Show("Nhập tên tài khoản mới!");
                else
                {
                    if (cboTypeList.Text == "Danh sách liên kết")
                    {
                        AccountBUS.Instance.changeName(txbUsername.Text, TxbNewName.Text, ref LinkedList);
                        TxbName.Text = TxbNewName.Text;
                        loadlvAccount(LinkedList);
                        MessageBox.Show("Thây đổi thành công!");
                    }
                    else if (cboTypeList.Text == "Danh sách đơn")
                    {
                        AccountBUS.Instance.changeNameinList(txbUsername.Text, TxbNewName.Text, ref listAccount);
                        TxbName.Text = TxbNewName.Text;
                        loadlvAccount(listAccount);
                        MessageBox.Show("Thây đổi thành công!");
                    }
                    else if (cboTypeList.Text == "Danh sách đặc")
                    {
                        AccountBUS.Instance.changeNameinArray(ref arrayAccount, txbUsername.Text, TxbNewName.Text);
                        TxbName.Text = TxbNewName.Text;
                        LinkedList = AccountBUS.Instance.toLinkedListAccount(arrayAccount);
                        listAccount = AccountBUS.Instance.toListAccount(arrayAccount);
                        loadlvAccount(arrayAccount);
                    }
                    else MessageBox.Show("Chọn loại danh sách!");
                }
            }
        }

        #endregion

       
    }
}
