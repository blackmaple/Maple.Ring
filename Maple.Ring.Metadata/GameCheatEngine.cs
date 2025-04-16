namespace Maple.Ring.Metadata
{
    public partial class GameCheatEngine(GameReourceCache reourceCache)
    {
        GameReourceCache ReourceCache { get; } = reourceCache;
        GameMetadataContext MetadataContext => ReourceCache.MetadataContext;
    }

}
