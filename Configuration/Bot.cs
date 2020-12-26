using Bot.Models.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TelegramBotConsole.Models.Configuration
{
    public static class Bot
    {
        private static TelegramBotClient client;
        private static List<Command> _commandsList;
        public static IReadOnlyList<Command> Commands { get => _commandsList.AsReadOnly(); }
        /// <summary>
        /// Инициализация бота Telegram
        /// </summary>
        /// <returns></returns>
        public static TelegramBotClient Build()
        {
            if (client != null) return client;
            _commandsList = new List<Command>();
            _commandsList.Add(new HelloCommand());
            client = new TelegramBotClient(BotSettings.Key);
            return client;
        }
    }
}
