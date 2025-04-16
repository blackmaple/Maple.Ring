namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."CandidateInitItemConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_CandidateInitItemConfigData>, Ptr_CandidateInitItemConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "CandidateInitItemConfigData", "DataAsset.CandidateInitItemConfigData")]
    public partial class CandidateInitItemConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_CandidateInitItemConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_CandidateInitItemConfigData(System.IntPtr ptr) => new Ptr_CandidateInitItemConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_CandidateInitItemConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_CandidateInitItemConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."CandidateInitItemConfigData"]
        /// </summary>
        partial struct Ptr_CandidateInitItemConfigData
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
            /// 0x14 System.Single chance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("chance", "System.Single")]
            public partial System.Single CHANCE { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 minValue
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("minValue", "System.Int32")]
            public partial System.Int32 MIN_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Int32 maxValue
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxValue", "System.Int32")]
            public partial System.Int32 MAX_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 requireLevel
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("requireLevel", "System.Int32")]
            public partial System.Int32 REQUIRE_LEVEL { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."CandidateInitItemConfigData"]
        /// </summary>
        partial struct Ptr_CandidateInitItemConfigData
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
            ///   DataAsset.ItemConfigData get_ItemConfigData()
            /// </summary>
            /// <returns>class DataAsset.ItemConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ItemConfigData", "DataAsset.ItemConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ITEM_CONFIG_DATA(); 
*/
        }
    }
}