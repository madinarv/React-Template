using JuanTemplate.DataAccesLayer;
using JuanTemplate.Interfaces;
using JuanTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace JuanTemplate.Services
{
    public class LayoutService : ILayoutService
    {
        private readonly AppDbContex _appDbContex;

        public LayoutService(AppDbContex appDbContex)
        {
            _appDbContex = appDbContex;
        }

        public async Task<IDictionary<string, string>> GetSettings() 
        {
            IDictionary<string,string> settings = await _appDbContex.Settings.ToDictionaryAsync(s=> s.Key,s => s.Value);
            
            return settings;
        }
    }
}
