using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1_BL
{
    public class MyBl
    {
        Ex1_DAL.MyDal dal;

        public MyBl()
        {
            dal = new Ex1_DAL.MyDal();
        }

        public string getResult()
        {
            return "result is:" + dal.getValue();
        }
    }
}
