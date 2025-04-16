namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."TechnologyConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TechnologyConfigData>, Ptr_TechnologyConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "TechnologyConfigData", "DataAsset.TechnologyConfigData")]
    public partial class TechnologyConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TechnologyConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TechnologyConfigData(System.IntPtr ptr) => new Ptr_TechnologyConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_TechnologyConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TechnologyConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."TechnologyConfigData"]
        /// </summary>
        partial struct Ptr_TechnologyConfigData
        {
            /// <summary>
            /// 0x10 System.String className
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("className", "System.String")]
            public partial nint CLASS_NAME { get; set; } 
*/

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
            /// 0x20 UnityEngine.Sprite lockedIcon
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Sprite"]
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lockedIcon", "UnityEngine.Sprite")]
            public partial nint LOCKED_ICON { get; set; } 
*/

            /// <summary>
            /// 0x28 UnityEngine.Sprite unlockedIcon
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Sprite"]
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("unlockedIcon", "UnityEngine.Sprite")]
            public partial nint UNLOCKED_ICON { get; set; } 
*/

            /// <summary>
            /// 0x30 UnityEngine.Sprite activedIcon
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Sprite"]
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("activedIcon", "UnityEngine.Sprite")]
            public partial nint ACTIVED_ICON { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.List<System.String> requirementRules
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("requirementRules", "System.Collections.Generic.List<System.String>")]
            public partial nint REQUIREMENT_RULES { get; set; } 
*/

            /// <summary>
            /// 0x40 Requirement.RequirementPresenter requirement
            /// class ["Assembly-CSharp.dll"."Requirement"."RequirementPresenter"]
            /// </summary>
            /// <returns>class Requirement.RequirementPresenter</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("requirement", "Requirement.RequirementPresenter")]
            public partial nint REQUIREMENT { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."TechnologyConfigData"]
        /// </summary>
        partial struct Ptr_TechnologyConfigData
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
            ///   System.Boolean <get_MaxLevel>b__10_0(DataAsset.TechnologyLevelConfigData config)
            /// </summary>
            /// <param name = "config">class DataAsset.TechnologyLevelConfigData</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<get_MaxLevel>b__10_0", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("DataAsset.TechnologyLevelConfigData", 0)]
            public partial System.Boolean GET_MAX_LEVELB__10_0(nint config); 
*/
            /// <summary>
            ///   System.Int32 get_MaxLevel()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MaxLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_MAX_LEVEL(); 
*/
            /// <summary>
            ///   I18n.I18nTextProvider get_Name()
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Name", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NAME(); 
*/
            /// <summary>
            ///   Requirement.RequirementPresenter get_Requirement()
            /// </summary>
            /// <returns>class Requirement.RequirementPresenter</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Requirement", "Requirement.RequirementPresenter", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_REQUIREMENT(); 
*/
        }
    }
}