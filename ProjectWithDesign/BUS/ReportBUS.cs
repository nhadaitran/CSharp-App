using ProjectWithDesign.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDesign.BUS
{
    class ReportBUS
    {
        LinkedListBillPayed billPayed = BillBUS.returnLinkedListBillPayed();

        public LinkedListBillPayed findDate(DateTime from,DateTime to)
        {
            LinkedListBillPayed result = new LinkedListBillPayed();
            LinkedListBillPayed temp = new LinkedListBillPayed();
            temp = billPayed;
            while(temp.next!=null)
            {
                if (temp.data.Saletime.Year >= from.Year && temp.data.Saletime.Year <= to.Year)
                    if (temp.data.Saletime.Month >= from.Month && temp.data.Saletime.Month <= to.Month)
                        if (temp.data.Saletime.Day >= from.Day && temp.data.Saletime.Day <= to.Day)
                        {
                            result = add(temp.data, temp.satusBill, temp.info);
                            result.next = temp;
                            temp = result;
                        }
                temp = temp.next;
            }
            return temp;
        }
        private LinkedListBillPayed add(BillDTO data, bool satusBill, LinkedListBill info)
        {
            LinkedListBillPayed p= new LinkedListBillPayed();
            p.data = data;
            p.info = info;
            p.satusBill = satusBill;
            p.next = null;
            return p;
        }
    }
}
