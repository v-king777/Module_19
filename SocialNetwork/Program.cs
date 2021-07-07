﻿using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.UserServices;
using SocialNetwork.PLL.Views;
using System;

namespace SocialNetwork
{
    class Program
    {
        static MessageService messageService;
        static UserService userService;
        static FriendService friendService;
        public static MainView mainView;
        public static RegistrationView registrationView;
        public static AuthenticationView authenticationView;
        public static UserMenuView userMenuView;
        public static UserInfoView userInfoView;
        public static UserDataUpdateView userDataUpdateView;
        public static FriendAddingView friendAddingView;
        public static MessageSendingView messageSendingView;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserOutcomingMessageView userOutcomingMessageView;
        public static FriendsListView friendsListView;

        static void Main(string[] args)
        {
            userService = new UserService();
            messageService = new MessageService();
            friendService = new FriendService();
            mainView = new MainView();
            registrationView = new RegistrationView(userService);
            authenticationView = new AuthenticationView(userService);
            userMenuView = new UserMenuView(userService);
            userInfoView = new UserInfoView();
            userDataUpdateView = new UserDataUpdateView(userService);
            friendAddingView = new FriendAddingView(friendService, userService);
            messageSendingView = new MessageSendingView(messageService, userService);
            userIncomingMessageView = new UserIncomingMessageView();
            userOutcomingMessageView = new UserOutcomingMessageView();
            friendsListView = new FriendsListView();

            while (true)
            {
                mainView.Show();
            }
        }
    }
}
