using MikeRobbins.SPEAKDemo.Interfaces;
using MikeRobbins.SPEAKDemo.Models;
using Sitecore.Data.Items;

namespace MikeRobbins.SPEAKDemo.Mapper
{
    public class NewsMapper : INewsMapper
    {
        public NewsArticle GetNewsArticle(Item item)
        {
            var newsArticle = new NewsArticle();

            var dateField = (Sitecore.Data.Fields.DateField)item.Fields["Date"];

            newsArticle.Title = item["Title"];
            newsArticle.Body = item["Body"];
            newsArticle.Date = dateField.DateTime;
            newsArticle.itemId = item.ID.ToString();
            newsArticle.Id = item.ID.ToString();
            newsArticle.Url = item.Paths.ContentPath;

            return newsArticle;
        }
    }
}