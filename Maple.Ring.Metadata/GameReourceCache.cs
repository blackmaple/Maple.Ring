using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;

namespace Maple.Ring.Metadata
{
    public partial class GameReourceCache
    {
        public GameMetadataContext MetadataContext { get; }


        public GameReourceCache(GameMetadataContext metadataContext)
        {
            this.MetadataContext = metadataContext;
        }


        public void LoadResource()
        {
           // DataAssetManager.Ptr_DataAssetManager.GET_MONSTER_DATAS
           
            foreach(var item in LoadItemDatas())
            {
                this.MetadataContext.Logger.LogInformation("id:{id}/name:{name}/desc:{desc}/type:{t}", item.ObjectId, item.DisplayName, item.DisplayDesc, item.DisplayCategory);
            }

        }

        public IEnumerable<GameInventoryDisplayDTO> LoadItemDatas()
        {
           var datas = DataAssetManager.Ptr_DataAssetManager.GET_ITEM_DATAS();
            if (datas.IsNull())
            {
                yield break;
            }
            foreach (var item in datas.DATAS.AsEnumerable())
            {
                yield return new GameInventoryDisplayDTO()
                {
                    ObjectId = item.ID.ToString(),
                    DisplayName = item.GET_TITLE().DOI18N().ToString(),
                    DisplayDesc = item.GET_DESCRIPTION().DOI18N().ToString(),
                    DisplayCategory = item.GET_TYPE().ToString(),
                };
            }
        }

    }

}
