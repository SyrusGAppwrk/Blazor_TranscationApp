using TranscationApp.Interfaces;
using TranscationApp.Models;
namespace TranscationApp.Services
{
    public class TranscationServices : ITranscationServices
    {
       private readonly TranscationContext _context;
        public TranscationServices(TranscationContext context)
        {
            _context = context; 
        }

        public async Task CreditAmount(TranscationModel transaction)
        {
           var balance= _context.Transactions.OrderByDescending(t => t.id).Take(1).Select(x=>x.Balance).ToList().FirstOrDefault();
            transaction.Balance = balance+transaction.Credit;
            transaction.Date = DateTime.UtcNow;
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<TranscationModel>> GetAllTransactions()
        {
            return  _context.Transactions.ToList();
        }

        public string SetDebitAmount(TranscationModel transaction)
        {
            var balance = _context.Transactions.OrderByDescending(t => t.id).Take(1).Select(x => x.Balance).ToList().FirstOrDefault();
            if (balance > 0 && transaction.Debit <= balance)
            {
                transaction.Balance = balance - transaction.Debit;
                transaction.Date = DateTime.Now;
                _context.Transactions.Add(transaction);
                _context.SaveChanges();
                return "Withdrawl Successfull!!";
            }
            else
            {
                return "There is not sifficient Balance to Withdraw";
            }

        }
    }
}
