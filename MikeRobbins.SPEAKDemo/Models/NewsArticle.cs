using System;
using System.ComponentModel.DataAnnotations;

namespace MikeRobbins.SPEAKDemo.Models
{
    public class NewsArticle : Sitecore.Services.Core.Model.EntityIdentity
    {
        public string itemId { get; set; }

        [Required]
        public string Title { get; set; }
        public string Body { get; set; }

        public DateTime Date { get; set; }
    }
}