using Bot.Models.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotConsole.Data;
using TelegramBotConsole.Interfaces;

namespace TelegramBotConsole.Models.Commands
{
    public class RegistrationCommand : Command
    {
        public override string Name { get => "Registration"; }
        private readonly IUserRepository users;
        private User user;
        public RegistrationCommand(IUserRepository users)
        {
            this.users = users;
            user = new User();
        }

        public override void Execute(Message message, ITelegramBotClient client)
        {
        }
    }
}
