namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."LevelAttributeConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_LevelAttributeConfigData>, Ptr_LevelAttributeConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "LevelAttributeConfigData", "DataAsset.LevelAttributeConfigData")]
    public partial class LevelAttributeConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_LevelAttributeConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_LevelAttributeConfigData(System.IntPtr ptr) => new Ptr_LevelAttributeConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_LevelAttributeConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_LevelAttributeConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."LevelAttributeConfigData"]
        /// </summary>
        partial struct Ptr_LevelAttributeConfigData
        {
            /// <summary>
            /// 0x10 System.Int32 level
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("level", "System.Int32")]
            public partial System.Int32 LEVEL { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Single nextLevelExp
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("nextLevelExp", "System.Single")]
            public partial System.Single NEXT_LEVEL_EXP { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Boolean needBreak
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("needBreak", "System.Boolean")]
            public partial System.Boolean NEED_BREAK { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Single attack
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attack", "System.Single")]
            public partial System.Single ATTACK { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Single defense
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("defense", "System.Single")]
            public partial System.Single DEFENSE { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Single speed
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("speed", "System.Single")]
            public partial System.Single SPEED { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Single hp
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hp", "System.Single")]
            public partial System.Single HP { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Single mp
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mp", "System.Single")]
            public partial System.Single MP { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Single killExp
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("killExp", "System.Single")]
            public partial System.Single KILL_EXP { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Int32 maxAge
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxAge", "System.Int32")]
            public partial System.Int32 MAX_AGE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."LevelAttributeConfigData"]
        /// </summary>
        partial struct Ptr_LevelAttributeConfigData
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
            ///   DataAsset.LevelAttributeConfigData get_NextLevelConfigData()
            /// </summary>
            /// <returns>class DataAsset.LevelAttributeConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_NextLevelConfigData", "DataAsset.LevelAttributeConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NEXT_LEVEL_CONFIG_DATA(); 
*/
        }
    }
}