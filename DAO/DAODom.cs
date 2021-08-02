using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DAODom

    {
        DataTable dt = new DataTable();

        public bool checkDom(string dom)
        {
            string str = "select * from Doms where domID='" + dom + "";
            dt = (new DataProvider()).executeQuery(str);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool addDom(string dom, int quantity)
        {
            string str = "insert into Doms values ('" + dom + "', " + quantity + ");" +
                "INSeRT INTO Rooms (roomID,quantity,roomRole,count,domID) VaLUeS ('" + dom + "101'," + quantity + ",0,0,'" + dom + "'),('" + dom + "102'," + quantity + ",0,0,'" + dom + "'),('" + dom + "103'," + quantity + ",1,0,'" + dom + "'),('" + dom + "104'," + quantity + ",0,0,'" + dom + "'),('" + dom + "105'," + quantity + ",1,0,'" + dom + "'),('" + dom + "106'," + quantity + ",1,0,'" + dom + "'),('" + dom + "107'," + quantity + ",0,0,'" + dom + "'),('" + dom + "108'," + quantity + ",0,0,'" + dom + "'),('" + dom + "109'," + quantity + ",1,0,'" + dom + "'),('" + dom + "110'," + quantity + ",0,0,'" + dom + "')," +
                "('" + dom + "111', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "112', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "113', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "114', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "201', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "202', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "203', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "204', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "205', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "206', " + quantity + ", 1, 0, '" + dom + "')," +
                "('" + dom + "207', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "208', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "209', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "210', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "211', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "212', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "213', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "214', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "301', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "302', " + quantity + ", 1, 0, '" + dom + "')," +
                "('" + dom + "303', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "304', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "305', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "306', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "307', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "308', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "309', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "310', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "311', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "312', " + quantity + ", 0, 0, '" + dom + "')," +
                "('" + dom + "407', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "408', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "313', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "314', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "401', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "402', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "403', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "404', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "405', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "406', " + quantity + ", 0, 0, '" + dom + "')," +
                "('" + dom + "409', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "410', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "411', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "412', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "413', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "414', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "501', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "502', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "503', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "504', " + quantity + ", 0, 0, '" + dom + "')," +
                "('" + dom + "505', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "506', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "507', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "508', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "509', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "510', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "511', " + quantity + ", 1, 0, '" + dom + "'),('" + dom + "512', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "513', " + quantity + ", 0, 0, '" + dom + "'),('" + dom + "514', " + quantity + ", 0, 0, '" + dom + "');";
            return (new DataProvider()).executeNonQuery(str);

        }
    }
}
