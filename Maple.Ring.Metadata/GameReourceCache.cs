﻿using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Maple.Ring.Metadata
{
    public partial class GameReourceCache
    {
        public GameMetadataContext MetadataContext { get; }
        ILogger Logger => this.MetadataContext.Logger;

        public GameInventoryDisplayDTOEX[] Items { get; }
        public GameSkillDisplayDTOEX[] Skills { get; }
        public GameMonsterDisplayDTOEX[] Monsters { get; }
        public GameValueInfoDTOEX[] Dicts { get; }
        public GameValueInfoDTOEX[] Elements { get; }

        public GameValueInfoDTO[] Sexs { get; }
        public GameValueInfoDTO[] Sects { get; }

        public Dictionary<string, GameValueInfoDTOEX[]> Personalities { get; }

        public GameReourceCache(GameMetadataContext metadataContext)
        {
            this.MetadataContext = metadataContext;

            this.Items = [.. LoadItemDatas()];
            this.Skills = [.. LoadSkillDatas()];
            this.Monsters = [.. LoadMonsterDatas()];
            this.Elements = [.. LoadElementDatas()];
            this.Dicts = [.. LoadDictDatas()];

            this.Sexs = [.. LoadSexDatas()];
            this.Sects = [.. LoadSectConfigData()];
            this.Personalities = LoadPersonalityDatas().GroupBy(p => p.ObjectId).ToDictionary(p => p.Key, p => p.ToArray());
        }

        IEnumerable<GameValueInfoDTOEX> LoadSectConfigData()
        {
            using (this.Logger.Running())
            {
                var datas = DataAssetManager.Ptr_DataAssetManager.GET_SECT_DATAS();
                if (datas.IsNull())
                {
                    yield break;
                }
                foreach (var item in datas.DATAS.AsEnumerable())
                {
                    var name = item.GET_TITLE().DOI18N().ToString();
                    var dto = new GameValueInfoDTOEX()
                    {
                        ObjectPointer = item.Ptr,
                        ObjectId = item.ID.ToString(),
                        DisplayName = name,
                        IntValue = item.ID,
                        //     DisplayDesc = item.GET_DESCRIPTION().DOI18N().ToString(),
                        //      DisplayCategory = item.GET_TYPE().ToString(),
                    };
                    this.Logger.LogInformation("id:{id}/name:{name}", dto.ObjectId, dto.DisplayName);
                    yield return dto;
                }


            }
        }

        IEnumerable<GameValueInfoDTO> LoadSexDatas()
        {
            using (this.Logger.Running())
            {
                foreach (var sex in Enum.GetValues<Sex>())
                {
                    var name = sex.ToString();
                    yield return new GameValueInfoDTO() { ObjectId = name, DisplayName = name, DisplayValue = name };
                }
            }
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
                    var id = item.ID;
                    var dto = new GameValueInfoDTOEX() { ObjectId = id.ToString(), DisplayName = item.GET_TITLE().DOI18N().ToString(), IntValue = id };
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

        IEnumerable<GameValueInfoDTOEX> LoadPersonalityDatas()
        {
            using (this.Logger.Running())
            {
                var personality_thresholds = GameSystemConfig.Ptr_GameSystemConfig.PERSONALITY_THRESHOLDS.AsReadOnlySpan().ToArray();
                foreach (var dict in Enum.GetValues<DictIndex>())
                {
                    if ((int)dict <= (int)DictIndex.attribute)
                    {
                        continue;
                    }
                    foreach (var p in personality_thresholds)
                    {
                        var i18 = Personality.Ptr_Personality.GET_LABEL(dict, p);
                        var lv = Personality.Ptr_Personality.GET_PERSONALITY_LEVEL(p);
                        if (i18.IsNotNull())
                        {
                            var dto = new GameValueInfoDTOEX()
                            {
                                ObjectId = dict.ToString(),

                                Min = p,
                                DisplayName = i18.DOI18N().ToString(),
                                IntValue = lv,
                            };
                            yield return dto;
                        }
                    }
                }

            }
        }

        public static bool InGame()
        {
            return GameManager.Ptr_GameManager.INSTANCE.GAME_STATE.STATE != StateType.StandBy;
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

        //  public DictIndex Index { get; set; }
        public float Min { set; get; }


    }





}
