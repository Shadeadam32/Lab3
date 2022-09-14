using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    internal class SSN
    {
        public string _number
        {
            get; init;
        }

        public SSN()
        {
            _number = GenerateInvalidSSN();
        }

        public string GenerateInvalidSSN()
        {
            string FalseSSN = String.Empty;
            Random rand = new Random();

            //gives a number from 900 999
            var nHundred = rand.Next(900, 1000).ToString();
            var triples = new string[] { "000", "666", nHundred };

            var first = triples[rand.Next(3)];
            var second = "00";
            var last = "0000";

            FalseSSN = first + second + last;
            return FalseSSN;
        }

        public override string ToString()
        {
            string social = _number;
            social = social.Insert(3, "-");
            social = social.Insert(6, "-");
            return social;
        }
    }
}
