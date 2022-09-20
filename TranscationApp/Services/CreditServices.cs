using TranscationApp.Interfaces;
using TranscationApp.Models;

namespace TranscationApp.Services
{
    public class CreditServices : ICreditServices
    {
       private readonly ITranscationServices _services;
        public CreditServices(ITranscationServices services)
        {
            _services = services;
        }

        public ITranscationServices TranscationServices => throw new NotImplementedException();

        public Task CreditAmount(TranscationModel transcationModel)
        {
           return _services.CreditAmount(transcationModel); 
        }
    }
}
