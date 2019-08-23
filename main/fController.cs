using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace main
{
    class fController
    {
        public clsDelete clsDelete1;
         public fController(String formName)
         {
             if (formName == "frmDelete")
             {
                 clsDelete1 = new clsDelete();
             }
         }

    }
}
