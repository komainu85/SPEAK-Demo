using MikeRobbins.SPEAKDemo.Models;
using Sitecore.Data.Items;

namespace MikeRobbins.SPEAKDemo.Interfaces
{
    public interface INewsMapper
    {
        NewsArticle GetNewsArticle(Item item);
    }
}