using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Maple.Ring.Metadata
{
    public partial class GameReourceCache
    {
        public GameMetadataContext MetadataContext { get; }
        ILogger Logger => this.MetadataContext.Logger;

        public List<GameInventoryDisplayDTOEX> Items { get; } = new List<GameInventoryDisplayDTOEX>(1024);
        public List<GameSkillDisplayDTOEX> Skills { get; } = new List<GameSkillDisplayDTOEX>(1024);
        public List<GameMonsterDisplayDTOEX> Monsters { get; } = new List<GameMonsterDisplayDTOEX>(1024);
        public List<GameValueInfoDTOEX> Dicts { get; } = new List<GameValueInfoDTOEX>(1024);
        public List<GameValueInfoDTOEX> Elements { get; } = new List<GameValueInfoDTOEX>(1024);


        public GameReourceCache(GameMetadataContext metadataContext)
        {
            this.MetadataContext = metadataContext;


        }


        public void LoadResource()
        {
            this.Items.AddRange(LoadItemDatas());
            this.Skills.AddRange(LoadSkillDatas());
            this.Monsters.AddRange(LoadMonsterDatas());
            this.Elements.AddRange(LoadElementDatas());


            this.Dicts.AddRange(LoadDictDatas());
        }

        IEnumerable<GameInventoryDisplayDTOEX> LoadItemDatas()
        {
            using (this.Logger.Running())
            {
                var datas = DataAssetManager.Ptr_DataAssetManager.GET_ITEM_DATAS();
                if (datas.IsNull())
                {
                    yield break;
                }
                foreach (var item in datas.DATAS.AsEnumerable())
                {
                    var dto = new GameInventoryDisplayDTOEX()
                    {
                        ObjectPointer = item.Ptr,
                        ObjectId = item.ID.ToString(),
                        DisplayName = item.GET_TITLE().DOI18N().ToString(),
                        DisplayDesc = item.GET_DESCRIPTION().DOI18N().ToString(),
                        DisplayCategory = item.GET_TYPE().ToString(),
                    };
                    this.Logger.LogInformation("id:{id}/name:{name}/desc:{desc}/type:{t}", dto.ObjectId, dto.DisplayName, dto.DisplayDesc, dto.DisplayCategory);
                    yield return dto;
                }

            }
        }

        IEnumerable<GameSkillDisplayDTOEX> LoadSkillDatas()
        {
            using (this.Logger.Running())
            {
                var datas = DataAssetManager.Ptr_DataAssetManager.GET_SKILL_DATAS();
                if (datas.IsNull())
                {
                    yield break;
                }
                foreach (var item in datas.DATAS.AsEnumerable())
                {
                    var dto = new GameSkillDisplayDTOEX()
                    {
                        ObjectPointer = item.Ptr,
                        ObjectId = item.ID.ToString(),
                        DisplayName = item.GET_TITLE().DOI18N().ToString(),
                        DisplayDesc = item.GET_DESCRIPTION().DOI18N().ToString(),
                        //   DisplayCategory = item.GET_TYPE().ToString(),
                    };
                    this.Logger.LogInformation("id:{id}/name:{name}/desc:{desc}/type:{t}", dto.ObjectId, dto.DisplayName, dto.DisplayDesc, dto.DisplayCategory);
                    yield return dto;

                }
            }


        }

        IEnumerable<GameMonsterDisplayDTOEX> LoadMonsterDatas()
        {
            using (this.Logger.Running())
            {
                var datas = DataAssetManager.Ptr_DataAssetManager.GET_MONSTER_DATAS();
                if (datas.IsNull())
                {
                    yield break;
                }
                foreach (var item in datas.DATAS.AsEnumerable())
                {
                    var dto = new GameMonsterDisplayDTOEX()
                    {
                        ObjectPointer = item.Ptr,
                        ObjectId = item.ID.ToString(),
                        DisplayName = item.GET_NAME().DOI18N().ToString(),
                        DisplayDesc = item.GET_ELEMENT().GET_TITLE().DOI18N().ToString(),
                        //   DisplayCategory = item.GET_TYPE().ToString(),
                    };
                    this.Logger.LogInformation("id:{id}/name:{name}/desc:{desc}/type:{t}", dto.ObjectId, dto.DisplayName, dto.DisplayDesc, dto.DisplayCategory);
                    yield return dto;
                }
            }
        }

        IEnumerable<GameValueInfoDTOEX> LoadElementDatas()
        {
            using (this.Logger.Running())
            {
                var datas = DataAssetManager.Ptr_DataAssetManager.GET_ELEMENT_DATAS();
                if (datas.IsNull())
                {
                    yield break;
                }
                foreach (var item in datas.DATAS.AsEnumerable())
                {
                    var dto = new GameValueInfoDTOEX() { ObjectId = item.ID.ToString(), DisplayName = item.GET_TITLE().DOI18N().ToString() };
                    this.Logger.LogInformation("id:{id}/name:{name}", dto.ObjectId, dto.DisplayName);
                    yield return dto;
                }
            }
        }

        IEnumerable<GameValueInfoDTOEX> LoadDictDatas()
        {
            using (this.Logger.Running())
            {
                var datas = DataAssetManager.Ptr_DataAssetManager.GET_DICT_DATAS();
                if (datas.IsNull())
                {
                    yield break;
                }
                foreach (var item in datas.DATAS.AsEnumerable())
                {
                    var dto = new GameValueInfoDTOEX() { ObjectId = item.INDEX.ToString()!, DisplayName = item.KEY.ToString(), DisplayValue = item.VALUE.ToString() };
                    this.Logger.LogInformation("id:{id}/name:{name}/val:{val}", dto.ObjectId, dto.DisplayName, dto.DisplayValue);
                    yield return dto;
                }
            }
        }

    }


    public class GameInventoryDisplayDTOEX : GameInventoryDisplayDTO
    {
        public nint ObjectPointer { get; set; }
    }

    public class GameSkillDisplayDTOEX : GameSkillDisplayDTO
    {
        public nint ObjectPointer { get; set; }

    }

    public class GameMonsterDisplayDTOEX : GameMonsterDisplayDTO
    {
        public nint ObjectPointer { get; set; }

    }


    public class GameValueInfoDTOEX : GameValueInfoDTO
    {
        public nint ObjectPointer { get; set; }

        public int ObjectCode { set; get; }
    }
}
