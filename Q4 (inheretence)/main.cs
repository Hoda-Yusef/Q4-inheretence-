using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4__inheretence_
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // שיטה שמקבלת כל הערכים שהמשתמש הקליד אחרי לחיצה על קבל מידע
        private void result_Click(object sender, EventArgs e)
        {
            if (Length.Value >= 0 && height.Value >= 0 && width.Value >= 0 && weight.Value >= 0)//בודקים אם המשתמש לא הקליד ערכים שליליים
            {
                if (Length.Value != 0 && height.Value != 0 && width.Value != 0)//בודקים אם המשתמש לא השאיר תא ריק
                {
                    if (weight.Value != 0)//בודקים אם המשתמש הקליד משקל
                    {
                        if (weight.Value <= 150)//בודקים אם המשקל בטווח המתאים
                        {
                            if (superBox.checkSuper(Length.Value, height.Value, width.Value, weight.Value))//בודקים במחלקה אם הקופסה היא מסוג גדול
                            {
                                box b = new box(Length.Value, height.Value, width.Value, colorBox.Text);
                                float area = b.area_calculate();
                                float capacity = b.capacity_calculate();
                                screen.Text = "Type : SuperBox\n" + "Box's area : " + area + "\nBox's capacity : " + capacity + "\nColor : " + colorBox.Text;//מדפיס את סוג הקופסה ואת כל החישובים לקופסה
                            }
                            else
                                screen.Text = "Invalid box";
                        }
                        else
                            screen.Text = "Invalid box";
                    }
                    else
                    {
                        if(miniBox.checkMini(Length.Value, height.Value, width.Value))//בודקים במחלקה אם הקופסה היא מסוג הקטן
                        {
                            box b = new box(Length.Value, height.Value, width.Value, colorBox.Text);
                            float area = b.area_calculate();
                            float capacity = b.capacity_calculate();
                            screen.Text = "Type : MiniBox\n" + "Box's area : " + area + "\nBox's capacity : " + capacity + "\nColor : " + colorBox.Text;//מדפיס את סוג הקופסה ואת כל החישובים לקופסה
                        }
                        else
                            screen.Text = "Invalid box";
                    }
                }
                else
                    MessageBox.Show("Please fill out this fields");

            }
            else
                MessageBox.Show("Invalid value");
             


        }

       
    }
}
