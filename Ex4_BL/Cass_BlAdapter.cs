using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4_BL
{
    public class Cass_BlAdapter
    {
        
        Ex4_DAL.IDAL dal;
        public Cass_BlAdapter()
        {
            Ex4_DAL.FactoryDal factory =
                new Ex4_DAL.FactoryDal();
            dal = factory.getDal();
        }

        public void add()
        {
            dal.add();

        }
        public void remove()
        {
            dal.remove();
        }
        ///…
    }
}
