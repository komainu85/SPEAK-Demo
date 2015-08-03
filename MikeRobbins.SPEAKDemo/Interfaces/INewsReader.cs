using System.Collections.Generic;
using MikeRobbins.SPEAKDemo.Models;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace MikeRobbins.SPEAKDemo.Interfaces
{
    public interface INewsReader
    {
        Item GetNewsItem(ID id);
        NewsArticle GetNewsArticle(ID id);
        List<NewsArticle> GetNewsArticles();
        bool NewsAticleExists(NewsArticle newsArticle );
    }
}