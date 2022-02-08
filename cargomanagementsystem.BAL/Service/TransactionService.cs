using cargomanagementsystem.DAL.Repository;
using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace cargomanagementsystem.BAL.Service
{
   public class TransactionService
    {
        ITransactionRepo _transactionRepo;
        public TransactionService(ITransactionRepo transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }
        public void AddTransaction_Details(Transaction transaction)
        {
            _transactionRepo.AddTransaction_Details(transaction);

        }
        public void UpdateTransaction_Details(Transaction transaction)
        {
            _transactionRepo.UpdateTransaction_Details(transaction);
        }
        public void DeleteTransaction_Details(int Bill_no)
        {
            _transactionRepo.DeleteTransaction_Details(Bill_no);
        }

        public void GetTransaction_Detailsbyno(int Bill_no)
        {
            _transactionRepo.GetTransactiont_Detailsbyno(Bill_no);
        }
        public void GetTransaction_Details()
        {
            _transactionRepo.GetTransaction_Details();
        }
        public IEnumerable<Transaction> GetTransaction()
        {
            return _transactionRepo.GetTransaction_Details();
        }
    }
}
