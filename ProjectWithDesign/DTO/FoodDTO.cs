using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDesign.DTO
{
    class ArrayFood
    {
        public FoodDTO[] ArrayListFood = new FoodDTO[100];
        public int count = 0;
    }
    class LinkedListFood
    {
        public FoodDTO data;
        public LinkedListFood next;
    }
    class FoodDTO
    {
        private string idFood, unitCount, nameFood;
        private int priceFood, idFoodCategory;

        public FoodDTO()
        {
            this.idFood = null;
            this.unitCount = null;
            this.nameFood = null;
            this.priceFood = 0;
            this.idFoodCategory = 0;
        }
        public FoodDTO(string idfood, string unitcount, string namefood, int pricefood, int idfoodcategory)
        {
            this.idFood = idfood;
            this.unitCount = unitcount;
            this.nameFood = namefood;
            this.priceFood = pricefood;
            this.idFoodCategory = idfoodcategory;
        }

        public FoodDTO(DataRow row)
        {
            this.idFood = row["idfood"].ToString();
            this.unitCount = row["unitcount"].ToString();
            this.nameFood = row["namefood"].ToString();
            this.priceFood = (int)row["pricefood"];
            this.idFoodCategory = (int)row["idfoodcategory"];
        }

        public string Idfood { get => idFood; set => idFood = value; }
        public string Unitcount { get => unitCount; set => unitCount = value; }
        public string Namefood { get => nameFood; set => nameFood = value; }
        public int Pricefood { get => priceFood; set => priceFood = value; }
        public int Idfoodcategory { get => idFoodCategory; set => idFoodCategory = value; }

    }
}
