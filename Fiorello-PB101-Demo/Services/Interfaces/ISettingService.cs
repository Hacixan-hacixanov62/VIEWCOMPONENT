namespace Fiorello_PB101_Demo.Demo.Services.Interfaces
{
    public interface ISettingService
    {
        Task<Dictionary<string, string>> GetSettingAsync();
    }
}
