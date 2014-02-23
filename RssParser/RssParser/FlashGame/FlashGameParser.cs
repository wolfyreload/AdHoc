using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebParsers.FlashGame
{
    public class FlashGameParser
    {
        private string FILENAME = "GameList.txt";
        private int THRESHOLD = 85;


        private List<GameItem> getListOfGamesFromXml()
        {
            WebClient client = new WebClient();
            var xmlString = client.DownloadString("http://feed43.com/4881410668382277.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(rss));
            StringReader rdr = new StringReader(xmlString);
            rss resultingMessage = (rss)serializer.Deserialize(rdr);

            return resultingMessage.channel.gameItems;
        }

        private HashSet<string> getCurrentListToDownload()
        {
            HashSet<string> set = new HashSet<string>();
            if (!File.Exists(FILENAME))
                File.Create(FILENAME).Close();
            var arrayOfLinks = File.ReadAllLines(FILENAME);
            foreach (var item in arrayOfLinks)
            {
                set.Add(item);
            }
            return set;
        }

        private void saveCurrentListToDownload(HashSet<string> list)
        {
            File.WriteAllLines("GameList.txt", list);
        }

        public void run()
        {
            var newListOfGames = getListOfGamesFromXml();
            HashSet<string> currentListOfGames = getCurrentListToDownload();

            foreach (var item in newListOfGames)
            {
                var index = item.description.IndexOf("% - based on ");
                var percentage = item.description.Substring(index - 2, 2);
                var intPercentage = int.Parse(percentage);

                if (intPercentage >= THRESHOLD)
                    currentListOfGames.Add(item.link);

            }

            saveCurrentListToDownload(currentListOfGames);
        }




    }
}
