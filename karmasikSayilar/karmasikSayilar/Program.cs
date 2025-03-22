using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Top
{
    Top[] toplar = new Top[50];
    int grup, numara;
    int k = 0;

    public void olustur()
    {
        int[] grubu = new int { "1", "2", "3", "4", "5" };
        int[] numarasi = new int { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                toplar[k] = new Top();
                toplar[k].grup = grubu[i];
                toplar[k].numara = numarasi[j];
                k++;
            }
        }
    }


}
