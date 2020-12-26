using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBotConsole.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Patronymic { get; set; }
        public enum Gender
        {
            Male,
            Female
        }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Position { get; set; }
        public string WorkPlace { get; set; }
        public bool AllPropsInit()
        {
            return typeof(User).GetProperties().All(p => p.GetValue(this) != null);
        }
    }
}
