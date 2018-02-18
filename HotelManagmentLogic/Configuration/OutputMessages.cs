﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Configuration
{
    class OutputMessages
    {
        public const string InvalidUserNameSyntax = "Invalid Username, please do not use special characters";
        public const string InvalidPasswordSyntax = "Invalid Password, please do not use special characters";
        public const string UserNameDuplicated = "This Username is already in use";

        public const string RegisterSuccesfulMessage = "User registered successfully";
        public const string UserInformationValid = "User information - valid";

        public static string InvalidUserName()
        {
            return String.Format("The Username must be between {0} and {1} characters long",
                                                Config.MinimumUserLenght, Config.MaxUserLength);
        }

        public static string InvalidPassword()
        {
            return String.Format("The Password must be between {0} and {1} characters long",
                                                Config.MinimumPasswordLenght, Config.MaxPasswordLength);
        }

        public static string PasswordNoMatch = "Password doesn't match";
    }
}