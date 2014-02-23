using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebParsers.FlashGame
{
    public class GameItem
    {
        public string guid;
        public string pubDate;
        public string title;
        public string link;
        public string description;
    }

    public class rss
    {
        public channel channel;
    }

    public class channel
    {
        public string title;
        public string link;
        public string description;
        public string lastBuildDate;
        public string generator;
        public string ttl;

        [XmlElement(ElementName = "item")]
        public List<GameItem> gameItems;
    }
}
