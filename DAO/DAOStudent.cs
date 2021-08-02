using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DAOStudent
    {
        public DataTable loadStudent()
        {
            return (new DataProvider()).executeQuery("SELECT Students.*, quantity, roomRole, [count], domID from Students " +
                "inner join Rooms on  Students.roomID=rooms.roomID WHERE Rooms.domID= 'A'");
        }

        public DataTable loadStudentFromRoom(string a)
        {
            return (new DataProvider()).executeQuery("SELECT Students.*, quantity, roomRole, [count], domID from Students " +
                "inner join Rooms on  Students.roomID=rooms.roomID WHERE Students.roomID = '" + a + "'");
        }

        public DataTable loadStudentFromDom(string a)
        {
            return (new DataProvider()).executeQuery("SELECT Students.*, quantity, roomRole, [count], domID from Students " +
                "inner join Rooms on  Students.roomID=rooms.roomID where Rooms.domID= '" + a + "'");
        }


        public DataTable searchStudent(string str)
        {
            return (new DataProvider()).executeQuery(str);
        }
        public bool deleteStudent(string a)
        {
            string str = "delete from Students where rollNumber='" + a + "'";
            return (new DataProvider().executeNonQuery(str));
        }
        public bool updateStudent(string mssv, string name, string db, int gender, string address, string phone, string room)
        {
            string str = "update Students set studentName='" + name + "',dateBirth='" + db + "',gender=" + gender + ",address='" + address + "'," +
                "phone='" + phone + "',roomID='" + room + "' where rollNumber='" + mssv + "';";
            return (new DataProvider().executeNonQuery(str));

        }
        public bool checkRollNumberInAcc(string mssv)
        {
            DataTable dt = new DataTable();
            string str = "select * from Accounts where account='" + mssv + "'";
            dt = (new DataProvider()).executeQuery(str);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool checkRollNumberInStudents(string mssv)
        {
            DataTable dt = new DataTable();
            string str = "select * from Students where rollNumber='" + mssv + "'";
            dt = (new DataProvider()).executeQuery(str);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool checkGender(int gender, string room)
        {
            DataTable dt = new DataTable();
            string str = "select * from Rooms where roomID='" + room + "' and roomRole=" + gender + ";";
            dt = (new DataProvider()).executeQuery(str);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool checkCount(string room)
        {
            DataTable dt = new DataTable();
            string str = "select * from Rooms where roomID='" + room + "' and quantity>count";
            dt = (new DataProvider()).executeQuery(str);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool addStudent(string mssv, string name, string db, int gender, string address, string phone, string room)
        {
            string str = "insert into Students values ('" + mssv + "','" + name + "','" + db + "'," + gender + ",'" + address + "'," +
                "'" + phone + "','" + room + "');";
            return (new DataProvider().executeNonQuery(str));

        }



    }
}
