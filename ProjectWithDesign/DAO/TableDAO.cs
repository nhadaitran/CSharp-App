using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectWithDesign.BUS;
using ProjectWithDesign.DTO;

namespace ProjectWithDesign.DAO
{
    class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set => instance = value;
        }

        private TableDAO() { }

        

        //Hàm thêm dữ liệu table từ sql vào listTable
        public List<TableDTO> loadTableToList()
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
       
    }
}
