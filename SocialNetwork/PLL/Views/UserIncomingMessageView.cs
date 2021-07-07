﻿using SocialNetwork.BLL.Models;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserIncomingMessageView
    {
        public void Show(IEnumerable<Message> incomingMessages)
        {
            InfoMessage.Show("Входящие сообщения");

            if (incomingMessages.Count() == 0)
            {
                Console.WriteLine("Входящих сообщений нет.");
                return;
            }

            incomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine("От кого: {0}\nТекст сообщения: {1}", message.SenderEmail, message.Content);
            });
        }
    }
}
