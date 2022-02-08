using cargomanagementsystem.DAL.Data;
using cargomanagementsystem.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cargomanagementsystem.DAL.Repository
{ 

        public class TransactionRepo : ITransactionRepo
        {
            cargomanagementDbContext _cargomanagementDBContext;
            public TransactionRepo(cargomanagementDbContext cargomanagementDBContext)
            {
                _cargomanagementDBContext = cargomanagementDBContext;
            }
            public void AddTransaction_Details(Transaction transaction)
            {
                _cargomanagementDBContext.Transaction.Add(transaction);
                _cargomanagementDBContext.SaveChanges();
            }
            public void UpdateTransaction_Details(Transaction transaction)
            {
                _cargomanagementDBContext.Entry(transaction).State = EntityState.Modified;
                _cargomanagementDBContext.SaveChanges();
            }

            public void DeleteTransaction_Details(int Bill_no)
            {
                var transaction = _cargomanagementDBContext.Transaction.Find(Bill_no);
                _cargomanagementDBContext.Transaction.Remove(transaction);
                _cargomanagementDBContext.SaveChanges();
            }


            public IEnumerable<Transaction> GetTransaction_Details()
            {
                return _cargomanagementDBContext.Transaction.ToList();
            }

        public Transaction GetTransactiont_Detailsbyno(int Bill_no)
        {
            return _cargomanagementDBContext.Transaction.Find(Bill_no);

        }
        
    }
    
}
