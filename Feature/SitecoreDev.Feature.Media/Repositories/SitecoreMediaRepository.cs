using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace SitecoreDev.Feature.Media.Repositories
{
    public class SitecoreMediaRepository: IMediaRepository
    {

        private Database _database;

        public SitecoreMediaRepository()
        {
            _database = Context.Database;
        }



        public Item GetItem(string contentGuid)
        {
            return _database.GetItem(new ID(contentGuid));
        }


    }
}