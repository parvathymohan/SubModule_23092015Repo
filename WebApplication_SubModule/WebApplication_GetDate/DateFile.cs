using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_GetDate
{
    public class DateFile
    {

        public string get_Date()
        {
            string currDate = string.Empty;
            currDate = DateTime.Now.ToString();
            return currDate;

        }

    }
}