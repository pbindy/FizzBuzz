using FizzBuzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.DataLayer
{
    public class FizzData
    {
        public bool AddLog(string log)
        {            
            using (var dataModel = new FizzContext())
            {
                using (var dbContextTransaction = dataModel.Database.BeginTransaction())
                {
                    try
                    {
                        dataModel.Logs.Add(new Log
                        {
                            Id = Guid.NewGuid(),
                            LogDetail = log
                        });

                        int flag = dataModel.SaveChanges();
                        dbContextTransaction.Commit();
                        return flag > 0;
                    }
                    catch (Exception)
                    {
                        dbContextTransaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
