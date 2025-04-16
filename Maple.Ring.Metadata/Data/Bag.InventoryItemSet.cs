namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Bag"."InventoryItemSet"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_InventoryItemSet>, Ptr_InventoryItemSet>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "Bag", "InventoryItemSet", "Bag.InventoryItemSet")]
    public partial class InventoryItemSet
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_InventoryItemSet(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_InventoryItemSet(System.IntPtr ptr) => new Ptr_InventoryItemSet(ptr);
            public static implicit operator System.IntPtr(Ptr_InventoryItemSet ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_InventoryItemSet ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Bag"."InventoryItemSet"]
        /// </summary>
        partial struct Ptr_InventoryItemSet
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
            /// 0x18 UniRx.IntReactiveProperty count
            /// class ["UniRx.dll"."UniRx"."IntReactiveProperty"]
            /// </summary>
            /// <returns>class UniRx.IntReactiveProperty</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("count", "UniRx.IntReactiveProperty")]
            public partial nint COUNT { get; set; } 
*/

            /// <summary>
            /// 0x20 DataAsset.ItemConfigData _data
            /// class ["Assembly-CSharp.dll"."DataAsset"."ItemConfigData"]
            /// </summary>
            /// <returns>class DataAsset.ItemConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_data", "DataAsset.ItemConfigData")]
            public partial nint _DATA { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Bag"."InventoryItemSet"]
        /// </summary>
        partial struct Ptr_InventoryItemSet
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 itemId, System.Int32 count)
            /// </summary>
            /// <param name = "itemId">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void CTOR(System.Int32 itemId, System.Int32 count); 
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
            ///   System.Int32 get_Stock()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Stock", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_STOCK(); 
*/
            /// <summary>
            ///   System.Void set_ItemConfigData(DataAsset.ItemConfigData value)
            /// </summary>
            /// <param name = "value">class DataAsset.ItemConfigData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ItemConfigData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DataAsset.ItemConfigData", 0)]
            public partial void SET_ITEM_CONFIG_DATA(nint value); 
*/
        }
    }
}