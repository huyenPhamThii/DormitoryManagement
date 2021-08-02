using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public class BUSBooking
    {

        public DataTable getBookingList()
        {
            return (new DAOBooking()).getBookingList();
        }

        public void bookingBed(string sql)
        {
            new DAOBooking().bookingBed(sql);
        }

        public DataTable getStatusOfBooking(string sql)
        {
            return (new DAOBooking()).getStatusOfBooking(sql);
        }

        public DataTable isRequested(string rollNumer)
        {
            return (new DAOBooking()).isRequested(rollNumer);
        }

        public bool updateRequest(string sql)
        {
           return new DAOBooking().updateRequest(sql);
        }

        public bool deleteStudentFromBooking(string rollNumber)
        {
            return (new DAOBooking()).deleteStudentFromBooking(rollNumber);
        }

        public object getBookingListHistory()
        {
            return (new DAOBooking()).getBookingListHistory();
        }
    }
}
