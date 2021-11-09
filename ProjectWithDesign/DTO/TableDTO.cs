using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDesign.DTO
{
    class LinkedListTable
    {
        public TableDTO data;
        public LinkedListTable next;
    }
    class ArrayTable
    {
        public TableDTO[] ArrayListTable = new TableDTO[100];
        public int count = 0;
    }
   
    class TableDTO
    {
        private int idtable;
        private string nametable, statustable;
        public TableDTO()
        {
            idtable = 0;
            nametable = null;
            statustable = null;
        }

        public TableDTO(int idtable, string nametable, string statustable)
        {
            this.idtable = idtable;
            this.nametable = nametable;
            this.statustable = statustable;
        }

        public int Idtable { get => idtable; set => idtable = value; }
        public string Nametable { get => nametable; set => nametable = value; }
        public string Statustable { get => statustable; set => statustable = value; }

        public TableDTO(DataRow row)
        {
            this.idtable = (int)row["idtable"];
            this.nametable = row["nametable"].ToString();
            this.statustable = row["statustable"].ToString();
        }
    }
}
