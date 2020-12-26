using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelegramBotConsole.Data;
using TelegramBotConsole.Models;

namespace TelegramBotConsole.Repositories
{
    public class UserRepository
    {
        private readonly ModelContext context;
        public UserRepository(ModelContext context)
        {
            this.context = context;
        }

        public User GetByEmail(string email)
        {
            return context.Users.FirstOrDefault(u => u.Email.Equals(email));
        }

        public User GetById(Guid id)
        {
            return context.Users.Find(id);
        }

        public void Register(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public bool UserExists(User user)
        {
            return context.Users.Any(u => u.Email.Equals(user.Email));
        }
    }
}
