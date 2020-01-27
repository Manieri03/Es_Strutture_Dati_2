using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Strutture_Dati_2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numeri = new HashSet<int>();
            using (StreamReader sr=new StreamReader("file.txt", Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    int n = int.Parse(line);
                    numeri.Add(n);
                }

            }
            using(StreamWriter sw=new StreamWriter("duplica.txt", false, Encoding.UTF8))
            {
                foreach(int s in numeri)
                {
                    sw.WriteLine(s);
                }
            }
        }
    }
}
