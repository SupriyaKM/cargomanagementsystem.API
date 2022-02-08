using cargomanagementsystem.DAL.Repository;
using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using cargomanagementsystem.BAL.Service;

namespace cargomanagementsystem.BAL.Service
{
   public class CustService
    {
        ICustRepository _custRepository;
        public CustService(ICustRepository custRepository)
        {
            _custRepository = custRepository;
        }
        public void AddCust_Details(Cust_details customer)
         {
             _custRepository.AddCust_details(customer);

         }
         public void UpdateCust_details(Cust_details customer)
         {
             _custRepository.UpdateCust_details(customer);
         }
         public void DeleteCust_details(int customerid)
         {
             _custRepository.DeleteCust_details(customerid);
         }

        public void GetCust_detailsbyid(int customerid)
         {
             _custRepository.GetCust_detailsbyid(customerid);
         }
         public void GetCust_details()
         {
             _custRepository.GetCust_details();
         }
        public IEnumerable<Cust_details> GetCustdetails()
        {
            return _custRepository.GetCust_details();
        }
    }
}

