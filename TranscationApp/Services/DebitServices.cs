using TranscationApp.Interfaces;
using TranscationApp.Models;

namespace TranscationApp.Services
{
    public class DebitServices : IDebitServices
    {
        private readonly ITranscationServices _services;
        public DebitServices(ITranscationServices services)
        {
            _services = services;   
        }

        public ITranscationServices TranscationServices => throw new NotImplementedException();

        public string DebitAmount(TranscationModel transcationModel)
        {
            return  _services.SetDebitAmount(transcationModel);
        }
    }

}
