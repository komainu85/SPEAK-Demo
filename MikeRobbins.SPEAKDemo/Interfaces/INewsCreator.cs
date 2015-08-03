using MikeRobbins.SPEAKDemo.Models;
using Sitecore.Data.Items;

namespace MikeRobbins.SPEAKDemo.Interfaces
{
    public interface INewsCreator
    {
        TemplateItem Template { get; set; }
        Item ParentItem { get; set; }
        Item CreateNewsArticle(NewsArticle newsArticle);
    }
}