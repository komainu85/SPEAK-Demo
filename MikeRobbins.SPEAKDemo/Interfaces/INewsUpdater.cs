using MikeRobbins.SPEAKDemo.Models;

namespace MikeRobbins.SPEAKDemo.Interfaces
{
    public interface INewsUpdater
    {
        void UpdateNewsArticle(NewsArticle newsArticle);
        void DeleteNewsArticle(NewsArticle newsArticle);
    }
}