using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSettingHelper
{
    class AppSettingHelper
    {
        public static void WriteSetting(string fname)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fname, FileMode.OpenOrCreate)))
            {
                
                writer.Write(Console.BackgroundColor.ToString());
                writer.Write(Console.Title);
                writer.Write(Console.WindowWidth);
                writer.Write(Console.WindowHeight);
            }
        }
        public static void ReadSetting(string fname)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(fname, FileMode.Open)))
            {
                
                while (reader.PeekChar() > -1)
                {
                    string color= reader.ReadString();
                    string titel = reader.ReadString();
                    int width = reader.ReadInt32();
                    int height = reader.ReadInt32();

                    Console.WriteLine($"Color:{color}\nTite:{titel}\nWidth:{width}\nHeight:{height}");
                       
                }
            }
        }
    }
}
