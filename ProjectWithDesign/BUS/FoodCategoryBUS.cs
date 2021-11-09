using ProjectWithDesign.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWithDesign.BUS
{

   
    class FoodCategoryBUS
    {
        private static FoodCategoryBUS instance;

        public static FoodCategoryBUS Instance
        {
            get { if (instance == null) instance = new FoodCategoryBUS(); return FoodCategoryBUS.instance; }
            private set { FoodCategoryBUS.instance = value; }
        }
        private FoodCategoryBUS() { }
        static public LinkedListFoodCategory fullLinkedListFoodCategory = takeLinkedListFoodCategory();
        static public List<CategoryDTO> listCategory = tolistCategory(fullLinkedListFoodCategory);
        static public ArrayCategory arrayCategory = toArrayCategory(fullLinkedListFoodCategory);

        #region lấy dslk từ sql
        public static LinkedListFoodCategory takeLinkedListFoodCategory()
        {
            string query = "select * from foodcategory order by idfoodcategory desc";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            LinkedListFoodCategory linkedList = new LinkedListFoodCategory();
            LinkedListFoodCategory temp = new LinkedListFoodCategory();
            foreach (DataRow row in table.Rows)
            {
                CategoryDTO data = new CategoryDTO(row);
                linkedList = adFoodCategory(data);
                linkedList.next = temp;
                temp = linkedList;
            }
            fullLinkedListFoodCategory = linkedList;
            return linkedList;
        }
        private static LinkedListFoodCategory adFoodCategory(CategoryDTO data)
        {
            LinkedListFoodCategory p = new LinkedListFoodCategory();
            p.data = data;
            p.next = null;
            return p;
        }
        #endregion

        #region chuyển cate

        #region linked list -> list
        static public List<CategoryDTO> tolistCategory(LinkedListFoodCategory listFoodCategory)
        {
            List<CategoryDTO> list = new List<CategoryDTO>();
            LinkedListFoodCategory p = listFoodCategory;
            while (p.next != null)
            {
                list.Add(p.data);
                p = p.next;
            }
            return list;
        }
        #endregion

        #region linked list -> array
        static public ArrayCategory toArrayCategory(LinkedListFoodCategory listCategory)
        {
            ArrayCategory array = new ArrayCategory();
            LinkedListFoodCategory p = listCategory;
            while (p.next != null)
            {
                array.ArrayListCategory[array.count++] = p.data;
                p = p.next;
            }
            return array;
        }
        #endregion

        #region list -> linked list
        static public LinkedListFoodCategory toLinkedListCategory(List<CategoryDTO> listCategory)
        {
            LinkedListFoodCategory p = new LinkedListFoodCategory();
            LinkedListFoodCategory temp = new LinkedListFoodCategory();
            foreach (CategoryDTO data in listCategory)
            {
                p = adFoodCategory(data);
                p.next = temp;
                temp = p;
            }
            return p;
        }
        #endregion

        #region list -> array
        static public ArrayCategory toArrayCategory(List<CategoryDTO> list)
        {
            ArrayCategory categories = new ArrayCategory();
            foreach(CategoryDTO data in list)
            {
                categories.ArrayListCategory[categories.count++] = data;
            }    
            return categories;
        }
        #endregion

        #region array -> list
        static public List<CategoryDTO> tolistCategory(ArrayCategory list)
        {
            List<CategoryDTO> categories = new List<CategoryDTO>();
            for(int i=0;i<list.count;i++)
            {
                categories.Add(list.ArrayListCategory[i]);
            }
            return categories;
        }
        #endregion

        #region array -> linked list
        static public LinkedListFoodCategory toLinkedListCategory(ArrayCategory arrayCategory)
        {
            LinkedListFoodCategory p = new LinkedListFoodCategory();
            LinkedListFoodCategory temp = new LinkedListFoodCategory();
            for (int i = 0; i < arrayCategory.count; i++)
            {
                p = adFoodCategory(arrayCategory.ArrayListCategory[i]);
                p.next = temp;
                temp = p;
            }
            return p;
        }
        #endregion

        #endregion

        #region Thêm

        #region Thêm category vào dslk

        public LinkedListFoodCategory newCategory(ref LinkedListFoodCategory listCate, string nameCategory)
        {
            LinkedListFoodCategory p = new LinkedListFoodCategory();
            p = listCate;
            int id = 1;

            while (checkIDCategory(listCate,id)!=false)
            {
                id++;
            }
            CategoryDTO category = new CategoryDTO(id, nameCategory);
            listCate = adFoodCategory(category);
            listCate.next = p;
            p = listCate;
            listCate = p;
            fullLinkedListFoodCategory = listCate;
            listCategory = tolistCategory(fullLinkedListFoodCategory);
            arrayCategory = toArrayCategory(fullLinkedListFoodCategory);
            return listCate;
        }
        private bool checkIDCategory(LinkedListFoodCategory listCategory, int id)
        {
            LinkedListFoodCategory p = listCategory;
            while (p.next != null)
            {
                if (p.data.Idcategory.Equals(id))
                    return true;
                p = p.next;
            }
            return false;
        }
        #endregion

        #region Thêm category vào list

        public List<CategoryDTO> newCategorytoList(ref List<CategoryDTO> list, string nameCategory)
        {
            int id = 1;
            while(checkIDListCategory(list, id)!=false)
            {
                id++;
            }
            CategoryDTO category = new CategoryDTO(id, nameCategory);
            list.Add(category);
            listCategory = list;
            fullLinkedListFoodCategory = toLinkedListCategory(listCategory);
            arrayCategory = toArrayCategory(listCategory);
            return list;
        }
        private bool checkIDListCategory(List<CategoryDTO> listCategory, int id)
        {
            foreach(CategoryDTO data in listCategory)
            {
                if (data.Idcategory.Equals(id))
                    return true;
            }
            return false;
        }
        #endregion

        #region Thêm category vào array

        public ArrayCategory newCategorytoArray(ref ArrayCategory list, string nameCategory)
        {
            int id = 1;
            while (checkIDArrayCategory(list, id) != false)
            {
                id++;
            }
            CategoryDTO category = new CategoryDTO(id, nameCategory);
            list.ArrayListCategory[list.count++] = category;
            arrayCategory = list;
            fullLinkedListFoodCategory = toLinkedListCategory(arrayCategory);
            listCategory = tolistCategory(arrayCategory);
            return list;
        }
        private bool checkIDArrayCategory(ArrayCategory listCategory, int id)
        {
            for (int i = 0; i < listCategory.count; i++)
            {
                if (listCategory.ArrayListCategory[i].Idcategory.Equals(id))
                    return true;
            }
            return false;
        }
        #endregion

        #endregion

        #region Xóa

        #region xóa 1 category  trong linked list
        public void delCategory(ref LinkedListFoodCategory listCate, int idCategory)
        {
            LinkedListFoodCategory p = new LinkedListFoodCategory();
            LinkedListFoodCategory pre = new LinkedListFoodCategory();
            if (listCate.data.Idcategory == idCategory)
                delFirst(ref listCate);
            else
            {
                p = listCate;
                pre = listCate;
                while (p.next != null && p.data.Idcategory != idCategory)
                {
                    pre = p;
                    p = p.next;
                }
                if (p != null)
                    pre.next = p.next;
            }
            fullLinkedListFoodCategory = listCate;
            listCategory = tolistCategory(fullLinkedListFoodCategory);
            arrayCategory = toArrayCategory(fullLinkedListFoodCategory);
        }
        private void delFirst(ref LinkedListFood listFood)
        {
            LinkedListFood p = new LinkedListFood();
            if (listFood != null)
            {
                p = listFood;
                listFood = p.next;
            }
        }
        private void delFirst(ref LinkedListFoodCategory listCategory)
        {
            LinkedListFoodCategory p = new LinkedListFoodCategory();
            if (listCategory != null)
            {
                p = listCategory;
                listCategory = p.next;
            }
        }
        #endregion

        #region Xóa 1 category tring list
        public void delCategoryInList(ref List<CategoryDTO> list, int idCategory)
        {
            for(int i=0;i<list.Count;i++)
            {
                if(list[i].Idcategory.Equals(idCategory))
                {
                    list.Remove(list[i]);
                }    
            }    
            listCategory = list;
            fullLinkedListFoodCategory = toLinkedListCategory(listCategory);
            arrayCategory = toArrayCategory(listCategory);
        }
        #endregion

        #region Xóa 1 category trong array
        public void delCategoryInArray(ref ArrayCategory list, int idCategory)
        {
            for (int i = 0; i < list.count; i++)
            {
                if (list.ArrayListCategory[i].Idcategory.Equals(idCategory))
                {
                    for (int j = i; j < list.count; j++)
                        list.ArrayListCategory[j] = list.ArrayListCategory[j + 1];
                    list.count = list.count - 1;
                    break;
                }
            }
            arrayCategory = list;
            fullLinkedListFoodCategory = toLinkedListCategory(arrayCategory);
            listCategory = tolistCategory(arrayCategory);
        }
        #endregion

        #endregion

        #region Sửa

        #region sửa thong tin của 1 category linked list
        public void editCategory(ref LinkedListFoodCategory foodCategory, string id, string name)
        {
            LinkedListFoodCategory p = new LinkedListFoodCategory();
            p = foodCategory;
            while (p.next != null)
            {
                if (p.data.Idcategory.Equals(int.Parse(id)))
                    p.data.Namecategory = name;
                p = p.next;
            }
            fullLinkedListFoodCategory = foodCategory;
            listCategory = tolistCategory(fullLinkedListFoodCategory);
            arrayCategory = toArrayCategory(fullLinkedListFoodCategory);
        }
        #endregion

        #region sửa thong tin của 1 category trong list
        public void editListCategory(ref List<CategoryDTO> foodCategory, string id, string name)
        {
           foreach(CategoryDTO data in foodCategory)
            {
                if (data.Idcategory.Equals(int.Parse(id)))
                    data.Namecategory = name;
            }
            listCategory = foodCategory;
            fullLinkedListFoodCategory = toLinkedListCategory(listCategory);
            arrayCategory = toArrayCategory(listCategory);
        }
        #endregion

        #region sửa thong tin của 1 category trong array
        public void editArrayCategory(ref ArrayCategory foodCategory, string id, string name)
        {
            for (int i = 0; i < foodCategory.count; i++)
            {
                if (foodCategory.ArrayListCategory[i].Idcategory.Equals(int.Parse(id)))
                    foodCategory.ArrayListCategory[i].Namecategory = name;
            }
            arrayCategory = foodCategory;
            fullLinkedListFoodCategory = toLinkedListCategory(arrayCategory);
            listCategory = tolistCategory(arrayCategory);
        }
        #endregion

        #endregion

        #region Tìm

        #region Tìm thông tin Category list
        public List<CategoryDTO> findInfo(List<CategoryDTO> list, string find)
        {
            List<CategoryDTO> newList = new List<CategoryDTO>();
            List<CategoryDTO> temp = new List<CategoryDTO>();
            temp = list;
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].Idcategory.ToString().ToLower() == find.ToLower())
                    newList.Add(list[i]);
                else
                {
                    string[] str = list[i].Namecategory.Split(' ');
                    for (int j = 0; j < str.Length; j++)
                        if (str[j].ToLower() == find.ToLower())
                            newList.Add(list[i]);
                }
            }
            return newList;
        }
        #endregion

        #region Tìm thông tin Category linked list

        public LinkedListFoodCategory FindCategory(LinkedListFoodCategory list, string find)
        {
            LinkedListFoodCategory temp = new LinkedListFoodCategory();
            temp = list;
            LinkedListFoodCategory p = new LinkedListFoodCategory();
            LinkedListFoodCategory get = new LinkedListFoodCategory();
            while (temp.next != null)
            {
                if (temp.data.Idcategory.ToString().ToLower().Equals(find.ToLower()))
                {
                    p = adFoodCategory(temp.data);
                    p.next = get;
                    get = p;
                }
                else
                {
                    string[] str = temp.data.Namecategory.Split(' ');
                    for (int i = 0; i < str.Length; i++)
                        if (str[i].ToLower().Equals(find.ToLower()))
                        {
                            p = adFoodCategory(temp.data);
                            p.next = get;
                            get = p;
                        }
                }
                temp = temp.next;
            }
            return get;
        }


        #endregion

        #region Tìm thông tin Category array
        public ArrayCategory findInfoArray(ArrayCategory array, string find)
        {
            ArrayCategory newList = new ArrayCategory();
            ArrayCategory temp = new ArrayCategory();
            temp = array;
            for (int i = 0; i < temp.count; i++)
            {
                if (temp.ArrayListCategory[i].Idcategory.ToString().ToLower() == find.ToLower())
                    newList.ArrayListCategory[newList.count++] = temp.ArrayListCategory[i];
                else
                {
                    string[] str = temp.ArrayListCategory[i].Namecategory.Split(' ');
                    for (int j = 0; j < str.Length; j++)
                        if (str[j].ToLower() == find.ToLower())
                            newList.ArrayListCategory[newList.count++] = temp.ArrayListCategory[i];
                }
            }
            return newList;
        }
        #endregion

        #endregion

        #region return 

        #region Linked List Category
        public static LinkedListFoodCategory returnLinkedListFoodCategory()
        {
            return fullLinkedListFoodCategory;
        }
        #endregion

        #region list Category
        public static List<CategoryDTO> returnListFoodCategory()
        {
            return listCategory;
        }
        #endregion

        #region array Category
        public static ArrayCategory returnArrayFoodCategory()
        {
            return arrayCategory;
        }
        #endregion

        #endregion

    }
}
