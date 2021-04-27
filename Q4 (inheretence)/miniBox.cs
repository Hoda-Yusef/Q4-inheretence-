//Hoda Khier + Yusef Aborokon 44/5
using System;
using System.Collections.Generic;
using System.Text;

namespace Q4__inheretence_
{
    class miniBox
    {

        //שיטה סטטית מקבלת ערכים ומחזירה אמת אם הערכים תואמים ושקר אם לא
        public static Boolean checkMini(decimal length, decimal hight, decimal width)
        {
            if ((float)hight <= 0.5 && (float)length <= 0.5 && (float)width <= 0.5)
            {
                return true;
            }
            else
                return false;
        }
    }
}
