using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolinaQuimExamenM5UF2
{
    public class ClRecu

    {
        private StreamReader fitxer;


        public static List<int> QuantesVocals(string xs)
        {
            xs=xs.ToUpper();
            List<int> result = new List<int>();
            result.Add(0);
            result.Add(0);
            result.Add(0);
            result.Add(0);
            result.Add(0);
            string A = "AÁÀÄ";
            string E = "EÈÉË";
            string I = "IÍÌÏ";
            string O = "OÓÒÖ";
            string U = "UÚÙÜ";

            foreach (char c in xs)
            {
                if (A.Contains(c)) result[0]+=1;
                else if (E.Contains(c)) result[1] += 1;
                else if (I.Contains(c)) result[2] += 1;
                else if (O.Contains(c)) result[3] += 1;
                else if (U.Contains(c)) result[4] += 1;
            }

            return result;
        }

        public static List<string> ParaulesMesRepetides(string xs1, string xs2)
        {
            List<string> result = new List<string>();
            string[] words1 = xs1.Split(' ');
            string[] words2 = xs2.Split(' ');

            foreach(string s in words1)
            {
                foreach(string s2 in words2)
                {
                    if (s == s2) result.Add(s);
                }
            }
            HashSet<string> hashWithoutDuplicates = new HashSet<string>(result);
            List<string> listWithoutDuplicates = hashWithoutDuplicates.ToList();

            return listWithoutDuplicates;
        }

        public static string elMeuEncode(string text, int n)
        {


            if (n >= 3 && n < 6)
            {



                char[] charArray = text.ToCharArray();


                string reverted = new string(charArray);

                int anyadir0 = 0;
                string asciitext = "";
                foreach (char c in reverted)
                {
                    int ascii = c;
                    anyadir0 = ascii;

                    while (Math.Floor(Math.Log10(anyadir0) + 1) < n)
                    {
                        anyadir0 *= 10;
                        asciitext += "0";
                    }


                    asciitext += ascii.ToString();

                }

                return asciitext;
            }
            return "";


        }


        public static string elMeuDecode(string ascii, int n)
        {


            if (n >= 3 && n < 6)
            {



                int i = 0;

                string oldChar = "";
                string newString = "";
                while (ascii.Length > 0)
                {
                    i = 0;
                    ascii = ascii.TrimStart(new Char[] { '0' });
                    while (ascii[i] != '0')
                    {
                        oldChar += ascii[i].ToString();
                        ascii = ascii.Substring(1);
                        i++;

                    }

                    int trueAscii = Int32.Parse(oldChar);

                    char newChar = (char)trueAscii;

                    newString += newChar.ToString();


                }

                char[] charArray = newString.ToCharArray();
                Array.Reverse(charArray);

                string reverted = new string(charArray);

                return reverted;
            }
            return "";


        }




    }
}
