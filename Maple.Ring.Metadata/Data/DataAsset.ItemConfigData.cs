using Maple.MonoGameAssistant.Core;

namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."DataAsset"."ItemConfigData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ItemConfigData>, Ptr_ItemConfigData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "DataAsset", "ItemConfigData", "DataAsset.ItemConfigData")]
    public partial class ItemConfigData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ItemConfigData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ItemConfigData(System.IntPtr ptr) => new Ptr_ItemConfigData(ptr);
            public static implicit operator System.IntPtr(Ptr_ItemConfigData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_ItemConfigData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."ItemConfigData"]
        /// </summary>
        partial struct Ptr_ItemConfigData
        {
            /// <summary>
            /// 0x10 System.Int32 id
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
         
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; } 
 

            /// <summary>
            /// 0x18 UnityEngine.Sprite icon
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Sprite"]
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("icon", "UnityEngine.Sprite")]
            public partial nint ICON { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String title
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            
            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("title", "System.String")]
            //public partial PMonoString TITLE { get; set; } 
 

            /// <summary>
            /// 0x28 System.Int32 typeId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
          
            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("typeId", "System.Int32")]
            //public partial System.Int32 TYPE_ID { get; set; } 
 

            /// <summary>
            /// 0x2C System.Boolean expendable
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("expendable", "System.Boolean")]
            public partial System.Boolean EXPENDABLE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 qualityId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("qualityId", "System.Int32")]
            public partial System.Int32 QUALITY_ID { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String description
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("description", "System.String")]
            public partial nint DESCRIPTION { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Boolean recyclable
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("recyclable", "System.Boolean")]
            public partial System.Boolean RECYCLABLE { get; set; } 
*/

            /// <summary>
            /// 0x41 System.Boolean availableOnSale
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("availableOnSale", "System.Boolean")]
            public partial System.Boolean AVAILABLE_ON_SALE { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Int32 buyPrice
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("buyPrice", "System.Int32")]
            public partial System.Int32 BUY_PRICE { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 sellPrice
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sellPrice", "System.Int32")]
            public partial System.Int32 SELL_PRICE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."DataAsset"."ItemConfigData"]
        /// </summary>
        partial struct Ptr_ItemConfigData
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
            ///   DataAsset.AlchemyRecipeConfigData get_AlchemyRecipeConfig()
            /// </summary>
            /// <returns>class DataAsset.AlchemyRecipeConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AlchemyRecipeConfig", "DataAsset.AlchemyRecipeConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ALCHEMY_RECIPE_CONFIG(); 
*/
            /// <summary>
            ///   DataAsset.ArtifactConfigData get_ArtifactConfig()
            /// </summary>
            /// <returns>class DataAsset.ArtifactConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ArtifactConfig", "DataAsset.ArtifactConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ARTIFACT_CONFIG(); 
*/
            /// <summary>
            ///   I18n.I18nTextProvider get_Description()
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>
         
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Description", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial I18nTextProvider.Ptr_I18nTextProvider GET_DESCRIPTION(); 
 
            /// <summary>
            ///   DataAsset.EquipmentConfigData get_EquipmentConfig()
            /// </summary>
            /// <returns>class DataAsset.EquipmentConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EquipmentConfig", "DataAsset.EquipmentConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_EQUIPMENT_CONFIG(); 
*/
            /// <summary>
            ///   DataAsset.ForgeRecipeConfigData get_ForgeRecipeConfig()
            /// </summary>
            /// <returns>class DataAsset.ForgeRecipeConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ForgeRecipeConfig", "DataAsset.ForgeRecipeConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FORGE_RECIPE_CONFIG(); 
*/
            /// <summary>
            ///   System.Boolean get_IsRecoveryHPArtifact()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsRecoveryHPArtifact", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_RECOVERY_HP_ARTIFACT(); 
*/
            /// <summary>
            ///   System.Boolean get_IsRecoveryHPItem()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsRecoveryHPItem", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_RECOVERY_HP_ITEM(); 
*/
            /// <summary>
            ///   DataAsset.ItemQualityConfigData get_Quality()
            /// </summary>
            /// <returns>class DataAsset.ItemQualityConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Quality", "DataAsset.ItemQualityConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_QUALITY(); 
*/
            /// <summary>
            ///   DataAsset.SkillBookConfigData get_SkillBookConfig()
            /// </summary>
            /// <returns>class DataAsset.SkillBookConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SkillBookConfig", "DataAsset.SkillBookConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKILL_BOOK_CONFIG(); 
*/
            /// <summary>
            ///   DataAsset.StoveConfigData get_StoveConfig()
            /// </summary>
            /// <returns>class DataAsset.StoveConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StoveConfig", "DataAsset.StoveConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_STOVE_CONFIG(); 
*/
            /// <summary>
            ///   DataAsset.StoveFireConfigData get_StoveFireConfig()
            /// </summary>
            /// <returns>class DataAsset.StoveFireConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_StoveFireConfig", "DataAsset.StoveFireConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_STOVE_FIRE_CONFIG(); 
*/
            /// <summary>
            ///   DataAsset.SupplementConfigData get_SupplementConfig()
            /// </summary>
            /// <returns>class DataAsset.SupplementConfigData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SupplementConfig", "DataAsset.SupplementConfigData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SUPPLEMENT_CONFIG(); 
*/
            /// <summary>
            ///   I18n.I18nTextProvider get_Title()
            /// </summary>
            /// <returns>class I18n.I18nTextProvider</returns>
            
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Title", "I18n.I18nTextProvider", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial I18nTextProvider.Ptr_I18nTextProvider GET_TITLE(); 
 
            /// <summary>
            ///   ItemType get_Type()
            /// </summary>
            /// <returns>enum ItemType</returns>
        
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Type", "ItemType", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial ItemType GET_TYPE(); 
 
        }
    }
}