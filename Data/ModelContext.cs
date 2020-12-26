using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TelegramBotConsole.Models;

namespace TelegramBotConsole.Data
{
    public class ModelContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
        {

        }
    }
}
