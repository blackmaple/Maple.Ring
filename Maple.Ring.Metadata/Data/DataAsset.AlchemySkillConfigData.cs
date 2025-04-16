namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."AlchemySkillConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AlchemySkillConfigData>, Ptr_AlchemySkillConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "AlchemySkillConfigData", "DataAsset.AlchemySkillConfigData")]
    public partial class AlchemySkillConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AlchemySkillConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AlchemySkillConfigData(System.IntPtr ptr) => new Ptr_AlchemySkillConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_AlchemySkillConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AlchemySkillConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."AlchemySkillConfigData"]
        /// </summary>
        partial struct Ptr_AlchemySkillConfigData
        {
            /// <summary>
            /// 0x10 System.Int32 id
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String title
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("title", "System.String")]
            public partial nint TITLE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 level
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("level", "System.Int32")]
            public partial System.Int32 LEVEL { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String levelDescription
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("levelDescription", "System.String")]
            public partial nint LEVEL_DESCRIPTION { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 levelUpExp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("levelUpExp", "System.Int32")]
            public partial System.Int32 LEVEL_UP_EXP { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Single chance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("chance", "System.Single")]
            public partial System.Single CHANCE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."AlchemySkillConfigData"]
        /// </summary>
        partial struct Ptr_AlchemySkillConfigData
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
            ///   I18n.I18nTextProvider get_LevelDescription()
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_LevelDescription", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_LEVEL_DESCRIPTION(); 
*/
            /// <summary>
            ///   DataAsset.AlchemySkillConfigData get_NextSkill()
            /// </summary>
            /// <returns>class DataAsset.AlchemySkillConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_NextSkill", "DataAsset.AlchemySkillConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NEXT_SKILL(); 
*/
            /// <summary>
            ///   I18n.I18nTextProvider get_Title()
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Title", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TITLE(); 
*/
            /// <summary>
            ///   System.Boolean get_Upgradable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Upgradable", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_UPGRADABLE(); 
*/
        }
    }
}