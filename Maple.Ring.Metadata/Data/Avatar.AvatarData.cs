namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Avatar"."AvatarData"]
    /// [System.Object]
    /// [Save.IStorable<Save.AvatarSaveData>]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AvatarData>, Ptr_AvatarData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "Avatar", "AvatarData", "Avatar.AvatarData")]
    public partial class AvatarData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AvatarData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AvatarData(System.IntPtr ptr) => new Ptr_AvatarData(ptr);
            public static implicit operator System.IntPtr(Ptr_AvatarData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AvatarData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Avatar"."AvatarData"]
        /// </summary>
        partial struct Ptr_AvatarData
        {
            /// <summary>
            /// 0x10 System.Collections.Generic.List<Avatar.AvatarPiece> <Pieces>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Avatar.AvatarPiece></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Pieces>k__BackingField", "System.Collections.Generic.List<Avatar.AvatarPiece>")]
            public partial nint PIECES { get; set; } 
*/

            /// <summary>
            /// 0x18 Avatar.SingleAvatar singleAvatar
            /// class ["Assembly-CSharp.dll"."Avatar"."SingleAvatar"]
            /// </summary>
            /// <returns>class Avatar.SingleAvatar</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("singleAvatar", "Avatar.SingleAvatar")]
            public partial nint SINGLE_AVATAR { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Avatar"."AvatarData"]
        /// </summary>
        partial struct Ptr_AvatarData
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
            ///   System.Boolean get_IsSingle()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsSingle", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_SINGLE(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<Avatar.AvatarPiece> get_Pieces()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Avatar.AvatarPiece></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Pieces", "System.Collections.Generic.List<Avatar.AvatarPiece>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PIECES(); 
*/
            /// <summary>
            ///   Avatar.SingleAvatar get_SingleAvatar()
            /// </summary>
            /// <returns>class Avatar.SingleAvatar</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SingleAvatar", "Avatar.SingleAvatar", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SINGLE_AVATAR(); 
*/
            /// <summary>
            ///   Avatar.AvatarPiece GetPiece(Avatar.AvatarPieceType type)
            /// </summary>
            /// <param name = "type">enum Avatar.AvatarPieceType</param>
            /// <returns>class Avatar.AvatarPiece</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPiece", "Avatar.AvatarPiece", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Avatar.AvatarPieceType", 0)]
            public partial nint GET_PIECE(Avatar.AvatarPieceType type); 
*/
            /// <summary>
            ///   System.Void Load(Save.AvatarSaveData avatarSaveData)
            /// </summary>
            /// <param name = "avatarSaveData">class Save.AvatarSaveData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Load", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Save.AvatarSaveData", 0)]
            public partial void LOAD(nint avatarSaveData); 
*/
            /// <summary>
            ///   System.Void LoadFromJson(SimpleJSON.JSONNode jsonNode)
            /// </summary>
            /// <param name = "jsonNode">abstract class SimpleJSON.JSONNode</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadFromJson", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SimpleJSON.JSONNode", 0)]
            public partial void LOAD_FROM_JSON(nint jsonNode); 
*/
            /// <summary>
            ///   Save.AvatarSaveData Save()
            /// </summary>
            /// <returns>class Save.AvatarSaveData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Save", "Save.AvatarSaveData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SAVE(); 
*/
            /// <summary>
            ///   System.Void set_Pieces(System.Collections.Generic.List<Avatar.AvatarPiece> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<Avatar.AvatarPiece></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Pieces", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<Avatar.AvatarPiece>", 0)]
            public partial void SET_PIECES(nint value); 
*/
            /// <summary>
            ///   System.Void set_SingleAvatar(Avatar.SingleAvatar value)
            /// </summary>
            /// <param name = "value">class Avatar.SingleAvatar</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_SingleAvatar", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Avatar.SingleAvatar", 0)]
            public partial void SET_SINGLE_AVATAR(nint value); 
*/
            /// <summary>
            ///   System.Void SetPiece(Avatar.AvatarPiece piece)
            /// </summary>
            /// <param name = "piece">class Avatar.AvatarPiece</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPiece", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Avatar.AvatarPiece", 0)]
            public partial void SET_PIECE(nint piece); 
*/
        }
    }
}