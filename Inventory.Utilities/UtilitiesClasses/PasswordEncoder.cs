using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Utilities.UtilitiesClasses
{
   public class PasswordEncoder
    {
        public static string EncodePassword(string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            string encodedPassword = Convert.ToBase64String(passwordBytes);
            return encodedPassword;
        }

    }
}
