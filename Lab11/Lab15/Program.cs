using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    enum PasswordStrength : byte
    {
        easy = 1,
        medium = 2,
        hard = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            string passLine = Console.ReadLine().ToString();
            char[] delimiter = { ' ' };
            string[] parts = passLine.Split(delimiter);
            string[] passwords = new string[3];
            PasswordStrength psEz = PasswordStrength.easy;
            PasswordStrength psMed = PasswordStrength.medium;
            PasswordStrength psHard = PasswordStrength.hard;
            passwords[0] = generatePassword(psEz);
            passwords[1] = generatePassword(psMed);
            passwords[2] = generatePassword(psHard);
            Console.WriteLine("Easy: {0}\nMedium: {1}\nHard: {2}", passwords[0], passwords[1], passwords[2]);
            Console.ReadKey();
        }
        static String generatePassword(PasswordStrength passwordStrength)
        {
            if (passwordStrength == PasswordStrength.easy)
            {
                return PassEasy();
            }
            else if (passwordStrength == PasswordStrength.medium)
            {
                Random random = new Random();
                return PassMedium(random.Next(6, 10));
            }
            else if (passwordStrength == PasswordStrength.hard)
            {
                Random random = new Random();
                return PassHard(random.Next(10, 40));
            }
            return "";
        }
        public static string PassEasy()
        {
            int length = 6;
            const string valid = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        public static string PassMedium(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        public static string PassHard(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_\\+=-/.<";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();


        }
    }
}
