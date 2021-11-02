using Business_Object;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class BillDetailRepository : IBillDetailRepository
    {
        public List<BillDetailObject> GetBillDetailList() => BillDetailDAO.Instance.GetBillDetailList();

        public void InsertBillDetail(BillDetailObject bill) => BillDetailDAO.Instance.InsertBillDetail(bill);
    }
}
