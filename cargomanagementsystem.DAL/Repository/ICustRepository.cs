using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace cargomanagementsystem.DAL.Repository
{
   public interface ICustRepository
    {
        void AddCust_details(Cust_details customer);
        void UpdateCust_details(Cust_details customer);
        void DeleteCust_details(int customerid);
        Cust_details GetCust_detailsbyid(int customerid);
        IEnumerable<Cust_details> GetCust_details();

    }
}
