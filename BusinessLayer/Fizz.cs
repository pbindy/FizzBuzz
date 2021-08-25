using FizzBuzz.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.BusinessLayer
{
    public class Fizz : IFizz
    {
        public List<string> FizzBuzz(int n)
        {
            List<string> fizzBuzzList = new List<string>();
            try
            {               
                for (int i = 1; i <= n; i++)
                {
                    if (i % 105 == 0)
                    {
                        //write FizzBuzzJazz
                        fizzBuzzList.Add("FizzBuzzJazz");
                    }
                    else if (i % 35 == 0)
                    {
                        //write BuzzJazz
                        fizzBuzzList.Add("BuzzJazz");
                    }
                    else if (i % 21 == 0)
                    {
                        //write FizzJazz
                        fizzBuzzList.Add("FizzJazz");

                    }
                    else if (i % 15 == 0)
                    {
                        //write FizzBuzz
                        fizzBuzzList.Add("FizzBuzz");

                    }
                    else if (i % 7 == 0)
                    {
                        //write Jazz
                        fizzBuzzList.Add("Jazz");

                    }
                    else if (i % 5 == 0)
                    {
                        //write Buzz
                        fizzBuzzList.Add("Buzz");

                    }
                    else if (i % 3 == 0)
                    {
                        //write Fizz
                        fizzBuzzList.Add("Fizz");

                    }
                    else
                    {
                        //write i
                        fizzBuzzList.Add(i.ToString());
                    }
                }
                return fizzBuzzList;
            }
            catch (Exception ex)
            {
                FizzData fizzData = new FizzData();
                fizzData.AddLog(ex.Message);
                throw;
            }


        }
    }
}
