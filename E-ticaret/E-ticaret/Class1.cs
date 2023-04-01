using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ticaret
{
    internal class Users
    {
        private string username;

        public string Username
        {
            get { return username; }
            set
            {
                bool oldumu = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetterOrDigit(value[i]))
                    {
                        oldumu = true;
                        break;
                    }
                }
                if (oldumu)
                {
                    throw new Exception("Kullanıcı Adı rakam veya harf dışında olamaz");
                }
                else
                {
                    this.username = value;
                }

            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                bool oldumu = false;
                int a;
                a = value.Length;
                if (a > 8)
                {
                    oldumu = true;

                }


                if (oldumu)
                {
                    throw new Exception("şifre 8 karakterden fazla olamaz");
                }
                else
                {
                    this.password = value;
                }
            }
        }
    }
}
