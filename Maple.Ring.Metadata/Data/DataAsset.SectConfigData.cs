namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."SectConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SectConfigData>, Ptr_SectConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "SectConfigData", "DataAsset.SectConfigData")]
    public partial class SectConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SectConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SectConfigData(System.IntPtr ptr) => new Ptr_SectConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_SectConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_SectConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."SectConfigData"]
        /// </summary>
        partial struct Ptr_SectConfigData
        {
            /// <summary>
            /// 0x10 System.Int32 id
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; }


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
            /// 0x20 System.Int32 moneyItemId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("moneyItemId", "System.Int32")]
           public partial System.Int32 MONEY_ITEM_ID { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Boolean canJoin
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("canJoin", "System.Boolean")]
           public partial System.Boolean CAN_JOIN { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."SectConfigData"]
        /// </summary>
        partial struct Ptr_SectConfigData
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
            ///   DataAsset.ItemConfigData get_MoneyItem()
            /// </summary>
            /// <returns>class DataAsset.ItemConfigData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MoneyItem", "DataAsset.ItemConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_MONEY_ITEM(); 
*/
            /// <summary>
            ///   I18n.I18nTextProvider get_Title()
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Title", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial I18nTextProvider.Ptr_I18nTextProvider GET_TITLE();

        }
    }
}