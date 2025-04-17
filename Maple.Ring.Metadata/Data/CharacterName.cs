namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."CharacterName"]
    /// [System.Object]
    /// [Save.IStorable<Save.CharacterNameSaveData>]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_CharacterName>, Ptr_CharacterName>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "CharacterName", "CharacterName")]
    public partial class CharacterName
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_CharacterName(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_CharacterName(System.IntPtr ptr) => new Ptr_CharacterName(ptr);
            public static implicit operator System.IntPtr(Ptr_CharacterName ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_CharacterName ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."CharacterName"]
        /// </summary>
        partial struct Ptr_CharacterName
        {
            /// <summary>
            /// 0x10 System.Collections.Generic.List<I18n.I18nTextProvider> firstNameList
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<I18n.I18nTextProvider></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("firstNameList", "System.Collections.Generic.List<I18n.I18nTextProvider>")]
            public partial nint FIRST_NAME_LIST { get; set; } 
*/

            /// <summary>
            /// 0x18 I18n.I18nTextProvider lastName
            /// class ["Assembly-CSharp.dll"."I18n"."I18nTextProvider"]
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lastName", "I18n.I18nTextProvider")]
            public partial nint LAST_NAME { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."CharacterName"]
        /// </summary>
        partial struct Ptr_CharacterName
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
            ///   System.Void .ctor(System.Collections.Generic.List<System.String> firstName, System.String lastName)
            /// </summary>
            /// <param name = "firstName">class System.Collections.Generic.List<System.String></param>
            /// <param name = "lastName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void CTOR(nint firstName, nint lastName); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.List<I18n.I18nTextProvider> firstName, I18n.I18nTextProvider lastName)
            /// </summary>
            /// <param name = "firstName">class System.Collections.Generic.List<I18n.I18nTextProvider></param>
            /// <param name = "lastName">class I18n.I18nTextProvider</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<I18n.I18nTextProvider>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("I18n.I18nTextProvider", 1)]
            public partial void CTOR(nint firstName, nint lastName); 
*/
            /// <summary>
            ///   I18n.I18nTextProvider get_FirstName()
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_FirstName", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FIRST_NAME(); 
*/
            /// <summary>
            ///   I18n.I18nTextProvider get_Value()
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>
            
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Value", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial I18nTextProvider.Ptr_I18nTextProvider GET_VALUE(); 
 
            /// <summary>
            ///   System.Void Load(Save.CharacterNameSaveData data)
            /// </summary>
            /// <param name = "data">class Save.CharacterNameSaveData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Load", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Save.CharacterNameSaveData", 0)]
            public partial void LOAD(nint data); 
*/
            /// <summary>
            ///   Save.CharacterNameSaveData Save()
            /// </summary>
            /// <returns>class Save.CharacterNameSaveData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Save", "Save.CharacterNameSaveData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SAVE(); 
*/
        }
    }
}