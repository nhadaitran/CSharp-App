using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectWithDesign.DTO;

namespace ProjectWithDesign.BUS
{
    class LoginBUS
    {
        private static LoginBUS instance;
        public static LoginBUS Instance
        {
            get { if (instance == null) instance = new LoginBUS(); return LoginBUS.instance; }
            private set { Instance = value; }
        }
        private LoginBUS() { }

        static private LinkedListAccount LinkedList = AccountBUS.getLinkedListAccount();
        public string checkAccount(string username, string password)
        {
            LinkedListAccount temp = new LinkedListAccount();
            temp = LinkedList;
            string type = "false";
            while (temp.next!=null)
            {
                if (temp.data.Account.Equals(username) && temp.data.Password.Equals(password))
                {
                    type = temp.data.Id;
                    break;
                }
                temp = temp.next;
            }
            return type;
        }

    
    }
}
