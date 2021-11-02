using Business_Object;
using System;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IBillRepository
    {
        public List<BillObject> GetBillList();
        public BillObject GetBillByID(int id);
        public void InsertBill(int id, int cusID, decimal total, decimal freight);
        public void UpdateBill(int id, decimal total);
        public void RemoveBill(int id);
        public int GetTotalBill();
        public List<BillObject> GetBillListByDate(DateTime start, DateTime end);
        public decimal GetTotalImportMoney();
        public List<BillObject> SortByTotalAscending();
        public List<BillObject> SortByTotalDescending();
    }
}
