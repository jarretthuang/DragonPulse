using System;
using System.Xml;
using HtmlAgilityPack;

namespace DragonPulse.Models
{
    public class WebScraper
    {
        public string Url { get; set; }
        public HtmlDocument Doc
        {
            get
            {
                HtmlWeb web = new HtmlWeb();
                return web.Load(Url);
            }
        }

        public string ScrapeHongmoonLevel()
        {
            var node = Doc.DocumentNode.SelectSingleNode("//span[@class='masteryLv']");
            return node.InnerText.Trim();
        }

        public string ScrapeHtml()
        {
            var node = Doc.DocumentNode.SelectSingleNode("//div[@class='wrapItem']");
            return node.OuterHtml;
        }

        public string ScrapeProfilePicUrl()
        {
            var node = Doc.DocumentNode.SelectSingleNode("//div[@class='charaterView']");
            var html = node.OuterHtml;
            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            return doc.DocumentNode.SelectSingleNode("//img").Attributes["src"].Value;
        }

    }
}
