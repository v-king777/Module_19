﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class Friend
    {
        public Friend(int id, string userEmail, string friendEmail)
        {
            Id = id;
            UserEmail = userEmail;
            FriendEmail = friendEmail;
        }

        public int Id { get; }
        public string UserEmail { get; }
        public string FriendEmail { get; }
    }
}
