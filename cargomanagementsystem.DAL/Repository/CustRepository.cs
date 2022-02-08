using cargomanagementsystem.DAL.Data;
using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace cargomanagementsystem.DAL.Repository
{
   public class CustRepository : ICustRepository
    {
        cargomanagementDbContext _cargomanagementDBContext;
        public CustRepository(cargomanagementDbContext cargomanagementDBContext)
        {
            _cargomanagementDBContext = cargomanagementDBContext;
        }
        public void AddCust_details(Cust_details customer)
        {
            _cargomanagementDBContext.Customer_Details.Add(customer);
            _cargomanagementDBContext.SaveChanges();
        }
        public void UpdateCust_details(Cust_details customer)
        {
            _cargomanagementDBContext.Entry(customer).State = EntityState.Modified;
            _cargomanagementDBContext.SaveChanges();
        }

        public void DeleteCust_details(int customerid)
        {
            var customer = _cargomanagementDBContext.Customer_Details.Find(customerid);
            _cargomanagementDBContext.Customer_Details.Remove(customer);
            _cargomanagementDBContext.SaveChanges();
        }
      

        public IEnumerable<Cust_details> GetCust_details()
        {
            return _cargomanagementDBContext.Customer_Details.ToList();
        }

        public Cust_details GetCust_detailsbyid(int customerid)
        {
            return _cargomanagementDBContext.Customer_Details.Find(customerid);
        }

       
    }
}
