using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDesign.DTO
{
    public class MenuDTO
    {  
        private int count;
        private float price;
        private string foodName;
        private float totalPrice;
        private string idfood;

        public MenuDTO(int count, float price, string foodName, float totalPrice,string idfood)
        {
            this.count = count;
            this.price = price;
            this.foodName = foodName;
            this.totalPrice = totalPrice;
            this.Idfood = idfood;
        }

        public MenuDTO(DataRow row)
        {
            this.idfood = row["idfood"].ToString();
            this.count = (int)row["countdish"];
            this.price = (float)Convert.ToDouble(row["pricefood"].ToString());
            this.foodName = row["namefood"].ToString();
            this.totalPrice = (float)Convert.ToDouble(row["totalprice"].ToString());
        }

        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Idfood { get => idfood; set => idfood = value; }
    }
}
