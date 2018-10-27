using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordChecker
{
    class Password
    {
        private int _length;
        private string _value;

        public Password()
        {
            _length = 0;
            _value = null;
        }

        public Password(int length)
        {
            _length = length;
            GeneratePassword();
        }

        public void GeneratePassword()
        {
            Random rng = new Random();
            string value = "";
            
            for(int i = 0; i < _length; i++)
            {
                value += (char)rng.Next(33, 126);
            }

            _value = value.ToString();
        }

        public bool IsStrong()
        {
            bool isStrong = false,
                isLower = false,
                isUpper = false,
                isDigit = false,
                isSymbol = false;

            for(int i = 0; i < _length; i++)
            {
                if (char.IsSymbol(_value[i]))
                    isSymbol = true;
                else if (char.IsDigit(_value[i]))
                    isDigit = true;
                else if (char.IsLower(_value[i]))
                    isLower = true;
                else if (char.IsUpper(_value[i]))
                    isUpper = true;
            }
            if (isUpper && isLower && isDigit && isSymbol)
                isStrong = true;

            return isStrong;
        }

        //accessors
        public int GetLength()
        {
            return _length;
        }
        public string GetValue()
        {
            return _value;
        }

        //mutators
        public void SetLength(int length)
        {
            _length = length;
        }
    }
}
