using Sitecore.Data.Items;

namespace SitecoreDev.Feature.Media.Repositories
{
    public interface IMediaRepository
    {
        Item GetItem(string contentGuid);

    }
}