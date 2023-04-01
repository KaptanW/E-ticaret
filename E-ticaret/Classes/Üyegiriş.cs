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

        private string name;

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        private string surname;

        public string SURNAME
        {
            get { return surname; }
            set { surname = value; }
        }

        private string adress;

        public string ADRESS
        {
            get { return adress; }
            set { adress = value; }
        }

        private string date;

        public string DATE
        {
            get { return date; }
            set { date = value; }
        }


        public bool giriş(string isim, string sifre)
        {
            if(isim == Username)
            {
                if(sifre == Password)
                {
                    return true;
                }
                else
                {
                    if (sifre.Length > 8)
                    {
                        throw new Exception("Şifre 8 Karakterden fazla olamaz");
                    }
                    else
                    {
                        throw new Exception("Girdiğiniz şifre hatalıdır.");
                    }
                }
            }
            else
            {
                for (int i = 0; i < isim.Length; i++)
                {
                    if (!char.IsLetterOrDigit(isim[i]))
                    {
                        throw new Exception("Kullanıcı Adı rakam veya harf dışında olamaz");
                    }
                }
                return false;
            }
        }
    }
}
