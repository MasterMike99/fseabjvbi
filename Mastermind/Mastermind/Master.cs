using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
   
    class Master
    {
        int[] zahl = new int[5];
        public void Start()
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                int neger = r.Next(1, 9);
                for (int a = 0; a < 5; a++)
                {
                    if (neger == zahl[a])
                    {
                        i--;
                    }
                }
                zahl[i] = neger;
            }
            
        }
        public int Schwarz;
        //public void getSchwarz(zahl[], feld[])
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        if (zahl[i] == feld[i]) 
        //        {
        //        Schwarz++;
        //        }
        //    }
        //    return;
        //}
        
    }
}
