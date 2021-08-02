using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class BUSRoom
    {
        public DataTable loadRoom(string a)
        {
            return (new DAORoom()).loadRoom(a);
        }

        public DataTable getTypeOfRoom(string sql)
        {
            return (new DAORoom()).getTypeOfRoom(sql);
        }

        public DataTable getStudentQuantityInRoom(string sql)
        {
            return (new DAORoom()).getStudentQuantityInRoom(sql);
        }

        public DataTable getStudentByGender(string sql)
        {
            return (new DAORoom()).getStudentByGender(sql);
        }
        public void countAdd(string room)
        {
            (new DAORoom()).countAdd(room);
        }
        public void countMinus(string room)
        {
            (new DAORoom()).countMinus(room);
        }


        public object loadRoomNotFull(string a, string b)
        {
            return (new DAORoom()).loadRoomNotFull(a, b);
        }

        public object loadRoomUsage(string a, string b)
        {
            return (new DAORoom()).loadRoomUsage(a, b);
        }
    }
}
