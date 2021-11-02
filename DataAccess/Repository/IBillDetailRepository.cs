using Business_Object;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IBillDetailRepository
    {
        public void InsertBillDetail(BillDetailObject bill);
        public List<BillDetailObject> GetBillDetailList();
    }
}
