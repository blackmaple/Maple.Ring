namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."ForgeRecipeConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ForgeRecipeConfigData>, Ptr_ForgeRecipeConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "ForgeRecipeConfigData", "DataAsset.ForgeRecipeConfigData")]
    public partial class ForgeRecipeConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ForgeRecipeConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ForgeRecipeConfigData(System.IntPtr ptr) => new Ptr_ForgeRecipeConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_ForgeRecipeConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_ForgeRecipeConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."ForgeRecipeConfigData"]
        /// </summary>
        partial struct Ptr_ForgeRecipeConfigData
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
            /// 0x14 System.Int32 requireLevel
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("requireLevel", "System.Int32")]
            public partial System.Int32 REQUIRE_LEVEL { get; set; } 
*/

            /// <summary>
            /// 0x18 DataAsset.RecipeMaterialSet mainMaterial
            /// class ["Assembly-CSharp.dll"."DataAsset"."RecipeMaterialSet"]
            /// </summary>
            /// <returns>class DataAsset.RecipeMaterialSet</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mainMaterial", "DataAsset.RecipeMaterialSet")]
            public partial nint MAIN_MATERIAL { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<DataAsset.RecipeMaterialSet> materials
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DataAsset.RecipeMaterialSet></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("materials", "System.Collections.Generic.List<DataAsset.RecipeMaterialSet>")]
            public partial nint MATERIALS { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 productItemId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("productItemId", "System.Int32")]
            public partial System.Int32 PRODUCT_ITEM_ID { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Single successChance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("successChance", "System.Single")]
            public partial System.Single SUCCESS_CHANCE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Single mainMaterialDestructionChance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mainMaterialDestructionChance", "System.Single")]
            public partial System.Single MAIN_MATERIAL_DESTRUCTION_CHANCE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."ForgeRecipeConfigData"]
        /// </summary>
        partial struct Ptr_ForgeRecipeConfigData
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
            /// <summary>
            ///   DataAsset.ItemConfigData get_Production()
            /// </summary>
            /// <returns>class DataAsset.ItemConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Production", "DataAsset.ItemConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PRODUCTION(); 
*/
        }
    }
}