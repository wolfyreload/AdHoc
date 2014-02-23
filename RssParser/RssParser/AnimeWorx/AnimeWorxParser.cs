using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;

namespace WebParsers.AnimeWorx
{
    public class AnimeWorxParser
    {
        public AnimeWorxParser()
        {
        }

        private List<AnimeWorxObject> getElementsOnAllPages()
    {
        List<AnimeWorxObject> items = new List<AnimeWorxObject>();
        
        HtmlWeb hw = new HtmlWeb();


        for (int i = 1; i <= 11; i++)
        {
            var path = string.Format("http://www.awx.co.za/shop/cat/t/Pre-Owned/s/PlayStation+3+Second+Hand-117/page/{0}.html", i);
            HtmlDocument doc = hw.Load(path);
            var mainPageContents = doc.GetElementbyId("left_content");



            foreach (HtmlNode link in mainPageContents.SelectNodes("//*[contains(@class,'main_gradient')]"))
            {
                var objectLink = new AnimeWorxObject();
                
                var price = link.SelectSingleNode(".//*[contains(@class,'price')]").InnerText;
                var stock = link.SelectSingleNode(".//*[contains(@class,'synopsis')]").InnerText;
                var name = link.SelectSingleNode(".//*[contains(@class,'prod_link')]").ChildNodes[0].Attributes[4].Value;
                objectLink.GameName = name;
                objectLink.Stock = stock;
                objectLink.Price = price.Trim().Substring(2);
                items.Add(objectLink);
            }
        }

        items = items.OrderBy(i => double.Parse(i.Price)).ToList();

        return items;
    }


        public void run()
        {
            var links = getElementsOnAllPages();

            FileStream htmlTest = new FileStream("animeworx.csv", FileMode.Create);
            StreamWriter writer = new StreamWriter(htmlTest);


            foreach (var link in links)
            {
                var g = link.GameName.Replace(",", "");
                var s = link.Stock.Replace(",", "");
                var p = link.Price.Replace(",", "");
                g = g.Replace("\r\n", "").Trim();
                s = s.Replace("\r\n", "").Trim();
                p = p.Replace("\r\n", "").Trim();
              
                writer.WriteLine(g + "," + s + "," + p);
            }
            writer.Flush();
            writer.Close();
            htmlTest.Close();



        }



    }
}