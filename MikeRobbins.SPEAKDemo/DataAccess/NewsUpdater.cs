using MikeRobbins.SPEAKDemo.Interfaces;
using MikeRobbins.SPEAKDemo.Models;

namespace MikeRobbins.SPEAKDemo.DataAccess
{
    public class NewsUpdater : INewsUpdater
    {
        private IFieldUpdater _iFieldUpdater;
        private INewsReader _iNewsReader;
        private ISitecoreUtilities _iSitecoreUtilities;

        public NewsUpdater(IFieldUpdater iFieldUpdater, INewsReader iNewsReader, ISitecoreUtilities iSitecoreUtilities)
        {
            _iFieldUpdater = iFieldUpdater;
            _iNewsReader = iNewsReader;
            _iSitecoreUtilities = iSitecoreUtilities;
        }

        public void UpdateNewsArticle(NewsArticle newsArticle)
        {
            var id = _iSitecoreUtilities.ParseId(newsArticle.Id);

            if (!id.IsNull)
            {
                var item = _iNewsReader.GetNewsItem(id);

                _iFieldUpdater.AddFieldsToItem(item, newsArticle);
            }
        }

        public void DeleteNewsArticle(NewsArticle newsArticle)
        {
            var id = _iSitecoreUtilities.ParseId(newsArticle.Id);

            var item = _iNewsReader.GetNewsItem(id);

            item.Delete();
        }

    }
}