using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDesign.DTO
{
    class LinkedListBillPayed
    {
        public BillDTO data;
        public bool satusBill = false;
        public LinkedListBill info;
        public LinkedListBillPayed next;
    }
    class Bill
    {
        public BillDTO data;
        public bool statusBill = false;
        public ArrayBillInfo info;
    }
    class ListBill
    {
        public BillDTO data;
        public bool statusBill = false;
        public List<BillInfoDTO> info;
    }
    class ArrayBill
    {
        public Bill[] ArrayListBill = new Bill[100];
        public int count = 0;
    }
    class BillDTO
    {
        private int idbill;
        private int discount;
        private int idtable;
        private float totalmoney;
        private DateTime saletime;

        public BillDTO(){ }

        public BillDTO(int idbill,int idtable, int discount, float totalmoney, DateTime saletime)
        {
            this.idbill = idbill;
            this.idtable = idtable;
            this.discount = discount;
            this.totalmoney = totalmoney;
            this.saletime = saletime;
        }

        public BillDTO(DataRow row)
        {
            this.idbill = (int)row["idbill"];
            this.idtable = (int)row["idtable"];
            this.totalmoney = (float)Convert.ToDouble(row["totalmoney"].ToString());
            this.saletime = Convert.ToDateTime(row["saletime"]);
            if (row["discount"].ToString() != "0")
                this.discount = (int)row["discount"];
        }



        public int Idbill
        {
            get { return idbill; }
            set { idbill = value; }
        }

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public float Totalmoney
        {
            get { return totalmoney; }
            set { totalmoney = value; }
        }

        public DateTime Saletime
        {
            get { return saletime; }
            set { saletime = value; }
        }

        public int Idtable { get => idtable; set => idtable = value; }
    }
}
