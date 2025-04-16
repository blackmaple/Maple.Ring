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

        protected override async ValueTask LoadGameDataAsync()
        {
            await this.MonoTaskAsync(static (p, @this) => @this.LoadGameMetadata(), this).ConfigureAwait(false);
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
    }

}
