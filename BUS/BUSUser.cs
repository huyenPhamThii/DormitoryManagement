using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
namespace BUS
{
    public class BUSUser
    {

        public bool checkUser(string account, string pass)
        {
            return (new DAOUser()).checkUser(account, pass);
        }
        public bool changePassword(string account, string newPass)
        {
            return (new DAOUser()).changePassword(account, newPass);
        }
        public bool checkAccountExist(string account)
        {
            return (new DAOUser()).checkAccountExist(account);
        }
        public bool register(string account, string pass)
        {
            return (new DAOUser()).register(account, pass);
        }

        public bool isAdmin(string userName)
        {
            return (new DAOUser()).isAdmin(userName);
        }
    }
}
