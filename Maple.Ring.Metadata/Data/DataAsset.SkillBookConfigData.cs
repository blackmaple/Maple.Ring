namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."SkillBookConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SkillBookConfigData>, Ptr_SkillBookConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "SkillBookConfigData", "DataAsset.SkillBookConfigData")]
    public partial class SkillBookConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SkillBookConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SkillBookConfigData(System.IntPtr ptr) => new Ptr_SkillBookConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_SkillBookConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_SkillBookConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."SkillBookConfigData"]
        /// </summary>
        partial struct Ptr_SkillBookConfigData
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
            /// 0x14 System.Int32 skillId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillId", "System.Int32")]
            public partial System.Int32 SKILL_ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 learnExp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("learnExp", "System.Int32")]
            public partial System.Int32 LEARN_EXP { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<System.String> requirementRules
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("requirementRules", "System.Collections.Generic.List<System.String>")]
            public partial nint REQUIREMENT_RULES { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 teachExpCost
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("teachExpCost", "System.Int32")]
            public partial System.Int32 TEACH_EXP_COST { get; set; } 
*/

            /// <summary>
            /// 0x30 Requirement.RequirementPresenter requirement
            /// class ["Assembly-CSharp.dll"."Requirement"."RequirementPresenter"]
            /// </summary>
            /// <returns>class Requirement.RequirementPresenter</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("requirement", "Requirement.RequirementPresenter")]
            public partial nint REQUIREMENT { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Boolean requirementInited
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("requirementInited", "System.Boolean")]
            public partial System.Boolean REQUIREMENT_INITED { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."SkillBookConfigData"]
        /// </summary>
        partial struct Ptr_SkillBookConfigData
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
            ///   DataAsset.ItemConfigData get_BookItem()
            /// </summary>
            /// <returns>class DataAsset.ItemConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BookItem", "DataAsset.ItemConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BOOK_ITEM(); 
*/
            /// <summary>
            ///   Requirement.RequirementPresenter get_Requirement()
            /// </summary>
            /// <returns>class Requirement.RequirementPresenter</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Requirement", "Requirement.RequirementPresenter", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_REQUIREMENT(); 
*/
            /// <summary>
            ///   DataAsset.SkillConfigData get_SkillConfigData()
            /// </summary>
            /// <returns>class DataAsset.SkillConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SkillConfigData", "DataAsset.SkillConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKILL_CONFIG_DATA(); 
*/
        }
    }
}