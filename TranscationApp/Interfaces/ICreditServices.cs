using TranscationApp.Models;

namespace TranscationApp.Interfaces
{
    public interface ICreditServices
    {
        ITranscationServices TranscationServices { get; }
        Task CreditAmount(TranscationModel transcationModel);
    }
}
