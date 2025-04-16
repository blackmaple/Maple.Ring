namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."AlchemyGrowthConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AlchemyGrowthConfigData>, Ptr_AlchemyGrowthConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "AlchemyGrowthConfigData", "DataAsset.AlchemyGrowthConfigData")]
    public partial class AlchemyGrowthConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AlchemyGrowthConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AlchemyGrowthConfigData(System.IntPtr ptr) => new Ptr_AlchemyGrowthConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_AlchemyGrowthConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AlchemyGrowthConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."AlchemyGrowthConfigData"]
        /// </summary>
        partial struct Ptr_AlchemyGrowthConfigData
        {
            /// <summary>
            /// 0x10 System.Int32 levelDiff
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("levelDiff", "System.Int32")]
            public partial System.Int32 LEVEL_DIFF { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 minProduction
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("minProduction", "System.Int32")]
            public partial System.Int32 MIN_PRODUCTION { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 maxProduction
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxProduction", "System.Int32")]
            public partial System.Int32 MAX_PRODUCTION { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Single expGrowChance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("expGrowChance", "System.Single")]
            public partial System.Single EXP_GROW_CHANCE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."AlchemyGrowthConfigData"]
        /// </summary>
        partial struct Ptr_AlchemyGrowthConfigData
        {
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