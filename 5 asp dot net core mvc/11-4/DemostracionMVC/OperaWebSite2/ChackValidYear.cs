using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using OperaWebSite2.Models;
using System.ComponentModel.DataAnnotations;


namespace OperaWebSite2
{
    public class ChackValidYear : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int year = (int)value;
            return year < 1598;
            
        }
    }
}

