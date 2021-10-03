using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_BL
{
    public class Cass_BlAdapter
    {
       Ex3_DAL.IDAL dal = new  Ex3_DAL.Class_dal_save_at_list();

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
