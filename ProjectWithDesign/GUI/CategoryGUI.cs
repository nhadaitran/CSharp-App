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
    public partial class CategoryGUI : Form
    {

        LinkedListFood ListFood = FoodBUS.returnLinkedListFood();
        LinkedListFoodCategory listCategory = FoodCategoryBUS.returnLinkedListFoodCategory();
        List<FoodDTO> Foods = FoodBUS.returnListFood();
        List<CategoryDTO> categories = FoodCategoryBUS.returnListFoodCategory();
        ArrayFood arrayfood = FoodBUS.returnArrayFood();
        ArrayCategory arrayCategory = FoodCategoryBUS.returnArrayFoodCategory();

        public CategoryGUI()
        {
            InitializeComponent();
            loadTableFood(ListFood);
            loadTableCategory(listCategory);
            panelLayoutManage.Visible = true;
            panelAdd.Visible = false;
            
        }

        #region Chọn ds
        private void cboTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTypeList.Text == "Danh sách liên kết")
            {
                loadTableFood(Foods);
                loadTableCategory(categories);
            }
            else if (cboTypeList.Text == "Danh sách đơn")
            {
                loadTableFood(ListFood);
                loadTableCategory(listCategory);
            }
            else if (cboTypeList.Text == "Danh sách đặc")
            {
                loadTableFood(arrayfood);
                loadTableCategory(arrayCategory);
            }
        }
        #endregion

        #region Decorate
        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.IconColor = Color.FromArgb(253, 138, 114);
            btnAdd.ForeColor = Color.FromArgb(253, 138, 114);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.IconColor = Color.Black;
            btnAdd.ForeColor = Color.Black;
        }



        private void iconFind_MouseHover(object sender, EventArgs e)
        {
            iconFind.IconColor = Color.FromArgb(253, 138, 114);
            iconFind.ForeColor = Color.FromArgb(253, 138, 114);
        }

        private void iconFind_MouseLeave(object sender, EventArgs e)
        {
            iconFind.IconColor = Color.Black;
            iconFind.ForeColor = Color.Black;
        }
        #endregion

        #region Load listview food

        #region dslk
        private void loadTableFood(LinkedListFood result)
        {
            LinkedListFood p = new LinkedListFood();
            p = result;
            lvFood.Items.Clear();
            while (p.next != null)
            {
                ListViewItem lvi = new ListViewItem(p.data.Idfood);
                lvi.SubItems.Add(p.data.Idfoodcategory.ToString());
                lvi.SubItems.Add(p.data.Namefood);
                lvi.SubItems.Add(p.data.Pricefood.ToString());
                lvi.SubItems.Add(p.data.Unitcount);
                p = p.next;
                lvFood.Items.Add(lvi);
            }

        }
        #endregion

        #region list
        private void loadTableFood(List<FoodDTO> listFood)
        {

            lvFood.Items.Clear();
            foreach (FoodDTO data in listFood)
            {
                ListViewItem lvi = new ListViewItem(data.Idfood);
                lvi.SubItems.Add(data.Idfoodcategory.ToString());
                lvi.SubItems.Add(data.Namefood);
                lvi.SubItems.Add(data.Pricefood.ToString());
                lvi.SubItems.Add(data.Unitcount);
                lvFood.Items.Add(lvi);
            }
        }
        #endregion

        #region Array
        private void loadTableFood(ArrayFood listFood)
        {

            ArrayFood foods = listFood;
            lvFood.Items.Clear();
            for (int i = 0; i < foods.count; i++)
            {
                ListViewItem lvi = new ListViewItem(foods.ArrayListFood[i].Idfood);
                lvi.SubItems.Add(foods.ArrayListFood[i].Idfoodcategory.ToString());
                lvi.SubItems.Add(foods.ArrayListFood[i].Namefood);
                lvi.SubItems.Add(foods.ArrayListFood[i].Pricefood.ToString());
                lvi.SubItems.Add(foods.ArrayListFood[i].Unitcount);
                lvFood.Items.Add(lvi);
            }
        }
        #endregion

        #endregion

        #region load listview category

        #region dslk
        private void loadTableCategory(LinkedListFoodCategory listFoodCategory)
        {
            lvFoodCategory.Items.Clear();
            LinkedListFoodCategory p = new LinkedListFoodCategory();
            p = listFoodCategory;
            while (p.next != null)
            {
                ListViewItem lvi = new ListViewItem(p.data.Idcategory.ToString());
                lvi.SubItems.Add(p.data.Namecategory);
                lvFoodCategory.Items.Add(lvi);
                p = p.next;
            }
        }
        #endregion

        #region list
        private void loadTableCategory(List<CategoryDTO> list)
        {
            lvFoodCategory.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(list[i].Idcategory.ToString());
                lvi.SubItems.Add(list[i].Namecategory.ToString());
                lvFoodCategory.Items.Add(lvi);
            }
        }
        #endregion

        #region array
        private void loadTableCategory(ArrayCategory array)
        {
            lvFoodCategory.Items.Clear();
            for (int i = 0; i < array.count; i++)
            {
                ListViewItem lvi = new ListViewItem(array.ArrayListCategory[i].Idcategory.ToString());
                lvi.SubItems.Add(array.ArrayListCategory[i].Namecategory.ToString());
                lvFoodCategory.Items.Add(lvi);
            }
        }
        #endregion
        #endregion

        #region load panel Add food N category
        private void checkButtonFoodOrCate()
        {
            if (rdbFoodOrCate.Checked == false)
            {
                rdbFoodOrCate.Text = "Thức ăn";
                panelAddFood.Visible = true;
                panelAddCate.Visible = false;

            }
            else
            {
                rdbFoodOrCate.Text = "Loại thức ăn";
                panelAddFood.Visible = false;
                panelAddCate.Visible = true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCatFoodmenu.Text = null;
            txtFoodmenu.Text = null;
            txtnmeCat.Text = null;
            txtUnitCount.Text = null;
            nudPriceFood.Value = 0;

            panelLayoutManage.Visible = true;
            panelAdd.Visible = true;
            rdbFoodOrCate.Visible = true;
            checkButtonFoodOrCate();
            txtCatFoodmenu.Items.Clear();
            foreach (CategoryDTO data in categories)
            {
                txtCatFoodmenu.Items.Add(data.Namecategory);
            }
            tbnAddFoodNCate.Visible = true;
            rdbFoodOrCate.Visible = true;
            panelIDCate.Visible = false;
            panelIDFood.Visible = false;
            panelAdd.Visible = true;
        }
        #endregion

        #region Find food N Category
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            //Tìm Category
            if (cboTypeList.Text == "Danh sách liên kết")//Tìm theo dslk
            {
                if (txtFind.Text == "")
                    loadTableCategory(listCategory);
                else
                {
                    LinkedListFoodCategory result = new LinkedListFoodCategory();
                    result = FoodCategoryBUS.Instance.FindCategory(listCategory, txtFind.Text);
                    loadTableCategory(result);
                }
            }
            else if (cboTypeList.Text == "Danh sách đơn")
            {
                if (txtFind.Text == "")
                    loadTableCategory(categories);
                else
                {
                    List<CategoryDTO> newlist = new List<CategoryDTO>();
                    newlist = FoodCategoryBUS.Instance.findInfo(categories, txtFind.Text);
                    loadTableCategory(newlist);
                }
            }
            else if (cboTypeList.Text == "Danh sách đặc")
            {
                if (txtFind.Text == "")
                    loadTableCategory(arrayCategory);
                else
                {
                    ArrayCategory newarray = new ArrayCategory();
                    newarray = FoodCategoryBUS.Instance.findInfoArray(arrayCategory, txtFind.Text);
                    loadTableCategory(newarray);
                }
            }
            else MessageBox.Show("Chọn loại danh sách!");
            //Tìm food
            if (cboTypeList.Text == "Danh sách liên kết")
            {
                LinkedListFood result = new LinkedListFood();
                if (txtFind.Text == "")
                    loadTableFood(ListFood);
                else
                {
                    result = FoodBUS.Instance.result(ListFood, txtFind.Text);
                    loadTableFood(result);
                }
            }
            else if (cboTypeList.Text == "Danh sách đơn")
            {
                List<FoodDTO> result = new List<FoodDTO>();
                if (txtFind.Text == "")
                    loadTableFood(Foods);
                else
                {
                    result = FoodBUS.Instance.resultList(Foods, txtFind.Text);
                    loadTableFood(result);
                }
            }
            else if (cboTypeList.Text == "Danh sách đặc")
            {
                ArrayFood result = new ArrayFood();
                if (txtFind.Text == "")
                    loadTableFood(arrayfood);
                else
                {
                    result = FoodBUS.Instance.resultArray(arrayfood, txtFind.Text);
                    loadTableFood(result);
                }
            }
        }

        #endregion

        #region Xóa food
        private void lvFood_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(lvFood, e.X, e.Y);
        }
        private void delFood_Click(object sender, EventArgs e)
        {
            string check = null;
            foreach (ListViewItem lvi in lvFood.SelectedItems)
                check = lvi.SubItems[0].Text;
            if(check==null)
            {
                MessageBox.Show("Chọn món cần xóa!");
                return;
            }    
            if (cboTypeList.Text == "Danh sách liên kết")
            {
                foreach (ListViewItem lvi in lvFood.SelectedItems)
                {
                    FoodBUS.Instance.delFood(ref ListFood, lvi.SubItems[0].Text);
                }
                Foods = FoodBUS.toListFood(ListFood);
                arrayfood = FoodBUS.toArrayFood(ListFood);
                loadTableFood(ListFood);
            }
            else if (cboTypeList.Text == "Danh sách đơn")
            {
                foreach (ListViewItem lvi in lvFood.SelectedItems)
                {
                    FoodBUS.Instance.delListFood(ref Foods, lvi.SubItems[0].Text);
                }
                ListFood = FoodBUS.toLinkedListFood(Foods);
                arrayfood = FoodBUS.toArrayFood(Foods);
                loadTableFood(Foods);
            }
            else if (cboTypeList.Text == "Danh sách đặc")
            {
                foreach (ListViewItem lvi in lvFood.SelectedItems)
                {
                    FoodBUS.Instance.delArrayFood(ref arrayfood, lvi.SubItems[0].Text);
                }
                Foods = FoodBUS.toListFood(arrayfood);
                ListFood = FoodBUS.toLinkedListFood(arrayfood);
                loadTableFood(arrayfood);
            }
            else MessageBox.Show("Chọn loại danh sách!");
        }


        #endregion

        #region Xóa Category

        private void lvFoodCategory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip2.Show(lvFoodCategory, e.X, e.Y);
        }


        private void xóaLoạiĐồĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string check = null;
            foreach (ListViewItem lvi in lvFoodCategory.SelectedItems)
                check = lvi.SubItems[0].Text;
            if (check == null)
            {
                MessageBox.Show("Chọn món cần xóa!");
                return;
            }
            int idDelCate = 0;
            if (cboTypeList.Text == "Danh sách liên kết")
            {
                foreach (ListViewItem lvi in lvFoodCategory.SelectedItems)
                {
                    idDelCate = int.Parse(lvi.SubItems[0].Text);
                    FoodCategoryBUS.Instance.delCategory(ref listCategory, idDelCate); //Xóa Category
                }
                LinkedListFood temp = new LinkedListFood();//Xóa food theo category
                temp = ListFood;
                while(temp.next!=null)
                {
                    if (temp.data.Idfoodcategory.Equals(idDelCate))
                        FoodBUS.Instance.delFood(ref ListFood, temp.data.Idfood);
                    temp = temp.next;
                }
                Foods = FoodBUS.toListFood(ListFood);
                arrayfood = FoodBUS.toArrayFood(ListFood);
                categories = FoodCategoryBUS.tolistCategory(listCategory);
                arrayCategory = FoodCategoryBUS.toArrayCategory(listCategory);

                loadTableCategory(listCategory);
                loadTableFood(ListFood);
            }
            else if (cboTypeList.Text == "Danh sách đơn")
            {
                foreach (ListViewItem lvi in lvFoodCategory.SelectedItems)
                {
                    idDelCate = int.Parse(lvi.SubItems[0].Text);
                    FoodCategoryBUS.Instance.delCategoryInList(ref categories, idDelCate);//Xóa Category
                }
                FoodBUS.Instance.delListFoodbyIdCate(ref Foods, idDelCate); //Xóa food theo category
                listCategory = FoodCategoryBUS.toLinkedListCategory(categories);
                arrayCategory = FoodCategoryBUS.toArrayCategory(categories);
                ListFood = FoodBUS.toLinkedListFood(Foods);
                arrayfood = FoodBUS.toArrayFood(Foods);
                loadTableFood(Foods);
                loadTableCategory(categories);
            }
            else if (cboTypeList.Text == "Danh sách đặc")
            {
                foreach (ListViewItem lvi in lvFoodCategory.SelectedItems)
                {
                    idDelCate = int.Parse(lvi.SubItems[0].Text);
                    FoodCategoryBUS.Instance.delCategoryInArray(ref arrayCategory, idDelCate);//Xóa Category
                }
                FoodBUS.Instance.delArrayFoodbyIdCate(ref arrayfood, idDelCate);//Xóa food theo category
                listCategory = FoodCategoryBUS.toLinkedListCategory(arrayCategory);
                categories = FoodCategoryBUS.tolistCategory(arrayCategory);
                Foods = FoodBUS.toListFood(arrayfood);
                ListFood = FoodBUS.toLinkedListFood(arrayfood);
                loadTableFood(arrayfood);
                loadTableCategory(arrayCategory);
            }
            else MessageBox.Show("Chọn loại danh sách!");
        }

        #endregion

        //layout 2
        #region Add food or category

        private void tbnAddFoodNCate_Click(object sender, EventArgs e)
        {
            if (rdbFoodOrCate.Checked == false)//=>Food
            {
                if (txtFoodmenu.Text == "" && txtCatFoodmenu.Text == "" && txtUnitCount.Text == "")
                    MessageBox.Show("Còn mục trống!");
                else
                {
                    if (cboTypeList.Text == "Danh sách liên kết")
                    {
                        LinkedListFoodCategory p = listCategory;
                        int temp = 0;
                        while (p.next != null)
                        {
                            if (txtCatFoodmenu.Text.Equals(p.data.Namecategory))
                            {
                                temp = p.data.Idcategory;
                                break;
                            }
                            p = p.next;
                        }
                        if(temp == 0)
                        {
                            MessageBox.Show("Không có danh mục đã chọn!");
                            return;
                        }    
                        ListFood = FoodBUS.Instance.newFood(ref ListFood, txtUnitCount.Text, txtFoodmenu.Text, (int)nudPriceFood.Value, temp, listCategory);
                        loadTableFood(ListFood);
                        Foods = FoodBUS.toListFood(ListFood);
                        arrayfood = FoodBUS.toArrayFood(ListFood);
                        MessageBox.Show("Thêm thành công!");
                    }
                    else if (cboTypeList.Text == "Danh sách đơn")
                    {
                        int temp = 0;
                        foreach (CategoryDTO data in categories)
                        {
                            if (txtCatFoodmenu.Text.Equals(data.Namecategory)) 
                                temp = data.Idcategory;
                        }
                        if (temp == 0)
                        {
                            MessageBox.Show("Không có danh mục đã chọn!");
                            return;
                        }
                        Foods = FoodBUS.Instance.newFoodtoList(ref Foods, txtUnitCount.Text, txtFoodmenu.Text, (int)nudPriceFood.Value, temp, categories);
                        loadTableFood(Foods);
                        ListFood = FoodBUS.toLinkedListFood(Foods);
                        arrayfood = FoodBUS.toArrayFood(Foods);
                        MessageBox.Show("Thêm thành công!");
                        
                    }
                    else if (cboTypeList.Text == "Danh sách đặc")
                    {
                        int temp = 0;
                        for(int i=0;i<arrayCategory.count;i++)
                        {
                            if (txtCatFoodmenu.Text.Equals(arrayCategory.ArrayListCategory[i].Namecategory))
                                temp = arrayCategory.ArrayListCategory[i].Idcategory;
                        }
                        if (temp == 0)
                        {
                            MessageBox.Show("Không có danh mục đã chọn!");
                            return;
                        }
                        arrayfood = FoodBUS.Instance.newFoodtoArray(ref arrayfood, txtIDmenu.Text, txtUnitCount.Text, txtFoodmenu.Text, (int)nudPriceFood.Value, temp, arrayCategory);
                        loadTableFood(arrayfood);
                        Foods = FoodBUS.toListFood(arrayfood);
                        ListFood = FoodBUS.toLinkedListFood(arrayfood);
                        MessageBox.Show("Thêm thành công!");                 
                    }
                    else MessageBox.Show("Chọn loại danh sách!");
                }
            }
            else//=>Category 
            {
                if (txtnmeCat.Text == "")
                    MessageBox.Show("Nhâp tên loại món ăn!");
                else
                {
                    if (cboTypeList.Text == "Danh sách liên kết")
                    {
                        listCategory = FoodCategoryBUS.Instance.newCategory(ref listCategory, txtnmeCat.Text);
                        categories = FoodCategoryBUS.tolistCategory(listCategory);
                        arrayCategory = FoodCategoryBUS.toArrayCategory(listCategory);
                        txtCatFoodmenu.Items.Add(txtnmeCat.Text);
                        loadTableCategory(listCategory);
                        MessageBox.Show("Thêm thành công!");
                    }
                    else if (cboTypeList.Text == "Danh sách đơn")
                    {
                        categories = FoodCategoryBUS.Instance.newCategorytoList(ref categories, txtnmeCat.Text);
                        listCategory = FoodCategoryBUS.toLinkedListCategory(categories);
                        arrayCategory = FoodCategoryBUS.toArrayCategory(categories);
                        txtCatFoodmenu.Items.Add(txtnmeCat.Text);
                        loadTableCategory(categories);
                        MessageBox.Show("Thêm thành công!");
                    }
                    else if (cboTypeList.Text == "Danh sách đặc")
                    {
                        arrayCategory = FoodCategoryBUS.Instance.newCategorytoArray(ref arrayCategory, txtnmeCat.Text);
                        listCategory = FoodCategoryBUS.toLinkedListCategory(arrayCategory);
                        categories = FoodCategoryBUS.tolistCategory(arrayCategory);
                        txtCatFoodmenu.Items.Add(txtnmeCat.Text);
                        loadTableCategory(arrayCategory);
                        MessageBox.Show("Thêm thành công!");
                    }
                    else MessageBox.Show("Chọn loại danh sách!");
                }   
            }
        }

        #endregion

        #region panel Add and edit menustrip

        private void iconBack_Click_1(object sender, EventArgs e)
        {
            panelLayoutManage.Visible = true;
            panelAddFood.Visible = false;
            panelAdd.Visible = false;
            panelIDFood.Visible = false;
        }

        private void rdbFoodOrCate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFoodOrCate.Checked == false)
            {
                rdbFoodOrCate.Text = "Thức ăn";
                panelAddFood.Visible = true;
                panelAddCate.Visible = false;

            }
            else
            {
                rdbFoodOrCate.Text = "Loại thức ăn";
                panelAddFood.Visible = false;
                panelAddCate.Visible = true;
            }

        }
       


        //layput Edit

        private void sửaThôngTinLoạiĐồĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string check = null;
            foreach (ListViewItem lvi in lvFoodCategory.SelectedItems)
                check = lvi.SubItems[0].Text;
            if (check == null)
            {
                MessageBox.Show("Chọn món cần sửa thông tin!");
                return;
            }
            panelLayoutManage.Visible = true;
            panelAdd.Visible = true;
            rdbFoodOrCate.Visible = false;
            rdbFoodOrCate.Checked = true;
            checkButtonFoodOrCate();
            tbnAddFoodNCate.Visible = false ;
            panelIDCate.Visible = true;
            panelIDFood.Visible = false;
            panelAdd.Visible = true;
           
        }

        private void sửaThôngTinMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string check = null;
            foreach (ListViewItem lvi in lvFood.SelectedItems)
                check = lvi.SubItems[0].Text;
            if (check == null)
            {
                MessageBox.Show("Chọn món cần sửa thông tin!");
                return;
            }
            panelLayoutManage.Visible = true;
            panelAdd.Visible = true;
            rdbFoodOrCate.Visible = false;
            rdbFoodOrCate.Checked = false;
            checkButtonFoodOrCate();
            tbnAddFoodNCate.Visible = false;
            panelIDCate.Visible = false;
            panelIDFood.Visible = true;
            panelAdd.Visible = true;
            foreach (CategoryDTO data in categories)
            {
                txtCatFoodmenu.Items.Add(data.Namecategory);
            }
        }

        #endregion

        #region Sửa


        private void lvFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvFoodCategory.SelectedItems)
            {
                txtIDCat.Text = lvi.SubItems[0].Text;
                txtnmeCat.Text = lvi.SubItems[1].Text;
            }
        }

        private void lvFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTypeList.Text == "Danh sách liên kết")
            {
                foreach (ListViewItem lvi in lvFood.SelectedItems)
                {
                    txtFoodmenu.Text = lvi.SubItems[2].Text;
                    txtIDmenu.Text = lvi.SubItems[0].Text;
                    nudPriceFood.Value = int.Parse(lvi.SubItems[3].Text);
                    LinkedListFoodCategory p = listCategory;
                    while (p.next != null)
                    {
                        if (lvi.SubItems[1].Text.Equals(p.data.Idcategory.ToString()))
                            txtCatFoodmenu.Text = p.data.Namecategory.ToString();
                        p = p.next;
                    }
                    txtUnitCount.Text = lvi.SubItems[4].Text;
                }
            }
            else if (cboTypeList.Text == "Danh sách đơn")
            {
                foreach (ListViewItem lvi in lvFood.SelectedItems)
                {
                    txtFoodmenu.Text = lvi.SubItems[2].Text;
                    txtIDmenu.Text = lvi.SubItems[0].Text;
                    nudPriceFood.Value = int.Parse(lvi.SubItems[3].Text);
                    foreach (CategoryDTO data in categories)
                    {
                        if (lvi.SubItems[1].Text.Equals(data.Idcategory.ToString()))
                        {
                            txtCatFoodmenu.Text = data.Namecategory.ToString();
                            break;
                        }
                    }
                    txtUnitCount.Text = lvi.SubItems[4].Text;
                }
            }
            else if (cboTypeList.Text == "Danh sách đặc")
            {
                foreach (ListViewItem lvi in lvFood.SelectedItems)
                {
                    txtFoodmenu.Text = lvi.SubItems[2].Text;
                    txtIDmenu.Text = lvi.SubItems[0].Text;
                    nudPriceFood.Value = int.Parse(lvi.SubItems[3].Text);
                    foreach (CategoryDTO data in arrayCategory.ArrayListCategory)
                    {
                        if (lvi.SubItems[1].Text.Equals(data.Idcategory.ToString()))
                        {
                            txtCatFoodmenu.Text = data.Namecategory.ToString();
                            break;
                        }
                    }
                    txtUnitCount.Text = lvi.SubItems[4].Text;
                }
            }
            else MessageBox.Show("Chọn loại danh sách!");
        }




       
        private void btnEditCate_Click(object sender, EventArgs e)
        {
            if (cboTypeList.Text == "Danh sách liên kết")
            {
                FoodCategoryBUS.Instance.editCategory(ref listCategory, txtIDCat.Text, txtnmeCat.Text);
                loadTableCategory(listCategory);
                categories = FoodCategoryBUS.tolistCategory(listCategory);
                arrayCategory = FoodCategoryBUS.toArrayCategory(listCategory);
                MessageBox.Show("Thây đổi thành công!");
            }
            else if (cboTypeList.Text == "Danh sách đơn")
            {
                FoodCategoryBUS.Instance.editListCategory(ref categories, txtIDCat.Text, txtnmeCat.Text);
                loadTableCategory(categories);
                listCategory = FoodCategoryBUS.toLinkedListCategory(categories);
                arrayCategory = FoodCategoryBUS.toArrayCategory(categories);
                MessageBox.Show("Thây đổi thành công!");
            }
            else if (cboTypeList.Text == "Danh sách đặc")
            {
                FoodCategoryBUS.Instance.editArrayCategory(ref arrayCategory, txtIDCat.Text, txtnmeCat.Text);
                loadTableCategory(arrayCategory);
                listCategory = FoodCategoryBUS.toLinkedListCategory(arrayCategory);
                categories = FoodCategoryBUS.tolistCategory(arrayCategory);
                MessageBox.Show("Thây đổi thành công!");
            }
            else MessageBox.Show("Chọn loại danh sách!");
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            if (cboTypeList.Text == "Danh sách liên kết")
            {
                FoodBUS.Instance.editFood(ref ListFood, listCategory, txtIDmenu.Text, txtUnitCount.Text, txtFoodmenu.Text, (int)nudPriceFood.Value, txtCatFoodmenu.Text);
                Foods = FoodBUS.toListFood(ListFood);
                arrayfood = FoodBUS.toArrayFood(ListFood);
                loadTableFood(ListFood);
                MessageBox.Show("Thây đổi thành công!");
            }
            else if (cboTypeList.Text == "Danh sách đơn")
            {
                FoodBUS.Instance.editListFood(ref Foods, categories, txtIDmenu.Text, txtUnitCount.Text, txtFoodmenu.Text, (int)nudPriceFood.Value, txtCatFoodmenu.Text);
                ListFood = FoodBUS.toLinkedListFood(Foods);
                arrayfood = FoodBUS.toArrayFood(Foods);
                loadTableFood(Foods);
                MessageBox.Show("Thây đổi thành công!");
            }
            else if (cboTypeList.Text == "Danh sách đặc")
            {
                FoodBUS.Instance.editArrayFood(ref arrayfood, arrayCategory, txtIDmenu.Text, txtUnitCount.Text, txtFoodmenu.Text, (int)nudPriceFood.Value, txtCatFoodmenu.Text);
                Foods = FoodBUS.toListFood(arrayfood);
                ListFood = FoodBUS.toLinkedListFood(arrayfood);
                loadTableFood(arrayfood);
                MessageBox.Show("Thây đổi thành công!");
            }
        }
        #endregion

       
    }
}
