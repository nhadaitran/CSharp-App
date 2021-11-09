using ProjectWithDesign.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDesign.BUS
{
   
    class FoodBUS
    {
        private static FoodBUS instance;

        public static FoodBUS Instance
        {
            get { if (instance == null) instance = new FoodBUS(); return FoodBUS.instance; }
            private set { FoodBUS.instance = value; }
        }
        private FoodBUS() { }

        static LinkedListFood fullListFood = takeLinkedList();
        static List<FoodDTO> fullFood = toListFood(fullListFood);
        static ArrayFood arraylistFood = toArrayFood(fullListFood);

        #region lấy ds từ sql
        private static LinkedListFood takeLinkedList()
        {
            string query = "select * from food order by idfoodcategory desc";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            LinkedListFood linkedList = new LinkedListFood();
            LinkedListFood temp = new LinkedListFood();
            foreach (DataRow row in table.Rows)
            {
                FoodDTO food = new FoodDTO(row);
                linkedList = adFood(food);
                linkedList.next = temp;
                temp = linkedList;
            }
            fullListFood = linkedList;
            return linkedList;
        }
        private static LinkedListFood adFood(FoodDTO temp)
        {
            LinkedListFood p = new LinkedListFood();
            p.data = temp;
            p.next = null;
            return p;
        }
        public LinkedListFood LinkedListFood()
        {
            return takeLinkedList();
        }
        #endregion

        #region chuyển đổi ds

        #region dslk -> list
        public static List<FoodDTO> toListFood(LinkedListFood linkedList)
        {
            List<FoodDTO> list = new List<FoodDTO>();
            LinkedListFood p = linkedList;
            while (p.next != null)
            {
                list.Add(p.data);
                p = p.next;
            }
            return list;
        }
        #endregion

        #region dslk -> array
        static public ArrayFood toArrayFood(LinkedListFood listFood)
        {
            ArrayFood array = new ArrayFood();
            LinkedListFood p = listFood;
            while (p.next != null)
            {
                array.ArrayListFood[array.count++] = p.data;
                p = p.next;
            }
            return array;
        }
        #endregion

        #region array -> dslk
        public static LinkedListFood toLinkedListFood(ArrayFood arrayFood)
        {
            LinkedListFood p = new LinkedListFood();
            LinkedListFood temp = new LinkedListFood();
            for (int i = 0; i < arrayFood.count; i++)
            {
                p = adFood(arrayFood.ArrayListFood[i]);
                p.next = temp;
                temp = p;
            }
            return p;
        }
        #endregion

        #region array -> list
        public static List<FoodDTO> toListFood(ArrayFood array)
        {
            List<FoodDTO> categories = new List<FoodDTO>();
            for(int i=0;i<array.count;i++)
            {
                categories.Add(array.ArrayListFood[i]);
            }    
            return categories;
        }
        #endregion

        #region list -> dslk
        public static LinkedListFood toLinkedListFood(List<FoodDTO> listFood)
        {
            LinkedListFood p = new LinkedListFood();
            LinkedListFood temp = new LinkedListFood();
            foreach (FoodDTO data in listFood)
            {
                p = adFood(data);
                p.next = temp;
                temp = p;
            }
            return p;
        }

        #endregion

        #region list -> array
        public static ArrayFood toArrayFood(List<FoodDTO> list)
        {
            ArrayFood food = new ArrayFood();
            foreach(FoodDTO data in list)
            {
                food.ArrayListFood[food.count++] = data;
            }    
            return food;
        }
        #endregion

        #endregion

        #region Thêm

        #region thêm món ăn linked list
        public LinkedListFood newFood(ref LinkedListFood listFood, string unitcount, string namefood, int pricefood, int iddoodcategory, LinkedListFoodCategory foodCategory)
        {
            LinkedListFood p = new LinkedListFood();
            p = listFood;
            LinkedListFood temp = new LinkedListFood();
            temp = listFood;
            int count = 1;
            string str = null;
            LinkedListFoodCategory c = foodCategory;
            string id = null;
            while (c.next != null)
            {
                if (iddoodcategory.Equals(c.data.Idcategory))
                {
                    string[] a = c.data.Namecategory.Split(' ');
                    if (a[a.Length - 1] != "nướng")
                        str = a[a.Length - 1].Substring(0, 1).ToUpper();
                    else str = "M";
                }
                c = c.next;
            }
            id = str + count.ToString();
            while (checkIDFood(listFood, id) != false)
            {
                count++;
                id = str + count.ToString();
            }
            FoodDTO food = new FoodDTO(id, unitcount, namefood, pricefood, iddoodcategory);
            listFood = adFood(food);
            listFood.next = p;
            p = listFood;
            listFood = p;
            fullListFood = listFood;
            fullFood = toListFood(fullListFood);
            arraylistFood = toArrayFood(fullListFood);
            return listFood;
        }
        private bool checkIDFood(LinkedListFood listFood, string id)
        {
            LinkedListFood temp = listFood;
            while (temp.next != null)
            {
                if (id.Equals(temp.data.Idfood))
                    return true;
                temp = temp.next;
            }
            return false;

        }
        #endregion

        #region Thêm món ăn vào list
        public List<FoodDTO> newFoodtoList(ref List<FoodDTO> listFood, string unitcount, string namefood, int pricefood, int iddoodcategory, List<CategoryDTO> foodCategory)
        {
            int count = 1;
            string str = null;
            List<CategoryDTO> c = foodCategory;
            string id = null;
            foreach (CategoryDTO data in foodCategory)
            {
                if (iddoodcategory.Equals(data.Idcategory))
                {
                    string[] a = data.Namecategory.Split(' ');
                    if (a[a.Length - 1] != "nướng")
                        str = a[a.Length - 1].Substring(0, 1).ToUpper();
                    else str = "M";
                }
            }
            id = str + count.ToString();
            while (checkIDListFood(listFood, id) != false)
            {
                count++;
                id = str + count.ToString();
            }
            FoodDTO food = new FoodDTO(id, unitcount, namefood, pricefood, iddoodcategory);
            listFood.Add(food);
            fullFood = listFood;
            fullListFood = toLinkedListFood(fullFood);
            arraylistFood = toArrayFood(fullFood);
            return listFood;
        }
        private bool checkIDListFood(List<FoodDTO> listFood, string id)
        {
            foreach (FoodDTO data in listFood)
            {
                if (id.Equals(data.Idfood))
                    return true;
            }
            return false;
        }
        #endregion

        #region Them món ăn vào array
        public ArrayFood newFoodtoArray(ref ArrayFood listFood, string idfood, string unitcount, string namefood, int pricefood, int iddoodcategory, ArrayCategory foodCategory)
        {
            int count = 1;
            string str = null;
            ArrayCategory c = foodCategory;
            string id = null;
            for (int i = 0; i < c.count; i++)
            {
                if (iddoodcategory.Equals(c.ArrayListCategory[i].Idcategory))
                {
                    string[] a = c.ArrayListCategory[i].Namecategory.Split(' ');
                    if (a[a.Length - 1] != "nướng")
                        str = a[a.Length - 1].Substring(0, 1).ToUpper();
                    else str = "M";
                }
            }
            id = str + count.ToString();
            while (checkIDArrayFood(listFood, id) != false)
            {
                count++;
                id = str + count.ToString();
            }
            FoodDTO food = new FoodDTO(id, unitcount, namefood, pricefood, iddoodcategory);
            listFood.ArrayListFood[listFood.count++] = food;
            fullListFood = toLinkedListFood(listFood);
            fullFood = toListFood(listFood);
            return listFood;
        }
        private bool checkIDArrayFood(ArrayFood listFood, string id)
        {
            for (int i = 0; i < listFood.count; i++)
            {
                if (id.Equals(listFood.ArrayListFood[i].Idfood))
                    return true;
            }
            return false;
        }
        #endregion

        #endregion

        #region Xóa

        #region Xóa món ăn linked list theo id food
        public void delFood(ref LinkedListFood listFood, string idfood)
        {
            LinkedListFood p = new LinkedListFood();
            LinkedListFood pre = new LinkedListFood();
            if (listFood.data.Idfood == idfood)
                delFirst(ref listFood);
            else
            {
                p = listFood;
                pre = listFood;
                while (p.next != null && p.data.Idfood != idfood)
                {
                    pre = p;
                    p = p.next;
                }
                if (p != null)
                    pre.next = p.next;
            }
            fullListFood = listFood;
            fullFood = toListFood(fullListFood);
            arraylistFood = toArrayFood(fullListFood);
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
        #endregion

        #region Xóa món ăn list theo idFood
        public void delListFood(ref List<FoodDTO> listFood, string idfood)
        {
            for (int i = 0; i < listFood.Count; i++)
            {
                if (listFood[i].Idfood.Equals(idfood))
                    listFood.RemoveAt(i);
            }
            fullFood = listFood;
            fullListFood = toLinkedListFood(fullFood);
            arraylistFood = toArrayFood(fullFood);
        }
        #endregion

        #region Xóa món ăn list theo idCategory
        public void delListFoodbyIdCate(ref List<FoodDTO> listFood, int idCategory)
        {
            for (int i = 0; i < listFood.Count; i++)
            {
                if (listFood[i].Idfoodcategory.Equals(idCategory))
                {
                    listFood.RemoveAt(i);
                    i--;
                }

            }
            fullFood = listFood;
            fullListFood = toLinkedListFood(fullFood);
            arraylistFood = toArrayFood(fullFood);
        }
        #endregion

        #region Xóa món ăn array theo idfood
        public void delArrayFood(ref ArrayFood listFood, string idfood)
        {
            for (int i = 0; i < listFood.count; i++)
            {
                if (listFood.ArrayListFood[i].Idfood.Equals(idfood))
                {
                    for (int j = i; j < listFood.count; j++)
                        listFood.ArrayListFood[j] = listFood.ArrayListFood[j + 1];
                    listFood.count = listFood.count - 1;
                    break;
                }
            }
            arraylistFood = listFood;
            fullListFood = toLinkedListFood(arraylistFood);
            fullFood = toListFood(arraylistFood);
        }
        #endregion

        #region Xóa món ăn array theo idCaterory
        public void delArrayFoodbyIdCate(ref ArrayFood listFood, int idCategory)
        {
            for (int i = 0; i < listFood.count; i++)
            {
                if (listFood.ArrayListFood[i].Idfoodcategory.Equals(idCategory))
                {
                    for (int j = i; j < listFood.count; j++)
                        listFood.ArrayListFood[j] = listFood.ArrayListFood[j + 1];
                    i--;
                    listFood.count = listFood.count - 1;
                }
            }
            arraylistFood = listFood;
            fullListFood = toLinkedListFood(arraylistFood);
            fullFood = toListFood(arraylistFood);
        }
        #endregion

        #endregion

        #region Sửa

        #region Edit food linked list
        public void editFood(ref LinkedListFood listFood, LinkedListFoodCategory linked, string idfood, string unitcount, string namefood, int pricefood, string iddoodcategory)
        {
            LinkedListFood p = new LinkedListFood();
            p = listFood;
            while (p.next != null)
            {
                if (p.data.Idfood == idfood)
                {
                    p.data.Unitcount = unitcount;
                    p.data.Namefood = namefood;
                    p.data.Pricefood = pricefood;
                    LinkedListFoodCategory listCategory = linked;
                    while (listCategory.next != null)
                    {
                        if (iddoodcategory.Equals(listCategory.data.Namecategory))
                            p.data.Idfoodcategory = listCategory.data.Idcategory;
                        listCategory = listCategory.next;
                    }
                }
                p = p.next;
            }
            fullListFood = listFood;
            fullFood = toListFood(fullListFood);
            arraylistFood = toArrayFood(fullListFood);
        }
        #endregion

        #region Edit food list
        public void editListFood(ref List<FoodDTO> listFood, List<CategoryDTO> linked, string idfood, string unitcount, string namefood, int pricefood, string iddoodcategory)
        {
           foreach(FoodDTO data in listFood)
            {
                if (data.Idfood == idfood)
                {
                    data.Unitcount = unitcount;
                    data.Namefood = namefood;
                    data.Pricefood = pricefood;
                    foreach (CategoryDTO cate in linked)
                    {
                        if (iddoodcategory.Equals(cate.Namecategory))
                            data.Idfoodcategory = cate.Idcategory;
                    }
                }
            }
            fullFood = listFood;
            fullListFood = toLinkedListFood(fullFood);
            arraylistFood = toArrayFood(fullFood);
        }
        #endregion

        #region Edit food array

        public void editArrayFood(ref ArrayFood listFood, ArrayCategory listCategory, string idfood, string unitcount, string namefood, int pricefood, string iddoodcategory)
        {
            for (int i = 0; i < listFood.count; i++)
            {
                if (listFood.ArrayListFood[i].Idfood == idfood)
                {
                    listFood.ArrayListFood[i].Unitcount = unitcount;
                    listFood.ArrayListFood[i].Namefood = namefood;
                    listFood.ArrayListFood[i].Pricefood = pricefood;
                    for (int j = 0; j < listCategory.count; j++)
                    {
                        if (iddoodcategory.Equals(listCategory.ArrayListCategory[i].Namecategory))
                            listFood.ArrayListFood[i].Idfoodcategory = listCategory.ArrayListCategory[i].Idcategory;
                    }
                }
            }
            arraylistFood = listFood;
            fullListFood = toLinkedListFood(arraylistFood);
            fullFood = toListFood(arraylistFood);
        }
        #endregion

        #endregion

        #region tìm

        #region find food linked list
        public LinkedListFood result(LinkedListFood list, string find)
        {
            LinkedListFood p = new LinkedListFood();
            LinkedListFood result = new LinkedListFood();
            LinkedListFood temp = new LinkedListFood();
            temp = list;
            while (temp.next != null) 
            {
                string[] str = temp.data.Namefood.Split(' ');
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j].ToLower() == find.ToLower())
                    {
                        result = adFood(temp.data);
                        result.next = p;
                        p = result;
                    }    
                }
                if (find.ToLower().Contains(temp.data.Idfood.ToLower()))
                {
                    result = adFood(temp.data);
                    result.next = p;
                    p = result;
                }
                else if (find.IndexOf(temp.data.Idfoodcategory.ToString().ToLower()) != -1)
                {
                    result = adFood(temp.data);
                    result.next = p;
                    p = result;
                }
                else if (find.IndexOf(temp.data.Unitcount.ToLower()) != -1)
                {
                    result = adFood(temp.data);
                    result.next = p;
                    p = result;
                }
                else if (find.Equals(temp.data.Pricefood.ToString().ToLower()))
                {
                    result = adFood(temp.data);
                    result.next = p;
                    p = result;
                }
                temp = temp.next;
            }
            return result;
        }
        #endregion

        #region find food list
        public List<FoodDTO> resultList(List<FoodDTO> list, string find)
        {
            List<FoodDTO> result = new List<FoodDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                string[] str = list[i].Namefood.Split(' ');
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j].ToLower() == find.ToLower())
                        result.Add(list[i]);
                }
                if (find.ToLower().Contains(list[i].Idfood.ToLower()))
                    result.Add(list[i]);
                else if (find.IndexOf(list[i].Idfoodcategory.ToString().ToLower()) != -1)
                    result.Add(list[i]);
                else if (find.IndexOf(list[i].Unitcount.ToLower()) != -1)
                    result.Add(list[i]);
                else if (find.Equals(list[i].Pricefood.ToString().ToLower()))
                    result.Add(list[i]);
            }
            return result;
        }
        #endregion

        #region find food array
        public ArrayFood resultArray(ArrayFood list, string find)
        {
            ArrayFood result = new ArrayFood();
            for (int i = 0; i < list.count; i++)
            {
                string[] str = list.ArrayListFood[i].Namefood.Split(' ');
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j].ToLower() == find.ToLower())
                        result.ArrayListFood[result.count++] = list.ArrayListFood[i];
                }
                if (find.ToLower().Contains(list.ArrayListFood[i].Idfood.ToLower()))
                    result.ArrayListFood[result.count++] = list.ArrayListFood[i];
                else if (find.IndexOf(list.ArrayListFood[i].Idfoodcategory.ToString().ToLower()) != -1)
                    result.ArrayListFood[result.count++] = list.ArrayListFood[i];
                else if (find.IndexOf(list.ArrayListFood[i].Unitcount.ToLower()) != -1)
                    result.ArrayListFood[result.count++] = list.ArrayListFood[i];
                else if (find.Equals(list.ArrayListFood[i].Pricefood.ToString().ToLower()))
                    result.ArrayListFood[result.count++] = list.ArrayListFood[i];
            }
            return result;
        }
        #endregion
        
        #endregion

        #region return

        #region Linked List Food
        public static LinkedListFood returnLinkedListFood()
        {
            return fullListFood;
        }
        #endregion

        #region  List Food
        public static List<FoodDTO> returnListFood()
        {
            return fullFood;
        }
        #endregion

        #region Array
        public static ArrayFood returnArrayFood()
        {
            return arraylistFood;
        }
        #endregion

        #endregion
    }
}
