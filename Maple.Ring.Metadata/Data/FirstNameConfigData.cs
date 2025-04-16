namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."FirstNameConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_FirstNameConfigData>, Ptr_FirstNameConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "FirstNameConfigData", "FirstNameConfigData")]
    public partial class FirstNameConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_FirstNameConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_FirstNameConfigData(System.IntPtr ptr) => new Ptr_FirstNameConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_FirstNameConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_FirstNameConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."FirstNameConfigData"]
        /// </summary>
        partial struct Ptr_FirstNameConfigData
        {
            /// <summary>
            /// 0x10 System.String name
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
            public partial nint NAME { get; set; } 
*/

            /// <summary>
            /// 0x18 Sex sex
            /// enum ["Assembly-CSharp.dll".""."Sex"]
            /// </summary>
            /// <returns>enum Sex</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sex", "Sex")]
            public partial Sex SEX { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."FirstNameConfigData"]
        /// </summary>
        partial struct Ptr_FirstNameConfigData
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