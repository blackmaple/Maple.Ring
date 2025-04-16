namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."CandidateInitSkillConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_CandidateInitSkillConfigData>, Ptr_CandidateInitSkillConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "CandidateInitSkillConfigData", "DataAsset.CandidateInitSkillConfigData")]
    public partial class CandidateInitSkillConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_CandidateInitSkillConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_CandidateInitSkillConfigData(System.IntPtr ptr) => new Ptr_CandidateInitSkillConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_CandidateInitSkillConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_CandidateInitSkillConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."CandidateInitSkillConfigData"]
        /// </summary>
        partial struct Ptr_CandidateInitSkillConfigData
        {
            /// <summary>
            /// 0x10 System.Int32 skillId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillId", "System.Int32")]
            public partial System.Int32 SKILL_ID { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Single chance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("chance", "System.Single")]
            public partial System.Single CHANCE { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 luckCost
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("luckCost", "System.Int32")]
            public partial System.Int32 LUCK_COST { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<System.Int32> requireSpiritualRootIds
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("requireSpiritualRootIds", "System.Collections.Generic.List<System.Int32>")]
            public partial nint REQUIRE_SPIRITUAL_ROOT_IDS { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 requireLevel
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("requireLevel", "System.Int32")]
            public partial System.Int32 REQUIRE_LEVEL { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Boolean isDefaultSkill
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isDefaultSkill", "System.Boolean")]
            public partial System.Boolean IS_DEFAULT_SKILL { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."CandidateInitSkillConfigData"]
        /// </summary>
        partial struct Ptr_CandidateInitSkillConfigData
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