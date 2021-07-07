using SocialNetwork.BLL.Models;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserOutcomingMessageView
    {
        public void Show(IEnumerable<Message> outcomingMessages)
        {
            InfoMessage.Show("Исходящие сообщения");

            if (outcomingMessages.Count() == 0)
            {
                Console.WriteLine("Исходящих сообщений нет.");
                return;
            }

            outcomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine("Кому: {0}\nТекст сообщения: {1}", message.RecipientEmail, message.Content);
            });
        }
    }
}
