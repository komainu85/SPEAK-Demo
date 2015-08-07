using System.Collections.Generic;
using MikeRobbins.SPEAKDemo.Interfaces;
using MikeRobbins.SPEAKDemo.Models;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace MikeRobbins.SPEAKDemo.DataAccess
{
    public class NewsReader : INewsReader
    {
        private INewsMapper _iNewsMapper;
        private ISitecoreUtilities _iSitecoreUtilities;

        public NewsReader(INewsMapper iNewsMapper, ISitecoreUtilities iSitecoreUtilities)
        {
            _iNewsMapper = iNewsMapper;
            _iSitecoreUtilities = iSitecoreUtilities;
        }

        public Item GetNewsItem(ID id)
        {
            return Sitecore.Data.Database.GetDatabase("master").GetItem(id);
        }

        public NewsArticle GetNewsArticle(ID id)
        {
            var item = GetNewsItem(id);

            return _iNewsMapper.GetNewsArticle(item);
        }

        public bool NewsAticleExists(NewsArticle newsArticle)
        {
            var exists = false;

            if (newsArticle.Id != null)
            {
                var id = _iSitecoreUtilities.ParseId(newsArticle.Id);
                exists = Sitecore.Data.Database.GetDatabase("master").GetItem(id) != null;
            }

            return exists;
        }

    }
}