using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crasher.Helpers.Validators
{
    public class IntegerValidator : Validator
    {
        /**
         * Il valore minimo accettato.
         */
        private readonly int _minValue;

        /**
         * Il valore massimo accettato.
         */
        private readonly int _maxValue;

        public IntegerValidator(int minValue, int maxValue)
        {
            this._minValue = minValue;
            this._maxValue = maxValue;
        }

        public override bool IsValid(string value)
        {
            if (value == null)
            {
                ErrorMessage = "null string not permitted";
                return false;
            }
            else if (value.Length == 0)
            {
                ErrorMessage = "empty string not permitted";
                return false;
            }
            else
            {
                try
                {
                    int n = Int32.Parse(value);
                    if (n < _minValue)
                    {
                        this.ErrorMessage = "value too small: " + value;
                        return false;
                    }
                    else if (n > _maxValue)
                    {
                        this.ErrorMessage = "value too big: " + value;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (FormatException fe)
                {
                    this.ErrorMessage = "value not valid: " + value;
                    return false;
                }
            }

        }
    }
}
