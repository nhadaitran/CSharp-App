using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDesign.DTO
{
    class ArrayBillInfo
    {
        public BillInfoDTO[] ArrayListBillInfo = new BillInfoDTO[100];
        public int count = 0;
    }
    class LinkedListBill
    {
        public BillInfoDTO data;
        public LinkedListBill next;

    }
    class BillInfoDTO
    {
        private int countdish;
        private int price;
        private string idfood;
        private string foodname;
        private int totalPrice;

        public BillInfoDTO()
        {
            countdish = 0;
            price = 0;
            idfood = null;
            foodname = null;
            totalPrice = 0;
        }
        public BillInfoDTO(int countdish,string idfood, string foodname, int price, int totalPrice)
        {
            this.Countdish = countdish;
            this.Idfood = idfood;
            this.Foodname = foodname;
            this.price = price;
            this.totalPrice = totalPrice;
        }

      
        public string Idfood { get => idfood; set => idfood = value; }
        public int Countdish { get => countdish; set => countdish = value; }
        public string Foodname { get => foodname; set => foodname = value; }
        public int Price { get => price; set => price = value; }
        public int TotalPrice { get => this.totalPrice; set => this.totalPrice = value; }

        private void total()
        {
            this.totalPrice = this.Countdish * this.Price;
        }
    }
}
