using TranscationApp.Models;

namespace TranscationApp.Interfaces
{
    public interface IDebitServices
    {
        ITranscationServices TranscationServices { get; }
        string DebitAmount(TranscationModel transcationModel);
    }
}
