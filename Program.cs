using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotConsole.Data;
using TelegramBotConsole.Models.Configuration;
using TelegramBotConsole.Services;

namespace ConsoleApp1
{
    class Program
    {
        private static TelegramBotClient botClient;

        static void Main(string[] args)
        {
            TelegramBotConsole.Models.User user = new TelegramBotConsole.Models.User();
            Console.WriteLine(user.AllPropsInit());
            /*user.City = "a";
            user.Email = "b";
            user.Firstname = "C";
            user.Lastname = "d";
            user.*/
            /*botClient = new TelegramBotClient(BotSettings.Key);
            var commands = new CommandsService(botClient);
            botClient.OnMessage += commands.OnReceivingMessage;
            botClient.StartReceiving();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            botClient.StopReceiving();*/
        }

       
    }
}
