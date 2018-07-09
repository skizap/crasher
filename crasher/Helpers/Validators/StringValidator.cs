using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Helpers.Validators
{
    public class StringValidator : Validator
    {
        public override bool IsValid(string value)
        {
            if (!String.IsNullOrWhiteSpace(value))
            {
                return true;
            }
            else
            {
                this.ErrorMessage = "String is null, whitespace or empty: " + value;
                return false;
            }
        }
    }
}
