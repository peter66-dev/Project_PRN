using Business_Object;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public void DeleteCustomer(int id) => CustomerDAO.Instance.DeleteCustomer(id);

        public CustomerObject GetACustomerByEmail(string email) => CustomerDAO.Instance.GetACustomerByEmail(email);

        public CustomerObject GetACustomerByPhone(string phone) => CustomerDAO.Instance.GetACustomerByPhone(phone);

        public List<CustomerObject> GetCustomerByEmail(string email) => CustomerDAO.Instance.GetCustomerByEmail(email);

        public CustomerObject GetCustomerByID(int id) => CustomerDAO.Instance.GetCustomerByID(id);

        public CustomerObject GetCustomerForeignKey(int cusID) => CustomerDAO.Instance.GetCustomerForeignKey(cusID);

        public List<CustomerObject> GetCustomerList() => CustomerDAO.Instance.GetCustomerList();

        public void InsertCustomer(CustomerObject cus) => CustomerDAO.Instance.InsertCustomer(cus);

        public List<CustomerObject> SortCustomerAscendingName() => CustomerDAO.Instance.SortCustomerAscendingName();

        public List<CustomerObject> SortCustomerDescendingName() => CustomerDAO.Instance.SortCustomerDescendingName();

        public void UpdateCustomer(CustomerObject cus) => CustomerDAO.Instance.UpdateCustomer(cus);
        public bool CheckCustomerByEmailAndPhone(string email, string phone) => CustomerDAO.Instance.CheckCustomerByEmailAndPhone(email, phone);
        public bool CheckCustomerByIDandEmailAndPhone(int id, string email, string phone) => CustomerDAO.Instance.CheckCustomerByIDandEmailAndPhone(id, email, phone);
        public void AddPointCustomer(int id) => CustomerDAO.Instance.AddPointCustomer(id);
    }
}
