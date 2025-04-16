namespace Maple.Ring.Metadata
{
    public partial class GameReourceCache
    {
        public GameMetadataContext MetadataContext { get; }


        public GameReourceCache(GameMetadataContext metadataContext)
        {
            this.MetadataContext = metadataContext;
        }
    }

}
