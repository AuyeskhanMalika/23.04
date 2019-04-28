using System.Collections.Generic;

namespace Shop
{
    internal class Login
    {
        public bool Access(List<User> users, string userLogin, string userPsswd)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (userLogin == users[i].Login)
                {
                    if (userPsswd == users[i].Password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}