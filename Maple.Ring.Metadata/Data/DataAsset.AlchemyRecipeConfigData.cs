namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."AlchemyRecipeConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AlchemyRecipeConfigData>, Ptr_AlchemyRecipeConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "AlchemyRecipeConfigData", "DataAsset.AlchemyRecipeConfigData")]
    public partial class AlchemyRecipeConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AlchemyRecipeConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AlchemyRecipeConfigData(System.IntPtr ptr) => new Ptr_AlchemyRecipeConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_AlchemyRecipeConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AlchemyRecipeConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."AlchemyRecipeConfigData"]
        /// </summary>
        partial struct Ptr_AlchemyRecipeConfigData
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
            /// 0x18 System.Collections.Generic.List<DataAsset.RecipeMaterialSet> materials
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DataAsset.RecipeMaterialSet></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("materials", "System.Collections.Generic.List<DataAsset.RecipeMaterialSet>")]
            public partial nint MATERIALS { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 productItemId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("productItemId", "System.Int32")]
            public partial System.Int32 PRODUCT_ITEM_ID { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Single successChance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("successChance", "System.Single")]
            public partial System.Single SUCCESS_CHANCE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Single stoveDestructionChance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("stoveDestructionChance", "System.Single")]
            public partial System.Single STOVE_DESTRUCTION_CHANCE { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Single reverseChance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("reverseChance", "System.Single")]
            public partial System.Single REVERSE_CHANCE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.List<DataAsset.RecipeRareProductSet> rareProducts
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DataAsset.RecipeRareProductSet></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("rareProducts", "System.Collections.Generic.List<DataAsset.RecipeRareProductSet>")]
            public partial nint RARE_PRODUCTS { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."AlchemyRecipeConfigData"]
        /// </summary>
        partial struct Ptr_AlchemyRecipeConfigData
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