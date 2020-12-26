using Bot.Models.Commands;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBotConsole.Services
{
   public class CommandsService
    {
        private IDictionary<string, Command> commands;
        private readonly ITelegramBotClient client;
        private readonly ILogger<CommandsService> logger = new NullLogger<CommandsService>();
        public CommandsService(ITelegramBotClient botClient)
        {
            commands = new Dictionary<string, Command>();
            client = botClient;
        }
        public void AddCommand(Command command)
        {
            commands.Add(command.Name, command);
        }
        public async void OnReceivingMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Text != null)
            {
                string mes = e.Message.Text;
                if (commands.ContainsKey(mes)){
                    Console.WriteLine($"Executing command {mes}...");
                    /*&& commands[mes].IsValidName(mes)*/ commands[mes].Execute(e.Message, client);
                }
                else
                {
                    var chatId = e.Message.Chat.Id;
                    var messageId = e.Message.MessageId;
                    Console.WriteLine($"No such command {mes}...");
                    //TODO: bot logic
                    await client.SendTextMessageAsync(chatId, "Sorry, unknown command", replyToMessageId: messageId, parseMode:
                        ParseMode.Markdown);
                }
                //commands[e.Message.Text].Execute(e.Message, client);
            }
            else {
                Console.WriteLine("Message is null...");
            }
        }
    }
}
