using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using static System.Collections.Specialized.BitVector32;

namespace Maple.Ring.Metadata
{
    public partial class GameCheatEngine(GameReourceCache reourceCache)
    {
        GameReourceCache ReourceCache { get; } = reourceCache;
        GameMetadataContext MetadataContext => ReourceCache.MetadataContext;
        ILogger Logger => this.MetadataContext.Logger;
        CharacterManager.Ptr_CharacterManager Ptr_CharacterManager { get; } = CharacterManager.Ptr_CharacterManager.INSTANCE;


        public static GameCheatEngine CreateThrowIfNotInGame(GameReourceCache gameReourceCache)
        {
            if (GameReourceCache.InGame())
            {
                return Create(gameReourceCache);
            }
            return GameException.ThrowIfNotLoaded<GameCheatEngine>();

        }
        public static GameCheatEngine Create(GameReourceCache gameReourceCache) => new(gameReourceCache);



        static GameCharacterDisplayDTO GetCharacterData(Character.Ptr_Character ptr_Character)
        {
            return new GameCharacterDisplayDTO()
            {
                ObjectId = ptr_Character.RACE.ToString(),
                DisplayName = ptr_Character.NICKNAME.Value.GET_VALUE().DOI18N().ToString(),
                DisplayCategory = ptr_Character.RACE.ToString(),
                DisplayDesc = string.Empty,

            };
        }
        public IEnumerable<GameCharacterDisplayDTO> GetGameCharacters()
        {
            var characterMgr = this.Ptr_CharacterManager;

            var master = characterMgr.MASTER;
            var masterCharacter = master.Value;
            this.MetadataContext.Logger.LogInformation("master:{p}/character:{pp}", master.Ptr.ToString("X8"), masterCharacter.Ptr.ToString("X8"));
            if (masterCharacter.IsNotNull())
            {
                yield return GetCharacterData(masterCharacter);
            }
            var player = characterMgr.PLAYER;
            var playerCharacter = player.Value;
            this.MetadataContext.Logger.LogInformation("player:{p}/character:{pp}", player.Ptr.ToString("X8"), playerCharacter.Ptr.ToString("X8"));

            if (playerCharacter.IsNotNull())
            {
                yield return GetCharacterData(playerCharacter);
            }
        }

        IEnumerable<GameSwitchDisplayDTO> GetGameCharacterStatusImp(Character.Ptr_Character ptr_Character)
        {

            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.AGE), DisplayName = "属性*年龄", ContentValue = ptr_Character.AGE.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.CURRENT_HP), DisplayName = "属性*气血", ContentValue = ptr_Character.CURRENT_HP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.CURRENT_MP), DisplayName = "属性*法术", ContentValue = ptr_Character.CURRENT_MP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.EXP), DisplayName = "属性*经验", ContentValue = ptr_Character.EXP.GET_VALUE().ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.TRUST_LEVEL), DisplayName = "属性*信任", ContentValue = ptr_Character.TRUST_LEVEL.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.ALCHEMY_PRESENTER), DisplayName = "经验*炼药", ContentValue = ptr_Character.ALCHEMY_PRESENTER.EXP.GET_VALUE().ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.FORGE_PRESENTER), DisplayName = "经验*锻造", ContentValue = ptr_Character.FORGE_PRESENTER.EXP.GET_VALUE().ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.ADDITIONAL_MAX_AGE), DisplayName = "额外*年龄", ContentValue = ptr_Character.ADDITIONAL_MAX_AGE.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.ADDITIONAL_ATTACK), DisplayName = "额外*攻击", ContentValue = ptr_Character.ADDITIONAL_ATTACK.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.ADDITIONAL_DEFENSE), DisplayName = "额外*防御", ContentValue = ptr_Character.ADDITIONAL_DEFENSE.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.ADDITIONAL_SPEED), DisplayName = "额外*速度", ContentValue = ptr_Character.ADDITIONAL_SPEED.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.ADDITIONAL_MAX_HP), DisplayName = "额外*气血", ContentValue = ptr_Character.ADDITIONAL_MAX_HP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.ADDITIONAL_MAX_MP), DisplayName = "额外*法术", ContentValue = ptr_Character.ADDITIONAL_MAX_HP.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };


            foreach (var sect in this.ReourceCache.Sects.Where(p => p.ObjectPointer != nint.Zero))
            {
                var sectId = sect.IntValue;
                var repVal = ptr_Character.REPUTATION.GET_SECT_REPUTATION(sectId);
                yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(Character.Ptr_Character.REPUTATION)}_{sectId}", DisplayName = $"{sect.DisplayName}*名声", ContentValue = repVal.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            }

            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.SEX), DisplayName = "属性*性别", ContentValue = ptr_Character.SEX.Value.ToString(), UIType = (int)EnumGameSwitchUIType.Selects, SelectedContents = [.. this.ReourceCache.Sexs] };
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.SECT_PRESENTER), DisplayName = "属性*门派", ContentValue = ptr_Character.SECT_PRESENTER.GET_SECT_ID().ToString(), SelectedContents = [.. this.ReourceCache.Sects], UIType = (int)EnumGameSwitchUIType.Selects };

            var lv_BRAVE = Personality.Ptr_Personality.GET_PERSONALITY_LEVEL(ptr_Character.PERSONALITY.BRAVE);
            var lv_EFFORT = Personality.Ptr_Personality.GET_PERSONALITY_LEVEL(ptr_Character.PERSONALITY.EFFORT);
            var lv_GREED = Personality.Ptr_Personality.GET_PERSONALITY_LEVEL(ptr_Character.PERSONALITY.GREED);
            var lv_PURE = Personality.Ptr_Personality.GET_PERSONALITY_LEVEL(ptr_Character.PERSONALITY.PURE);
            var lv_MORAL = Personality.Ptr_Personality.GET_PERSONALITY_LEVEL(ptr_Character.PERSONALITY.MORAL);
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(Character.Ptr_Character.PERSONALITY)}_{nameof(Character.Ptr_Character.PERSONALITY.BRAVE)}", DisplayName = "性格*勇气", ContentValue = lv_BRAVE.ToString(), UIType = (int)EnumGameSwitchUIType.Selects, SelectedContents = [.. this.ReourceCache.Personalities[DictIndex.personality_brave.ToString()]] };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(Character.Ptr_Character.PERSONALITY)}_{nameof(Character.Ptr_Character.PERSONALITY.EFFORT)}", DisplayName = "性格*精力", ContentValue = lv_EFFORT.ToString(), UIType = (int)EnumGameSwitchUIType.Selects, SelectedContents = [.. this.ReourceCache.Personalities[DictIndex.personality_effort.ToString()]] };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(Character.Ptr_Character.PERSONALITY)}_{nameof(Character.Ptr_Character.PERSONALITY.GREED)}", DisplayName = "性格*贪欲", ContentValue = lv_GREED.ToString(), UIType = (int)EnumGameSwitchUIType.Selects, SelectedContents = [.. this.ReourceCache.Personalities[DictIndex.personality_greed.ToString()]] };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(Character.Ptr_Character.PERSONALITY)}_{nameof(Character.Ptr_Character.PERSONALITY.PURE)}", DisplayName = "性格*纯洁", ContentValue = lv_PURE.ToString(), UIType = (int)EnumGameSwitchUIType.Selects, SelectedContents = [.. this.ReourceCache.Personalities[DictIndex.personality_pure.ToString()]] };
            yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(Character.Ptr_Character.PERSONALITY)}_{nameof(Character.Ptr_Character.PERSONALITY.MORAL)}", DisplayName = "性格*道德", ContentValue = lv_MORAL.ToString(), UIType = (int)EnumGameSwitchUIType.Selects, SelectedContents = [.. this.ReourceCache.Personalities[DictIndex.personality_moral.ToString()]] };

            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(Character.Ptr_Character.ALIVE), DisplayName = "属性*存活", ContentValue = ptr_Character.ALIVE.ToString(), UIType = (int)EnumGameSwitchUIType.Switches };
            if (ptr_Character.SPIRITUAL_ROOTS.IsNotNull())
            {
                var roots = ptr_Character.SPIRITUAL_ROOTS.AsEnumerable().ToArray();

                foreach (var e in this.ReourceCache.Elements)
                {
                    yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(Character.Ptr_Character.SPIRITUAL_ROOTS)}_{e.DisplayName}", DisplayName = $"灵根*{e.DisplayName}", SwitchValue = roots.Contains(e.IntValue), UIType = (int)EnumGameSwitchUIType.Switches };

                }
            }

        }
        public GameCharacterStatusDTO GetGameCharacterStatus(GameCharacterObjectDTO characterObjectDTO)
        {
            if (Enum.TryParse<Race>(characterObjectDTO.CharacterCategory, out var characterCategory))
            {
                var characterMgr = this.Ptr_CharacterManager;

                var master = characterMgr.MASTER;
                var masterCharacter = master.Value;
                if (masterCharacter.IsNotNull() && masterCharacter.RACE == characterCategory)
                {
                    return new GameCharacterStatusDTO() { ObjectId = characterObjectDTO.CharacterId, CharacterAttributes = [.. GetGameCharacterStatusImp(masterCharacter)] };
                }
                var player = characterMgr.PLAYER;
                var playerCharacter = player.Value;
                if (playerCharacter.IsNotNull() && playerCharacter.RACE == characterCategory)
                {
                    return new GameCharacterStatusDTO() { ObjectId = characterObjectDTO.CharacterId, CharacterAttributes = [.. GetGameCharacterStatusImp(playerCharacter)] };
                }
            }




            return GameException.Throw<GameCharacterStatusDTO>($"NOT FOUND:{characterObjectDTO.CharacterCategory}");

        }

        IEnumerable<GameSkillInfoDTO> GetGameCharacterSkillsImp(Character.Ptr_Character ptr_Character)
        {

            yield return new GameSkillInfoDTO() { ObjectId = string.Empty, DisplayName = string.Empty, DisplayCategory = nameof(SkillConfigData), DisplayDesc = string.Empty, DisplayImage = string.Empty, CanWrite = true };


            var skillDatas = ptr_Character.SKILLS;
            if (skillDatas.IsNull())
            {
                yield break;
            }
            foreach (var skill in skillDatas.AsEnumerable())
            {
                var findSkill = this.ReourceCache.Skills.FirstOrDefault(p => p.ObjectId == skill.ID.ToString());
                if (findSkill is not null)
                {
                    yield return new GameSkillInfoDTO() { ObjectId = findSkill.ObjectId, DisplayName = findSkill.DisplayName, SkillAttributes = findSkill.SkillAttributes, DisplayCategory = findSkill.DisplayCategory, DisplayDesc = findSkill.DisplayDesc, DisplayImage = findSkill.DisplayImage, CanWrite = true };
                }
            }
        }
        public GameCharacterSkillDTO GetGameCharacterSkills(GameCharacterObjectDTO characterObjectDTO)
        {
            if (Enum.TryParse<Race>(characterObjectDTO.CharacterCategory, out var characterCategory))
            {
                var characterMgr = this.Ptr_CharacterManager;

                var master = characterMgr.MASTER;
                var masterCharacter = master.Value;
                if (masterCharacter.IsNotNull() && masterCharacter.RACE == characterCategory)
                {
                    return new GameCharacterSkillDTO() { ObjectId = characterObjectDTO.CharacterId, SkillInfos = [.. GetGameCharacterSkillsImp(masterCharacter)] };
                }
                var player = characterMgr.PLAYER;
                var playerCharacter = player.Value;
                if (playerCharacter.IsNotNull() && playerCharacter.RACE == characterCategory)
                {
                    return new GameCharacterSkillDTO() { ObjectId = characterObjectDTO.CharacterId, SkillInfos = [.. GetGameCharacterSkillsImp(playerCharacter)] };
                }
            }
            return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND:{characterObjectDTO.CharacterCategory}");

        }
        public GameCharacterSkillDTO UpdateGameCharacterSkills(GameCharacterModifyDTO characterModifyDTO)
        {


            if (Enum.TryParse<Race>(characterModifyDTO.CharacterCategory, out var characterCategory))
            {

                var remove = int.TryParse(characterModifyDTO.ModifyObject, out int oldSkill);
                var add = int.TryParse(characterModifyDTO.NewValue, out int newSkill);

                var characterMgr = this.Ptr_CharacterManager;

                var master = characterMgr.MASTER;
                var masterCharacter = master.Value;
                if (masterCharacter.IsNotNull() && masterCharacter.RACE == characterCategory)
                {
                    UpdateSkill(masterCharacter, newSkill, oldSkill, add, remove);

                    return new GameCharacterSkillDTO() { ObjectId = characterModifyDTO.CharacterId, SkillInfos = [.. GetGameCharacterSkillsImp(masterCharacter)] };
                }
                var player = characterMgr.PLAYER;
                var playerCharacter = player.Value;
                if (playerCharacter.IsNotNull() && playerCharacter.RACE == characterCategory)
                {
                    UpdateSkill(playerCharacter, newSkill, oldSkill, add, remove);

                    return new GameCharacterSkillDTO() { ObjectId = characterModifyDTO.CharacterId, SkillInfos = [.. GetGameCharacterSkillsImp(playerCharacter)] };
                }
            }
            return GameException.Throw<GameCharacterSkillDTO>($"NOT FOUND:{characterModifyDTO.CharacterCategory}");

            static void UpdateSkill(Character.Ptr_Character ptr_Character, int newSkill, int oldSkill, bool add, bool remove)
            {
                if (remove && FindSaveSkillInfo(ptr_Character, oldSkill, out var _, out var index))
                {
                    ptr_Character.SKILLS.REMOVE(index);
                }
                if (add)
                {
                    ptr_Character.ADD_SKILL(newSkill);
                }
            }
            static bool FindSaveSkillInfo(Character.Ptr_Character ptr_Character, int skillId, out SkillSaveData.Ptr_SkillSaveData ptr_SkillSaveData, out int index)
            {
                Unsafe.SkipInit(out ptr_SkillSaveData);
                Unsafe.SkipInit(out index);
                foreach (var skillInfo in ptr_Character.SKILLS.AsEnumerable().Index())
                {
                    if (skillInfo.Item.ID == skillId)
                    {
                        ptr_SkillSaveData = skillInfo.Item;
                        index = skillInfo.Index;
                        return true;
                    }
                }
                return false;
            }
        }



        static int GetGameInventoryInfoImp(Character.Ptr_Character ptr_Character, string code)
        {
            if (int.TryParse(code, out var itemId))
            {
                return ptr_Character.INVENTORY.GET_STOCK(itemId);

            }
            return default;
        }

        static int UpdateGameInventoryInfoImp(Character.Ptr_Character ptr_Character, string code, int newCount)
        {
            if (int.TryParse(code, out var itemId))
            {
                var oldCount = ptr_Character.INVENTORY.GET_STOCK(itemId);

                var diff = newCount - oldCount;

                if (diff >= 0)
                {
                    ptr_Character.INVENTORY.ADD_ITEM(itemId, diff);
                }
                else
                {
                    ptr_Character.INVENTORY.REMOVE_ITEM(itemId, Math.Abs(diff));
                }




            }
            return GetGameInventoryInfoImp(ptr_Character, code);
        }

        public GameCurrencyInfoDTO GetGameCurrencyInfo(GameCurrencyObjectDTO currencyInfoDTO)
        {
            var characterMgr = this.Ptr_CharacterManager;

            //var player = characterMgr.PLAYER;
            //var ptr_Player = player.Value;
            //if (player.IsNotNull() && ptr_Player.IsNotNull())
            //{
            //    this.Logger.LogInformation("player-item:{p}", ptr_Player.INVENTORY.Ptr.ToString("X8"));
            //}

            var master = characterMgr.MASTER;
            var ptr_Master = master.Value;
            if (ptr_Master.IsNotNull())
            {
                return new GameCurrencyInfoDTO()
                {
                    ObjectId = currencyInfoDTO.CurrencyObject,
                    Currency = GetGameInventoryInfoImp(ptr_Master, currencyInfoDTO.CurrencyObject)
                };
            }




            return GameException.Throw<GameCurrencyInfoDTO>($"ERROR:{currencyInfoDTO.CurrencyObject}");

        }
        public GameCurrencyInfoDTO UpdateGameCurrencyInfo(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var characterMgr = this.Ptr_CharacterManager;

            //var player = characterMgr.PLAYER;
            //var ptr_Player = player.Value;
            //if (player.IsNotNull() && ptr_Player.IsNotNull())
            //{
            //    this.Logger.LogInformation("player-item:{p}", ptr_Player.INVENTORY.Ptr.ToString("X8"));
            //}

            var master = characterMgr.MASTER;
            var ptr_Master = master.Value;
            if (ptr_Master.IsNotNull())
            {
                var count = UpdateGameInventoryInfoImp(ptr_Master, currencyModifyDTO.CurrencyObject, currencyModifyDTO.IntValue);
                return new GameCurrencyInfoDTO() { ObjectId = currencyModifyDTO.CurrencyObject, Currency = count };
            }



            return GameException.Throw<GameCurrencyInfoDTO>($"ERROR:{currencyModifyDTO.CurrencyObject}");

        }


        public GameInventoryInfoDTO GetGameInventoryInfo(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var characterMgr = this.Ptr_CharacterManager;

            //var player = characterMgr.PLAYER;
            //var ptr_Player = player.Value;
            //if (player.IsNotNull() && ptr_Player.IsNotNull())
            //{
            //    this.Logger.LogInformation("player-item:{p}", ptr_Player.INVENTORY.Ptr.ToString("X8"));
            //}

            var master = characterMgr.MASTER;
            var ptr_Master = master.Value;
            if (ptr_Master.IsNotNull())
            {
                return new GameInventoryInfoDTO()
                {
                    ObjectId = inventoryObjectDTO.InventoryObject,
                    InventoryCount = GetGameInventoryInfoImp(ptr_Master, inventoryObjectDTO.InventoryObject)
                };
            }
            return GameException.Throw<GameInventoryInfoDTO>($"ERROR:{inventoryObjectDTO.InventoryObject}");

        }
        public GameInventoryInfoDTO UpdateGameInventoryInfo(GameInventoryModifyDTO inventoryModifyDTO)
        {
            var characterMgr = this.Ptr_CharacterManager;

            //var player = characterMgr.PLAYER;
            //var ptr_Player = player.Value;
            //if (player.IsNotNull() && ptr_Player.IsNotNull())
            //{
            //    this.Logger.LogInformation("player-item:{p}", ptr_Player.INVENTORY.Ptr.ToString("X8"));
            //}

            var master = characterMgr.MASTER;
            var ptr_Master = master.Value;
            if (ptr_Master.IsNotNull())
            {
                var count = UpdateGameInventoryInfoImp(ptr_Master, inventoryModifyDTO.InventoryObject, inventoryModifyDTO.InventoryCount);
                return new GameInventoryInfoDTO() { ObjectId = inventoryModifyDTO.InventoryObject, InventoryCount = count };
            }
            return GameException.Throw<GameInventoryInfoDTO>($"ERROR:{inventoryModifyDTO.InventoryObject}");

        }



    }

}
