using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdlingComplaintTest.Utils
{
    public static class StringUtilities
    {
        public static string GenerateRandomString(int length)
        {
            const string acceptedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            string str = string.Empty;
            for (int i = 0; i < length; i++)
            {
                str += acceptedChars[random.Next(0, acceptedChars.Length)];
            }
            return str;
        }

    }
}
