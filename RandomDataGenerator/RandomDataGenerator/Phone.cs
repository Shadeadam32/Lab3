using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    internal class Phone
    {
        public string Number
        {
            get;
            init;
        }
        public  Phone()
        {
            Number = Format();
        }
        

        public string Format(char separator  = '-')
        {
            Random rng = new Random();
            string phono = "";
            
            int[] randomNumbers = new int[10];
            for (int i = 1; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rng.Next(10);
            }

            if (randomNumbers[0] == 0 || randomNumbers[0] == 1)
            {
                randomNumbers[0] = rng.Next(2, 10);
            }

            foreach (int i in randomNumbers)
            {
                phono = phono + i;
            }
            return phono;

        }

    }
}
