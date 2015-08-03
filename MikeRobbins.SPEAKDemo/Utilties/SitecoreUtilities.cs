using MikeRobbins.SPEAKDemo.Interfaces;
using Sitecore.Data;

namespace MikeRobbins.SPEAKDemo.Utilties
{
    public class SitecoreUtilities : ISitecoreUtilities
    {
        public ID ParseId(string id)
        {
            var sID = ID.Null;

            ID.TryParse(id, out sID);

            return sID;
        }

    }
}