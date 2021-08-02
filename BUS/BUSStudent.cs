
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAO;
namespace BUS
{
    public class BUSStudent
    {
        public DataTable loadStudent()
        {
            return (new DAOStudent()).loadStudent();
        }

        public DataTable loadStudentFromRoom(string a)
        {
            return (new DAOStudent()).loadStudentFromRoom(a);

        }
        public DataTable loadStudentFromDom(string a)
        {
            return (new DAOStudent()).loadStudentFromDom(a);

        }

        public DataTable searchStudent(string str)
        {
            return (new DAOStudent()).searchStudent(str);
        }
        public bool deleteStudent(string a)
        {
            return (new DAOStudent()).deleteStudent(a);
        }
        public bool updateStudent(string mssv, string name, string db, int gender, string address, string phone, string room)
        {
            return (new DAOStudent()).updateStudent(mssv, name, db, gender, address, phone, room);
        }
        public bool checkRollNumberInAcc(string mssv)
        {
            return (new DAOStudent()).checkRollNumberInAcc(mssv);
        }
        public bool checkRollNumberInStudents(string mssv)
        {
            return (new DAOStudent()).checkRollNumberInStudents(mssv);
        }
        public bool checkGender(int gender, string room)
        {
            return (new DAOStudent()).checkGender(gender, room);
        }
        public bool checkCount(string room)
        {
            return (new DAOStudent()).checkCount(room);
        }
        public bool addStudent(string mssv, string name, string db, int gender, string address, string phone, string room)
        {
            return (new DAOStudent()).addStudent(mssv, name, db, gender, address, phone, room);
        }


    }
}
