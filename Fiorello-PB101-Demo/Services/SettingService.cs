﻿using Fiorello_PB101_Demo.Data;
using Fiorello_PB101_Demo.Demo.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_PB101_Demo.Demo.Services
{
    public class SettingService : ISettingService
    {
        private readonly AppDbContext _context;
        public SettingService(AppDbContext context)
        {
          _context = context;
        }
        public async Task<Dictionary<string, string>> GetSettingAsync()
        {
            return await _context.Settings.ToDictionaryAsync(m=>m.Key, m=>m.Value); 
        }
    }
}
