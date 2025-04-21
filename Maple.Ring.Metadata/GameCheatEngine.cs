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

        private IEnumerable<GameSwitchDisplayDTO> GetGameCharacterStatusImp(Character.Ptr_Character ptr_Character)
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







    }

}
