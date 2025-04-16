namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."SingleElementRestraintConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SingleElementRestraintConfigData>, Ptr_SingleElementRestraintConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "SingleElementRestraintConfigData", "DataAsset.SingleElementRestraintConfigData")]
    public partial class SingleElementRestraintConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SingleElementRestraintConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SingleElementRestraintConfigData(System.IntPtr ptr) => new Ptr_SingleElementRestraintConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_SingleElementRestraintConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_SingleElementRestraintConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."SingleElementRestraintConfigData"]
        /// </summary>
        partial struct Ptr_SingleElementRestraintConfigData
        {
            /// <summary>
            /// 0x10 System.Collections.Generic.List<DataAsset.ElementRestraintConfigData> datas
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<DataAsset.ElementRestraintConfigData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("datas", "System.Collections.Generic.List<DataAsset.ElementRestraintConfigData>")]
            public partial nint DATAS { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."SingleElementRestraintConfigData"]
        /// </summary>
        partial struct Ptr_SingleElementRestraintConfigData
        {
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.List<DataAsset.ElementRestraintConfigData> datas)
            /// </summary>
            /// <param name = "datas">class System.Collections.Generic.List<DataAsset.ElementRestraintConfigData></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<DataAsset.ElementRestraintConfigData>", 0)]
            public partial void CTOR(nint datas); 
*/
            /// <summary>
            ///   DataAsset.ElementRestraintConfigData get_Item(System.Int32 targetElementId)
            /// </summary>
            /// <param name = "targetElementId">struct System.Int32</param>
            /// <returns>class DataAsset.ElementRestraintConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Item", "DataAsset.ElementRestraintConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_ITEM(System.Int32 targetElementId); 
*/
        }
    }
}