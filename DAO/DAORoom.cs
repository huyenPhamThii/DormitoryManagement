using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DAORoom
    {
        public DataTable loadRoom(string a)
        {
            return (new DataProvider()).executeQuery("Select roomID AS Room from Rooms where domID='" + a + "'");
        }

        public DataTable getTypeOfRoom(string sql)
        {
            return (new DataProvider()).executeQuery(sql);
        }

        public DataTable getStudentQuantityInRoom(string sql)
        {
            return (new DataProvider()).executeQuery(sql);
        }

        public DataTable getStudentByGender(string sql)
        {
            return (new DataProvider()).executeQuery(sql);
        }
        public void countAdd(string room)
        {
            string str = "update Rooms set count=(count+1) where roomID='" + room + "'";
            (new DataProvider()).executeNonQuery(str);
        }
        public void countMinus(string room)
        {
            string str = "update Rooms set count=(count-1) where roomID='" + room + "'";
            (new DataProvider()).executeNonQuery(str);
        }

        public object loadRoomNotFull(string a, string b)
        {
            return (new DataProvider()).executeQuery("Select roomID as 'Room', count as 'Quantity Of Student' FROM Rooms where count < quantity and domID = '" + a + "' and roomRole = '" + b + "'");
        }

        public object loadRoomUsage(string a, string b)
        {
            return (new DataProvider()).executeQuery("Select SUM(quantity) As 'TotalBed', SUM(count) AS'UsedBed', SUM(quantity)-SUM(count) as 'FreeBed'from Rooms where domID = '" + a + "' and roomRole = '" + b + "'");
        }

    }
}
