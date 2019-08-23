using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace main
{
    class Controller
    {
        public clsDelete clsDelete1;
        public clsInsert clsInsert1;
        public clsUpdate clsUpdate1;

        public Controller(String formName)
        {
            if (formName == "frmInsert")
            {
                clsInsert1 = new clsInsert();
            }
            else if (formName == "frmDelete")
            {
                clsDelete1 = new clsDelete();
            }
            else if (formName == "frmUpdate")
            {
                clsUpdate1 = new clsUpdate();

            }

        }
    }
}