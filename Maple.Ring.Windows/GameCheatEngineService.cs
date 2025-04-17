using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Maple.Ring.Metadata;
using Microsoft.Extensions.Logging;
using System;

namespace Maple.Ring.Windows
{
    internal sealed class GameCheatEngineService
        (ILogger<GameCheatEngineService> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
                : GameContextService<GameMetadataContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)
    {
        protected sealed override GameMetadataContext LoadGameContext()
        {



            var searchService = new MonoGameAssistant.MetadataExtensions.MetadataService.MetadataCollectorSearchService();
            searchService.UpdateMetadata(new MonoDescriptionCollectionDTO()
            {
                Classes = GameMetadataContext.MonoJsonClassDTO,
                Methods = GameMetadataContext.MonoJsonMethodDTO,
                Fields = GameMetadataContext.MonoJsonFieldDTO,
            });


            return new GameMetadataContext(Logger, searchService, RuntimeContext);



        }

        public required GameReourceCache Cache { get; set; }

        protected override async ValueTask LoadGameDataAsync()
        {
            this.Cache = await this.MonoTaskAsync(static (p) => new GameReourceCache(p)).ConfigureAwait(false);
        }

        private void LoadGameMetadata()
        {
            foreach (var image in this.Context.ImageNames)
            {
                if (!image.Utf8Name.AsSpan().StartsWith("Assembly-CSharp"u8))
                {
                    continue;
                }

                //   var classes = this.RuntimeContext.EnumMonoObjects(image.Pointer);
                foreach (var klass in this.RuntimeContext.EnumMonoObjects(image.Pointer))
                {
                    bool singleton = false;
                    foreach (var parent in this.RuntimeContext.RuntiemProvider.EnumMonoParentClasses(klass.Pointer))
                    {
                        var className = this.RuntimeContext.RuntiemProvider.GetMonoClassName(parent);
                        if (className.AsReadOnlySpan().StartsWith("Singleton"u8))
                        {
                            singleton = true;
                            break;
                        }
                    }
                    if (singleton)
                    {
                        var className = this.RuntimeContext.RuntiemProvider.GetMonoClassName(klass.Pointer);
                        this.Logger.LogInformation("classname:{name}", className.ToString());
                    }
                }

            }
        }


        protected override IUnityPlayerNativeMethods? LoadUnityEngineContext()
        {
            throw new NotImplementedException();
        }


        public Task<GameCheatEngine> GetGameCheatEngine() => this.MonoTaskAsync((p, cache) => GameCheatEngine.Create(cache), this.Cache);
        public Task<GameCheatEngine> GetGameCheatEngineThrowIfNotInGame() => this.MonoTaskAsync((p, cache) => GameCheatEngine.CreateThrowIfNotInGame(cache), this.Cache);


        public sealed override async ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
        {
            var cheatengine = await this.GetGameCheatEngineThrowIfNotInGame().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, c) => cheatengine.GetGameCharacters().ToArray(), cheatengine).ConfigureAwait(false);

        }


        public sealed override ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            return new ValueTask<GameInventoryDisplayDTO[]>(this.Cache.Items);
        }
        public sealed override ValueTask<GameMonsterDisplayDTO[]> GetListMonsterDisplayAsync()
        {
            return new ValueTask<GameMonsterDisplayDTO[]>(this.Cache.Monsters);
        }
        public sealed override ValueTask<GameSkillDisplayDTO[]> GetListSkillDisplayAsync()
        {
            return new ValueTask<GameSkillDisplayDTO[]>(this.Cache.Skills);
        }

    }

}
