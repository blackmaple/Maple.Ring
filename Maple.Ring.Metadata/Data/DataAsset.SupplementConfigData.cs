namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."SupplementConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SupplementConfigData>, Ptr_SupplementConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "SupplementConfigData", "DataAsset.SupplementConfigData")]
    public partial class SupplementConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SupplementConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SupplementConfigData(System.IntPtr ptr) => new Ptr_SupplementConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_SupplementConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_SupplementConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."SupplementConfigData"]
        /// </summary>
        partial struct Ptr_SupplementConfigData
        {
            /// <summary>
            /// 0x10 System.Int32 itemId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("itemId", "System.Int32")]
            public partial System.Int32 ITEM_ID { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Boolean useInBattle
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("useInBattle", "System.Boolean")]
            public partial System.Boolean USE_IN_BATTLE { get; set; } 
*/

            /// <summary>
            /// 0x15 System.Boolean useInNormal
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("useInNormal", "System.Boolean")]
            public partial System.Boolean USE_IN_NORMAL { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 skillId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillId", "System.Int32")]
            public partial System.Int32 SKILL_ID { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."SupplementConfigData"]
        /// </summary>
        partial struct Ptr_SupplementConfigData
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
            ///   DataAsset.SkillConfigData get_SkillConfigData()
            /// </summary>
            /// <returns>class DataAsset.SkillConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SkillConfigData", "DataAsset.SkillConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKILL_CONFIG_DATA(); 
*/
        }
    }
}