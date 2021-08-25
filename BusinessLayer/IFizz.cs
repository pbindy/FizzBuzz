using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.BusinessLayer
{
    public interface IFizz
    {       
        public List<string> FizzBuzz(int n);
    }
}
