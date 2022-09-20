using TranscationApp.Models;
namespace TranscationApp.Interfaces

{
    public interface ITranscationList
    { 
        Task<IEnumerable<TranscationModel>> GetAllTransactions();
    }
}
