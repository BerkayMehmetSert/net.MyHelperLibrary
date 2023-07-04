using Helper.Logging.Model;

namespace Helper.Logging;

public interface ILogModelCreatorService
{
    LogModel LogModel { get; }
    string ConvertToString();
}