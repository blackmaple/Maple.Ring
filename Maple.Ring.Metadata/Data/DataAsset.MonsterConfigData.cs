namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."MonsterConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_MonsterConfigData>, Ptr_MonsterConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "MonsterConfigData", "DataAsset.MonsterConfigData")]
    public partial class MonsterConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_MonsterConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_MonsterConfigData(System.IntPtr ptr) => new Ptr_MonsterConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_MonsterConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_MonsterConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."MonsterConfigData"]
        /// </summary>
        partial struct Ptr_MonsterConfigData
        {
            /// <summary>
            /// 0x10 System.Int32 id
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; }


            /// <summary>
            /// 0x18 System.String name
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
           public partial nint NAME { get; set; } 
*/

            /// <summary>
            /// 0x20 UnityEngine.Sprite figure
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Sprite"]
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("figure", "UnityEngine.Sprite")]
           public partial nint FIGURE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 elementId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("elementId", "System.Int32")]
           public partial System.Int32 ELEMENT_ID { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Single attackMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attackMultiper", "System.Single")]
           public partial System.Single ATTACK_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Single defenseMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("defenseMultiper", "System.Single")]
           public partial System.Single DEFENSE_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Single speedMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("speedMultiper", "System.Single")]
           public partial System.Single SPEED_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Single HPMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HPMultiper", "System.Single")]
           public partial System.Single HP_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x3C System.Single MPMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MPMultiper", "System.Single")]
           public partial System.Single MP_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Single killExpMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("killExpMultiper", "System.Single")]
           public partial System.Single KILL_EXP_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Single maxAgeMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxAgeMultiper", "System.Single")]
           public partial System.Single MAX_AGE_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32[] items
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("items", "System.Int32[]")]
           public partial nint ITEMS { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String AIfilename
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AIfilename", "System.String")]
           public partial nint A_IFILENAME { get; set; } 
*/

            /// <summary>
            /// 0x58 System.String defeatSFX
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("defeatSFX", "System.String")]
           public partial nint DEFEAT_SFX { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."MonsterConfigData"]
        /// </summary>
        partial struct Ptr_MonsterConfigData
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
            ///   DataAsset.ElementConfigData get_Element()
            /// </summary>
            /// <returns>class DataAsset.ElementConfigData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Element", "DataAsset.ElementConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial ElementConfigData.Ptr_ElementConfigData GET_ELEMENT();

            /// <summary>
            ///   I18n.I18nTextProvider get_Name()
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Name", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial I18nTextProvider.Ptr_I18nTextProvider GET_NAME();

        }
    }
}