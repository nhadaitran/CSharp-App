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
    public partial class BillGUI : Form
    {
        private LinkedListBillPayed linkedListBillPayed = BillBUS.returnLinkedListBillPayed();

        public BillGUI()
        {
            InitializeComponent();
            loadListBill();
            panelMange.BringToFront();
            panelInfo.Visible = false;
        }
        #region Load

        private void BillGUI_Load(object sender, EventArgs e)
        {
            loadListBill();
        }

        public void loadListBill()
        {
            LinkedListBillPayed p = linkedListBillPayed;
            lvwListBill.Items.Clear();
            while (p.next != null)
            {
                string status = null;
                ListViewItem lvi = new ListViewItem(p.data.Idbill.ToString());
                lvi.SubItems.Add(p.data.Idtable.ToString());
                lvi.SubItems.Add(p.data.Saletime.ToString());
                lvi.SubItems.Add(p.data.Discount.ToString() + " %");
                lvi.SubItems.Add(p.data.Totalmoney.ToString());
                if (p.satusBill == false)
                    status = "Chưa thanh toán";
                else
                    status = "Đã thanh toán";
                lvi.SubItems.Add(status);
                lvwListBill.Items.Add(lvi);
                p = p.next;
            }
        }
        public void loadListBillInfo(int id)
        {
            lvwBill.Items.Clear();
            if (id != -1)
            {
                LinkedListBillPayed p = linkedListBillPayed;
                while (p.next != null)// lấy info bill theo vị trí của bill
                {
                    if (p.data.Idbill == id)
                        break;
                    p = p.next;
                }
                LinkedListBill temp = p.info;
                while (temp.next != null)
                {
                    ListViewItem lvi = new ListViewItem(temp.data.Idfood.ToString());
                    lvi.SubItems.Add(temp.data.Foodname.ToString());
                    lvi.SubItems.Add(temp.data.Countdish.ToString());
                    lvi.SubItems.Add(temp.data.Price.ToString());
                    lvi.SubItems.Add(temp.data.TotalPrice.ToString());
                    lvwBill.Items.Add(lvi);
                    temp = temp.next;
                }
            }
        }
        #endregion

        #region Del Bill
        private void lvwListBill_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
                cmsAction.Show(lvwListBill, e.X, e.Y);
        }

        private void xóaBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn xoá hoá đơn " + lvwListBill.SelectedItems[0].SubItems[0].Text.ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int idbill = (int)Convert.ToDouble(lvwListBill.SelectedItems[0].SubItems[0].Text.ToString());
                LinkedListBillPayed p = new LinkedListBillPayed();
                p = linkedListBillPayed;
                while (p.next != null && p.data.Idbill != idbill)
                {
                    p = p.next;
                }
                if (p.satusBill == false)
                {
                    TableBUS.Instance.delTable(p.data.Idtable);
                }
                BillBUS.Instance.delLinkedBilPayed(idbill, ref linkedListBillPayed);
                LinkedListBillPayed temp = new LinkedListBillPayed();
            }
            loadListBill();
        }
        #endregion

        #region Del Food
        private void lvwBill_MouseDown(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Right)
                    cmsDelFood.Show(lvwListBill, e.X, e.Y);            
        }

        private void xoáMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn xoá món " + lvwBill.SelectedItems[0].SubItems[1].Text.ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int idbill = (int)Convert.ToDouble(lvwListBill.SelectedItems[0].SubItems[0].Text.ToString());
                string idfood = lvwBill.SelectedItems[0].SubItems[0].Text.ToString();
                int idTable = (int)Convert.ToDouble(lvwListBill.SelectedItems[0].SubItems[1].Text.ToString());
                LinkedListBillPayed p = new LinkedListBillPayed();
                p = linkedListBillPayed;
                while (p.next != null && p.data.Idbill != idbill)
                {
                    p = p.next;
                }
                if (p.satusBill == false)
                {
                    TableBUS.Instance.delFoodinLinkedBill(ref p.info,idfood);
                    TableBUS.Instance.UpdateBillInfo(p.info, idTable);
                    p.data = BillBUS.Instance.updateInfo(p.data,p.info);
                    if (p.info.next == null)
                    {
                        TableBUS.Instance.delTable(p.data.Idtable);
                        BillBUS.Instance.delLinkedBilPayed(idbill, ref linkedListBillPayed);
                    }                    
                    panelMange.Visible = true;
                    panelInfo.Visible = false;                    
                }
                else
                {
                    MessageBox.Show("Bill đã thanh toán ! Không thể xoá món !");
                }
                loadListBill();
            }    
        }
        #endregion


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            panelMange.Visible = true;
            panelInfo.Visible = false;
        }

        private void lvwListBill_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int idbill = (int)Convert.ToDouble(lvwListBill.SelectedItems[0].SubItems[0].Text.ToString());
            labelInfo.Text = "Thông tin của Bill :" + idbill;
            panelInfo.Visible = true;
            loadListBillInfo(idbill);
        }

        
    }
}
