using JuanTemplate.Models;

namespace JuanTemplate.Interfaces
{
    public interface ILayoutService
    {
        Task<IDictionary<string, string>> GetSettings();
    }
}
