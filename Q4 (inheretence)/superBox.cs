using System;
using System.Collections.Generic;
using System.Text;

namespace Q4__inheretence_
{
    class superBox
    {
        //שיטה סטטית מקבלת ערכים ומחזירה אמת אם הערכים תואמים ושקר אם לא
        public static Boolean checkSuper(decimal length, decimal hight, decimal width, decimal weight)
        {
            if (hight <= 3 && length <= 3 && width <= 3 && weight <=150)
            {
                return true;
            }
            else
                return false;
        }

      
    }
}
