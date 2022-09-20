using TranscationApp.Models;

namespace TranscationApp.Interfaces
{
    public interface ITranscationServices
    {
        Task<IEnumerable<TranscationModel>> GetAllTransactions();
        Task CreditAmount(TranscationModel transaction);
        string SetDebitAmount(TranscationModel transaction);
    }
}
