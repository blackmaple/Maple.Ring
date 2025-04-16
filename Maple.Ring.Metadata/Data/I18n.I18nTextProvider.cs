using Maple.MonoGameAssistant.Core;

namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."I18n"."I18nTextProvider"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_I18nTextProvider>, Ptr_I18nTextProvider>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "I18n", "I18nTextProvider", "I18n.I18nTextProvider")]
    public partial class I18nTextProvider
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_I18nTextProvider(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_I18nTextProvider(System.IntPtr ptr) => new Ptr_I18nTextProvider(ptr);
            public static implicit operator System.IntPtr(Ptr_I18nTextProvider ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_I18nTextProvider ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."I18n"."I18nTextProvider"]
        /// </summary>
        partial struct Ptr_I18nTextProvider
        {
            /// <summary>
            /// 0x10 System.String text
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("text", "System.String")]
            public partial nint TEXT { get; set; } 
*/

            /// <summary>
            /// 0x18 I18n.I18nTextProvider[] subProviders
            /// class ["Assembly-CSharp.dll"."I18n"."I18nTextProvider[]"]
            /// </summary>
            /// <returns>class I18n.I18nTextProvider[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("subProviders", "I18n.I18nTextProvider[]")]
            public partial nint SUB_PROVIDERS { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."I18n"."I18nTextProvider"]
        /// </summary>
        partial struct Ptr_I18nTextProvider
        {
            /// <summary>
            ///   System.Void .ctor(System.String text, I18n.I18nTextProvider[] subProviders)
            /// </summary>
            /// <param name = "text">class System.String</param>
            /// <param name = "subProviders">class I18n.I18nTextProvider[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("I18n.I18nTextProvider[]", 1)]
            public partial void CTOR(nint text, nint subProviders); 
*/
            /// <summary>
            ///   System.String DOI18n()
            /// </summary>
            /// <returns>class System.String</returns>
          
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DOI18n", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial PMonoString DOI18N(); 
 
            /// <summary>
            ///   System.String get_Key()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Key", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_KEY(); 
*/
        }
    }
}