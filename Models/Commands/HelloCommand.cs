using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
namespace Bot.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name { get => @"/hello"; }

        public override async void Execute(Message message, ITelegramBotClient client)
        {
            logger.LogInformation("Start executing command " + Name);
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;
            //TODO: bot logic
            var botMessage = await client.SendTextMessageAsync(chatId, "Hello!", replyToMessageId: messageId, parseMode: 
                ParseMode.Markdown);
            logger.LogInformation(botMessage.MessageId.ToString());
        }
    }
}
