using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDesign.DTO
{
    class ArrayCategory
    {
        public CategoryDTO[] ArrayListCategory = new CategoryDTO[100];
        public int count = 0;
    }
    class LinkedListFoodCategory
    {
        public CategoryDTO data;
        public LinkedListFoodCategory next;
    }
    class CategoryDTO
    {
        private string  namecategory;
        private int idcategory;

        public CategoryDTO(int idcategory, string namecategory)
        {
            this.idcategory = idcategory;
            this.namecategory = namecategory;
        }
        public CategoryDTO(DataRow row)
        {
            this.idcategory = (int)row["idfoodcategory"];
            this.namecategory = row["namefoodcategory"].ToString();
        }


        public int Idcategory { get => idcategory; set => idcategory = value; }
        public string Namecategory { get => namecategory; set => namecategory = value; }
    }
}
