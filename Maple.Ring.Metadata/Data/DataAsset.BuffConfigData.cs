namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."BuffConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_BuffConfigData>, Ptr_BuffConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "BuffConfigData", "DataAsset.BuffConfigData")]
    public partial class BuffConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_BuffConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_BuffConfigData(System.IntPtr ptr) => new Ptr_BuffConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_BuffConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_BuffConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."BuffConfigData"]
        /// </summary>
        partial struct Ptr_BuffConfigData
        {
            /// <summary>
            /// 0x0 System.Int32 infiniteDurationValue
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            public const System.Int32 INFINITE_DURATION_VALUE = -1; 
*/
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
            /// 0x20 System.Int32 sourceId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sourceId", "System.Int32")]
            public partial System.Int32 SOURCE_ID { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Int32 level
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("level", "System.Int32")]
            public partial System.Int32 LEVEL { get; set; } 
*/

            /// <summary>
            /// 0x28 UnityEngine.Sprite icon
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Sprite"]
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("icon", "UnityEngine.Sprite")]
            public partial nint ICON { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Boolean isDebuff
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isDebuff", "System.Boolean")]
            public partial System.Boolean IS_DEBUFF { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String description
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("description", "System.String")]
            public partial nint DESCRIPTION { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 duration
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("duration", "System.Int32")]
            public partial System.Int32 DURATION { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Boolean removable
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("removable", "System.Boolean")]
            public partial System.Boolean REMOVABLE { get; set; } 
*/

            /// <summary>
            /// 0x45 System.Boolean unique
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("unique", "System.Boolean")]
            public partial System.Boolean UNIQUE { get; set; } 
*/

            /// <summary>
            /// 0x48 DataAsset.BuffImpactDefinition[] impactDefinitions
            /// class ["Assembly-CSharp.dll"."DataAsset"."BuffImpactDefinition[]"]
            /// </summary>
            /// <returns>class DataAsset.BuffImpactDefinition[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("impactDefinitions", "DataAsset.BuffImpactDefinition[]")]
            public partial nint IMPACT_DEFINITIONS { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String[] descriptionReplacers
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("descriptionReplacers", "System.String[]")]
            public partial nint DESCRIPTION_REPLACERS { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."BuffConfigData"]
        /// </summary>
        partial struct Ptr_BuffConfigData
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
            ///   I18n.I18nTextProvider get_Description()
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Description", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DESCRIPTION(); 
*/
            /// <summary>
            ///   System.Boolean get_IsInfinite()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsInfinite", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_INFINITE(); 
*/
            /// <summary>
            ///   I18n.I18nTextProvider get_Title()
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Title", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TITLE(); 
*/
        }
    }
}