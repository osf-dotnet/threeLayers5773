using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex2_DAL;


namespace Ex2_BL
{
    public class Cass_BlAdapter
    {
      Class_dal_save_at_list dal =
          new  Ex2_DAL.Class_dal_save_at_list();

       public void add()
       {
           /// 
           dal.add();
       }
       public void remove()
       {
           dal.remove();
       }
        ///…
    }
}
