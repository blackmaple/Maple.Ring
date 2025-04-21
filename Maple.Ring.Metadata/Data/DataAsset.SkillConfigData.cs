using Maple.MonoGameAssistant.MetadataCollections;

namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."SkillConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SkillConfigData>, Ptr_SkillConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "SkillConfigData", "DataAsset.SkillConfigData")]
    public partial class SkillConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SkillConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SkillConfigData(System.IntPtr ptr) => new Ptr_SkillConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_SkillConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_SkillConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."SkillConfigData"]
        /// </summary>
        partial struct Ptr_SkillConfigData
        {
            /// <summary>
            /// 0x10 System.Int32 INFINITY_USE_TIME
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("INFINITY_USE_TIME", "System.Int32")]
           public partial System.Int32 INFINITY_USE_TIME { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String CostMPImpactName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CostMPImpactName", "System.String")]
           public partial nint COST_MP_IMPACT_NAME { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String RecoverMPImpactName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RecoverMPImpactName", "System.String")]
           public partial nint RECOVER_MP_IMPACT_NAME { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 id
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; }


            /// <summary>
            /// 0x30 System.String title
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("title", "System.String")]
           public partial nint TITLE { get; set; } 
*/

            /// <summary>
            /// 0x38 UnityEngine.Sprite icon
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Sprite"]
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("icon", "UnityEngine.Sprite")]
           public partial nint ICON { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 sourceId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sourceId", "System.Int32")]
           public partial System.Int32 SOURCE_ID { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Int32 level
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("level", "System.Int32")]
            public partial System.Int32 LEVEL { get; set; }


            /// <summary>
            /// 0x48 System.Int32 nextLevelExp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("nextLevelExp", "System.Int32")]
           public partial System.Int32 NEXT_LEVEL_EXP { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String description
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("description", "System.String")]
           public partial nint DESCRIPTION { get; set; } 
*/

            /// <summary>
            /// 0x58 System.String[] descriptionReplacer
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("descriptionReplacer", "System.String[]")]
           public partial nint DESCRIPTION_REPLACER { get; set; } 
*/

            /// <summary>
            /// 0x60 System.String subDescription
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("subDescription", "System.String")]
           public partial nint SUB_DESCRIPTION { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Collections.Generic.List<SkillType> types
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<SkillType></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("types", "System.Collections.Generic.List<SkillType>")]
            public partial SysPtrList<SkillType> TYPES { get; set; }


            /// <summary>
            /// 0x70 System.Int32 totalTimes
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("totalTimes", "System.Int32")]
           public partial System.Int32 TOTAL_TIMES { get; set; } 
*/

            /// <summary>
            /// 0x74 System.Int32 elementId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("elementId", "System.Int32")]
           public partial System.Int32 ELEMENT_ID { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Single costHP
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("costHP", "System.Single")]
           public partial System.Single COST_HP { get; set; } 
*/

            /// <summary>
            /// 0x7C System.Single costHPMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("costHPMultiper", "System.Single")]
           public partial System.Single COST_HP_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Single costMP
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("costMP", "System.Single")]
           public partial System.Single COST_MP { get; set; } 
*/

            /// <summary>
            /// 0x84 System.Single costMPMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("costMPMultiper", "System.Single")]
           public partial System.Single COST_MP_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Single power
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("power", "System.Single")]
           public partial System.Single POWER { get; set; } 
*/

            /// <summary>
            /// 0x8C System.Single powerConst
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("powerConst", "System.Single")]
           public partial System.Single POWER_CONST { get; set; } 
*/

            /// <summary>
            /// 0x90 Skill.WeighterSetting[] powerBuffMultiper
            /// class ["Assembly-CSharp.dll"."Skill"."WeighterSetting[]"]
            /// </summary>
            /// <returns>class Skill.WeighterSetting[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("powerBuffMultiper", "Skill.WeighterSetting[]")]
           public partial nint POWER_BUFF_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x98 Skill.SelectorType selectorType
            /// enum ["Assembly-CSharp.dll"."Skill"."SelectorType"]
            /// </summary>
            /// <returns>enum Skill.SelectorType</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("selectorType", "Skill.SelectorType")]
           public partial Skill.SelectorType SELECTOR_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x9C Skill.AttackType attackType
            /// enum ["Assembly-CSharp.dll"."Skill"."AttackType"]
            /// </summary>
            /// <returns>enum Skill.AttackType</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attackType", "Skill.AttackType")]
           public partial Skill.AttackType ATTACK_TYPE { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.String[] attackTargetTags
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attackTargetTags", "System.String[]")]
           public partial nint ATTACK_TARGET_TAGS { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Boolean useToMe
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("useToMe", "System.Boolean")]
           public partial System.Boolean USE_TO_ME { get; set; } 
*/

            /// <summary>
            /// 0xA9 System.Boolean useToEnemy
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("useToEnemy", "System.Boolean")]
           public partial System.Boolean USE_TO_ENEMY { get; set; } 
*/

            /// <summary>
            /// 0xAA System.Boolean canUseToPartner
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("canUseToPartner", "System.Boolean")]
           public partial System.Boolean CAN_USE_TO_PARTNER { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Int32[] buffs
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("buffs", "System.Int32[]")]
           public partial nint BUFFS { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.String[] impactTypes
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("impactTypes", "System.String[]")]
           public partial nint IMPACT_TYPES { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Single attackCount
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attackCount", "System.Single")]
           public partial System.Single ATTACK_COUNT { get; set; } 
*/

            /// <summary>
            /// 0xC4 System.Int32 nextSkillId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("nextSkillId", "System.Int32")]
           public partial System.Int32 NEXT_SKILL_ID { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.String prefabName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("prefabName", "System.String")]
           public partial nint PREFAB_NAME { get; set; } 
*/

            /// <summary>
            /// 0xD0 UnityEngine.GameObject skillPrefab
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."GameObject"]
            /// </summary>
            /// <returns>class UnityEngine.GameObject</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillPrefab", "UnityEngine.GameObject")]
           public partial nint SKILL_PREFAB { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.String animationName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("animationName", "System.String")]
           public partial nint ANIMATION_NAME { get; set; } 
*/

            /// <summary>
            /// 0xE0 UnityEngine.GameObject animationPrefab
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."GameObject"]
            /// </summary>
            /// <returns>class UnityEngine.GameObject</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("animationPrefab", "UnityEngine.GameObject")]
           public partial nint ANIMATION_PREFAB { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.String hitFxName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hitFxName", "System.String")]
           public partial nint HIT_FX_NAME { get; set; } 
*/

            /// <summary>
            /// 0xF0 System.String hitEmotionId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hitEmotionId", "System.String")]
           public partial nint HIT_EMOTION_ID { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Single durationTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("durationTime", "System.Single")]
           public partial System.Single DURATION_TIME { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."SkillConfigData"]
        /// </summary>
        partial struct Ptr_SkillConfigData
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Boolean <get_MaxLevel>b__70_0(DataAsset.SkillConfigData data)
            /// </summary>
            /// <param name = "data">class DataAsset.SkillConfigData</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<get_MaxLevel>b__70_0", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DataAsset.SkillConfigData", 0)]
           public partial System.Boolean GET_MAX_LEVELB__70_0(nint data); 
*/
            /// <summary>
            ///   I18n.I18nTextProvider get_Description()
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Description", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial I18nTextProvider.Ptr_I18nTextProvider GET_DESCRIPTION();

            /// <summary>
            ///   System.Single get_DurationTime()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_DurationTime", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single GET_DURATION_TIME(); 
*/
            /// <summary>
            ///   DataAsset.ElementConfigData get_Element()
            /// </summary>
            /// <returns>class DataAsset.ElementConfigData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Element", "DataAsset.ElementConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_ELEMENT(); 
*/
            /// <summary>
            ///   System.Boolean get_IsAttackSkill()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsAttackSkill", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_ATTACK_SKILL(); 
*/
            /// <summary>
            ///   System.Boolean get_IsBuffSkill()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsBuffSkill", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_BUFF_SKILL(); 
*/
            /// <summary>
            ///   System.Boolean get_IsDamageSkill()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsDamageSkill", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_DAMAGE_SKILL(); 
*/
            /// <summary>
            ///   System.Boolean get_IsDebuffSkill()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsDebuffSkill", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_DEBUFF_SKILL(); 
*/
            /// <summary>
            ///   System.Boolean get_IsInfinity()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsInfinity", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_INFINITY(); 
*/
            /// <summary>
            ///   System.Boolean get_IsRecoverMPSkill()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsRecoverMPSkill", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_RECOVER_MP_SKILL(); 
*/
            /// <summary>
            ///   System.Boolean get_IsTreatSkill()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsTreatSkill", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_TREAT_SKILL(); 
*/
            /// <summary>
            ///   System.Boolean get_IsUpgradeSkill()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsUpgradeSkill", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_IS_UPGRADE_SKILL(); 
*/
            /// <summary>
            ///   System.Int32 get_MaxLevel()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MaxLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 GET_MAX_LEVEL(); 
*/
            /// <summary>
            ///   DataAsset.SkillConfigData get_NextSkillconfig()
            /// </summary>
            /// <returns>class DataAsset.SkillConfigData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_NextSkillconfig", "DataAsset.SkillConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_NEXT_SKILLCONFIG(); 
*/
            /// <summary>
            ///   I18n.I18nTextProvider get_SubDescription()
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SubDescription", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial I18nTextProvider.Ptr_I18nTextProvider GET_SUB_DESCRIPTION();

            /// <summary>
            ///   I18n.I18nTextProvider get_Title()
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Title", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial I18nTextProvider.Ptr_I18nTextProvider GET_TITLE();

            /// <summary>
            ///   System.Boolean get_Upgradeable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Upgradeable", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_UPGRADEABLE(); 
*/
        }
    }
}