using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4_DAL
{
    public class FactoryDal
    {
        public  IDAL getDal()
        {
            return new Class_dal_save_at_list();
        }

    }
}
