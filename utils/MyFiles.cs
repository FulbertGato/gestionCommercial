using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.utils
{
    public class MyFiles
    {
        private static readonly string PATH_FILE = @"F:\reference.txt.txt";

        private static int readFile()
        {
            StreamReader stream = new StreamReader(PATH_FILE);
            string seq = stream.ReadLine();
            stream.Close();
            return int.Parse(seq);
        }
        private static void writeFile(int seq)
        {
            StreamWriter stream = new StreamWriter(PATH_FILE);
            stream.Write(seq);
            stream.Close();

        }

        public static int generateSeqence()
        {
            int seq = readFile();
            writeFile(seq + 1);
            return seq;
        }
    }
}
