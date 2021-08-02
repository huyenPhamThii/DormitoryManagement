using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DAOBooking
    {

        public DataTable getBookingList()
        {
            return (new DataProvider()).executeQuery("SELECT * FROM Booking");
        }

        public bool bookingBed(string sql)
        {
            return (new DataProvider().executeNonQuery(sql));
        }

        public DataTable getStatusOfBooking(string sql)
        {
           return (new DataProvider()).executeQuery(sql);
        }

        public DataTable isRequested(string rollNumer)
        {
            return (new DataProvider().executeQuery("SELECT * FROM Booking WHERE rollNumber = '"+rollNumer+"'"));
        }

        public bool updateRequest(string sql)
        {
            return (new DataProvider().executeNonQuery(sql));
        }

        public bool deleteStudentFromBooking(string rollNumber)
        {
            return (new DataProvider()).executeNonQuery(" DELETE  FROM Booking WHERE rollNumber ='"+rollNumber+"'");
        }

        public object getBookingListHistory()
        {
            return (new DataProvider()).executeQuery("SELECT * FROM BookingHistory");
        }
    }
}
