namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."Personality"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Personality>, Ptr_Personality>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "Personality", "Personality")]
    public partial class Personality
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Personality(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_Personality(System.IntPtr ptr) => new Ptr_Personality(ptr);
            public static implicit operator System.IntPtr(Ptr_Personality ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_Personality ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."Personality"]
        /// </summary>
        partial struct Ptr_Personality
        {
            /// <summary>
            /// 0x10 System.Single brave
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("brave", "System.Single")]
            public partial System.Single BRAVE { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Single effort
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("effort", "System.Single")]
            public partial System.Single EFFORT { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Single greed
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("greed", "System.Single")]
            public partial System.Single GREED { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Single pure
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("pure", "System.Single")]
            public partial System.Single PURE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Single moral
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("moral", "System.Single")]
            public partial System.Single MORAL { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."Personality"]
        /// </summary>
        partial struct Ptr_Personality
        {
            /// <summary>
            /// static  System.Single GetDeviationValue(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDeviationValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial System.Single GET_DEVIATION_VALUE(System.Single value); 
*/
            /// <summary>
            /// static  System.Single GetDeviationValueZeroToOne(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDeviationValueZeroToOne", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial System.Single GET_DEVIATION_VALUE_ZERO_TO_ONE(System.Single value); 
*/
            /// <summary>
            /// static  I18n.I18nTextProvider GetLabel(DictIndex index, System.Single value)
            /// </summary>
            /// <param name = "index">enum DictIndex</param>
            /// <param name = "value">struct System.Single</param>
            /// <returns>class I18n.I18nTextProvider</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLabel", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DictIndex", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial nint GET_LABEL(DictIndex index, System.Single value); 
*/
            /// <summary>
            /// static  System.Int32 GetPersonalityLevel(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPersonalityLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial System.Int32 GET_PERSONALITY_LEVEL(System.Single value); 
*/
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