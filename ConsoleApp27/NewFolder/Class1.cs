using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27.NewFolder
{
   public static class Class1
    {
        public static bool Word(this string word,string hissecik)
        {
            StringBuilder sb = new StringBuilder(hissecik);
            string[] letter = word.Split(' ');
            StringBuilder sb1 = new StringBuilder(word);
            foreach (var item in word)
            {

                foreach (var item1 in hissecik)
                {
                    if (item1 == item)
                    {
                        return true;
                    }
                }
            }

            return false;
            
        }
    }
}
