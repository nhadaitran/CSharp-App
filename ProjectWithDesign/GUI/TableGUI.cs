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
    public partial class TableGUI : Form
    {
        private static List<TableDTO> listTable = TableBUS.Instance.returnListTable();

        private static Dictionary<int, List<BillInfoDTO>> dicListTable = TableBUS.returndicListTable();
        private static List<BillInfoDTO> listBillInfo = new List<BillInfoDTO>();
        private static List<ListBill> listBill = BillBUS.returnListBillPayed();

        private ArrayTable arrayTable = TableBUS.Instance.ListToArray(listTable);
        private ArrayBillInfo arrayBillInfo = BillBUS.Instance.ListToArrayInfo(listBillInfo);
        private ArrayBill arrayBill = BillBUS.Instance.ListToArray(listBill);

        private LinkedListTable linkedListTable = TableBUS.Instance.ListtoLinkedList(listTable);
        private LinkedListBill linkedListBillInfo = BillBUS.Instance.ListtoLinkedListInfo(listBillInfo);
        private LinkedListBillPayed linkedListBill = BillBUS.Instance.ListtoLinkedList(listBill);

        public float price;

        private void check()//Hàm kiểm tra lại bàn sau khí xóa bên bill
        {
           
            for (int i = 0; i < listTable.Count; i++)
            {
                int pos = i + 1;
                if (dicListTable.ContainsKey(pos))
                    listTable[i].Statustable = "Có người";
                else
                    listTable[i].Statustable = "Trống";
            }

        }
        public TableGUI()
        {
            InitializeComponent();
            check();
            loadTable(0);
            loadCategory();
            loadFoodList();
            panelManage.Visible = true;
            panelChangeTable.Visible = false;
        }

        #region load bill

        #region Array
        void showBill(ArrayBillInfo listBill)
        {
            lviBill.Items.Clear();
            for(int i=0;i<listBill.count;i++)
            {
                ListViewItem lvi = new ListViewItem(listBill.ArrayListBillInfo[i].Idfood.ToString());
                lvi.SubItems.Add(listBill.ArrayListBillInfo[i].Foodname.ToString());
                lvi.SubItems.Add(listBill.ArrayListBillInfo[i].Countdish.ToString());
                lvi.SubItems.Add(listBill.ArrayListBillInfo[i].Price.ToString());
                lvi.SubItems.Add(listBill.ArrayListBillInfo[i].TotalPrice.ToString());
                price += listBill.ArrayListBillInfo[i].TotalPrice;
                lviBill.Items.Add(lvi);
            }
            btPay.Text = price.ToString() + "đ";
        }
        #endregion

        #region List
        void showBill(List<BillInfoDTO> listBill)
        {
            float totalallprice = 0;
            lviBill.Items.Clear();
            foreach (BillInfoDTO data in listBill)
            {
                ListViewItem lvi = new ListViewItem(data.Idfood.ToString());
                lvi.SubItems.Add(data.Foodname.ToString());
                lvi.SubItems.Add(data.Countdish.ToString());
                lvi.SubItems.Add(data.Price.ToString());
                lvi.SubItems.Add(data.TotalPrice.ToString());
                totalallprice += data.TotalPrice;
                lviBill.Items.Add(lvi);
            }
            btPay.Text = totalallprice.ToString() + "đ";
        }
        #endregion

        #region dslk
        void showBill(LinkedListBill listBill)
        {
            price = 0;
            lviBill.Items.Clear();
            LinkedListBill p = listBill;
            while (p.next != null)
            {
                ListViewItem lvi = new ListViewItem(p.data.Idfood.ToString());
                lvi.SubItems.Add(p.data.Foodname.ToString());
                lvi.SubItems.Add(p.data.Countdish.ToString());
                lvi.SubItems.Add(p.data.Price.ToString());
                lvi.SubItems.Add(p.data.TotalPrice.ToString());
                price += p.data.TotalPrice;
                lviBill.Items.Add(lvi);
                p = p.next;
            }
            btPay.Text = price.ToString() + "đ";
        }
        #endregion

        #endregion

        #region Decorate


        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btAdd.IconColor = Color.FromArgb(172, 126, 241);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btAdd.IconColor = Color.Black;
        }



        #endregion

        #region Load Table
        public void loadTable(int current)
        {
            flTable.Controls.Clear();
            foreach (TableDTO table in listTable)
            {
                Button btnTable = new Button() { Width = 100, Height = 100 };
                btnTable.Text = table.Nametable + Environment.NewLine + table.Statustable;
                btnTable.Click += btnTable_click;
                btnTable.Tag = table;
                if (table.Statustable == "Trống")
                    btnTable.BackColor = Color.DeepPink;
                else btnTable.BackColor = Color.Gold;
                if (table.Idtable == current)
                    btnTable.BackColor = Color.Green;
                flTable.Controls.Add(btnTable);
            }
        }
        #endregion

        #region event when click button
        void btnTable_click(object sender, EventArgs e)
        {
            int idtable = ((sender as Button).Tag as TableDTO).Idtable;
            lviBill.Tag = (sender as Button).Tag;
           
                List<BillInfoDTO> p = new List<BillInfoDTO>();
                foreach (KeyValuePair<int, List<BillInfoDTO>> item in dicListTable)
                {
                    if (item.Key == idtable)
                    {
                        showBill(item.Value);
                        loadCategory();
                        break;
                    }
                    else
                    {
                        showBill(p);
                        loadCategory();
                    }
                }  
        loadTable(idtable);
        }
        #endregion

        #region load toàn bộ ds thức ăn
        public void loadFoodList()
        {
            if (cboTypeList.Text == "Danh sách liên kết")
            {
                LinkedListFood listFoodByID = FoodBUS.returnLinkedListFood();
                lvwListFood.Items.Clear();
                while (listFoodByID.next != null)
                {
                    string name = null;
                    LinkedListFoodCategory listCaterogy = FoodCategoryBUS.returnLinkedListFoodCategory();
                    while (listCaterogy.next != null)
                    {
                        if (listCaterogy.data.Idcategory.Equals(listFoodByID.data.Idfoodcategory))
                        {
                            name = listCaterogy.data.Namecategory;
                            break;
                        }
                        listCaterogy = listCaterogy.next;
                    }
                    ListViewItem lvi = new ListViewItem(name.ToString());
                    lvi.SubItems.Add(listFoodByID.data.Idfood.ToString());
                    lvi.SubItems.Add(listFoodByID.data.Namefood.ToString());
                    lvi.SubItems.Add(listFoodByID.data.Pricefood.ToString());
                    lvi.SubItems.Add(listFoodByID.data.Unitcount.ToString());
                    lvwListFood.Items.Add(lvi);
                    listFoodByID = listFoodByID.next;
                }
            }
            else if (cboTypeList.Text == "Danh sách đơn")
            {
                List<FoodDTO> listFoodByID = FoodBUS.returnListFood();
                string name = null;
                List<CategoryDTO> listCaterogy = FoodCategoryBUS.returnListFoodCategory();
                foreach (FoodDTO food in listFoodByID)
                {
                    foreach (CategoryDTO cate in listCaterogy)
                        if (cate.Idcategory.Equals(food.Idfoodcategory))
                        {
                            name = cate.Namecategory;
                            break;
                        }
                    ListViewItem lvi = new ListViewItem(name);
                    lvi.SubItems.Add(food.Idfood.ToString());
                    lvi.SubItems.Add(food.Namefood.ToString());
                    lvi.SubItems.Add(food.Pricefood.ToString());
                    lvi.SubItems.Add(food.Unitcount.ToString());
                    lvwListFood.Items.Add(lvi);
                }
            }
            else if (cboTypeList.Text == "Danh sách đặc")
            {
                ArrayFood listFoodByID = FoodBUS.returnArrayFood();
                ArrayCategory listCaterogy = FoodCategoryBUS.returnArrayFoodCategory();
                string name = null;
                for (int j = 0; j < listFoodByID.count; j++)
                {
                    for (int i = 0; i < listCaterogy.count; i++)
                        if (listCaterogy.ArrayListCategory[i].Idcategory.Equals(listFoodByID.ArrayListFood[j].Idfoodcategory))
                        {
                            name = listCaterogy.ArrayListCategory[i].Namecategory;
                            break;
                        }
                    ListViewItem lvi = new ListViewItem(name);
                    lvi.SubItems.Add(listFoodByID.ArrayListFood[j].Idfood.ToString());
                    lvi.SubItems.Add(listFoodByID.ArrayListFood[j].Namefood.ToString());
                    lvi.SubItems.Add(listFoodByID.ArrayListFood[j].Pricefood.ToString());
                    lvi.SubItems.Add(listFoodByID.ArrayListFood[j].Unitcount.ToString());
                    lvwListFood.Items.Add(lvi);
                }
            }
            else MessageBox.Show("Chọn loại danh sách!");
        }
        #endregion

        #region Load Category

        public void loadCategory()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.Add("Tất cả thức ăn");
            cboCategory.Text = "Tất cả thức ăn";
            if (cboTypeList.Text == "Danh sách liên kết")
            {
                LinkedListFoodCategory listCategory = FoodCategoryBUS.returnLinkedListFoodCategory();
                while (listCategory.next != null)
                {
                    cboCategory.Items.Add(listCategory.data.Namecategory);
                    listCategory = listCategory.next;
                }
                cboCategory.DisplayMember = "namecategory";
            }
            else if (cboTypeList.Text == "Danh sách đơn")
            {
                List<CategoryDTO> listCategory = FoodCategoryBUS.returnListFoodCategory();
                foreach (CategoryDTO item in listCategory)
                    cboCategory.Items.Add(item.Namecategory);
                cboCategory.DisplayMember = "namecategory";
            }
            else if (cboTypeList.Text == "Danh sách đặc")
            {
                ArrayCategory listCategory = FoodCategoryBUS.returnArrayFoodCategory();
                for (int i = 0; i < listCategory.count; i++)
                    cboCategory.Items.Add(listCategory.ArrayListCategory[i].Namecategory);
                cboCategory.DisplayMember = "namecategory";
            }
            else MessageBox.Show("Chọn loại danh sách!");


        }
        #endregion

        #region Load list Food and list food by id category

        #region dslk
        public void loadFoodLinkedByCategoryID(int id)
        {
            LinkedListFood listFoodByID = FoodBUS.returnLinkedListFood();
            lvwListFood.Items.Clear();
            if (id == -1)                    //Nếu ì là -1 thì load tất cả
            {
                loadFoodList();
            }
            else
            {
                string name = null;
                LinkedListFoodCategory listCaterogy = FoodCategoryBUS.returnLinkedListFoodCategory();
                while (listCaterogy.next != null)
                {
                    if (listCaterogy.data.Idcategory.Equals(id))
                    {
                        name = listCaterogy.data.Namecategory;
                        break;
                    }
                    listCaterogy = listCaterogy.next;
                }
                while (listFoodByID.next != null)
                {
                    if (listFoodByID.data.Idfoodcategory.Equals(id))
                    {
                        ListViewItem lvi = new ListViewItem(name);
                        lvi.SubItems.Add(listFoodByID.data.Idfood.ToString());
                        lvi.SubItems.Add(listFoodByID.data.Namefood.ToString());
                        lvi.SubItems.Add(listFoodByID.data.Pricefood.ToString());
                        lvi.SubItems.Add(listFoodByID.data.Unitcount.ToString());
                        lvwListFood.Items.Add(lvi);
                    }
                    listFoodByID = listFoodByID.next;
                }
            }
        }
        #endregion

        #region List
        public void loadListFoodByCategoryID(int id)
        {
            List<FoodDTO> listFoodByID = FoodBUS.returnListFood();
            lvwListFood.Items.Clear();
            if (id == -1)                    //Nếu ì là -1 thì load tất cả
            {
                loadFoodList();
            }
            else
            {
                string name = null;
                List<CategoryDTO> listCaterogy = FoodCategoryBUS.returnListFoodCategory();
                foreach (CategoryDTO item in listCaterogy)
                    if (item.Idcategory.Equals(id))
                    {
                        name = item.Namecategory;
                        break;
                    }
                foreach (FoodDTO item in listFoodByID)
                    if (item.Idfoodcategory.Equals(id))
                    {
                        ListViewItem lvi = new ListViewItem(name);
                        lvi.SubItems.Add(item.Idfood.ToString());
                        lvi.SubItems.Add(item.Namefood.ToString());
                        lvi.SubItems.Add(item.Pricefood.ToString());
                        lvi.SubItems.Add(item.Unitcount.ToString());
                        lvwListFood.Items.Add(lvi);
                    }
            }
        }
        #endregion

        #region Array
        public void loadArrayFoodByCategoryID(int id)
        {
            ArrayFood listFoodByID = FoodBUS.returnArrayFood();
            lvwListFood.Items.Clear();
            ArrayCategory listCaterogy = FoodCategoryBUS.returnArrayFoodCategory();
            if (id == -1)                    //Nếu ì là -1 thì load tất cả
            {
                loadFoodList();
            }
            else
            { 
                string name = null;
                for (int i = 0; i < listCaterogy.count; i++)
                    if (listCaterogy.ArrayListCategory[i].Idcategory.Equals(id))
                    {
                        name = listCaterogy.ArrayListCategory[i].Namecategory;
                        break;
                    }
                for (int j = 0; j < listFoodByID.count; j++)
                    if (listFoodByID.ArrayListFood[j].Idfoodcategory.Equals(id))
                    {
                        ListViewItem lvi = new ListViewItem(name);
                        lvi.SubItems.Add(listFoodByID.ArrayListFood[j].Idfood.ToString());
                        lvi.SubItems.Add(listFoodByID.ArrayListFood[j].Namefood.ToString());
                        lvi.SubItems.Add(listFoodByID.ArrayListFood[j].Pricefood.ToString());
                        lvi.SubItems.Add(listFoodByID.ArrayListFood[j].Unitcount.ToString());
                        lvwListFood.Items.Add(lvi);
                    }
            }
        }
        #endregion

        #endregion

        #region select food from Category
        private void cboCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboTypeList.Text == "Danh sách liên kết")
            {
                if (cboCategory.Text == "Tất cả thức ăn")
                    loadFoodLinkedByCategoryID(-1); // Nếu là tất cả thì truyền về là -1
                else
                {
                    LinkedListFoodCategory cate = FoodCategoryBUS.returnLinkedListFoodCategory();
                    while (cate.next != null)
                    {
                        if (cboCategory.Text.ToString().Equals(cate.data.Namecategory))
                            break;
                        cate = cate.next;
                    }
                    loadFoodLinkedByCategoryID(cate.data.Idcategory);
                }
            }
            else if (cboTypeList.Text == "Danh sách đơn")
            {
                if (cboCategory.Text == "Tất cả thức ăn")
                    loadListFoodByCategoryID(-1); // Nếu là tất cả thì truyền về là -1
                else
                {
                    List<CategoryDTO> cate = FoodCategoryBUS.returnListFoodCategory();
                    int id = 0;
                    foreach (CategoryDTO item in cate)
                    {
                        if (cboCategory.Text.ToString().Equals(item.Namecategory))
                        {
                            id = item.Idcategory;
                            break;
                        }
                    }
                    loadListFoodByCategoryID(id);
                }
            }
            else if (cboTypeList.Text == "Danh sách đặc")
            {
                if (cboCategory.Text == "Tất cả thức ăn")
                    loadArrayFoodByCategoryID(-1); // Nếu là tất cả thì truyền về là -1
                else
                {
                    ArrayCategory listCaterogy = FoodCategoryBUS.returnArrayFoodCategory();
                    int id = 0;
                    for (int i = 0; i < listCaterogy.count; i++)
                    {
                        if (cboCategory.Text.ToString().Equals(listCaterogy.ArrayListCategory[i].Namecategory))
                        {
                            id = listCaterogy.ArrayListCategory[i].Idcategory;
                            break;
                        }                      
                    }
                    loadArrayFoodByCategoryID(id);
                }
            }
            else MessageBox.Show("Chọn loại danh sách!");
        }

        #endregion

        #region Discount
        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            TableDTO table = lviBill.Tag as TableDTO;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }
            int discount = (int)nudDiscount.Value;
            float total = 0;
            for (int i = 0; i < lviBill.Items.Count; i++)
                total += (float)Convert.ToDouble(lviBill.Items[0].SubItems[4].Text.ToString());            
            float totalAfterDiscount = total - (total * discount / 100);

            btPay.Text = totalAfterDiscount.ToString() + "đ";
        }

        #endregion

        #region Add food
        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btAdd_Click(sender, e);
        }

        private void lvwListFood_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cmsAddFood.Show(lvwListFood, e.X, e.Y);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            TableDTO table = lviBill.Tag as TableDTO;

            int count = (int)nudCount.Value; //hàm dùng để lấy số lượng món thêm vào 
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }
            int i = table.Idtable;
            FoodDTO food = new FoodDTO();
            string check = null;
            foreach(ListViewItem lvi in lvwListFood.SelectedItems)
            {
                check = lvi.SubItems[1].Text;
            }

            if (check != null)
            {
                if (cboTypeList.Text == "Danh sách liên kết")
                {
                    LinkedListFood LinkedListFood = FoodBUS.returnLinkedListFood();

                    if (LinkedListFood.next == null)
                    {
                        MessageBox.Show("Hãy chọn món");
                        return;
                    }
                    else
                    {
                        while (LinkedListFood.next != null && LinkedListFood.data.Namefood != lvwListFood.SelectedItems[0].SubItems[2].Text)
                        {
                            LinkedListFood = LinkedListFood.next;
                        }
                        if (lvwListFood.SelectedItems[0].SubItems[2].Text != "")
                        {
                            if (table.Statustable.Equals("Trống"))// thêm bàn trống
                            {
                                LinkedListBill listbill = TableBUS.Instance.addToLinkedBill(ref linkedListBillInfo, i, LinkedListFood.data.Idfood, LinkedListFood.data.Namefood, LinkedListFood.data.Pricefood, count); // loi them mon
                                listBill = BillBUS.Instance.getPayedListBill((int)nudDiscount.Value, table.Idtable, dicListTable[table.Idtable], false);
                                arrayBill = BillBUS.Instance.ListToArray(listBill);
                                linkedListBill = BillBUS.Instance.ListtoLinkedList(listBill);
                                table.Statustable = "Có người";
                                showBill(BillBUS.Instance.LinkedListtoListInfo(listbill));
                                loadTable(table.Idtable);
                            }
                            else // thêm bàn có người
                            {
                                LinkedListBill p = new LinkedListBill();
                                p = BillBUS.Instance.ListtoLinkedListInfo(dicListTable[table.Idtable]);
                                LinkedListBill listbill = TableBUS.Instance.addToLinkedBill(ref p, i, LinkedListFood.data.Idfood, LinkedListFood.data.Namefood, LinkedListFood.data.Pricefood, count);
                                listBill = BillBUS.Instance.getPayedListBill((int)nudDiscount.Value, table.Idtable, dicListTable[table.Idtable], false);
                                arrayBill = BillBUS.Instance.ListToArray(listBill);
                                linkedListBill = BillBUS.Instance.ListtoLinkedList(listBill);
                                dicListTable[table.Idtable] = BillBUS.Instance.LinkedListtoListInfo(listbill);
                                showBill(BillBUS.Instance.LinkedListtoListInfo(listbill));
                                loadTable(table.Idtable);
                            }
                        }
                    }
                }
                else if (cboTypeList.Text == "Danh sách đơn")
                {
                    List<FoodDTO> listFood = FoodBUS.returnListFood();
                    
                   
                    if (listFood == null)
                    {
                        MessageBox.Show("Hãy chọn món");
                        return;
                    }
                    else
                    {
                        foreach (FoodDTO item in listFood)
                        {
                            if (item.Namefood == lvwListFood.SelectedItems[0].SubItems[2].Text)
                            {
                                food = item;
                                break;
                            }
                        }
                        if (lvwListFood.SelectedItems[0].SubItems[2].Text != "")
                        {
                            if (table.Statustable.Equals("Trống"))// thêm bàn trống
                            {
                                List<BillInfoDTO> listbill = TableBUS.Instance.addToListBill(ref listBillInfo, i, food.Idfood, food.Namefood, food.Pricefood, count);
                                listBill = BillBUS.Instance.getPayedListBill((int)nudDiscount.Value, table.Idtable, dicListTable[table.Idtable], false);
                                arrayBill = BillBUS.Instance.ListToArray(listBill);
                                linkedListBill = BillBUS.Instance.ListtoLinkedList(listBill);
                                table.Statustable = "Có người";
                                showBill(listbill);
                                loadTable(table.Idtable);
                            }
                            else // thêm bàn có người
                            {
                                List<BillInfoDTO> p = new List<BillInfoDTO>();
                                p = dicListTable[table.Idtable];
                                List<BillInfoDTO> listbill = TableBUS.Instance.addToListBill(ref p, i, food.Idfood, food.Namefood, food.Pricefood, count);
                                listBill = BillBUS.Instance.getPayedListBill((int)nudDiscount.Value, table.Idtable, dicListTable[table.Idtable], false);
                                arrayBill = BillBUS.Instance.ListToArray(listBill);
                                linkedListBill = BillBUS.Instance.ListtoLinkedList(listBill);
                                dicListTable[table.Idtable] = listbill;
                                showBill(listbill);
                                loadTable(table.Idtable);
                            }
                        }
                    }
                }
                else if (cboTypeList.Text == "Danh sách đặc")
                {
                    ArrayFood arrayFood = FoodBUS.returnArrayFood();
                    
                    if (arrayFood.ArrayListFood == null)
                    {
                        MessageBox.Show("Hãy chọn món");
                        return;
                    }
                    else
                    {
                        for (int j = 0; j < arrayFood.count; j++)
                        {
                            if (arrayFood.ArrayListFood[j].Namefood == lvwListFood.SelectedItems[0].SubItems[2].Text)
                            {
                                food = arrayFood.ArrayListFood[j];
                                break;
                            }

                        }
                        if (lvwListFood.SelectedItems[0].SubItems[2].Text != "")
                        {
                            if (table.Statustable.Equals("Trống"))// thêm bàn trống
                            {
                                ArrayBillInfo listbill = TableBUS.Instance.addToArrayBill(ref arrayBillInfo, i, food.Idfood, food.Namefood, food.Pricefood, count);
                                listBill = BillBUS.Instance.getPayedListBill((int)nudDiscount.Value, table.Idtable, dicListTable[table.Idtable], false);
                                arrayBill = BillBUS.Instance.ListToArray(listBill);
                                linkedListBill = BillBUS.Instance.ListtoLinkedList(listBill);
                                table.Statustable = "Có người";
                                showBill(BillBUS.Instance.ArraytoListInfo(listbill));
                                loadTable(table.Idtable);
                            }
                            else // thêm bàn có người
                            {
                                ArrayBillInfo p = new ArrayBillInfo();
                                p = BillBUS.Instance.ListToArrayInfo(dicListTable[table.Idtable]);
                                ArrayBillInfo listbill = TableBUS.Instance.addToArrayBill(ref p, i, food.Idfood, food.Namefood, food.Pricefood, count);
                                listBill = BillBUS.Instance.getPayedListBill((int)nudDiscount.Value, table.Idtable, dicListTable[table.Idtable], false);
                                arrayBill = BillBUS.Instance.ListToArray(listBill);
                                linkedListBill = BillBUS.Instance.ListtoLinkedList(listBill);
                                dicListTable[table.Idtable] = BillBUS.Instance.ArraytoListInfo(listbill);
                                showBill(BillBUS.Instance.ArraytoListInfo(listbill));
                                loadTable(table.Idtable);
                            }
                        }
                    }
                }
                else MessageBox.Show("Chọn loại danh sách!");
            }
            else MessageBox.Show("Hãy chọn món ăn!");
        }
        #endregion

        #region Delete Food
        private void lviBill_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cmsDelFood.Show(lviBill, e.X, e.Y);
        }

        private void xoáMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btDel_Click(sender, e);
        }
        private void btDel_Click(object sender, EventArgs e)
        {
            TableDTO table = lviBill.Tag as TableDTO;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }
            string check = null;
            foreach (ListViewItem lvi in lviBill.SelectedItems)
            {
                check = lvi.SubItems[0].Text;
            }
            if (check == null)
            {
                MessageBox.Show("Chọn món cần xóa!");
                return;
            }
            else
            {
                string foodID = lviBill.SelectedItems[0].SubItems[0].Text.ToString();
                BillDTO bill = new BillDTO();
                if (cboTypeList.Text == "Danh sách liên kết")
                {
                    LinkedListBill p = new LinkedListBill();
                    LinkedListBillPayed linkedbill = linkedListBill;
                    p = BillBUS.Instance.ListtoLinkedListInfo(dicListTable[table.Idtable]);
                    while (linkedbill.data != null)
                    {
                        BillDTO data = linkedbill.data;
                        if (data.Idtable == table.Idtable)
                        {
                            bill = data;
                            break;
                        }
                        linkedbill = linkedbill.next;
                    }
                    TableBUS.Instance.delFoodinLinkedBill(ref p, foodID);
                    dicListTable[table.Idtable] = BillBUS.Instance.LinkedListtoListInfo(p);                    
                    if (p.next == null)
                    {
                        table.Statustable = "Trống";
                        BillBUS.Instance.delLinkedBilPayed(bill.Idbill, ref linkedListBill);
                        dicListTable.Remove(table.Idtable);
                    }
                    else
                        linkedListBill = BillBUS.Instance.UpdateLinkedBill(bill.Idbill, p);
                    listBill = BillBUS.Instance.LinkedListtoList(linkedListBill);
                    arrayBill = BillBUS.Instance.ListToArray(listBill);
                    showBill(BillBUS.Instance.LinkedListtoListInfo(p));
                    loadTable(table.Idtable);

                }
                else if (cboTypeList.Text == "Danh sách đặc")
                {
                    ArrayBillInfo p = new ArrayBillInfo();
                    p = BillBUS.Instance.ListToArrayInfo(dicListTable[table.Idtable]);
                    for(int i=0;i<arrayBill.count;i++)
                        if (arrayBill.ArrayListBill[i].data.Idtable == table.Idtable)
                        {
                            bill = arrayBill.ArrayListBill[i].data;
                            break;
                        }
                    TableBUS.Instance.delFoodinArrayBill(ref p, foodID);
                    dicListTable[table.Idtable] = BillBUS.Instance.ArraytoListInfo(p);
                    if (p.count == 0)
                    {
                        table.Statustable = "Trống";
                        BillBUS.Instance.delBilPayed(bill.Idbill, ref arrayBill);
                        dicListTable.Remove(table.Idtable);
                    }
                    else
                    arrayBill = BillBUS.Instance.UpdateArrrayBill(bill.Idbill, p);
                    listBill = BillBUS.Instance.ArraytoList(arrayBill);
                    linkedListBill = BillBUS.Instance.ListtoLinkedList(listBill);                    
                    showBill(p);
                    loadTable(table.Idtable);
                }
                else if (cboTypeList.Text == "Danh sách đơn")
                {
                    List<BillInfoDTO> p = new List<BillInfoDTO>();
                    p = dicListTable[table.Idtable];
                    foreach (ListBill item in listBill)
                        if (item.data.Idtable == table.Idtable)
                        {
                            bill = item.data;
                            break;
                        }
                    TableBUS.Instance.delFoodinListBill(ref p, foodID);
                    dicListTable[table.Idtable] = p;                    
                    if (p.Count == 0)
                    {
                        table.Statustable = "Trống";
                        BillBUS.Instance.delListBilPayed(bill.Idbill, ref listBill);
                        dicListTable.Remove(table.Idtable);
                    }
                    else
                        listBill = BillBUS.Instance.UpdateListBill(bill.Idbill, dicListTable[table.Idtable]);
                    linkedListBill = BillBUS.Instance.ListtoLinkedList(listBill);
                    arrayBill = BillBUS.Instance.ListToArray(listBill);
                    showBill(p);
                    loadTable(table.Idtable);
                }
                else MessageBox.Show("Chọn loại danh sách!");
            }    
               
        }

        #endregion

        #region Load Avilable Table
        public void loadAvilableTable()
        {
            flAvailableTable.Controls.Clear();
            foreach (TableDTO table in listTable)
            {
                if (table.Statustable == "Trống")
                {
                    Button btnTable = new Button() { Width = 100, Height = 100 };
                    btnTable.Text = table.Nametable + Environment.NewLine + table.Statustable;
                    btnTable.Click += btnTableAvilable_click;
                    btnTable.Tag = table;
                    btnTable.BackColor = Color.Pink;
                    flAvailableTable.Controls.Add(btnTable);
                }
            }
        }
        void btnTableAvilable_click(object sender, EventArgs e)
        {

            int idAviTable = ((sender as Button).Tag as TableDTO).Idtable;
            DialogResult result = MessageBox.Show("Bạn chắc muốn chuyển sang bàn " + idAviTable, "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TableDTO table = lviBill.Tag as TableDTO;
                int idTable = table.Idtable;
                if (listTable[idAviTable - 1].Statustable == "Trống")
                {
                    dicListTable.Add(idAviTable, dicListTable[table.Idtable]);
                    dicListTable.Remove(table.Idtable);
                    table.Statustable = "Trống";
                    listTable[idAviTable - 1].Statustable = "Có người";
                }
                else MessageBox.Show("Bàn đang có người", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panelChangeTable.Visible = false;
                panelManage.Visible = true;
                loadTable(idTable);
                BillBUS.Instance.UpdateIdTable(idTable, idAviTable);
                lviBill.Items.Clear();
            }
        }
        #endregion

        #region Change Table


        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            TableDTO table = lviBill.Tag as TableDTO;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }
            if (table.Statustable == "Trống")
            {
                MessageBox.Show("Hãy chọn bàn có người");
                return;
            }
            panelChangeTable.Visible = true;
            loadAvilableTable();
        }

        #endregion

        #region Pay Button
        private void btPay_Click(object sender, EventArgs e)
        {
            TableDTO table = lviBill.Tag as TableDTO;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thanh toán cho " + table.Nametable + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (table.Statustable != "Trống")//Bàn trống sẽ ko đc thanh toán
                {
                    listBill = BillBUS.Instance.getPayedListBill((int)nudDiscount.Value, table.Idtable, dicListTable[table.Idtable], true);
                    arrayBill = BillBUS.Instance.ListToArray(listBill);
                    linkedListBill = BillBUS.Instance.ListtoLinkedList(listBill);
                    lviBill.Items.Clear();
                    dicListTable.Remove(table.Idtable);
                    btPay.Text = "0đ";
                    table.Statustable = "Trống";
                    nudDiscount.Value = 0;
                }
                else MessageBox.Show("Bàn không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadTable(0);
        }
        #endregion

        #region button back in changeTable
        private void iconBack_Click(object sender, EventArgs e)
        {
            panelChangeTable.Visible = false;
            panelManage.Visible = true;
        }

        #endregion

        #region Find Food
        private void cboCategory_TextChanged(object sender, EventArgs e)
        {
            LinkedListFood listFood = FoodBUS.returnLinkedListFood();
            LinkedListFood result = FoodBUS.Instance.result(listFood, cboCategory.Text);
            lvwListFood.Items.Clear();
            while (result.next != null)
            {
                string name = null;
                LinkedListFoodCategory listCaterogy = FoodCategoryBUS.returnLinkedListFoodCategory();
                while (listCaterogy.next != null)
                {
                    if (listCaterogy.data.Idcategory.Equals(result.data.Idfoodcategory))
                    {
                        name = listCaterogy.data.Namecategory;
                        break;
                    }
                    listCaterogy = listCaterogy.next;
                }
                ListViewItem lvi = new ListViewItem(name.ToString());
                lvi.SubItems.Add(result.data.Idfood.ToString());
                lvi.SubItems.Add(result.data.Namefood.ToString());
                lvi.SubItems.Add(result.data.Pricefood.ToString());
                lvi.SubItems.Add(result.data.Unitcount.ToString());
                lvwListFood.Items.Add(lvi);
                result = result.next;
            }
        }
        #endregion

        private void cboTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTypeList.Text == "Danh sách liên kết")
            {
                loadTable(0);
                loadCategory();
                lviBill.Items.Clear();
            }
            else if (cboTypeList.Text == "Danh sách đơn")
            {
                loadTable(0);
                loadCategory();
                lviBill.Items.Clear();
            }
            else if (cboTypeList.Text == "Danh sách đặc")
            {
                loadTable(0);
                loadCategory();
                lviBill.Items.Clear();
            }
        }
      
    }

}
