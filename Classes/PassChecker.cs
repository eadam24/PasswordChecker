using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker.Classes
{
    class PassChecker
    {
        private string password;
        private string[] specialChar = { "~", "!", "@", "#", ".", "$", "%", "^", "&", "*", "-", ",", "<", ">", ",", "/", "|", "\\"  };
        char[] UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] LowerCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
        char[] Nums = "1234567890".ToCharArray();


        private bool containsSpecialChars = false;
        private bool containsUpper = false;
        private bool containsLower = false;
        private bool containsNum = false;
        private bool isShort = true;

        public bool isStrong { get; set; }
        public PassChecker(string password)
        {
            this.password = password;
            isStrong = false;
        }

        public string CheckPassword()
        {
            if(password == null) { return "No password provided"; }

            string result = string.Empty;

            if (password.Length <= 8)
            {
                result = result + "Password is too short!";
                isShort = true;
            }
            else
            {
                isShort = false;
            }

            foreach(string c in specialChar)
            {
                if (password.Contains(c))
                {
                    containsSpecialChars = true;
                }
            }

            if(!containsSpecialChars)
            {
                result = result + "\nAdd special characters!";
            }

            foreach(char u in UpperCase)
            {
                if (password.Contains(u))
                {   
                    containsUpper = true;
                }
            }

            if (!containsUpper)
            {
                result = result + "\nAdd Upper Case!";
            }

            foreach (char u in LowerCase)
            {
                if (password.Contains(u))
                {
                    containsLower = true;
                }
            }

            if (!containsLower)
            {
                result = result + "\nAdd Lower Case!";
            }
            foreach (char u in Nums)
            {
                if (password.Contains(u))
                {
                    containsNum = true;
                }
            }

            if (!containsNum)
            {
                result = result + "\nAdd Numbers!";
            }

            if (containsLower && containsNum && containsSpecialChars && containsUpper && !isShort)
            {
                isStrong = true;
                return "Password is strong!";
            }

            return result;
        }
    }
}
