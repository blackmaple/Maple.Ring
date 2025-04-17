using Maple.MonoGameAssistant.Core;

namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."GameSystemConfig"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_GameSystemConfig>, Ptr_GameSystemConfig>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "GameSystemConfig", "GameSystemConfig")]
    public partial class GameSystemConfig
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_GameSystemConfig(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_GameSystemConfig(System.IntPtr ptr) => new Ptr_GameSystemConfig(ptr);
            public static implicit operator System.IntPtr(Ptr_GameSystemConfig ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_GameSystemConfig ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."GameSystemConfig"]
        /// </summary>
        partial struct Ptr_GameSystemConfig
        {
            /// <summary>
            /// 0x0 System.String dataAssetFilePath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint DATA_ASSET_FILE_PATH = DataAssets/; 
*/
            /// <summary>
            /// 0x0 System.Boolean encryptSaveFile
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            public const System.Boolean ENCRYPT_SAVE_FILE = False; 
*/
            /// <summary>
            /// 0x0 System.String encryptKey
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint ENCRYPT_KEY = 2pgameselderringsoundsreallycool; 
*/
            /// <summary>
            /// 0x0 System.String encryptVI
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint ENCRYPT_VI = whosyourdaddy666; 
*/
            /// <summary>
            /// 0x0 System.String settingFilePath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint SETTING_FILE_PATH = Settings; 
*/
            /// <summary>
            /// 0x0 System.String audioMixerFilepath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint AUDIO_MIXER_FILEPATH = Audios/AudioMixer; 
*/
            /// <summary>
            /// 0x0 System.Single minVolume
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            public const System.Single MIN_VOLUME = -80; 
*/
            /// <summary>
            /// 0x0 System.Single maxVolume
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            public const System.Single MAX_VOLUME = 0; 
*/
            /// <summary>
            /// 0x0 System.Int32 mouseLeftButtonValue
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            public const System.Int32 MOUSE_LEFT_BUTTON_VALUE = 0; 
*/
            /// <summary>
            /// 0x0 System.Int32 mouseRightButtonValue
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            public const System.Int32 MOUSE_RIGHT_BUTTON_VALUE = 1; 
*/
            /// <summary>
            /// 0x0 System.Int32 mouseLeftButtonPointerId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            public const System.Int32 MOUSE_LEFT_BUTTON_POINTER_ID = -1; 
*/
            /// <summary>
            /// 0x0 System.Int32 mouseRightButtonPointerId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            public const System.Int32 MOUSE_RIGHT_BUTTON_POINTER_ID = -2; 
*/
            /// <summary>
            /// 0x0 System.Single basePowerEffectMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            public const System.Single BASE_POWER_EFFECT_MULTIPER = 1; 
*/
            /// <summary>
            /// 0x0 System.String SaveDataPath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SaveDataPath", "System.String")]
            public static partial nint SAVE_DATA_PATH { get; set; } 
*/

            /// <summary>
            /// 0x8 System.String SettingSaveFilePath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SettingSaveFilePath", "System.String")]
            public static partial nint SETTING_SAVE_FILE_PATH { get; set; } 
*/

            /// <summary>
            /// 0x10 System.Int32 playerActorId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("playerActorId", "System.Int32")]
            public static partial System.Int32 PLAYER_ACTOR_ID { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 masterActorId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("masterActorId", "System.Int32")]
            public static partial System.Int32 MASTER_ACTOR_ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Single secondsPerDay
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("secondsPerDay", "System.Single")]
            public static partial System.Single SECONDS_PER_DAY { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Int32 defaultMonsterId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("defaultMonsterId", "System.Int32")]
            public static partial System.Int32 DEFAULT_MONSTER_ID { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 prologueStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("prologueStoryId", "System.Int32")]
            public static partial System.Int32 PROLOGUE_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Int32 masterDeadStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("masterDeadStoryId", "System.Int32")]
            public static partial System.Int32 MASTER_DEAD_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 masterLifeEndStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("masterLifeEndStoryId", "System.Int32")]
            public static partial System.Int32 MASTER_LIFE_END_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Single personalityMinValue
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("personalityMinValue", "System.Single")]
            public static partial System.Single PERSONALITY_MIN_VALUE { get; set; } 
 

            /// <summary>
            /// 0x30 System.Single personalityMaxValue
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("personalityMaxValue", "System.Single")]
            public static partial System.Single PERSONALITY_MAX_VALUE { get; set; } 
 

            /// <summary>
            /// 0x38 System.Single[] personalityThresholds
            /// class ["mscorlib.dll"."System"."Single[]"]
            /// </summary>
            /// <returns>class System.Single[]</returns>
              
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("personalityThresholds", "System.Single[]")]
            public static partial PMonoArray<Single> PERSONALITY_THRESHOLDS { get; set; } 
 

            /// <summary>
            /// 0x40 System.Int32[] defaultBookCopierBooks
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("defaultBookCopierBooks", "System.Int32[]")]
            public static partial nint DEFAULT_BOOK_COPIER_BOOKS { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 worldAreaId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("worldAreaId", "System.Int32")]
            public static partial System.Int32 WORLD_AREA_ID { get; set; } 
*/

            /// <summary>
            /// 0x4C System.Single crossWorldStandardTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("crossWorldStandardTime", "System.Single")]
            public static partial System.Single CROSS_WORLD_STANDARD_TIME { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Single trustMaxValue
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("trustMaxValue", "System.Single")]
            public static partial System.Single TRUST_MAX_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x54 System.Single trustMinValue
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("trustMinValue", "System.Single")]
            public static partial System.Single TRUST_MIN_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Int32 practiseSkillTriggerId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("practiseSkillTriggerId", "System.Int32")]
            public static partial System.Int32 PRACTISE_SKILL_TRIGGER_ID { get; set; } 
*/

            /// <summary>
            /// 0x5C System.Int32 moneyItemId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
           
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("moneyItemId", "System.Int32")]
            public static partial System.Int32 MONEY_ITEM_ID { get; set; } 
 

            /// <summary>
            /// 0x60 System.Int32 levelBreakStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("levelBreakStoryId", "System.Int32")]
            public static partial System.Int32 LEVEL_BREAK_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x64 System.Int32 healStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("healStoryId", "System.Int32")]
            public static partial System.Int32 HEAL_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Int32 advice1StoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("advice1StoryId", "System.Int32")]
            public static partial System.Int32 ADVICE1_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x6C System.Int32 advice2StoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("advice2StoryId", "System.Int32")]
            public static partial System.Int32 ADVICE2_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Int32 advice3StoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("advice3StoryId", "System.Int32")]
            public static partial System.Int32 ADVICE3_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x74 System.Int32 advice4StoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("advice4StoryId", "System.Int32")]
            public static partial System.Int32 ADVICE4_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Int32 adviceMoveStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("adviceMoveStoryId", "System.Int32")]
            public static partial System.Int32 ADVICE_MOVE_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x7C System.Int32 adviceMoveTriggerId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("adviceMoveTriggerId", "System.Int32")]
            public static partial System.Int32 ADVICE_MOVE_TRIGGER_ID { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Int32 adventureForArtifactStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("adventureForArtifactStoryId", "System.Int32")]
            public static partial System.Int32 ADVENTURE_FOR_ARTIFACT_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x84 System.Int32 ahForArtifactStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ahForArtifactStoryId", "System.Int32")]
            public static partial System.Int32 AH_FOR_ARTIFACT_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Int32 exchangeArtifactStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("exchangeArtifactStoryId", "System.Int32")]
            public static partial System.Int32 EXCHANGE_ARTIFACT_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x8C System.Int32 killForArtifactStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("killForArtifactStoryId", "System.Int32")]
            public static partial System.Int32 KILL_FOR_ARTIFACT_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Int32 sectForArtifactStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sectForArtifactStoryId", "System.Int32")]
            public static partial System.Int32 SECT_FOR_ARTIFACT_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x94 System.Int32 shoppingForArtifactStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("shoppingForArtifactStoryId", "System.Int32")]
            public static partial System.Int32 SHOPPING_FOR_ARTIFACT_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x98 System.Int32 adventureForSkillBookStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("adventureForSkillBookStoryId", "System.Int32")]
            public static partial System.Int32 ADVENTURE_FOR_SKILL_BOOK_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0x9C System.Int32 ahForSkillBookStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ahForSkillBookStoryId", "System.Int32")]
            public static partial System.Int32 AH_FOR_SKILL_BOOK_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Int32 exchangeSkillBookStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("exchangeSkillBookStoryId", "System.Int32")]
            public static partial System.Int32 EXCHANGE_SKILL_BOOK_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xA4 System.Int32 killForSkillBookStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("killForSkillBookStoryId", "System.Int32")]
            public static partial System.Int32 KILL_FOR_SKILL_BOOK_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Int32 sectForSkillBookStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sectForSkillBookStoryId", "System.Int32")]
            public static partial System.Int32 SECT_FOR_SKILL_BOOK_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xAC System.Int32 shoppingForSkillBookStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("shoppingForSkillBookStoryId", "System.Int32")]
            public static partial System.Int32 SHOPPING_FOR_SKILL_BOOK_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Int32 ahForSuppliesStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ahForSuppliesStoryId", "System.Int32")]
            public static partial System.Int32 AH_FOR_SUPPLIES_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xB4 System.Int32 concoctingStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("concoctingStoryId", "System.Int32")]
            public static partial System.Int32 CONCOCTING_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Int32 exchangeSuppliesStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("exchangeSuppliesStoryId", "System.Int32")]
            public static partial System.Int32 EXCHANGE_SUPPLIES_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xBC System.Int32 shoppingForSuppliesStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("shoppingForSuppliesStoryId", "System.Int32")]
            public static partial System.Int32 SHOPPING_FOR_SUPPLIES_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Int32 battleForPracticeStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("battleForPracticeStoryId", "System.Int32")]
            public static partial System.Int32 BATTLE_FOR_PRACTICE_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xC4 System.Int32 learnSkillStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("learnSkillStoryId", "System.Int32")]
            public static partial System.Int32 LEARN_SKILL_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Int32 battleForExpStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("battleForExpStoryId", "System.Int32")]
            public static partial System.Int32 BATTLE_FOR_EXP_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xCC System.Int32 breakthroughStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("breakthroughStoryId", "System.Int32")]
            public static partial System.Int32 BREAKTHROUGH_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.Int32 meditationStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("meditationStoryId", "System.Int32")]
            public static partial System.Int32 MEDITATION_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xD4 System.Int32 useItemForExpStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("useItemForExpStoryId", "System.Int32")]
            public static partial System.Int32 USE_ITEM_FOR_EXP_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.Int32 restStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("restStoryId", "System.Int32")]
            public static partial System.Int32 REST_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xDC System.Int32 useRecoveryArtifactStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("useRecoveryArtifactStoryId", "System.Int32")]
            public static partial System.Int32 USE_RECOVERY_ARTIFACT_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xE0 System.Int32 useRecoveryItemStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("useRecoveryItemStoryId", "System.Int32")]
            public static partial System.Int32 USE_RECOVERY_ITEM_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xE4 System.Int32 idleStoryId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("idleStoryId", "System.Int32")]
            public static partial System.Int32 IDLE_STORY_ID { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Int32 GGSkillId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("GGSkillId", "System.Int32")]
            public static partial System.Int32 GG_SKILL_ID { get; set; } 
*/

            /// <summary>
            /// 0xEC System.Single fireSRAlchemySuccessRate
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("fireSRAlchemySuccessRate", "System.Single")]
            public static partial System.Single FIRE_SR_ALCHEMY_SUCCESS_RATE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."GameSystemConfig"]
        /// </summary>
        partial struct Ptr_GameSystemConfig
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
        }
    }
}