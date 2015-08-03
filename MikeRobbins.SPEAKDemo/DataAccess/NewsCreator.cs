using MikeRobbins.SPEAKDemo.Interfaces;
using MikeRobbins.SPEAKDemo.Models;
using Sitecore.Data.Items;

namespace MikeRobbins.SPEAKDemo.DataAccess
{
    public class NewsCreator : INewsCreator
    {
        public TemplateItem Template { get; set; }
        public Item ParentItem { get; set; }

        private IFieldUpdater _iFieldUpdater = null;

        public NewsCreator(IFieldUpdater iFieldUpdater)
        {
            _iFieldUpdater = iFieldUpdater;
        }

        public Item CreateNewsArticle(NewsArticle newsArticle)
        {
            var newItem = ParentItem.Add(newsArticle.Title, Template);

            _iFieldUpdater.AddFieldsToItem(newItem, newsArticle);

            return newItem;
        }

    }
}