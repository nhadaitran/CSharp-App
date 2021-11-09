using System;
using System.Collections.Generic;
using ProjectWithDesign.DTO;

namespace ProjectWithDesign.BUS
{
    class BillBUS
    {
        private static BillBUS instance;

        public static BillBUS Instance
        {
            get { if (instance == null) instance = new BillBUS(); return BillBUS.instance; }
            private set { BillBUS.instance = value; }
        }
        public BillBUS() { }


        private static ArrayBill arrayBillPayed = new ArrayBill();
        private static LinkedListBillPayed linkedListBillPayed = new LinkedListBillPayed();
        private static List<ListBill> listBillPayed = new List<ListBill>();

        #region Update bill after changing table
        public void UpdateIdTable(int idCurrent, int idTableChange)
        {
            LinkedListBillPayed temp = new LinkedListBillPayed();
            temp = linkedListBillPayed;
            while(temp.next!=null)
            {
                if (temp.satusBill == false)
                    if (temp.data.Idtable.Equals(idCurrent))
                        temp.data.Idtable = idTableChange;
                temp = temp.next;
            }    
        }
        #endregion
        

        #region Array

        #region Take Payed bill
        public ArrayBill getPayedBill(int discount, int idTable, ArrayBillInfo infoBill, bool statusBill)
        {
            ArrayBill temp2 = new ArrayBill();
            temp2 = arrayBillPayed;
            for (int i = 0; i < temp2.count; i++)
            {
                if (temp2.ArrayListBill[i].data.Idtable == idTable && temp2.ArrayListBill[i].statusBill == false)
                {
                    delBilPayed(temp2.ArrayListBill[i].data.Idbill, ref arrayBillPayed);
                    break;
                }
            }
            int id = 1;
            while (checkID(arrayBillPayed, id) != false)
            {
                id++;
            }
            DateTime date = DateTime.Today;
            int totalMoney = 0;
            ArrayBillInfo price = new ArrayBillInfo();
            price = infoBill;
            for (int j = 0; j < price.count; j++)
            {
                totalMoney += price.ArrayListBillInfo[j].TotalPrice;
            }
            int totalAfterDis = totalMoney - (totalMoney * discount / 100);
            BillDTO data = new BillDTO(id, idTable, discount, totalAfterDis, date);
            ArrayBillInfo info = infoBill;
            Bill newBill = new Bill();
            newBill.data = data;
            newBill.info = info;
            newBill.statusBill = statusBill;
            arrayBillPayed.ArrayListBill[arrayBillPayed.count++] = newBill;
            listBillPayed = BillBUS.instance.ArraytoList(arrayBillPayed);
            linkedListBillPayed = BillBUS.instance.ListtoLinkedList(listBillPayed);
            return arrayBillPayed;
        }
        private bool checkID(ArrayBill list, int id)
        {
            ArrayBill p = new ArrayBill();
            p = list;
            for (int i = 0; i < p.count; i++)
            {
                if (p.ArrayListBill[i].data.Idbill.Equals(id))
                    return true;
            }
            return false;

        }
        #endregion


        #region Update bill food
        public ArrayBill UpdateArrrayBill(int idBill, ArrayBillInfo billinfo)
        {
            ArrayBill listbill = arrayBillPayed;
            for (int i = 0; i < listbill.count; i++)
            {
                if (listbill.ArrayListBill[i].data.Idbill.Equals(idBill))
                    listbill.ArrayListBill[i].info = billinfo;
                break;
            }
            arrayBillPayed = listbill;
            listBillPayed = BillBUS.instance.ArraytoList(arrayBillPayed);
            linkedListBillPayed = BillBUS.instance.ListtoLinkedList(listBillPayed);
            return listbill;
        }
        #endregion

        #region Delete Bill
        public void delBilPayed(int id, ref ArrayBill billPayed)
        {
            for (int i = 0; i < billPayed.count; i++)
                if (billPayed.ArrayListBill[i].data.Idbill == id)
                {
                    for (int j = i; j < billPayed.count; j++)
                        billPayed.ArrayListBill[j] = billPayed.ArrayListBill[j + 1];
                    billPayed.count = billPayed.count - 1;
                    break;
                }
        }
        #endregion

        #region return bill for using
        public static ArrayBill returnArrayBillPayed()
        {
            return arrayBillPayed;
        }
        #endregion

        #region addFoodtoBill
        //public void addFoodtoBill(int idBill, string idFood, int dishCount)
        //{
        //    ArrayBill p = arrayBillPayed;
        //    ArrayFood food = FoodBUS.returnArrayFood();
        //    FoodDTO data = new FoodDTO();
        //    for (int i = 0; i < food.count; i++)
        //        if (food.ArrayListFood[i].Idfood.Equals(idFood))
        //        {
        //            data = food.ArrayListFood[i];
        //            break;
        //        }
        //    for (int j = 0; j < p.count; j++)
        //    {
        //        if (p.ArrayListBill[j].data.Idbill.Equals(idBill))
        //        {
        //            int total = data.Pricefood * dishCount;
        //            BillInfoDTO bill = new BillInfoDTO(dishCount, idFood, data.Namefood, data.Pricefood, total);
        //            ArrayBillInfo temp = new ArrayBillInfo();
        //            ArrayBillInfo temp2 = new ArrayBillInfo();
        //            p.ArrayListBill[j].info.ArrayListBillInfo[temp.count++] = bill;
        //            break;
        //        }
        //    }
        //    arrayBillPayed = p;
        //    listBillPayed = BillBUS.instance.ArraytoList(arrayBillPayed);
        //    linkedListBillPayed = BillBUS.instance.ArraytoLinkedList(arrayBillPayed);
        //}
        #endregion

        #region Delete Food
        //public void delFoodtoBill(int idBill, string idFood, ref ArrayBill arrayBillPayed)
        //{
        //    ArrayBill p = arrayBillPayed;
        //    ArrayFood food = FoodBUS.returnArrayFood();
        //    FoodDTO data = new FoodDTO();
        //    for (int i = 0; i < food.count; i++)
        //        if (food.ArrayListFood[i].Idfood.Equals(idFood))
        //        {
        //            data = food.ArrayListFood[i];
        //            break;
        //        }
        //    for (int j = 0; j < p.count; j++)
        //    {
        //        if (p.ArrayListBill[j].data.Idbill.Equals(idBill))
        //        {
        //            for (int k = 0; k < p.ArrayListBill[j].info.count; k++)
        //                if (p.ArrayListBill[j].info.ArrayListBillInfo[k].Idfood == idFood)
        //                {
        //                    for (int x = k; x < p.ArrayListBill[j].info.count; x++)
        //                        p.ArrayListBill[j].info.ArrayListBillInfo[x] = p.ArrayListBill[j].info.ArrayListBillInfo[x + 1];
        //                    p.ArrayListBill[j].info.count = p.ArrayListBill[j].info.count - 1;
        //                    break;
        //                }
        //            break;
        //        }
        //    }            

        //}
        #endregion

        #endregion

        #region LinkedList
        #region Take Payed bill
        public LinkedListBillPayed getPayedLinkedBill(int discount, int idTable, LinkedListBill infoBill, bool statusBill)
        {
            LinkedListBillPayed temp2 = new LinkedListBillPayed();
            temp2 = linkedListBillPayed;
            while (temp2.next != null)
            {
                if (temp2.data.Idtable == idTable && temp2.satusBill == false)
                {
                    delLinkedBilPayed(temp2.data.Idbill, ref linkedListBillPayed);
                    break;
                }
                temp2 = temp2.next;
            }
            LinkedListBillPayed p = new LinkedListBillPayed();
            LinkedListBillPayed temp = new LinkedListBillPayed();
            temp = linkedListBillPayed;
            int id = 1;
            while (checkIDLinked(linkedListBillPayed, id) != false)
            {
                id++;
            }
            DateTime date = DateTime.Today;
            int totalMoney = 0;
            LinkedListBill price = new LinkedListBill();
            price = infoBill;
            while (price.next != null)
            {
                totalMoney += price.data.TotalPrice;
                price = price.next;
            }
            int totalAfterDis = totalMoney - (totalMoney * discount / 100);
            BillDTO data = new BillDTO(id, idTable, discount, totalAfterDis, date);
            LinkedListBill info = infoBill;
            p = addNewBill(data, info);
            p.next = temp;
            p.satusBill = statusBill;
            temp = p;
            linkedListBillPayed = temp;
            listBillPayed = BillBUS.instance.LinkedListtoList(linkedListBillPayed);
            arrayBillPayed = BillBUS.instance.LinkedListtoArray(linkedListBillPayed);
            return linkedListBillPayed;
        }

        private LinkedListBillPayed addNewBill(BillDTO data, LinkedListBill dataInfo)
        {
            LinkedListBillPayed p = new LinkedListBillPayed();
            p.data = data;
            p.info = dataInfo;
            p.next = null;
            return p;
        }
        private bool checkIDLinked(LinkedListBillPayed list, int id)
        {
            LinkedListBillPayed p = new LinkedListBillPayed();
            p = list;
            while (p.next != null)
            {
                if (p.data.Idbill.Equals(id))
                    return true;
                p = p.next;
            }
            return false;

        }
        #endregion

        #region Update bill table changed
        public void UpdateIdLinkedTable(int idCurrent, int idTableChange)
        {
            LinkedListBillPayed temp = new LinkedListBillPayed();
            temp = linkedListBillPayed;
            while (temp.next != null)
            {
                if (temp.satusBill == false)
                    if (temp.data.Idtable.Equals(idCurrent))
                        temp.data.Idtable = idTableChange;
                temp = temp.next;
            }
            linkedListBillPayed = temp;
            listBillPayed = BillBUS.instance.LinkedListtoList(linkedListBillPayed);
            arrayBillPayed = BillBUS.instance.LinkedListtoArray(linkedListBillPayed);
        }
        #endregion

        #region Update bill food
        public LinkedListBillPayed UpdateLinkedBill(int idBill, LinkedListBill billinfo)
        {
            LinkedListBillPayed listbill = linkedListBillPayed;
            while (listbill.next != null && listbill.data.Idbill.Equals(idBill)==false)
            {
                listbill = listbill.next;
            }
            BillDTO temp = new BillDTO();
            LinkedListBill temp1 = new LinkedListBill();
            temp1 = billinfo;
            float total = 0;
            temp.Totalmoney = 0;
            while (temp1.next != null)
            {
                total += temp1.data.Countdish * temp1.data.Price;
                temp1 = temp1.next;
            }
            BillDTO data = new BillDTO(temp.Idbill, temp.Idtable, temp.Discount, total, temp.Saletime);
            listbill.data = data;
            listbill.info = billinfo;
            arrayBillPayed = BillBUS.instance.LinkedListtoArray(linkedListBillPayed);
            listBillPayed = BillBUS.instance.LinkedListtoList(linkedListBillPayed);
            return linkedListBillPayed;
        }
        #endregion

        #region Delete Bill
        public void delLinkedBilPayed(int id, ref LinkedListBillPayed billPayed)
        {
            LinkedListBillPayed p = new LinkedListBillPayed();
            LinkedListBillPayed pre = new LinkedListBillPayed();
            if (billPayed.data.Idbill == id)
                delFirst(ref billPayed);
            else
            {
                p = billPayed;
                pre = billPayed;
                while (p.next != null && p.data.Idbill != id)
                {
                    pre = p;
                    p = p.next;
                }
                if (p != null)
                    pre.next = p.next;
            }
            linkedListBillPayed = billPayed;
            listBillPayed = BillBUS.instance.LinkedListtoList(linkedListBillPayed);
            arrayBillPayed = BillBUS.instance.LinkedListtoArray(linkedListBillPayed);
        }
        private void delFirst(ref LinkedListBillPayed list)
        {
            LinkedListBillPayed p = new LinkedListBillPayed();
            if (list != null)
            {
                p = list;
                list = p.next;
            }
        }
        #endregion

        #region return bill for using
        public static LinkedListBillPayed returnLinkedListBillPayed()
        {
            return linkedListBillPayed;
        }
        #endregion

        #region addFoodtoBill
        //public void addFoodtoLinkedBill(int idBill, string idFood, int dishCount)
        //{
        //    LinkedListBillPayed p = linkedListBillPayed;
        //    LinkedListFood food = FoodBUS.returnLinkedListFood();
        //    FoodDTO data = new FoodDTO();
        //    while (food.next != null)
        //    {
        //        if (food.data.Idfood.Equals(idFood))
        //        {
        //            data = food.data;
        //            break;
        //        }
        //        food = food.next;
        //    }
        //    while (p.next != null)
        //    {
        //        if (p.data.Idbill.Equals(idBill))
        //        {
        //            int total = data.Pricefood * dishCount;
        //            BillInfoDTO bill = new BillInfoDTO(dishCount, idFood, data.Namefood, data.Pricefood, total);
        //            LinkedListBill temp = new LinkedListBill();
        //            temp = p.info;
        //            LinkedListBill temp2 = new LinkedListBill();
        //            temp2 = p.info;
        //            temp = adFoodToBill(bill);
        //            temp.next = temp2;
        //            temp2 = temp;
        //            p.info = temp2;
        //        }
        //        p = p.next;
        //    }
        //    listBillPayed = BillBUS.instance.LinkedListtoList(linkedListBillPayed);
        //}
        private LinkedListBill adFoodToBill(BillInfoDTO temp)
        {
            LinkedListBill p = new LinkedListBill();
            p.data = temp;
            p.next = null;
            return p;
        }
        #endregion

        #region Delete Food
        //public void delFoodtoLinkedBill(int idBill, string idFood, ref LinkedListBillPayed listBillPayed)
        //{
        //    LinkedListBillPayed p = listBillPayed;
        //    LinkedListFood food = FoodBUS.returnLinkedListFood();
        //    FoodDTO data = new FoodDTO();
        //    while (food.next != null)
        //    {
        //        if (food.data.Idfood.Equals(idFood))
        //        {
        //            data = food.data;
        //            break;
        //        }
        //        food = food.next;
        //    }
        //    while (p.next != null)
        //    {
        //        if (p.data.Idbill.Equals(idBill))
        //        {
        //            LinkedListBill temp = new LinkedListBill();
        //            LinkedListBill pre = new LinkedListBill();
        //            if (p.info.data.Idfood == idFood)
        //                delFirst(ref p.info);
        //            else
        //            {
        //                temp = p.info;
        //                pre = p.info;
        //                while (temp.next != null && temp.data.Idfood != idFood)
        //                {
        //                    pre = temp;
        //                    temp = temp.next;
        //                }
        //                if (temp != null)
        //                    pre.next = temp.next;
        //            }
        //        }
        //        p = p.next;
        //    }

        //}
        //private void delFirst(ref LinkedListBill list)
        //{
        //    LinkedListBill p = new LinkedListBill();
        //    p = list;
        //    if (list != null)
        //    {
        //        p = list;
        //        list = p.next;
        //    }
        //}
        #endregion

        #endregion

        #region List

        #region Take Payed bill
        public List<ListBill> getPayedListBill(int discount, int idTable, List<BillInfoDTO> infoBill, bool statusBill)
        {
            List<ListBill> temp2 = new List<ListBill>();
            temp2 = listBillPayed;
            foreach (ListBill item in temp2)
            {
                if (item.data.Idtable == idTable && item.statusBill == false)
                {
                    delListBilPayed(item.data.Idbill, ref listBillPayed);
                    break;
                }
            }
            int id = 1;
            while (checkIDList(listBillPayed, id) != false)
            {
                id++;
            }
            DateTime date = DateTime.Today;
            int totalMoney = 0;
            List<BillInfoDTO> price = new List<BillInfoDTO>();
            price = infoBill;
            foreach (BillInfoDTO item in price)
            {
                totalMoney += item.TotalPrice;
            }
            int totalAfterDis = totalMoney - (totalMoney * discount / 100);
            BillDTO data = new BillDTO(id, idTable, discount, totalAfterDis, date);
            List<BillInfoDTO> info = infoBill;
            ListBill newBill = new ListBill();
            newBill.data = data;
            newBill.info = info;
            newBill.statusBill = statusBill;
            listBillPayed.Add(newBill);
            arrayBillPayed = BillBUS.instance.ListToArray(listBillPayed);
            linkedListBillPayed = BillBUS.instance.ListtoLinkedList(listBillPayed);
            return listBillPayed;
        }
        private bool checkIDList(List<ListBill> list, int id)
        {
            List<ListBill> p = new List<ListBill>();
            foreach (ListBill item in list)
            {
                if (item.data.Idbill.Equals(id))
                    return true;
            }
            return false;
        }
        #endregion

        #region Update bill table changed
        public void UpdateIdListTable(int idCurrent, int idTableChange)
        {
            foreach (ListBill item in listBillPayed)
            {
                if (item.statusBill == false)
                    if (item.data.Idtable.Equals(idCurrent))
                        item.data.Idtable = idTableChange;
                break;
            }
            arrayBillPayed = BillBUS.instance.ListToArray(listBillPayed);
            linkedListBillPayed = BillBUS.instance.ListtoLinkedList(listBillPayed);
        }
        #endregion

        #region Update bill food
        public List<ListBill> UpdateListBill(int idBill, List<BillInfoDTO> billinfo)
        {
            List<ListBill> listbill = listBillPayed;
            foreach (ListBill item in listbill)
            {
                if (item.data.Idbill.Equals(idBill))
                    item.info = billinfo;
                break;
            }
            listBillPayed = listbill;
            arrayBillPayed = BillBUS.instance.ListToArray(listBillPayed);
            linkedListBillPayed = BillBUS.instance.ListtoLinkedList(listBillPayed);
            return listbill;
        }
        #endregion

        #region Delete Bill
        public void delListBilPayed(int id, ref List<ListBill> billPayed)
        {
            foreach (ListBill item in billPayed)
                if (item.data.Idbill == id)
                {
                    billPayed.Remove(item);
                    break;
                }
        }
        #endregion

        #region return bill for using
        public static List<ListBill> returnListBillPayed()
        {
            return listBillPayed;
        }
        #endregion

        #region addFoodtoBill
        //public void addFoodtoListBill(int idBill, string idFood, int dishCount)
        //{
        //    List<ListBill> p = listBillPayed;
        //    List<FoodDTO> food = FoodBUS.returnListFood();
        //    FoodDTO data = new FoodDTO();
        //    foreach (FoodDTO item in food)
        //        if (item.Idfood.Equals(idFood))
        //        {
        //            data = item;
        //            break;
        //        }
        //    foreach (ListBill item in p)
        //    {
        //        if (item.data.Idbill.Equals(idBill))
        //        {
        //            int total = data.Pricefood * dishCount;
        //            BillInfoDTO bill = new BillInfoDTO(dishCount, idFood, data.Namefood, data.Pricefood, total);
        //            item.info.Add(bill);
        //            break;
        //        }
        //    }
        //    listBillPayed = p;
        //}
        #endregion

        #region Delete Food
        //public void delFoodtoListBill(int idBill, string idFood, ref List<ListBill> list)
        //{
        //    List<ListBill> p = list;
        //    List<FoodDTO> food = FoodBUS.returnListFood();
        //    FoodDTO data = new FoodDTO();
        //    foreach (FoodDTO item in food)
        //        if (item.Idfood.Equals(idFood))
        //        {
        //            data = item;
        //            break;
        //        }
        //    foreach (ListBill item in p)
        //    {
        //        if (item.data.Idbill.Equals(idBill))
        //        {
        //            for (int i = 0; i < item.info.Count; i++)
        //                if (item.info[i].Idfood == idFood)
        //                {
        //                    item.info.RemoveAt(i);
        //                    break;
        //                }
        //            break;
        //        }
        //    }

        //}
        #endregion

        #endregion

        #region addFoodtoBill
        public void addFoodtoBill(int idBill,string idFood, int dishCount)
        {
            LinkedListBillPayed p = linkedListBillPayed;
            LinkedListFood food = FoodBUS.returnLinkedListFood();
            FoodDTO data = new FoodDTO();
            while (food.next != null)
            {
                if (food.data.Idfood.Equals(idFood))
                {
                    data = food.data;
                    break;
                }
                food = food.next;
            }
            while(p.next!=null)
            {
                if(p.data.Idbill.Equals(idBill))
                {
                    int total = data.Pricefood * dishCount;
                    BillInfoDTO bill = new BillInfoDTO(dishCount, idFood, data.Namefood, data.Pricefood, total);
                    LinkedListBill temp = new LinkedListBill();
                    temp = p.info;
                    LinkedListBill temp2 = new LinkedListBill();
                    temp2 = p.info;
                    temp = adFoodToBill(bill);
                    temp.next = temp2;
                    temp2 = temp;
                    p.info = temp2;
                }
                p = p.next;
            }
           
        }
       
        #endregion

        #region Delete Food
        public void delFoodtoBill(int idBill, string idFood,ref LinkedListBillPayed listBillPayed)
        {
            LinkedListBillPayed p = listBillPayed;
            LinkedListFood food = FoodBUS.returnLinkedListFood();
            FoodDTO data = new FoodDTO();
            while (food.next != null)
            {
                if (food.data.Idfood.Equals(idFood))
                {
                    data = food.data;
                    break;
                }
                food = food.next;
            }
            while (p.next != null)
            {
                if (p.data.Idbill.Equals(idBill))
                {
                    LinkedListBill temp = new LinkedListBill();
                    LinkedListBill pre = new LinkedListBill();
                    if (p.info.data.Idfood == idFood)
                        delFirst(ref p.info);
                else
                    {
                        temp = p.info;
                        pre = p.info;
                        while (temp.next != null && temp.data.Idfood != idFood)
                        {
                            pre = temp;
                            temp = temp.next;
                        }
                        if (temp != null)
                            pre.next = temp.next;
                    }
                }
                p = p.next;

            }

        }
        private void delFirst(ref LinkedListBill list)
        {
            LinkedListBill p = new LinkedListBill();
            p = list;
            if (list != null)
            {
                p = list;
                list = p.next;
            }
        }
        #endregion

        #region Update Info 
        public BillDTO updateInfo(BillDTO bill, LinkedListBill p)
        {
            LinkedListBill temp = new LinkedListBill();
            temp = p;
            float total = 0;
            bill.Totalmoney = 0;
            while (temp.next != null)
            {
                total += temp.data.Countdish * temp.data.Price;
                temp = temp.next;
            }
            BillDTO data = new BillDTO(bill.Idbill, bill.Idtable, bill.Discount, total, bill.Saletime);
            return data;
        }
        #endregion

        #region Chuyển Bill

        #region chuyển từ array sang list
        public List<ListBill> ArraytoList(ArrayBill array)
        {
            List<ListBill> list = new List<ListBill>();
            ListBill bill = new ListBill();
            List<BillInfoDTO> info = new List<BillInfoDTO>();
            for (int i = 0; i < array.count; i++)
            {
                bill.data = array.ArrayListBill[i].data;
                bill.statusBill = array.ArrayListBill[i].statusBill;
                for (int j = 0; j < array.ArrayListBill[i].info.count; j++)
                {
                    info.Add(array.ArrayListBill[i].info.ArrayListBillInfo[j]);
                    bill.info = info;
                }
                list.Add(bill);
            }
            return list;
        }
        #endregion

        #region chuyển từ list sang array
        public ArrayBill ListToArray(List<ListBill> list)
        {
            ArrayBill array = new ArrayBill();
            Bill bill = new Bill();
            BillDTO dto = new BillDTO();
            ArrayBillInfo arrayBillInfo = new ArrayBillInfo();
            for (int i = 0; i < list.Count; i++)
            {
                dto = list[i].data;
                bill.data = dto;
                array.ArrayListBill[i] = bill;
                array.ArrayListBill[i].statusBill = list[i].statusBill;
                for (int j = 0; j < list[i].info.Count; j++)
                {
                    arrayBillInfo.ArrayListBillInfo[j] = list[i].info[j];
                }
                int count = list[i].info.Count;
                arrayBillInfo.count = count;
                array.ArrayListBill[i].info = arrayBillInfo;
            }
            array.count = list.Count;
            return array;
        }
        #endregion

        #region chuyển từ array sang dslk
        //public LinkedListBillPayed ArraytoLinkedList(ArrayBill array)
        //{
        //    LinkedListBillPayed p = new LinkedListBillPayed();
        //    LinkedListBillPayed temp = new LinkedListBillPayed();
        //    LinkedListBill temp2 = new LinkedListBill();
        //    BillInfoDTO[] arrayinfo = new BillInfoDTO[100];
        //    for (int i = 0; i < array.count; i++)
        //    {
        //        p.data = array.ArrayListBill[i].data;
        //        p.satusBill = array.ArrayListBill[i].statusBill;
        //        arrayinfo = array.ArrayListBill[i].info.ArrayListBillInfo;
        //        for (int j = 0; j < array.ArrayListBill[i].info.count; j++)
        //        {
        //            p.info.data = arrayinfo[j];
        //            p.info.next = temp2;
        //            temp2 = p.info;
        //        }
        //        p.next = temp;
        //        temp = p;
        //    }
        //    return p;
        //}
        #endregion

        #region chuyển từ dslk sang array
        public ArrayBill LinkedListtoArray(LinkedListBillPayed linkedlist)
        {
            ArrayBill array = new ArrayBill();
            Bill bill = new Bill();
            BillDTO dto = new BillDTO();
            ArrayBillInfo arrayInfo = new ArrayBillInfo();
            LinkedListBill pinfo = linkedlist.info;
            LinkedListBillPayed p = linkedlist;
            while (p.next != null)
            {
                dto = p.data;
                bill.data = dto;
                array.ArrayListBill[array.count] = bill;
                array.ArrayListBill[array.count].statusBill = p.satusBill;
                int count = 0;
                while (pinfo.next != null)
                {
                    arrayInfo.ArrayListBillInfo[count] = pinfo.data;
                    array.ArrayListBill[array.count].info = arrayInfo;
                    count++;
                    pinfo = pinfo.next;
                }
                array.count++;
                p = p.next;
            }
            return array;
        }
        #endregion

        #region chuyển từ dslk sang list
        public List<ListBill> LinkedListtoList(LinkedListBillPayed linkedlist)
        {
            List<ListBill> list = new List<ListBill>();
            LinkedListBillPayed p = linkedlist;
            LinkedListBill pinfo = linkedlist.info;
            ListBill bill = new ListBill();
            List<BillInfoDTO> info = new List<BillInfoDTO>();
            while (p.next != null)
            {
                bill.data = p.data;
                bill.statusBill = p.satusBill;
                while (pinfo.next != null)
                {
                    info.Add(pinfo.data);
                    pinfo = pinfo.next;
                    bill.info = info;
                }
                list.Add(bill);
                p = p.next;
            }
            return list;
        }
        #endregion

        #region chuyển từ list sang dslk
        public LinkedListBillPayed ListtoLinkedList(List<ListBill> list)
        {
            LinkedListBillPayed p = new LinkedListBillPayed();
            LinkedListBillPayed temp = new LinkedListBillPayed();
            LinkedListBill temp2 = new LinkedListBill();
            foreach (ListBill bill in list)
            {
                p = addbillPayed(bill);
                p.next = temp;
                temp = p;
            }
            return p;
        }
        public LinkedListBillPayed addbillPayed(ListBill list)
        {
            LinkedListBillPayed p = new LinkedListBillPayed();
            LinkedListBill temp2 = new LinkedListBill();
            p.data = list.data;
            p.satusBill = list.statusBill;
            foreach (BillInfoDTO info in list.info) 
                {
                p.info = adFoodToBill(info);
                p.info.next = temp2;
                temp2 = p.info;
                }
            p.next = null;
            return p;
        }
        #endregion

        #endregion

        #region Chuyển BillInfo

        #region chuyển từ array sang list
        public List<BillInfoDTO> ArraytoListInfo(ArrayBillInfo array)
        {
            List<BillInfoDTO> info = new List<BillInfoDTO>();
            BillInfoDTO[] arrayinfo = array.ArrayListBillInfo;
            for (int i = 0; i < array.count; i++)
                info.Add(arrayinfo[i]);
            return info;
        }
        #endregion

        #region chuyển từ list sang array
        public ArrayBillInfo ListToArrayInfo(List<BillInfoDTO> list)
        {
            ArrayBillInfo info = new ArrayBillInfo();
            info.ArrayListBillInfo = list.ToArray();
            info.count = list.Count;
            return info;
        }
        #endregion

        #region chuyển từ array sang dslk
        public LinkedListBill ArraytoLinkedListInfo(ArrayBillInfo array)
        {
            LinkedListBill p = new LinkedListBill();
            LinkedListBill temp = new LinkedListBill();
            for (int i = 0; i < array.count; i++)
            {
                p = adFoodToBill(array.ArrayListBillInfo[i]);
                p.next = temp;
                temp = p;
            }
            return p;
        }
        #endregion

        #region chuyển từ dslk sang array
        public ArrayBillInfo LinkedListtoArrayInfo(LinkedListBill linkedlist)
        {
            ArrayBillInfo array = new ArrayBillInfo();
            LinkedListBill p = linkedlist;
            while (p.next != null)
            {
                array.ArrayListBillInfo[array.count++] = p.data;
                p = p.next;
            }
            return array;
        }
        #endregion

        #region chuyển từ dslk sang list
        public List<BillInfoDTO> LinkedListtoListInfo(LinkedListBill linkedlist) //sai 
        {
            List<BillInfoDTO> list = new List<BillInfoDTO>();
            LinkedListBill p = linkedlist;
            while (p.next != null)
            {
                list.Add(p.data);
                p = p.next;
            }
            return list;
        }
        #endregion

        #region chuyển từ list sang dslk
        public LinkedListBill ListtoLinkedListInfo(List<BillInfoDTO> list)
        {
            LinkedListBill p = new LinkedListBill();
            LinkedListBill temp = new LinkedListBill();
            foreach (BillInfoDTO data in list)
            {
                p = adFoodToBill(data);
                p.next = temp;
                temp = p;
            }
            return p;
        }
        #endregion

        #endregion
    }
}
