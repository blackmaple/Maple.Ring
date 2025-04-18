namespace Maple.Ring.Metadata
{
    /// <summary>
    /// class ["UniRx.dll"."UniRx"."IntReactiveProperty"]
    /// [UniRx.ReactiveProperty<System.Int32>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_IntReactiveProperty>, Ptr_IntReactiveProperty>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("UniRx.dll", "UniRx", "IntReactiveProperty", "UniRx.IntReactiveProperty")]
    public partial class IntReactiveProperty
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_IntReactiveProperty(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_IntReactiveProperty(System.IntPtr ptr) => new Ptr_IntReactiveProperty(ptr);
            public static implicit operator System.IntPtr(Ptr_IntReactiveProperty ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_IntReactiveProperty ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["UniRx.dll"."UniRx"."IntReactiveProperty"]
        /// </summary>
        partial struct Ptr_IntReactiveProperty
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.IEqualityComparer<System.Int32> defaultEqualityComparer
            /// interface ["mscorlib.dll"."System.Collections.Generic"."IEqualityComparer`1"]
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEqualityComparer<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("defaultEqualityComparer", "System.Collections.Generic.IEqualityComparer<System.Int32>")]
            public static partial nint DEFAULT_EQUALITY_COMPARER { get; set; } 
*/

            /// <summary>
            /// 0x10 System.Int32 value
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("value", "System.Int32")]
            public partial System.Int32 VALUE { get; set; } 
*/

            /// <summary>
            /// 0x18 UniRx.ObserverNode<System.Int32> root
            /// class ["UniRx.dll"."UniRx"."ObserverNode`1"]
            /// </summary>
            /// <returns>class UniRx.ObserverNode<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("root", "UniRx.ObserverNode<System.Int32>")]
            public partial nint ROOT { get; set; } 
*/

            /// <summary>
            /// 0x20 UniRx.ObserverNode<System.Int32> last
            /// class ["UniRx.dll"."UniRx"."ObserverNode`1"]
            /// </summary>
            /// <returns>class UniRx.ObserverNode<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("last", "UniRx.ObserverNode<System.Int32>")]
            public partial nint LAST { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Boolean isDisposed
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isDisposed", "System.Boolean")]
            public partial System.Boolean IS_DISPOSED { get; set; } 
*/
        }

        /// <summary>
        /// class ["UniRx.dll"."UniRx"."IntReactiveProperty"]
        /// </summary>
        partial struct Ptr_IntReactiveProperty
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
            ///   System.Void .ctor(System.Int32 initialValue)
            /// </summary>
            /// <param name = "initialValue">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void CTOR(System.Int32 initialValue); 
*/
        }

        /// <summary>
        /// class ["UniRx.dll"."UniRx"."ReactiveProperty`1"]
        /// </summary>
        partial struct Ptr_IntReactiveProperty
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial void CCTOR(); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 initialValue)
            /// </summary>
            /// <param name = "initialValue">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void CTOR(System.Int32 initialValue); 
*/
            /// <summary>
            ///   System.Void Dispose()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Dispose", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void DISPOSE(); 
*/
            /// <summary>
            ///   System.Void Dispose(System.Boolean disposing)
            /// </summary>
            /// <param name = "disposing">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Dispose", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void DISPOSE(System.Boolean disposing); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEqualityComparer<System.Int32> get_EqualityComparer()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEqualityComparer<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_EqualityComparer", "System.Collections.Generic.IEqualityComparer<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_EQUALITY_COMPARER(); 
*/
            /// <summary>
            ///   System.Boolean get_HasValue()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_HasValue", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean GET_HAS_VALUE(); 
*/
            /// <summary>
            ///   System.Int32 get_Value()
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Value", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_VALUE();

            /// <summary>
            ///   System.Boolean IsRequiredSubscribeOnCurrentThread()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsRequiredSubscribeOnCurrentThread", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean IS_REQUIRED_SUBSCRIBE_ON_CURRENT_THREAD(); 
*/
            /// <summary>
            ///   System.Void RaiseOnNext(System.Int32& value)
            /// </summary>
            /// <param name = "value">struct System.Int32&</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RaiseOnNext", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 0)]
           public partial void RAISE_ON_NEXT(System.Int32 &value); 
*/
            /// <summary>
            ///   System.Void set_Value(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Value", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_VALUE(System.Int32 value);

            /// <summary>
            ///   System.Void SetValue(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetValue", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void SET_VALUE(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void SetValueAndForceNotify(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetValueAndForceNotify", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void SET_VALUE_AND_FORCE_NOTIFY(System.Int32 value); 
*/
            /// <summary>
            ///   System.IDisposable Subscribe(System.IObserver<System.Int32> observer)
            /// </summary>
            /// <param name = "observer">interface System.IObserver<System.Int32></param>
            /// <returns>interface System.IDisposable</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Subscribe", "System.IDisposable", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IObserver<System.Int32>", 0)]
           public partial nint SUBSCRIBE(nint observer); 
*/
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint TO_STRING(); 
*/
            /// <summary>
            ///   System.Void UniRx.IObserverLinkedList<T>.UnsubscribeNode(UniRx.ObserverNode<System.Int32> node)
            /// </summary>
            /// <param name = "node">class UniRx.ObserverNode<System.Int32></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UniRx.IObserverLinkedList<T>.UnsubscribeNode", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UniRx.ObserverNode<System.Int32>", 0)]
           public partial void UNI_RX_I_OBSERVER_LINKED_LIST_T_UNSUBSCRIBE_NODE(nint node); 
*/
        }
    }
}