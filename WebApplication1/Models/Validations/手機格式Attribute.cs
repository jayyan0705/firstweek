using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApplication1.Models.Validations
{
    public class 手機格式Attribute : DataTypeAttribute
   {
       public 手機格式Attribute() : base(DataType.Text)
       {
          this.ErrorMessage = "手機格式錯誤";
       }

        public override bool IsValid(object value)
        {
            string str = Convert.ToString(value);



            if (! Regex.IsMatch(str, "[^d{4}]-[^d{6}]"))
            {
                return false;
            }

            return true;
        }
    }
}