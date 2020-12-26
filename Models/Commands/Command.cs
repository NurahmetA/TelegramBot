using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Bot.Models.Commands
{
    public abstract class Command
    {
        public readonly ILogger<Command> logger = new NullLogger<Command>();
        public abstract string Name { get; }
        public abstract void Execute(Message message, ITelegramBotClient client);
        public bool IsValidName(string name) => name == Name;
    }
}
