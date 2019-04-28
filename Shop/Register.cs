using System;
using System.Collections.Generic;

namespace Shop
{
    internal class Register
    {
        const int MIN_PSSWD_LEN = 6;
        public bool TryAddUser(List<User> users, out User newUser)
        {
            PasswordWriter passwordWriter = new PasswordWriter();
            newUser = new User();

            string usLoginStr, usPsswdStr;

            Console.WriteLine("New user");
            Console.WriteLine("Enter login: ");

            usLoginStr = Console.ReadLine();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Login == usLoginStr)
                {
                    Console.WriteLine("Login is already taken!");
                    return false;
                }
            }

            if (CheckUsername(usLoginStr))
            {
                Console.WriteLine($"Enter the password (more{MIN_PSSWD_LEN} characters):");
                usPsswdStr = passwordWriter.Write();

                if (CheckPassword(usPsswdStr))
                {
                    newUser.Login = usLoginStr.Trim();
                    newUser.Password = usPsswdStr;
                    return true;
                }
                else Console.WriteLine("Password is not long enough!");
            }
            else Console.WriteLine("Логин пустой!");

            return false;
        }

        private bool CheckUsername(string userName)
        {
            if (!string.IsNullOrWhiteSpace(userName))
            {
                return true;
            }
            return false;
        }
        private bool CheckPassword(string userPsswd)
        {
            if (!string.IsNullOrWhiteSpace(userPsswd))
            {
                if (userPsswd.Length > MIN_PSSWD_LEN)
                {
                    return true;
                }
            }
            return false;
        }
    }
}