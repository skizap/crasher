using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Helpers.Validators
{
    public class Validator
    {
        protected string ErrorMessage = "";

        public virtual bool IsValid(string value)
        {
            ErrorMessage = "";
            if(!String.IsNullOrWhiteSpace(value))
            {
                return true;
            }
            else
            {
                ErrorMessage = "String too short: " + value;
                return false;
            }
        }

        public string GetErrorMessage()
        {
            return ErrorMessage;
        }

    }
}
