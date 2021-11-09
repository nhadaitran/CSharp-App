using System.Collections.Generic;
using System.Data;
using ProjectWithDesign.DAO;
using ProjectWithDesign.DTO;
using System;
using System.Linq;

namespace ProjectWithDesign.BUS
{
   
    class TableBUS
    {
        private static TableBUS instance;
        public static TableBUS Instance
        {
            get { if (instance == null) instance = new TableBUS();return TableBUS.instance; }
            private set { TableBUS.instance = value; }
        }
        public TableBUS() { }

        private List<TableDTO> listTableNo = TableDAO.Instance.loadTableToList();
        private static Dictionary<int, LinkedListBill> dicLinkedTable = new Dictionary<int, LinkedListBill>();
        private static Dictionary<int, List<BillInfoDTO>> dicListTable = new Dictionary<int, List<BillInfoDTO>>();
        private static Dictionary<int, ArrayBillInfo> dicArrayTable = new Dictionary<int, ArrayBillInfo>();
        private static LinkedListBill listTable = new LinkedListBill();

        #region return listTable for using
        public List<TableDTO> returnListTable()
        {
            return listTableNo;
        }
        #endregion


        #region List

        //Hàm thêm dữ liệu table từ sql vào ArrayTable
        public static List<TableDTO> loadTableToList()
        {
            List<TableDTO> listTable = new List<TableDTO>();
            DataTable date = DataProvider.Instance.ExecuteQuery("select * from tablefood");
            foreach (DataRow row in date.Rows)
            {
                TableDTO table = new TableDTO(row);
                listTable.Add(table);
            }
            return listTable;
        }

        private List<TableDTO> ListTableNo = loadTableToList();

      

        #region add food to listBillByTable

        public List<BillInfoDTO> addToListBill(ref List<BillInfoDTO> listBillInfo, int pos, string idFood, string nameFood, int price, int dishCount)
        {
            if (dicListTable.ContainsKey(pos))//nếu đã có bill
            {
                if (checkFoodinListBill(listBillInfo, idFood))//nếu đã có loại cần thêm vào
                {
                    List<BillInfoDTO> p = listBillInfo;
                    foreach (BillInfoDTO item in p)
                    {
                        if (item.Idfood == idFood)
                        {
                            item.Countdish += dishCount;
                            item.TotalPrice = item.Countdish * item.Price;
                            break;
                        }
                    }
                    dicListTable[pos] = listBillInfo;
                    return dicListTable[pos];
                }
                else // thêm mới nếu ko có thức ăn cần thêm
                {
                    List<BillInfoDTO> p = dicListTable[pos];
                    int total = price * dishCount;
                    BillInfoDTO bill = new BillInfoDTO(dishCount, idFood, nameFood, price, total);
                    dicListTable[pos].Add(bill);
                    return dicListTable[pos];
                }
            }
            else// tao bill mới
            {
                List<BillInfoDTO> info = new List<BillInfoDTO>();
                int total = price * dishCount;
                BillInfoDTO bill = new BillInfoDTO(dishCount, idFood, nameFood, price, total);
                info.Add(bill);
                dicListTable.Add(pos, info);
                return info;
            }
        }
        private bool checkFoodinListBill(List<BillInfoDTO> list, string idFood)// kiểm tra đã có thức ăn đó chưa
        {
            foreach (BillInfoDTO item in list)
                if (item.Idfood.Equals(idFood))
                    return true;
            return false;
        }
        #endregion

        #region return DicListTable
        static public Dictionary<int, List<BillInfoDTO>> returndicListTable()
        {
            return dicListTable;
        }
        #endregion

        #region delete a dish in a bill
        public void delFoodinListBill(ref List<BillInfoDTO> listBillInfo, string idFood)
        {
            foreach (BillInfoDTO item in listBillInfo)
                if (item.Idfood == idFood)
                {
                    listBillInfo.Remove(item);
                    break;
                }
        }
        #endregion

        #endregion

        #region LinkedList        
        //Hàm thêm dữ liệu table từ sql vào listTable
        public static LinkedListTable loadTableToLinked()
        {
            LinkedListTable listTable = new LinkedListTable();
            LinkedListTable temp = new LinkedListTable();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from tablefood");
            foreach (DataRow row in data.Rows)
            {
                TableDTO table = new TableDTO(row);
                listTable = addTable(table);
                listTable.next = temp;
                temp = listTable;
            }
            return listTable;
        }
        private static LinkedListTable addTable(TableDTO temp)
        {
            LinkedListTable p = new LinkedListTable();
            p.data = temp;
            p.next = null;
            return p;
        }
        private LinkedListTable LinkedTableNo = loadTableToLinked();

        #region return LinkedListTable for using
        public LinkedListTable returnLinkedTable()
        {
            return LinkedTableNo;
        }
        #endregion

        #region add food to LinkedListBillByTable

        public LinkedListBill addToLinkedBill(ref LinkedListBill listBill, int pos, string idFood, string nameFood, int price, int dishCount)
        {
            if (dicListTable.ContainsKey(pos))//nếu đã có bill
            {
                if (checkFoodinLinkedBill(listBill, idFood))//nếu đã có loại cần thêm vào
                {
                    LinkedListBill p = listBill;
                    while (p.next != null)
                    {
                        if (p.data.Idfood == idFood)
                        {
                            p.data.Countdish += dishCount;
                            p.data.TotalPrice = p.data.Countdish * p.data.Price;
                            break;
                        }
                        p = p.next;
                    }
                    dicListTable[pos] = BillBUS.Instance.LinkedListtoListInfo(listBill);
                    return listBill;
                }
                else // thêm mới nếu ko có thức ăn cần thêm
                {
                    LinkedListBill dicLinkedTable = BillBUS.Instance.ListtoLinkedListInfo(dicListTable[pos]);
                    LinkedListBill p = dicLinkedTable;
                    int total = price * dishCount;
                    BillInfoDTO bill = new BillInfoDTO(dishCount, idFood, nameFood, price, total);
                    p = adFoodToLinkedBill(bill);
                    p.next = dicLinkedTable;
                    dicLinkedTable = p;
                    dicListTable[pos] = BillBUS.Instance.LinkedListtoListInfo(dicLinkedTable);
                    return dicLinkedTable;
                }
            }
            else// tao bill mới
            {
                LinkedListBill temp = new LinkedListBill();
                int total = price * dishCount;
                BillInfoDTO bill = new BillInfoDTO(dishCount, idFood, nameFood, price, total);
                listBill = adFoodToLinkedBill(bill);
                listBill.next = temp;
                temp = listBill;
                listBill = temp;
                dicListTable.Add(pos, BillBUS.Instance.LinkedListtoListInfo(listBill));
                return listBill;
            }
        }
        private bool checkFoodinLinkedBill(LinkedListBill list, string idFood)// kiểm tra đã có thức ăn đó chưa
        {
            LinkedListBill p = new LinkedListBill();
            p = list;
            while (p.next != null)
            {
                if (p.data.Idfood.Equals(idFood))
                    return true;
                p = p.next;
            }
            return false;
        }
        private LinkedListBill adFoodToLinkedBill(BillInfoDTO temp)
        {
            LinkedListBill p = new LinkedListBill();
            p.data = temp;
            p.next = null;
            return p;
        }
        #endregion

        #region delete a dish in a bill
        public void delFoodinLinkedBill(ref LinkedListBill listBill, string idFood)
        {
            LinkedListBill p = new LinkedListBill();
            LinkedListBill pre = new LinkedListBill();
            if (listBill.data.Idfood == idFood)
                delFirst(ref listBill);
            else
            {
                p = listBill;
                pre = listBill;
                while (p.next != null && p.data.Idfood != idFood)
                {
                    pre = p;
                    p = p.next;
                }
                if (p != null)
                    pre.next = p.next;
            }
        }
        private void delFirst(ref LinkedListBill list)
        {
            LinkedListBill p = new LinkedListBill();
            if (list != null)
            {
                p = list;
                list = p.next;
            }
        }
        #endregion

        #endregion

        #region Array        
        //Hàm thêm dữ liệu table từ sql vào ArrayTable
        public static ArrayTable loadTableToArray()
        {
            ArrayTable listTable = new ArrayTable();
            ArrayTable temp = new ArrayTable();
            DataTable date = DataProvider.Instance.ExecuteQuery("select * from tablefood");
            foreach (DataRow row in date.Rows)
            {
                TableDTO table = new TableDTO(row);
                temp.ArrayListTable[temp.count++] = table;
            }
            listTable = temp;
            return listTable;
        }

        private ArrayTable ArrayTableNo = loadTableToArray();

        #region return arrayTable for using
        public ArrayTable returnArrayTable()
        {
            return ArrayTableNo;
        }
        #endregion

        #region add food to ArrayBillByTable

        public ArrayBillInfo addToArrayBill(ref ArrayBillInfo listBillInfo, int pos, string idFood, string nameFood, int price, int dishCount)
        {
            if (dicListTable.ContainsKey(pos))//nếu đã có bill
            {
                if (checkFoodinBill(listBillInfo, idFood))//nếu đã có loại cần thêm vào
                {
                    ArrayBillInfo p = listBillInfo;
                    for (int i = 0; i < p.count; i++)
                    {
                        if (p.ArrayListBillInfo[i].Idfood == idFood)
                        {
                            p.ArrayListBillInfo[i].Countdish += dishCount;
                            p.ArrayListBillInfo[i].TotalPrice = p.ArrayListBillInfo[i].Countdish * p.ArrayListBillInfo[i].Price;
                            break;
                        }
                    }
                    dicListTable[pos] = BillBUS.Instance.ArraytoListInfo(listBillInfo);
                    return listBillInfo;
                }
                else // thêm mới nếu ko có thức ăn cần thêm
                {
                    int total = price * dishCount;
                    BillInfoDTO bill = new BillInfoDTO(dishCount, idFood, nameFood, price, total);
                    dicListTable[pos].Add(bill);
                    return BillBUS.Instance.ListToArrayInfo(dicListTable[pos]);
                }
            }
            else// tao bill mới
            {
                int total = price * dishCount;
                BillInfoDTO bill = new BillInfoDTO(dishCount, idFood, nameFood, price, total);
                //listBillInfo.ArrayListBillInfo[listBillInfo.count++] = bill;
                List<BillInfoDTO> info = new List<BillInfoDTO>();
                info.Add(bill);
                listBillInfo = BillBUS.Instance.ListToArrayInfo(info);
                dicListTable.Add(pos, info);
                return listBillInfo;
            }
        }
        private bool checkFoodinBill(ArrayBillInfo list, string idFood)// kiểm tra đã có thức ăn đó chưa
        {
            ArrayBillInfo p = new ArrayBillInfo();
            p = list;
            for (int i = 0; i < p.count; i++)
                if (p.ArrayListBillInfo[i].Idfood.Equals(idFood))
                    return true;
            return false;
        }
        #endregion

        #region delete a dish in a bill
        public void delFoodinArrayBill(ref ArrayBillInfo listBillInfo, string idFood)
        {
            BillInfoDTO[] array = new BillInfoDTO[100];
            array = listBillInfo.ArrayListBillInfo;
            for (int i = 0; i < listBillInfo.count; i++)
                if (listBillInfo.ArrayListBillInfo[i].Idfood == idFood)
                {
                    array = array.Where((source, index) => index != i).ToArray();
                    listBillInfo.ArrayListBillInfo = array;
                    listBillInfo.count--;
                    break;
                }
        }
        #endregion

        #endregion

        #region Del Table
        public void delTable(int idTable)
        {
            dicLinkedTable.Remove(idTable);
            dicListTable.Remove(idTable);
            dicArrayTable.Remove(idTable);
        }
        #endregion

        #region chuyển

        #region chuyển từ array sang list
        public List<TableDTO> ArraytoList(ArrayTable array)
        {
            List<TableDTO> table = new List<TableDTO>();
            for (int i = 0; i < array.count; i++)
                table.Add(array.ArrayListTable[i]);
            return table;
        }
        #endregion

        #region chuyển từ list sang array
        public ArrayTable ListToArray(List<TableDTO> list)
        {
            ArrayTable table = new ArrayTable();
            table.ArrayListTable = list.ToArray();
            table.count = list.Count;
            return table;
        }
        #endregion

        #region chuyển từ array sang dslk
        public LinkedListTable ArraytoLinkedList(ArrayTable array)
        {
            LinkedListTable p = new LinkedListTable();
            LinkedListTable temp = new LinkedListTable();
            for (int i = 0; i < array.count; i++)
            {
                p = addTable(array.ArrayListTable[i]);
                p.next = temp;
                temp = p;
            }
            return p;
        }
        #endregion

        #region chuyển từ dslk sang array
        static public ArrayTable LinkedListtoArray(LinkedListTable linkedlist)
        {
            ArrayTable array = new ArrayTable();
            LinkedListTable p = linkedlist;
            while (p.next != null)
            {
                array.ArrayListTable[array.count++] = p.data;
                p = p.next;
            }
            return array;
        }
        #endregion

        #region chuyển từ dslk sang list
        static public List<TableDTO> LinkedListtoList(LinkedListTable linkedlist)
        {
            List<TableDTO> list = new List<TableDTO>();
            LinkedListTable p = linkedlist;
            while (p.next != null)
            {
                list.Add(p.data);
                p = p.next;
            }
            return list;
        }
        #endregion

        #region chuyển từ list sang dslk
        public LinkedListTable ListtoLinkedList(List<TableDTO> list)
        {
            LinkedListTable p = new LinkedListTable();
            LinkedListTable temp = new LinkedListTable();
            foreach (TableDTO data in list)
            {
                p = addTable(data);
                p.next = temp;
                temp = p;
            }
            return p;
        }
        #endregion

        #endregion

        #region Update bill Info 
        public void UpdateBillInfo(LinkedListBill p, int idTable)
        {
            List<BillInfoDTO> temp = BillBUS.Instance.LinkedListtoListInfo(p);
            dicListTable[idTable] = temp;
        }
        #endregion
    }
}
