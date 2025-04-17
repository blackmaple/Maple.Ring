using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;

namespace Maple.Ring.Metadata
{
    public partial class GameCheatEngine(GameReourceCache reourceCache)
    {
        GameReourceCache ReourceCache { get; } = reourceCache;
        GameMetadataContext MetadataContext => ReourceCache.MetadataContext;



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
            var characterMgr = CharacterManager.Ptr_CharacterManager.INSTANCE;
            if (characterMgr.IsNull())
            {
                yield break;
            }
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



    }

}
