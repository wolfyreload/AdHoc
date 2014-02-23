using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebParsers
{
    class Program
    {
        


        static void Main(string[] args)
        {
            var parser = new FlashGame.FlashGameParser();
            parser.run();

            var parser2 = new AnimeWorx.AnimeWorxParser();
            parser2.run();
        }
    }
}
