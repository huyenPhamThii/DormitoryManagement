using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class BUSDom
    {
        public bool checkDom(string dom)
        {
            return (new DAODom()).checkDom(dom);
        }
        public bool addDom(string dom, int quantity)
        {
            return (new DAODom()).addDom(dom, quantity);
        }
    }
}
