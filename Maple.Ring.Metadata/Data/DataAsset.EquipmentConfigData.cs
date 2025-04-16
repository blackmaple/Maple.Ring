namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."EquipmentConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_EquipmentConfigData>, Ptr_EquipmentConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "EquipmentConfigData", "DataAsset.EquipmentConfigData")]
    public partial class EquipmentConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_EquipmentConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_EquipmentConfigData(System.IntPtr ptr) => new Ptr_EquipmentConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_EquipmentConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_EquipmentConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."EquipmentConfigData"]
        /// </summary>
        partial struct Ptr_EquipmentConfigData
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
            /// 0x14 EquipmentPart equipmentPart
            /// enum ["Assembly-CSharp.dll".""."EquipmentPart"]
            /// </summary>
            /// <returns>enum EquipmentPart</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("equipmentPart", "EquipmentPart")]
            public partial EquipmentPart EQUIPMENT_PART { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.List<System.String> requirementRules
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("requirementRules", "System.Collections.Generic.List<System.String>")]
            public partial nint REQUIREMENT_RULES { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Single attack
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attack", "System.Single")]
            public partial System.Single ATTACK { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Single defense
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("defense", "System.Single")]
            public partial System.Single DEFENSE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Single speed
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("speed", "System.Single")]
            public partial System.Single SPEED { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Single hp
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hp", "System.Single")]
            public partial System.Single HP { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Single mp
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mp", "System.Single")]
            public partial System.Single MP { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Single attackMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attackMultiper", "System.Single")]
            public partial System.Single ATTACK_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Single defenseMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("defenseMultiper", "System.Single")]
            public partial System.Single DEFENSE_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x3C System.Single speedMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("speedMultiper", "System.Single")]
            public partial System.Single SPEED_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Single hpMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hpMultiper", "System.Single")]
            public partial System.Single HP_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Single mpMultiper
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mpMultiper", "System.Single")]
            public partial System.Single MP_MULTIPER { get; set; } 
*/

            /// <summary>
            /// 0x48 Requirement.RequirementPresenter requirement
            /// class ["Assembly-CSharp.dll"."Requirement"."RequirementPresenter"]
            /// </summary>
            /// <returns>class Requirement.RequirementPresenter</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("requirement", "Requirement.RequirementPresenter")]
            public partial nint REQUIREMENT { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Boolean requirementInited
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("requirementInited", "System.Boolean")]
            public partial System.Boolean REQUIREMENT_INITED { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."EquipmentConfigData"]
        /// </summary>
        partial struct Ptr_EquipmentConfigData
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
            ///   DataAsset.ItemConfigData get_ItemConfigData()
            /// </summary>
            /// <returns>class DataAsset.ItemConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ItemConfigData", "DataAsset.ItemConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ITEM_CONFIG_DATA(); 
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