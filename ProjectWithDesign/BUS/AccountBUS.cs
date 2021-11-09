using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectWithDesign.DTO;

namespace ProjectWithDesign.BUS
{
   
    class AccountBUS
    {
        private static AccountBUS instance;
        public static AccountBUS Instance
        {
            get { if (instance == null) instance = new AccountBUS(); return AccountBUS.instance; }
            private set { AccountBUS.instance = value; }
        }
        static LinkedListAccount linkedlistAccount = linkedListAccount();
        List<AccountDTO> listAccount = new List<AccountDTO>();
        ArrayAccount arraylistAccount = new ArrayAccount();

        #region Lấy ds từ sql


        // TẠo danh sách liên kết các phần tử 
        public static LinkedListAccount linkedListAccount()
        {
            string query = "select * from  users";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            LinkedListAccount linkedList = new LinkedListAccount();
            LinkedListAccount temp = new LinkedListAccount();
            foreach (DataRow row in data.Rows)
            {
                AccountDTO account = new AccountDTO(row);
                linkedList = addItem(account);
                linkedList.next = temp;
                temp = linkedList;
            }
            return linkedList;
        }

        // Tạo 1 phần tử
        private static LinkedListAccount addItem(AccountDTO account)
        {
            LinkedListAccount p = new LinkedListAccount();
            p.data = account;
            p.next = null;
            return p;
        }
        #endregion

        #region chuyển

        #region linkedlist -> list
        public List<AccountDTO> toListAccount(LinkedListAccount list)
        {
            List<AccountDTO> accounts = new List<AccountDTO>();
            LinkedListAccount p = new LinkedListAccount();
            p = list;
            while (p.next != null)
            {
                accounts.Add(p.data);
                p = p.next;
            }
            return accounts;
        }

        #endregion

        #region array -> list
        public List<AccountDTO> toListAccount(ArrayAccount list)
        {
            List<AccountDTO> accounts = list.ArrayListAccount.ToList();
            return accounts;
        }
        #endregion

        #region list -> linkedlist
        public LinkedListAccount toLinkedListAccount(List<AccountDTO> list)
        {
            LinkedListAccount p = new LinkedListAccount();
            LinkedListAccount temp = new LinkedListAccount();
            foreach (AccountDTO data in list)
            {
                p = addItem(data);
                p.next = temp;
                temp = p;
            }
            return p;
        }
        #endregion

        #region array -> linkedlist
        public LinkedListAccount toLinkedListAccount(ArrayAccount list)
        {
            LinkedListAccount p = new LinkedListAccount();
            LinkedListAccount temp = new LinkedListAccount();
            for (int i = 0; i < list.count; i++)
            {
                p = addItem(list.ArrayListAccount[i]);
                p.next = temp;
                temp = p;
            }
            return p;
        }

        #region list -> array
        public ArrayAccount toArrayAccount(List<AccountDTO> list)
        {
            ArrayAccount accounts = new ArrayAccount();
            accounts.ArrayListAccount = list.ToArray();
            accounts.count = list.Count;
            return accounts;
        }
        #endregion

        
        #endregion

        #region linkedlist -> array
        public ArrayAccount toArrayAccount(LinkedListAccount list)
        {
            ArrayAccount array = new ArrayAccount();
            LinkedListAccount p = list;
            while (p.next != null)
            {
                array.ArrayListAccount[array.count++] = p.data;
                p = p.next;
            }
            return array;
        }
        #endregion

        #endregion

        #region đổi mật khẩu

        #region change password linked list
        //Đổi mật khẩu
        public void changePassword(ref LinkedListAccount temp, string username, string newpass)
        {
            LinkedListAccount p = new LinkedListAccount();
            p = temp;
            while (p.next != null)
            {
                if (p.data.Account.Equals(username))
                {
                    p.data.Password = newpass;
                }
                p = p.next;
            }
            linkedlistAccount = temp;
        }
        #endregion

        #region change password  list
        //Đổi mật khẩu
        public void changePasswordinList(ref List<AccountDTO> temp, string username, string newpass)
        {
            foreach (AccountDTO data in temp)
            {
                if (data.Account.Equals(username))
                    data.Password = newpass;
            }
            listAccount = temp;
        }
        #endregion

        #region change password array
        //Đổi mật khẩu
        public void changePasswordinArray(ref ArrayAccount temp, string username, string newpass)
        {
            for (int i = 0; i < temp.count; i++)
            {
                if (temp.ArrayListAccount[i].Account.Equals(username))
                    temp.ArrayListAccount[i].Password = newpass;
            }
            arraylistAccount = temp;
        }
        #endregion

        #endregion

        #region đổi tên tài khoản

        #region change Name linked list
        public void changeName(string username, string newname, ref LinkedListAccount temp)
        {
            LinkedListAccount p = new LinkedListAccount();
            p = temp;
            while (p.next != null)
            {
                if (p.data.Account.Equals(username))
                {
                    p.data.Nameuser = newname;
                }
                p = p.next;
            }
            linkedlistAccount = temp;
        }

        #endregion

        #region change Name list
        public void changeNameinList(string username, string newname, ref List<AccountDTO> temp)
        {
            foreach(AccountDTO data in temp)
            {
                if (data.Account.Equals(username))
                    data.Nameuser = newname;
            }
            listAccount = temp;
        }

        #endregion

        #region change Name array
        public void changeNameinArray(ref ArrayAccount temp, string username, string newname)
        {
            for (int i = 0; i < temp.count; i++)
            {
                if (temp.ArrayListAccount[i].Account.Equals(username))
                    temp.ArrayListAccount[i].Nameuser = newname;
            }
            arraylistAccount = temp;
        }
        #endregion

        #endregion

        public static LinkedListAccount getLinkedListAccount()
        {
            return linkedlistAccount;
        }

        public List<AccountDTO> getListAccount()
        {
            return listAccount;
        }
    }
}

        ////-----------------------------------------------------------------------------
        //        //Đổi mật khẩu
        //        public LinkedListAccount changePassword(LinkedListAccount temp, string id, string username, string nameuser, string newpass)
        //        {
        //            LinkedListAccount p = temp;
        //            while (temp.next != null)
        //            {
        //                if (temp.data.Account.Equals(username))
        //                {
        //                    temp.data.Password = newpass;
        //                }
        //                temp = temp.next;
        //            }
        //            return temp;
        //        }

//        public LinkedListAccount changeName(string username, string newname, LinkedListAccount temp)
//        {
//            LinkedListAccount p = temp;
//            while (p.next != null)
//            {
//                if (p.data.Account.Equals(username))
//                {
//                    p.data.Password = newname;
//                }
//                p = p.next;
//            }
//            return temp;
//        }

//        private LinkedListAccount addAccountToList(LinkedListAccount linkedList, string id, string account, string nameuser, string password)
//        {
//            LinkedListAccount temp = new LinkedListAccount();
//            temp = linkedList;
//            AccountDTO acc = new AccountDTO(id, account, nameuser, password);
//            linkedList = addItem(acc);
//            linkedList.next = temp;
//            temp = linkedList;
//            linkedList = temp;
//            return linkedList;
//        }

//        public LinkedListAccount deleteAccount(LinkedListAccount linkedList, string account)
//        {
//            LinkedListAccount pre = new LinkedListAccount();
//            pre = linkedList;
//            while (linkedList.next != null&&linkedList.data.Account==account)
//            {
//                pre = linkedList;
//                linkedList = linkedList.next;
//            }
//             if(linkedList.next!=null)
//                pre.next = linkedList.next;
//            return pre;      
//        }

