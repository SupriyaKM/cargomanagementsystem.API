using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace cargomanagementsystem.DAL.Repository
{
   public interface ITransactionRepo
    {
        void AddTransaction_Details(Transaction transaction);
        void UpdateTransaction_Details (Transaction transaction);
        void DeleteTransaction_Details(int Bill_no);
        Transaction GetTransactiont_Detailsbyno(int Bill_no);
        IEnumerable<Transaction> GetTransaction_Details();
    }
}
