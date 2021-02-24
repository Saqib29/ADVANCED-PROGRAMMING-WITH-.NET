using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DbFirstApproach.Attributes
{
    public class NameCheckAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value == null || value.ToString().Contains("+"))
            {
                return false;
            }
            return true;
        }
    }
}