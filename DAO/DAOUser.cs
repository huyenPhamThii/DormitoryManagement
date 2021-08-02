using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DAOUser
    {
        DataTable dt = new DataTable();

        public bool checkUser(string account, string pass)
        {
            string str = "select * from Accounts where account='" + account + "' and pass='" + pass + "'";
            dt = (new DataProvider()).executeQuery(str);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool changePassword(string account, string newpass)
        {
            string str = "update Accounts set pass = '" + newpass + "' where account = '" + account + "'";
            return (new DataProvider().executeNonQuery(str));
        }

        public bool checkAccountExist(string account)
        {
            string str = "select * from Accounts where account='" + account + "'";
            dt = (new DataProvider()).executeQuery(str);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool isAdmin(string userName)
        {
            string sql = "SELECT * FROM Accounts WHERE account = '" + userName + "' AND isadmin = 1";
            if ((new DataProvider()).executeQuery(sql).Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool register(string account, string pass)
        {
            string str = "Insert into Accounts values('" + account + "','" + pass + "','0')";
            return (new DataProvider().executeNonQuery(str));
        }
    }
}
