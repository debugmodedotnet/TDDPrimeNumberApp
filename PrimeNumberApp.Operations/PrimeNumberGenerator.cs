using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeNumberApp.Core;

namespace PrimeNumberApp.Operations
{
    public class PrimeNumberGenerator  : IPrimeNumberGenerator
    {       
        List<int> IPrimeNumberGenerator.GetNumbers(int count)
        {
            int i, j; 
            List<int> lstPrimeNumbers = new List<int>();
            lstPrimeNumbers.Add(1);
           
            for ( i = 2; i <= count; i++ )
            {
                 for( j = 2; j <i; j++)
                 {
                     if (i % j == 0)
                     {
                         break;
                     }
                    
                 }

                 if (j == i)
                 {
                     lstPrimeNumbers.Add(i);
                 }
            }

            return lstPrimeNumbers; 
                
        }
    }
}
