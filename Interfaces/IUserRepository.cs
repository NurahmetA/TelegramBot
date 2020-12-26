using System;
using System.Collections.Generic;
using System.Text;
using TelegramBotConsole.Models;

namespace TelegramBotConsole.Interfaces
{
    public interface IUserRepository
    {
        void Register(User user);
        bool UserExists(User user);
        User GetById(Guid id);
        User GetByEmail(string email);
    }
}
