using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnesAssistent.DB;

namespace FitnesAssistent.Validation

{
    public class ValidationResult
    {
        //public static bool ValidationPassword(string password)
        //{
        //    if (password.Length < 8 || password.Length > 20)
        //        return false;
        //    if (!password.Any(Char.IsUpper))
        //        return false;
        //    if (!password.Any(Char.IsLower))
        //        return false;
        //    if (!password.Any(Char.IsDigit))
        //        return false;
        //    if (!password.Any(Char.IsPunctuation))
        //        return false;

        //    return true;
        //}


        public static bool ValidationPassword(string password)
        {
            if (password == null || password == "")
                return false;
            if (password.Length < 8 || password.Length > 20)
                return false;
            if (!password.Any(Char.IsUpper))
                return false;
            if (!password.Any(Char.IsLower))
                return false;
            if (!password.Any(Char.IsDigit))
                return false;
            if (!password.Any(Char.IsPunctuation))
                return false;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == ' ')
                    return false;
            }
            return true;








            //        if ((String.IsNullOrWhiteSpace(password)) || password == null)
            //        {
            //            return false;
            //        }
            //        if ((password.Length <= 8 || password.Length >= 20))
            //        {
            //            return false;
            //        }

            //        for (int i = 0; i < password.Length; i++)
            //        {
            //            if ((password[i] >= '0') && (password[i] <= '9'))
            //            {
            //                for (int j = 0; j < password.Length; j++)
            //                {
            //                    if ((password[j] >= 'a') && (password[j] <= 'z'))
            //                    {
            //                        for (int k = 0; k < password.Length; k++)
            //                        {
            //                            if ((password[k] >= 'A') && (password[k] <= 'Z'))
            //                            {
            //                                for (int c = 0; c < password.Length; c++)
            //                                {
            //                                    if ((password[c] >= '!') && (password[c] <= '?'))
            //                                    {
            //                                        return true;
            //                                    }
            //                                }
            //                            }
            //                        }
            //                        return false;
            //                    }
            //                }
            //                return false;
            //            }
            //        }
            //        return false;
        }

        public static bool ValidationLogin(string login)
        {
            if (login.Length < 2 || login.Length > 50)
                return false;

            if (AppData.context.User.Where(i => i.Login == login).FirstOrDefault() != null)
                {
                    return false;
                }
            return true;
            
        }
        public static bool ValidationDateOfBirth(DateTime dateofbirth)
        {
            if (dateofbirth >= DateTime.Now.Date)
            { 
                return false;
            }
            return true;
        }

        public static bool ValidationWeightHeight(string str)

        {
            if(int.TryParse(str,out int height)&& height>10 && height<300)
                return true;
            else
                return false;
        }

        public static bool ValidationNameLName(string namelname)
        {
            if (namelname == null || namelname == "")
            {
                return false;
            }
            if (namelname.Length < 2 || namelname.Length > 50)
            {
                return false;
            }
            string Symbs = "!\"#$%&'()*+,-./;:<=>?@[\\]:_{|}0123456789 ";
            if (namelname.IndexOfAny(Symbs.ToCharArray()) >=1)
            {
                return false;
            }
            return true;
        }





    }
}
