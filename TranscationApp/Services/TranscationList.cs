using TranscationApp.Interfaces;
using TranscationApp.Models;
namespace TranscationApp.Services
{
    public class TranscationList : ITranscationList
    {
        private readonly ITranscationServices _services;
        public TranscationList(ITranscationServices services)
        {
            _services = services;
        }

        public Task<IEnumerable<TranscationModel>> GetAllTransactions()
        {
           return _services.GetAllTransactions();
        }
    }
}
