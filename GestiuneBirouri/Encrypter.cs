using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneBirouri
{
    class Encrypter
    {
        private static String salt = "saltForStudenti"; ///ar trebui sa fie random si cumva in baza de date, dar pentru simplificare ramane asa.
        public String encryptPassword(string password)
        {
            byte[] bytesForPassword = System.Text.Encoding.UTF8.GetBytes(password + salt);
            System.Security.Cryptography.SHA256Managed hashString = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = hashString.ComputeHash(bytesForPassword);

            return BitConverter.ToString(hash).Replace("-", string.Empty); ;
        }
    }

    
}
