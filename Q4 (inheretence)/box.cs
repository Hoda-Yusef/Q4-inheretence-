using System;
using System.Collections.Generic;
using System.Text;

namespace Q4__inheretence_
{
    class box
    {
        //תכונות של מחלקה
        private decimal length;
        private decimal hight;
        private decimal width;
        private string color;


       
        //בנאי מקבל ערכים 
        public box(decimal length, decimal hight, decimal width, string color)
        {
            this.length = length;
            this.hight = hight;
            this.width = width;
            this.color = color;
        }

        public float area_calculate()//שיטה לחישוב שטח של קופסה
        {
            return (float)(2 * (width * length) + 2 * (width * hight) + 2 * (length * hight));
        }

        public float capacity_calculate()//שיטה לחישוב נפח של קופסה
        {
            return (float)(length * width * hight);
        }
     


        
    }
}
