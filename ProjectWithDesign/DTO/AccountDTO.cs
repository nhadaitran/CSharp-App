using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDesign.DTO
{
    class ArrayAccount
    {
        public AccountDTO[] ArrayListAccount = new AccountDTO[100];
        public int count = 0;
    }
    class LinkedListAccount
    {
        public AccountDTO data;
        public LinkedListAccount next;
    }
    class AccountDTO
    {
        private string id, account, nameuser, password;

        public AccountDTO(string id, string account, string nameuser, string password)
        {
            this.Id = id;
            this.Account = account;
            this.Nameuser = nameuser;
            this.Password = password;
        }

        public AccountDTO(DataRow row)
        {
            this.id = row["iduser"].ToString();
            this.account = row["account"].ToString();
            this.nameuser = row["nameuser"].ToString();
            this.password = row["passworduser"].ToString();
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string Account
        {
            get { return account; }
            set { account = value; }
        }

        public string Nameuser
        {
            get { return nameuser; }
            set { nameuser = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
