namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."MonsterSkillConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_MonsterSkillConfigData>, Ptr_MonsterSkillConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "MonsterSkillConfigData", "DataAsset.MonsterSkillConfigData")]
    public partial class MonsterSkillConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_MonsterSkillConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_MonsterSkillConfigData(System.IntPtr ptr) => new Ptr_MonsterSkillConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_MonsterSkillConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_MonsterSkillConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."MonsterSkillConfigData"]
        /// </summary>
        partial struct Ptr_MonsterSkillConfigData
        {
            /// <summary>
            /// 0x10 System.Int32 monsterId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monsterId", "System.Int32")]
            public partial System.Int32 MONSTER_ID { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 level
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("level", "System.Int32")]
            public partial System.Int32 LEVEL { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 skillId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillId", "System.Int32")]
            public partial System.Int32 SKILL_ID { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."MonsterSkillConfigData"]
        /// </summary>
        partial struct Ptr_MonsterSkillConfigData
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