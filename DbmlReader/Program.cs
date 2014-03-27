using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DbmlReader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            serialize("MembazDataClasses.dbml");
            serialize("ReportDataClasses.dbml");
        }

        private static void serialize(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Database));
            var file = new FileStream(filename, FileMode.Open);
            var file2 = new FileStream("new" + filename, FileMode.Create);

            var db = (Database)serializer.Deserialize(file);
            file.Close();
            db.Table = db.Table.OrderBy(t => t.Member).ToList();

            db.Function = db.Function.OrderBy(f => f.Method).ToList();

            serializer.Serialize(file2, db);
        }
    }
}
