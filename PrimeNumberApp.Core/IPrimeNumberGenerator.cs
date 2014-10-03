using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberApp.Core
{
   public interface IPrimeNumberGenerator
    {

     PrimeNumberResult GetNumbers(int count);

    }
}
