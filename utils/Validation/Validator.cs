using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.utils.Validation
{
   public  class Validator
    {
        private  string[] arrayErrors;

        public static void isValidMail(string email, string champ = "email")
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
               // return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                //return addr.Address == trimmedEmail;
                if(addr.Address == trimmedEmail)
                {
                    
                }
            }
            catch
            {
               // return false;
            }
        }
    }
}
