using Business_Object;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface ICustomerRepository
    {
        public List<CustomerObject> GetCustomerList();

        public void InsertCustomer(CustomerObject cus);

        public void UpdateCustomer(CustomerObject cus);

        public CustomerObject GetCustomerByID(int id);

        public List<CustomerObject> GetCustomerByEmail(string email);

        public CustomerObject GetCustomerForeignKey(int cusID);

        public void DeleteCustomer(int id);
        public List<CustomerObject> SortCustomerAscendingName();
        public List<CustomerObject> SortCustomerDescendingName();
        public CustomerObject GetACustomerByEmail(string email);
        public CustomerObject GetACustomerByPhone(string phone);
        public bool CheckCustomerByEmailAndPhone(string email, string phone);
        public bool CheckCustomerByIDandEmailAndPhone(int id, string email, string phone);
        public void AddPointCustomer(int id);
    }
}
