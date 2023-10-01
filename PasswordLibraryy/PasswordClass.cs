using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordLibraryy
{
    public class PasswordClass
    {
        public bool CheckPassword(string password)
        {
            string regex = @"^(?=.{8,15}$)((?=.*\d)(?=.*[a-z])(?=.*[A-Z]))";
            string secondRegex = @"[(\!\@\#\$\%\^\&\*\(\)\{\}\;\.\,\[\]\+\=\-\>\<]";
            string thirdRegex = @"(?=.*[а-я])|(?=.*[А-Я])";

            if (Regex.Match(password, regex).Success && Regex.Match(password, secondRegex).Success && !Regex.Match(password, thirdRegex).Success)
            {
                return true;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
